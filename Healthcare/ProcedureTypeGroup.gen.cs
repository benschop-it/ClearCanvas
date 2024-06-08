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
    /// ProcedureTypeGroup entity
    /// </summary>
	
	public  partial class ProcedureTypeGroup : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private string _name;
	  	
	  	private string _description;
	  	
	  	private ISet<ClearCanvas.Healthcare.ProcedureType> _procedureTypes;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public ProcedureTypeGroup()
	  	{
		 	
		  	_procedureTypes = new HashSet<ClearCanvas.Healthcare.ProcedureType>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public ProcedureTypeGroup(string name1, string description1, ISet<ClearCanvas.Healthcare.ProcedureType> proceduretypes1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_name = name1;
		  	
		  	_description = description1;
		  	
		  	_procedureTypes = proceduretypes1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(100)]
		[Unique]
	  	public virtual string Name
	  	{
			
			get { return _name; }
			
			
			 set { _name = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(1024)]
	  	public virtual string Description
	  	{
			
			get { return _description; }
			
			
			 set { _description = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Healthcare.ProcedureType> ProcedureTypes
	  	{
			
			get { return _procedureTypes; }
			
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
