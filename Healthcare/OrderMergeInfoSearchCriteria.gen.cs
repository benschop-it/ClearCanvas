// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// Search criteria for <see cref="OrderMergeInfo"/> class.
    /// </summary>
	public partial class OrderMergeInfoSearchCriteria : SearchCriteria
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public OrderMergeInfoSearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public OrderMergeInfoSearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected OrderMergeInfoSearchCriteria(OrderMergeInfoSearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new OrderMergeInfoSearchCriteria(this);
        }


		
	  	public ClearCanvas.Healthcare.StaffSearchCriteria MergedBy
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("MergedBy"))
	  			{
	  				this.SubCriteria["MergedBy"] = new ClearCanvas.Healthcare.StaffSearchCriteria("MergedBy");
	  			}
	  			return (ClearCanvas.Healthcare.StaffSearchCriteria)this.SubCriteria["MergedBy"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> MergedTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("MergedTime"))
	  			{
	  				this.SubCriteria["MergedTime"] = new SearchCondition<DateTime?>("MergedTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["MergedTime"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.OrderSearchCriteria MergeDestinationOrder
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("MergeDestinationOrder"))
	  			{
	  				this.SubCriteria["MergeDestinationOrder"] = new ClearCanvas.Healthcare.OrderSearchCriteria("MergeDestinationOrder");
	  			}
	  			return (ClearCanvas.Healthcare.OrderSearchCriteria)this.SubCriteria["MergeDestinationOrder"];
	  		}
	  	}
	  	
	}
}
