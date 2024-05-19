// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// Search criteria for <see cref="PatientNoteCategory"/> class.
    /// </summary>
	public partial class PatientNoteCategorySearchCriteria : EntitySearchCriteria<PatientNoteCategory>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public PatientNoteCategorySearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public PatientNoteCategorySearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected PatientNoteCategorySearchCriteria(PatientNoteCategorySearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new PatientNoteCategorySearchCriteria(this);
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
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.NoteSeverity> Severity
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Severity"))
	  			{
	  				this.SubCriteria["Severity"] = new SearchCondition<ClearCanvas.Healthcare.NoteSeverity>("Severity");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.NoteSeverity>)this.SubCriteria["Severity"];
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
	  	
	}
}
