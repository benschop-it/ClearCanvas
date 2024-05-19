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
    /// NotePosting entity
    /// </summary>
	
	public  partial class NotePosting : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private DateTime _creationTime;
	  	
	  	private ClearCanvas.Healthcare.Note _note;
	  	
	  	private bool _isAcknowledged;
	  	
	  	private ClearCanvas.Healthcare.NoteAcknowledgement _acknowledgedBy;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public NotePosting()
	  	{
		 	
		  	_creationTime = Platform.Time;
		  	
		  	_acknowledgedBy = new ClearCanvas.Healthcare.NoteAcknowledgement();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public NotePosting(DateTime creationtime1, ClearCanvas.Healthcare.Note note1, bool isacknowledged1, ClearCanvas.Healthcare.NoteAcknowledgement acknowledgedby1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_creationTime = creationtime1;
		  	
		  	_note = note1;
		  	
		  	_isAcknowledged = isacknowledged1;
		  	
		  	_acknowledgedBy = acknowledgedby1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual DateTime CreationTime
	  	{
			
			get { return _creationTime; }
			
			
			 set { _creationTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.Note Note
	  	{
			
			get { return _note; }
			
			
			 set { _note = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool IsAcknowledged
	  	{
			
			get { return _isAcknowledged; }
			
			
			 set { _isAcknowledged = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValue]
	  	public virtual ClearCanvas.Healthcare.NoteAcknowledgement AcknowledgedBy
	  	{
			
			get { return _acknowledgedBy; }
			
			
			 set { _acknowledgedBy = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
