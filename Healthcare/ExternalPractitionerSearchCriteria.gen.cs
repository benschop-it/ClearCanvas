// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// Search criteria for <see cref="ExternalPractitioner"/> class.
    /// </summary>
	public partial class ExternalPractitionerSearchCriteria : EntitySearchCriteria<ExternalPractitioner>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public ExternalPractitionerSearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public ExternalPractitionerSearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected ExternalPractitionerSearchCriteria(ExternalPractitionerSearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new ExternalPractitionerSearchCriteria(this);
        }


		
	  	public ClearCanvas.Healthcare.PersonNameSearchCriteria Name
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Name"))
	  			{
	  				this.SubCriteria["Name"] = new ClearCanvas.Healthcare.PersonNameSearchCriteria("Name");
	  			}
	  			return (ClearCanvas.Healthcare.PersonNameSearchCriteria)this.SubCriteria["Name"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> LicenseNumber
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("LicenseNumber"))
	  			{
	  				this.SubCriteria["LicenseNumber"] = new SearchCondition<string>("LicenseNumber");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["LicenseNumber"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> BillingNumber
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("BillingNumber"))
	  			{
	  				this.SubCriteria["BillingNumber"] = new SearchCondition<string>("BillingNumber");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["BillingNumber"];
	  		}
	  	}
	  	
	  	public ISearchCondition<bool> IsVerified
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("IsVerified"))
	  			{
	  				this.SubCriteria["IsVerified"] = new SearchCondition<bool>("IsVerified");
	  			}
	  			return (ISearchCondition<bool>)this.SubCriteria["IsVerified"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> LastVerifiedTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("LastVerifiedTime"))
	  			{
	  				this.SubCriteria["LastVerifiedTime"] = new SearchCondition<DateTime?>("LastVerifiedTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["LastVerifiedTime"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> LastEditedTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("LastEditedTime"))
	  			{
	  				this.SubCriteria["LastEditedTime"] = new SearchCondition<DateTime?>("LastEditedTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["LastEditedTime"];
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
	  	
	  	public ISearchCondition<bool> Deactivated
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Deactivated"))
	  			{
	  				this.SubCriteria["Deactivated"] = new SearchCondition<bool>("Deactivated");
	  			}
	  			return (ISearchCondition<bool>)this.SubCriteria["Deactivated"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.ExternalPractitionerSearchCriteria MergedInto
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("MergedInto"))
	  			{
	  				this.SubCriteria["MergedInto"] = new ClearCanvas.Healthcare.ExternalPractitionerSearchCriteria("MergedInto");
	  			}
	  			return (ClearCanvas.Healthcare.ExternalPractitionerSearchCriteria)this.SubCriteria["MergedInto"];
	  		}
	  	}
	  	
	}
}
