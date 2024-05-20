#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

#if UNIT_TESTS && !__MonoCS__

using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using ClearCanvas.Common.Utilities.Tests;
using NUnit.Framework;

namespace ClearCanvas.Common.Configuration.Tests
{
	[TestFixture]
	internal class AltAppSettingsFolderTests
	{
		/// <summary>
		/// Tests known evidence hashes gathered from the field.
		/// </summary>
		[Test]
		public void TestKnownEvidenceHashes()
		{
			Assert.AreEqual("bxushgmob2kgr2bbhnkomw10ycdtxyd1", UserUpgradeStrategy.ComputeEvidenceHash(@"file:///c:/program files/clearcanvas/clearcanvas workstation/clearcanvas.desktop.executable.exe".ToUpperInvariant()));
			Assert.AreEqual("h4r1xj22u5jcc205qirm1uq5sdyih1a5", UserUpgradeStrategy.ComputeEvidenceHash(@"file:///c:\Program Files\ClearCanvas\ClearCanvas Workstation\ClearCanvas.Desktop.Executable.exe".ToUpperInvariant()));
		}

		/// <summary>
		/// Tests a large number of randomly generated inputs against a reference implementation of the evidence hashing function.
		/// </summary>
		[Test]
		public void TestRandomEvidenceHashes()
		{
			var rng = new PseudoRandom(0x262E5635);
			var data = new byte[512];

			using (var sha1 = new SHA1CryptoServiceProvider()) {
                for (var n = 0; n < 10000; ++n) {
                    rng.NextBytes(data);
                    var evidenceInfo = Convert.ToBase64String(data);

                    // Serialize evidenceInfo using UTF8Encoding instead of BinaryFormatter
                    var serializedEvidenceInfo = Encoding.UTF8.GetBytes(evidenceInfo);
                    var expectedHash = ToBase32(sha1.ComputeHash(serializedEvidenceInfo));
                    var actualHash = UserUpgradeStrategy.ComputeEvidenceHash(evidenceInfo);

                    Assert.AreEqual(expectedHash, actualHash, $"n = {n}");
                }
            }
		}

		/// <summary>
		/// Reference implementation of the Base32 converter from System.Configuration.ClientConfigPaths
		/// </summary>
		private static string ToBase32(byte[] buff)
		{
			// or just invoke the real function using reflection
			return (string) _base32ReferenceMethod.Invoke(null, new object[] {buff});
		}

		private static readonly MethodInfo _base32ReferenceMethod = typeof (ConfigurationManager).Assembly.GetType("System.Configuration.ClientConfigPaths")
			.GetMethod("ToBase32StringSuitableForDirName", BindingFlags.Static | BindingFlags.NonPublic, null, new[] {typeof (byte[])}, null);
	}
}

#endif