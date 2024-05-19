// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Common;
using ClearCanvas.Enterprise.Core;

namespace ClearCanvas.Enterprise.Configuration
{

    /// <summary>
    /// Search criteria for <see cref="ConfigurationDocumentBody"/> class.
    /// </summary>
	public partial class ConfigurationDocumentBodySearchCriteria : EntitySearchCriteria<ConfigurationDocumentBody>
	{
		/// <summary>
		/// Constructor for top-level search criteria (no key required)
		/// </summary>
		public ConfigurationDocumentBodySearchCriteria()
		{
		}
	
		/// <summary>
		/// Constructor for sub-criteria (key required)
		/// </summary>
		public ConfigurationDocumentBodySearchCriteria(string key)
			:base(key)
		{
		}
		
		/// <summary>
		/// Copy constructor
		/// </summary>
		protected ConfigurationDocumentBodySearchCriteria(ConfigurationDocumentBodySearchCriteria other)
			:base(other)
		{
		}
		
		public override object Clone()
        {
            return new ConfigurationDocumentBodySearchCriteria(this);
        }


		
	  	public ClearCanvas.Enterprise.Configuration.ConfigurationDocumentSearchCriteria Document
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("Document"))
	  			{
	  				this.SubCriteria["Document"] = new ClearCanvas.Enterprise.Configuration.ConfigurationDocumentSearchCriteria("Document");
	  			}
	  			return (ClearCanvas.Enterprise.Configuration.ConfigurationDocumentSearchCriteria)this.SubCriteria["Document"];
	  		}
	  	}
	  	
	  	public ISearchCondition<string> DocumentText
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("DocumentText"))
	  			{
	  				this.SubCriteria["DocumentText"] = new SearchCondition<string>("DocumentText");
	  			}
	  			return (ISearchCondition<string>)this.SubCriteria["DocumentText"];
	  		}
	  	}
	  	
	  	public ISearchCondition<DateTime> ModifiedTime
	  	{
	  		get
	  		{
	  			if(!this.SubCriteria.ContainsKey("ModifiedTime"))
	  			{
	  				this.SubCriteria["ModifiedTime"] = new SearchCondition<DateTime>("ModifiedTime");
	  			}
	  			return (ISearchCondition<DateTime>)this.SubCriteria["ModifiedTime"];
	  		}
	  	}
	  	
	}
}
