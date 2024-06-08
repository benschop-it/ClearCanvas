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
using System.Text;
using Iesi.Collections;
using Iesi.Collections.Generic;

namespace ClearCanvas.Healthcare.Tests
{
    internal static class TestDiagnosticServiceFactory
    {
        internal static DiagnosticService CreateDiagnosticService()
        {
            return CreateDiagnosticService(1);
        }

        internal static DiagnosticService CreateDiagnosticService(int numReqProcs)
        {
            // create a bunch of dummy procedure types (without procedure plans)
            HashSet<ProcedureType> procedureTypes = new HashSet<ProcedureType>();
            for (int p = 0; p < numReqProcs; p++)
            {
                ProcedureType pt = new ProcedureType("20" + p, "Procedure 20" + p);
                procedureTypes.Add(pt);
            }
            return new DiagnosticService("301", "Diagnostic Service 301", procedureTypes);
        }
    }
}
