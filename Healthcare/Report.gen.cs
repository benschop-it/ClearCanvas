// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using Iesi.Collections.Generic;
using ClearCanvas.Common;
using ClearCanvas.Enterprise.Core;
using ClearCanvas.Enterprise.Core.Modelling;


namespace ClearCanvas.Healthcare
{


    /// <summary>
    /// Report entity
    /// </summary>
	
	public  partial class Report : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.ReportStatus _status;
	  	
	  	private Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> _procedures;
	  	
	  	private IList<ClearCanvas.Healthcare.ReportPart> _parts;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public Report()
	  	{
		 	
		  	_procedures = new HashedSet<ClearCanvas.Healthcare.Procedure>();
		  	
		  	_parts = new List<ClearCanvas.Healthcare.ReportPart>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public Report(ClearCanvas.Healthcare.ReportStatus status1, Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> procedures1, IList<ClearCanvas.Healthcare.ReportPart> parts1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_status = status1;
		  	
		  	_procedures = procedures1;
		  	
		  	_parts = parts1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.ReportStatus Status
	  	{
			
			get { return _status; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> Procedures
	  	{
			
			get { return _procedures; }
			
			
			protected set { _procedures = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual IList<ClearCanvas.Healthcare.ReportPart> Parts
	  	{
			
			get { return _parts; }
			
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
