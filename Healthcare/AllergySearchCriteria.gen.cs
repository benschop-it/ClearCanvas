// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// Search criteria for <see cref="Allergy"/> class.
    /// </summary>
	public partial class AllergySearchCriteria : SearchCriteria
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public AllergySearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public AllergySearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected AllergySearchCriteria(AllergySearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new AllergySearchCriteria(this);
        }


		
	  	public ISearchCondition<ClearCanvas.Healthcare.AllergyAllergenTypeEnum> AllergenType
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("AllergenType"))
	  			{
	  				this.SubCriteria["AllergenType"] = new SearchCondition<ClearCanvas.Healthcare.AllergyAllergenTypeEnum>("AllergenType");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.AllergyAllergenTypeEnum>)this.SubCriteria["AllergenType"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> AllergenDescription
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("AllergenDescription"))
	  			{
	  				this.SubCriteria["AllergenDescription"] = new SearchCondition<string>("AllergenDescription");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["AllergenDescription"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.AllergySeverityEnum> Severity
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Severity"))
	  			{
	  				this.SubCriteria["Severity"] = new SearchCondition<ClearCanvas.Healthcare.AllergySeverityEnum>("Severity");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.AllergySeverityEnum>)this.SubCriteria["Severity"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> Reaction
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Reaction"))
	  			{
	  				this.SubCriteria["Reaction"] = new SearchCondition<string>("Reaction");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["Reaction"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.AllergySensitivityTypeEnum> SensitivityType
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("SensitivityType"))
	  			{
	  				this.SubCriteria["SensitivityType"] = new SearchCondition<ClearCanvas.Healthcare.AllergySensitivityTypeEnum>("SensitivityType");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.AllergySensitivityTypeEnum>)this.SubCriteria["SensitivityType"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> OnsetTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("OnsetTime"))
	  			{
	  				this.SubCriteria["OnsetTime"] = new SearchCondition<DateTime?>("OnsetTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["OnsetTime"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime?> ReportedTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ReportedTime"))
	  			{
	  				this.SubCriteria["ReportedTime"] = new SearchCondition<DateTime?>("ReportedTime");
	  			}
	  			return (ISearchCondition<DateTime?>)this.SubCriteria["ReportedTime"];
	  		}
	  	}
	  	
	  	public ClearCanvas.Healthcare.PersonNameSearchCriteria Reporter
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Reporter"))
	  			{
	  				this.SubCriteria["Reporter"] = new ClearCanvas.Healthcare.PersonNameSearchCriteria("Reporter");
	  			}
	  			return (ClearCanvas.Healthcare.PersonNameSearchCriteria)this.SubCriteria["Reporter"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.PersonRelationshipTypeEnum> ReporterRelationshipType
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ReporterRelationshipType"))
	  			{
	  				this.SubCriteria["ReporterRelationshipType"] = new SearchCondition<ClearCanvas.Healthcare.PersonRelationshipTypeEnum>("ReporterRelationshipType");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.PersonRelationshipTypeEnum>)this.SubCriteria["ReporterRelationshipType"];
	  		}
	  	}
	  	
	}
}
