// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// Search criteria for <see cref="Procedure"/> class.
    /// </summary>
	public partial class ProcedureSearchCriteria : EntitySearchCriteria<Procedure>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public ProcedureSearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public ProcedureSearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected ProcedureSearchCriteria(ProcedureSearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new ProcedureSearchCriteria(this);
        }


		
	  	public ClearCanvas.Healthcare.OrderSearchCriteria Order
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Order"))
	  			{
	  				this.SubCriteria["Order"] = new ClearCanvas.Healthcare.OrderSearchCriteria("Order");
	  			}
	  			return (ClearCanvas.Healthcare.OrderSearchCriteria)this.SubCriteria["Order"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.ProcedureTypeSearchCriteria Type
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Type"))
	  			{
	  				this.SubCriteria["Type"] = new ClearCanvas.Healthcare.ProcedureTypeSearchCriteria("Type");
	  			}
	  			return (ClearCanvas.Healthcare.ProcedureTypeSearchCriteria)this.SubCriteria["Type"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> Number
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Number"))
	  			{
	  				this.SubCriteria["Number"] = new SearchCondition<string>("Number");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["Number"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> ScheduledStartTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ScheduledStartTime"))
	  			{
	  				this.SubCriteria["ScheduledStartTime"] = new SearchCondition<DateTime?>("ScheduledStartTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["ScheduledStartTime"];
	  		}
	  	}
	  	
	  	public ISearchCondition<int> ScheduledDuration
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ScheduledDuration"))
	  			{
	  				this.SubCriteria["ScheduledDuration"] = new SearchCondition<int>("ScheduledDuration");
	  			}
	  			return (ISearchCondition<int>)this.SubCriteria["ScheduledDuration"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> ScheduledEndTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ScheduledEndTime"))
	  			{
	  				this.SubCriteria["ScheduledEndTime"] = new SearchCondition<DateTime?>("ScheduledEndTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["ScheduledEndTime"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.SchedulingCodeEnum> SchedulingCode
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("SchedulingCode"))
	  			{
	  				this.SubCriteria["SchedulingCode"] = new SearchCondition<ClearCanvas.Healthcare.SchedulingCodeEnum>("SchedulingCode");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.SchedulingCodeEnum>)this.SubCriteria["SchedulingCode"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> StartTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("StartTime"))
	  			{
	  				this.SubCriteria["StartTime"] = new SearchCondition<DateTime?>("StartTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["StartTime"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> EndTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("EndTime"))
	  			{
	  				this.SubCriteria["EndTime"] = new SearchCondition<DateTime?>("EndTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["EndTime"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.ProcedureStatus> Status
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Status"))
	  			{
	  				this.SubCriteria["Status"] = new SearchCondition<ClearCanvas.Healthcare.ProcedureStatus>("Status");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.ProcedureStatus>)this.SubCriteria["Status"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.FacilitySearchCriteria PerformingFacility
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("PerformingFacility"))
	  			{
	  				this.SubCriteria["PerformingFacility"] = new ClearCanvas.Healthcare.FacilitySearchCriteria("PerformingFacility");
	  			}
	  			return (ClearCanvas.Healthcare.FacilitySearchCriteria)this.SubCriteria["PerformingFacility"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.DepartmentSearchCriteria PerformingDepartment
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("PerformingDepartment"))
	  			{
	  				this.SubCriteria["PerformingDepartment"] = new ClearCanvas.Healthcare.DepartmentSearchCriteria("PerformingDepartment");
	  			}
	  			return (ClearCanvas.Healthcare.DepartmentSearchCriteria)this.SubCriteria["PerformingDepartment"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.Laterality> Laterality
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Laterality"))
	  			{
	  				this.SubCriteria["Laterality"] = new SearchCondition<ClearCanvas.Healthcare.Laterality>("Laterality");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.Laterality>)this.SubCriteria["Laterality"];
	  		}
	  	}
	  	
	  	public ISearchCondition<bool> Portable
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Portable"))
	  			{
	  				this.SubCriteria["Portable"] = new SearchCondition<bool>("Portable");
	  			}
	  			return (ISearchCondition<bool>)this.SubCriteria["Portable"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.ProcedureCheckInSearchCriteria ProcedureCheckIn
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ProcedureCheckIn"))
	  			{
	  				this.SubCriteria["ProcedureCheckIn"] = new ClearCanvas.Healthcare.ProcedureCheckInSearchCriteria("ProcedureCheckIn");
	  			}
	  			return (ClearCanvas.Healthcare.ProcedureCheckInSearchCriteria)this.SubCriteria["ProcedureCheckIn"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.ImageAvailability> ImageAvailability
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ImageAvailability"))
	  			{
	  				this.SubCriteria["ImageAvailability"] = new SearchCondition<ClearCanvas.Healthcare.ImageAvailability>("ImageAvailability");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.ImageAvailability>)this.SubCriteria["ImageAvailability"];
	  		}
	  	}
	  	
	  	public ISearchCondition<bool> DowntimeRecoveryMode
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("DowntimeRecoveryMode"))
	  			{
	  				this.SubCriteria["DowntimeRecoveryMode"] = new SearchCondition<bool>("DowntimeRecoveryMode");
	  			}
	  			return (ISearchCondition<bool>)this.SubCriteria["DowntimeRecoveryMode"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> StudyInstanceUID
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("StudyInstanceUID"))
	  			{
	  				this.SubCriteria["StudyInstanceUID"] = new SearchCondition<string>("StudyInstanceUID");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["StudyInstanceUID"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.ProcedureSearchCriteria GhostOf
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("GhostOf"))
	  			{
	  				this.SubCriteria["GhostOf"] = new ClearCanvas.Healthcare.ProcedureSearchCriteria("GhostOf");
	  			}
	  			return (ClearCanvas.Healthcare.ProcedureSearchCriteria)this.SubCriteria["GhostOf"];
	  		}
	  	}
	  	
	}
}
