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
    /// User entity
    /// </summary>
	
	public  partial class User : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private string _userName;
	  	
	  	private ClearCanvas.Enterprise.Authentication.UserAccountType _accountType;
	  	
	  	private ClearCanvas.Enterprise.Authentication.Password _password;
	  	
	  	private string _displayName;
	  	
	  	private DateTime? _validFrom;
	  	
	  	private DateTime? _validUntil;
	  	
	  	private bool _enabled;
	  	
	  	private DateTime _creationTime;
	  	
	  	private DateTime? _lastLoginTime;
	  	
	  	private string _emailAddress;
	  	
	  	private ISet<ClearCanvas.Enterprise.Authentication.AuthorityGroup> _authorityGroups;
	  	
	  	private ISet<ClearCanvas.Enterprise.Authentication.UserSession> _sessions;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public User()
	  	{
		 	
		  	_password = new ClearCanvas.Enterprise.Authentication.Password();
		  	
		  	_creationTime = Platform.Time;
		  	
		  	_authorityGroups = new HashSet<ClearCanvas.Enterprise.Authentication.AuthorityGroup>();
		  	
		  	_sessions = new HashSet<ClearCanvas.Enterprise.Authentication.UserSession>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public User(string username1, ClearCanvas.Enterprise.Authentication.UserAccountType accounttype1, ClearCanvas.Enterprise.Authentication.Password password1, string displayname1, DateTime? validfrom1, DateTime? validuntil1, bool enabled1, DateTime creationtime1, DateTime? lastlogintime1, string emailaddress1, ISet<ClearCanvas.Enterprise.Authentication.AuthorityGroup> authoritygroups1, ISet<ClearCanvas.Enterprise.Authentication.UserSession> sessions1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_userName = username1;
		  	
		  	_accountType = accounttype1;
		  	
		  	_password = password1;
		  	
		  	_displayName = displayname1;
		  	
		  	_validFrom = validfrom1;
		  	
		  	_validUntil = validuntil1;
		  	
		  	_enabled = enabled1;
		  	
		  	_creationTime = creationtime1;
		  	
		  	_lastLoginTime = lastlogintime1;
		  	
		  	_emailAddress = emailaddress1;
		  	
		  	_authorityGroups = authoritygroups1;
		  	
		  	_sessions = sessions1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
		[Unique]
	  	public virtual string UserName
	  	{
			
			get { return _userName; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Enterprise.Authentication.UserAccountType AccountType
	  	{
			
			get { return _accountType; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[EmbeddedValue]
	  	public virtual ClearCanvas.Enterprise.Authentication.Password Password
	  	{
			
			get { return _password; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual string DisplayName
	  	{
			
			get { return _displayName; }
			
			
			 set { _displayName = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? ValidFrom
	  	{
			
			get { return _validFrom; }
			
			
			 set { _validFrom = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? ValidUntil
	  	{
			
			get { return _validUntil; }
			
			
			 set { _validUntil = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool Enabled
	  	{
			
			get { return _enabled; }
			
			
			 set { _enabled = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual DateTime CreationTime
	  	{
			
			get { return _creationTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? LastLoginTime
	  	{
			
			get { return _lastLoginTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(255)]
	  	public virtual string EmailAddress
	  	{
			
			get { return _emailAddress; }
			
			
			 set { _emailAddress = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Enterprise.Authentication.AuthorityGroup> AuthorityGroups
	  	{
			
			get { return _authorityGroups; }
			
			
			protected set { _authorityGroups = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Enterprise.Authentication.UserSession> Sessions
	  	{
			
			get { return _sessions; }
			
			
			protected set { _sessions = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
