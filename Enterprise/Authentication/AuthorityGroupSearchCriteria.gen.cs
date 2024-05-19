// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Enterprise.Authentication
{

    /// <summary>
    /// Search criteria for <see cref="AuthorityGroup"/> class.
    /// </summary>
	public partial class AuthorityGroupSearchCriteria : EntitySearchCriteria<AuthorityGroup>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public AuthorityGroupSearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public AuthorityGroupSearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected AuthorityGroupSearchCriteria(AuthorityGroupSearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new AuthorityGroupSearchCriteria(this);
        }


		
	  	public ISearchCondition<string> Name
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Name"))
	  			{
	  				this.SubCriteria["Name"] = new SearchCondition<string>("Name");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["Name"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> Description
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Description"))
	  			{
	  				this.SubCriteria["Description"] = new SearchCondition<string>("Description");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["Description"];
	  		}
	  	}
	  	
	  	public ISearchCondition<bool> BuiltIn
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("BuiltIn"))
	  			{
	  				this.SubCriteria["BuiltIn"] = new SearchCondition<bool>("BuiltIn");
	  			}
	  			return (ISearchCondition<bool>)this.SubCriteria["BuiltIn"];
	  		}
	  	}
	  	
	  	public ISearchCondition<bool> DataGroup
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("DataGroup"))
	  			{
	  				this.SubCriteria["DataGroup"] = new SearchCondition<bool>("DataGroup");
	  			}
	  			return (ISearchCondition<bool>)this.SubCriteria["DataGroup"];
	  		}
	  	}
	  	
	}
}
