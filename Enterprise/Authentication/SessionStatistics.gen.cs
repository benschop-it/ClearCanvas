// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using Iesi.Collections.Generic;
using ClearCanvas.Common;
using ClearCanvas.Enterprise.Core;
using ClearCanvas.Enterprise.Core.Modelling;


namespace ClearCanvas.Enterprise.Authentication
{


    /// <summary>
    /// SessionStatistics entity
    /// </summary>
	
	public  partial class SessionStatistics : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private DateTime _timestamp;
	  	
	  	private string _application;
	  	
	  	private Int32 _activeSessions;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public SessionStatistics()
	  	{
		 	
		  	_timestamp = Platform.Time;
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public SessionStatistics(DateTime timestamp1, string application1, Int32 activesessions1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_timestamp = timestamp1;
		  	
		  	_application = application1;
		  	
		  	_activeSessions = activesessions1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual DateTime Timestamp
	  	{
			
			get { return _timestamp; }
			
			
			 set { _timestamp = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(255)]
	  	public virtual string Application
	  	{
			
			get { return _application; }
			
			
			 set { _application = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual Int32 ActiveSessions
	  	{
			
			get { return _activeSessions; }
			
			
			 set { _activeSessions = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
