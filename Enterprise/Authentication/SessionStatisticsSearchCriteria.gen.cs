// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Enterprise.Authentication
{

    /// <summary>
    /// Search criteria for <see cref="SessionStatistics"/> class.
    /// </summary>
	public partial class SessionStatisticsSearchCriteria : EntitySearchCriteria<SessionStatistics>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public SessionStatisticsSearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public SessionStatisticsSearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected SessionStatisticsSearchCriteria(SessionStatisticsSearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new SessionStatisticsSearchCriteria(this);
        }


		
	  	public ISearchCondition<DateTime> Timestamp
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Timestamp"))
	  			{
	  				this.SubCriteria["Timestamp"] = new SearchCondition<DateTime>("Timestamp");
	  			}
	  			return (ISearchCondition<DateTime>)this.SubCriteria["Timestamp"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> Application
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Application"))
	  			{
	  				this.SubCriteria["Application"] = new SearchCondition<string>("Application");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["Application"];
	  		}
	  	}
	  	
	  	public ISearchCondition<Int32> ActiveSessions
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ActiveSessions"))
	  			{
	  				this.SubCriteria["ActiveSessions"] = new SearchCondition<Int32>("ActiveSessions");
	  			}
	  			return (ISearchCondition<Int32>)this.SubCriteria["ActiveSessions"];
	  		}
	  	}
	  	
	}
}
