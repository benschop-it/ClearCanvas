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
    /// Modality entity
    /// </summary>
	
	[DeactivationFlag("Deactivated")]
	public  partial class Modality : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private string _id;
	  	
	  	private string _name;
	  	
	  	private ClearCanvas.Healthcare.Facility _facility;
	  	
	  	private string _aETitle;
	  	
	  	private ClearCanvas.Healthcare.DicomModalityEnum _dicomModality;
	  	
	  	private bool _deactivated;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public Modality()
	  	{
		 	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public Modality(string id1, string name1, ClearCanvas.Healthcare.Facility facility1, string aetitle1, ClearCanvas.Healthcare.DicomModalityEnum dicommodality1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_id = id1;
		  	
		  	_name = name1;
		  	
		  	_facility = facility1;
		  	
		  	_aETitle = aetitle1;
		  	
		  	_dicomModality = dicommodality1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(30)]
		[Unique]
	  	public virtual string Id
	  	{
			
			get { return _id; }
			
			
			 set { _id = value; }
			
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
	  	public virtual ClearCanvas.Healthcare.Facility Facility
	  	{
			
			get { return _facility; }
			
			
			 set { _facility = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(16)]
	  	public virtual string AETitle
	  	{
			
			get { return _aETitle; }
			
			
			 set { _aETitle = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.DicomModalityEnum DicomModality
	  	{
			
			get { return _dicomModality; }
			
			
			 set { _dicomModality = value; }
			
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
