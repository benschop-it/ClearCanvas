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
    /// Patient entity
    /// </summary>
	
	public  partial class Patient : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private ISet<ClearCanvas.Healthcare.PatientProfile> _profiles;
	  	
	  	private IList<ClearCanvas.Healthcare.PatientAttachment> _attachments;
	  	
	  	private ISet<ClearCanvas.Healthcare.PatientNote> _notes;
	  	
	  	private IList<ClearCanvas.Healthcare.Allergy> _allergies;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public Patient()
	  	{
		 	
		  	_profiles = new HashSet<ClearCanvas.Healthcare.PatientProfile>();
		  	
		  	_attachments = new List<ClearCanvas.Healthcare.PatientAttachment>();
		  	
		  	_notes = new HashSet<ClearCanvas.Healthcare.PatientNote>();
		  	
		  	_allergies = new List<ClearCanvas.Healthcare.Allergy>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public Patient(ISet<ClearCanvas.Healthcare.PatientProfile> profiles1, IList<ClearCanvas.Healthcare.PatientAttachment> attachments1, ISet<ClearCanvas.Healthcare.PatientNote> notes1, IList<ClearCanvas.Healthcare.Allergy> allergies1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_profiles = profiles1;
		  	
		  	_attachments = attachments1;
		  	
		  	_notes = notes1;
		  	
		  	_allergies = allergies1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Healthcare.PatientProfile> Profiles
	  	{
			
			get { return _profiles; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValueCollection(typeof(ClearCanvas.Healthcare.PatientAttachment))]
	  	public virtual IList<ClearCanvas.Healthcare.PatientAttachment> Attachments
	  	{
			
			get { return _attachments; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Healthcare.PatientNote> Notes
	  	{
			
			get { return _notes; }
			
			
			protected set { _notes = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValueCollection(typeof(ClearCanvas.Healthcare.Allergy))]
	  	public virtual IList<ClearCanvas.Healthcare.Allergy> Allergies
	  	{
			
			get { return _allergies; }
			
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
