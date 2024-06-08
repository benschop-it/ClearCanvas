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
    /// Facility entity
    /// </summary>
	
	[DeactivationFlag("Deactivated")]
	public  partial class Facility : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private string _code;
	  	
	  	private string _name;
	  	
	  	private string _description;
	  	
	  	private ClearCanvas.Healthcare.InformationAuthorityEnum _informationAuthority;
	  	
	  	private ISet<ClearCanvas.Healthcare.Department> _departments;
	  	
	  	private bool _deactivated;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public Facility()
	  	{
		 	
		  	_departments = new HashSet<ClearCanvas.Healthcare.Department>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public Facility(string code1, string name1, string description1, ClearCanvas.Healthcare.InformationAuthorityEnum informationauthority1, ISet<ClearCanvas.Healthcare.Department> departments1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_code = code1;
		  	
		  	_name = name1;
		  	
		  	_description = description1;
		  	
		  	_informationAuthority = informationauthority1;
		  	
		  	_departments = departments1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(30)]
		[Unique]
	  	public virtual string Code
	  	{
			
			get { return _code; }
			
			
			 set { _code = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(200)]
		[Unique]
	  	public virtual string Name
	  	{
			
			get { return _name; }
			
			
			 set { _name = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(200)]
	  	public virtual string Description
	  	{
			
			get { return _description; }
			
			
			 set { _description = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.InformationAuthorityEnum InformationAuthority
	  	{
			
			get { return _informationAuthority; }
			
			
			 set { _informationAuthority = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Healthcare.Department> Departments
	  	{
			
			get { return _departments; }
			
			
			protected set { _departments = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool Deactivated
	  	{
			
			get { return _deactivated; }
			
			
			 set { _deactivated = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
