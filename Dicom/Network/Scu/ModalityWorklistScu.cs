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

using System;
using System.Collections.Generic;
using ClearCanvas.Dicom.Iod.Iods;

namespace ClearCanvas.Dicom.Network.Scu
{
    /// <summary>
    /// Modality Worklist Scu.
    /// <para>
    /// <example>
    /// ModalityWorklistScu modalityWorklistScu = new ModalityWorklistScu();
    /// ModalityWorklistIod modalityWorklistIod = new ModalityWorklistIod();
    /// modalityWorklistIod.SetCommonTags();
    /// modalityWorklistScu.GetWorkList("myClientAeTitle", "myServerAeTitle", "127.0.0.1", 5678, modalityWorklistIod);
    /// System.Diagnostics.Debug.WriteLine(ModalityWorklistResults.Count.ToString()); 
    /// </example>
    /// </para>
    /// </summary>
    public class ModalityWorklistScu : FindScuBase
    {
        #region Public Events/Delegates
        public delegate IList<ModalityWorklistIod> ModalityWorklistDelegate(string clientAETitle, string remoteAE, string remoteHost, int remotePort, ModalityWorklistIod modalityWorklistIod);
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationScu"/> class.
        /// </summary>
        public ModalityWorklistScu()
            :base()
        {
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Specifies the find sop class (ModalityWorklistInformationModelFind)
        /// </summary>
        /// <value>The find sop class.</value>
        /// <remarks>Abstract so subclass can specify.</remarks>
        public override SopClass FindSopClass
        {
            get { return SopClass.ModalityWorklistInformationModelFind; }
        }

        /// <summary>
        /// Gets the results as a bindinglist of ModalityWorklistIods.
        /// </summary>
        /// <value>The modality worklist results.</value>
        public IList<ModalityWorklistIod> ModalityWorklistResults
        {
            get
            {
                IList<ModalityWorklistIod> results = new System.ComponentModel.BindingList<ModalityWorklistIod>();
                if (base.Results != null)
                {
                    foreach (DicomAttributeCollection dicomAttributeCollection in base.Results)
                        results.Add(new ModalityWorklistIod(dicomAttributeCollection));
                }
                return results;
            }
        }
        #endregion

        #region Protected Overridden Methods
        /// <summary>
        /// Determines whether [is query level valid].
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if [is query level valid]; otherwise, <c>false</c>.
        /// </returns>
        protected override bool ValidateQuery()
        {
            // Modality Worklist shouldn't have a query retrieve level... 
            return true;

        }
        #endregion

    }
}
