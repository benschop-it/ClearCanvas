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
    /// AttachedDocument entity
    /// </summary>
	
	public  partial class AttachedDocument : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private string _mimeType;
	  	
	  	private string _fileExtension;
	  	
	  	private DateTime _creationTime;
	  	
	  	private string _contentUrl;
	  	
	  	private ClearCanvas.Healthcare.AttachedDocument _ghostOf;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public AttachedDocument()
	  	{
		 	
		  	_creationTime = Platform.Time;
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public AttachedDocument(string mimetype1, string fileextension1, DateTime creationtime1, string contenturl1, ClearCanvas.Healthcare.AttachedDocument ghostof1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_mimeType = mimetype1;
		  	
		  	_fileExtension = fileextension1;
		  	
		  	_creationTime = creationtime1;
		  	
		  	_contentUrl = contenturl1;
		  	
		  	_ghostOf = ghostof1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(32)]
	  	public virtual string MimeType
	  	{
			
			get { return _mimeType; }
			
			
			 set { _mimeType = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(16)]
	  	public virtual string FileExtension
	  	{
			
			get { return _fileExtension; }
			
			
			 set { _fileExtension = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual DateTime CreationTime
	  	{
			
			get { return _creationTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(1024)]
	  	public virtual string ContentUrl
	  	{
			
			get { return _contentUrl; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.AttachedDocument GhostOf
	  	{
			
			get { return _ghostOf; }
			
			
			 set { _ghostOf = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
