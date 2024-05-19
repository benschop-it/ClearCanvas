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
    /// ExternalPractitioner entity
    /// </summary>
	
	[DeactivationFlag("Deactivated")]
	public  partial class ExternalPractitioner : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.PersonName _name;
	  	
	  	private string _licenseNumber;
	  	
	  	private string _billingNumber;
	  	
	  	private bool _isVerified;
	  	
	  	private DateTime? _lastVerifiedTime;
	  	
	  	private DateTime? _lastEditedTime;
	  	
	  	private Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.ExternalPractitionerContactPoint> _contactPoints;
	  	
	  	private IDictionary<string, string> _extendedProperties;
	  	
	  	private bool _deactivated;
	  	
	  	private ClearCanvas.Healthcare.ExternalPractitioner _mergedInto;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public ExternalPractitioner()
	  	{
		 	
		  	_name = new ClearCanvas.Healthcare.PersonName();
		  	
		  	_contactPoints = new HashedSet<ClearCanvas.Healthcare.ExternalPractitionerContactPoint>();
		  	
		  	_extendedProperties = new Dictionary<string, string>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public ExternalPractitioner(ClearCanvas.Healthcare.PersonName name1, string licensenumber1, string billingnumber1, bool isverified1, DateTime? lastverifiedtime1, DateTime? lasteditedtime1, Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.ExternalPractitionerContactPoint> contactpoints1, IDictionary<string, string> extendedproperties1, ClearCanvas.Healthcare.ExternalPractitioner mergedinto1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_name = name1;
		  	
		  	_licenseNumber = licensenumber1;
		  	
		  	_billingNumber = billingnumber1;
		  	
		  	_isVerified = isverified1;
		  	
		  	_lastVerifiedTime = lastverifiedtime1;
		  	
		  	_lastEditedTime = lasteditedtime1;
		  	
		  	_contactPoints = contactpoints1;
		  	
		  	_extendedProperties = extendedproperties1;
		  	
		  	_mergedInto = mergedinto1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
		[EmbeddedValue]
	  	public virtual ClearCanvas.Healthcare.PersonName Name
	  	{
			
			get { return _name; }
			
			
			 set { _name = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(100)]
	  	public virtual string LicenseNumber
	  	{
			
			get { return _licenseNumber; }
			
			
			 set { _licenseNumber = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(100)]
	  	public virtual string BillingNumber
	  	{
			
			get { return _billingNumber; }
			
			
			 set { _billingNumber = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool IsVerified
	  	{
			
			get { return _isVerified; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? LastVerifiedTime
	  	{
			
			get { return _lastVerifiedTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? LastEditedTime
	  	{
			
			get { return _lastEditedTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.ExternalPractitionerContactPoint> ContactPoints
	  	{
			
			get { return _contactPoints; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[ExtendedPropertiesCollection]
	  	public virtual IDictionary<string, string> ExtendedProperties
	  	{
			
			get { return _extendedProperties; }
			
			
			protected set { _extendedProperties = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool Deactivated
	  	{
			
			get { return _deactivated; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.ExternalPractitioner MergedInto
	  	{
			
			get { return _mergedInto; }
			
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
