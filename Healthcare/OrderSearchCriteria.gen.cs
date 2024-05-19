// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// Search criteria for <see cref="Order"/> class.
    /// </summary>
	public partial class OrderSearchCriteria : EntitySearchCriteria<Order>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public OrderSearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public OrderSearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected OrderSearchCriteria(OrderSearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new OrderSearchCriteria(this);
        }


		
	  	public ClearCanvas.Healthcare.PatientSearchCriteria Patient
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Patient"))
	  			{
	  				this.SubCriteria["Patient"] = new ClearCanvas.Healthcare.PatientSearchCriteria("Patient");
	  			}
	  			return (ClearCanvas.Healthcare.PatientSearchCriteria)this.SubCriteria["Patient"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.VisitSearchCriteria Visit
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Visit"))
	  			{
	  				this.SubCriteria["Visit"] = new ClearCanvas.Healthcare.VisitSearchCriteria("Visit");
	  			}
	  			return (ClearCanvas.Healthcare.VisitSearchCriteria)this.SubCriteria["Visit"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> PlacerNumber
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("PlacerNumber"))
	  			{
	  				this.SubCriteria["PlacerNumber"] = new SearchCondition<string>("PlacerNumber");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["PlacerNumber"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> AccessionNumber
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("AccessionNumber"))
	  			{
	  				this.SubCriteria["AccessionNumber"] = new SearchCondition<string>("AccessionNumber");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["AccessionNumber"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.DiagnosticServiceSearchCriteria DiagnosticService
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("DiagnosticService"))
	  			{
	  				this.SubCriteria["DiagnosticService"] = new ClearCanvas.Healthcare.DiagnosticServiceSearchCriteria("DiagnosticService");
	  			}
	  			return (ClearCanvas.Healthcare.DiagnosticServiceSearchCriteria)this.SubCriteria["DiagnosticService"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime> EnteredTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("EnteredTime"))
	  			{
	  				this.SubCriteria["EnteredTime"] = new SearchCondition<DateTime>("EnteredTime");
	  			}
	  			return (ISearchCondition<DateTime>)this.SubCriteria["EnteredTime"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.StaffSearchCriteria EnteredBy
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("EnteredBy"))
	  			{
	  				this.SubCriteria["EnteredBy"] = new ClearCanvas.Healthcare.StaffSearchCriteria("EnteredBy");
	  			}
	  			return (ClearCanvas.Healthcare.StaffSearchCriteria)this.SubCriteria["EnteredBy"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> EnteredComment
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("EnteredComment"))
	  			{
	  				this.SubCriteria["EnteredComment"] = new SearchCondition<string>("EnteredComment");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["EnteredComment"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> SchedulingRequestTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("SchedulingRequestTime"))
	  			{
	  				this.SubCriteria["SchedulingRequestTime"] = new SearchCondition<DateTime?>("SchedulingRequestTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["SchedulingRequestTime"];
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
	  	
	  	public ClearCanvas.Healthcare.ExternalPractitionerSearchCriteria OrderingPractitioner
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("OrderingPractitioner"))
	  			{
	  				this.SubCriteria["OrderingPractitioner"] = new ClearCanvas.Healthcare.ExternalPractitionerSearchCriteria("OrderingPractitioner");
	  			}
	  			return (ClearCanvas.Healthcare.ExternalPractitionerSearchCriteria)this.SubCriteria["OrderingPractitioner"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.FacilitySearchCriteria OrderingFacility
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("OrderingFacility"))
	  			{
	  				this.SubCriteria["OrderingFacility"] = new ClearCanvas.Healthcare.FacilitySearchCriteria("OrderingFacility");
	  			}
	  			return (ClearCanvas.Healthcare.FacilitySearchCriteria)this.SubCriteria["OrderingFacility"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> ReasonForStudy
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ReasonForStudy"))
	  			{
	  				this.SubCriteria["ReasonForStudy"] = new SearchCondition<string>("ReasonForStudy");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["ReasonForStudy"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.OrderPriority> Priority
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Priority"))
	  			{
	  				this.SubCriteria["Priority"] = new SearchCondition<ClearCanvas.Healthcare.OrderPriority>("Priority");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.OrderPriority>)this.SubCriteria["Priority"];
	  		}
	  	}
	  	
	  	public ISearchCondition<int> PriorityRank
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("PriorityRank"))
	  			{
	  				this.SubCriteria["PriorityRank"] = new SearchCondition<int>("PriorityRank");
	  			}
	  			return (ISearchCondition<int>)this.SubCriteria["PriorityRank"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.OrderStatus> Status
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Status"))
	  			{
	  				this.SubCriteria["Status"] = new SearchCondition<ClearCanvas.Healthcare.OrderStatus>("Status");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.OrderStatus>)this.SubCriteria["Status"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.OrderCancelInfoSearchCriteria CancelInfo
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("CancelInfo"))
	  			{
	  				this.SubCriteria["CancelInfo"] = new ClearCanvas.Healthcare.OrderCancelInfoSearchCriteria("CancelInfo");
	  			}
	  			return (ClearCanvas.Healthcare.OrderCancelInfoSearchCriteria)this.SubCriteria["CancelInfo"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.OrderMergeInfoSearchCriteria MergeInfo
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("MergeInfo"))
	  			{
	  				this.SubCriteria["MergeInfo"] = new ClearCanvas.Healthcare.OrderMergeInfoSearchCriteria("MergeInfo");
	  			}
	  			return (ClearCanvas.Healthcare.OrderMergeInfoSearchCriteria)this.SubCriteria["MergeInfo"];
	  		}
	  	}
	  	
	  	public ExtendedPropertiesSearchCriteria ExtendedProperties
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ExtendedProperties"))
	  			{
	  				this.SubCriteria["ExtendedProperties"] = new ExtendedPropertiesSearchCriteria("ExtendedProperties");
	  			}
	  			return (ExtendedPropertiesSearchCriteria)this.SubCriteria["ExtendedProperties"];
	  		}
	  	}
	  	
	}
}
