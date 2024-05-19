// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// Search criteria for <see cref="Modality"/> class.
    /// </summary>
	public partial class ModalitySearchCriteria : EntitySearchCriteria<Modality>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public ModalitySearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public ModalitySearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected ModalitySearchCriteria(ModalitySearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new ModalitySearchCriteria(this);
        }


		
	  	public ISearchCondition<string> Id
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Id"))
	  			{
	  				this.SubCriteria["Id"] = new SearchCondition<string>("Id");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["Id"];
	  		}
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
	  	
	  	public ClearCanvas.Healthcare.FacilitySearchCriteria Facility
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Facility"))
	  			{
	  				this.SubCriteria["Facility"] = new ClearCanvas.Healthcare.FacilitySearchCriteria("Facility");
	  			}
	  			return (ClearCanvas.Healthcare.FacilitySearchCriteria)this.SubCriteria["Facility"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> AETitle
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("AETitle"))
	  			{
	  				this.SubCriteria["AETitle"] = new SearchCondition<string>("AETitle");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["AETitle"];
	  		}
	  	}
	  	
	  	public ISearchCondition<ClearCanvas.Healthcare.DicomModalityEnum> DicomModality
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("DicomModality"))
	  			{
	  				this.SubCriteria["DicomModality"] = new SearchCondition<ClearCanvas.Healthcare.DicomModalityEnum>("DicomModality");
	  			}
	  			return (ISearchCondition<ClearCanvas.Healthcare.DicomModalityEnum>)this.SubCriteria["DicomModality"];
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
