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
    /// ExternalPractitionerContactPoint entity
    /// </summary>
	
	[DeactivationFlag("Deactivated")]
	public  partial class ExternalPractitionerContactPoint : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.ExternalPractitioner _practitioner;
	  	
	  	private string _name;
	  	
	  	private string _description;
	  	
	  	private ClearCanvas.Healthcare.ResultCommunicationMode _preferredResultCommunicationMode;
	  	
	  	private ClearCanvas.Healthcare.InformationAuthorityEnum _informationAuthority;
	  	
	  	private bool _isDefaultContactPoint;
	  	
	  	private IList<ClearCanvas.Healthcare.TelephoneNumber> _telephoneNumbers;
	  	
	  	private IList<ClearCanvas.Healthcare.Address> _addresses;
	  	
	  	private IList<ClearCanvas.Healthcare.EmailAddress> _emailAddresses;
	  	
	  	private bool _deactivated;
	  	
	  	private ClearCanvas.Healthcare.ExternalPractitionerContactPoint _mergedInto;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public ExternalPractitionerContactPoint()
	  	{
		 	
		  	_telephoneNumbers = new List<ClearCanvas.Healthcare.TelephoneNumber>();
		  	
		  	_addresses = new List<ClearCanvas.Healthcare.Address>();
		  	
		  	_emailAddresses = new List<ClearCanvas.Healthcare.EmailAddress>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public ExternalPractitionerContactPoint(ClearCanvas.Healthcare.ExternalPractitioner practitioner1, string name1, string description1, ClearCanvas.Healthcare.ResultCommunicationMode preferredresultcommunicationmode1, ClearCanvas.Healthcare.InformationAuthorityEnum informationauthority1, bool isdefaultcontactpoint1, IList<ClearCanvas.Healthcare.TelephoneNumber> telephonenumbers1, IList<ClearCanvas.Healthcare.Address> addresses1, IList<ClearCanvas.Healthcare.EmailAddress> emailaddresses1, ClearCanvas.Healthcare.ExternalPractitionerContactPoint mergedinto1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_practitioner = practitioner1;
		  	
		  	_name = name1;
		  	
		  	_description = description1;
		  	
		  	_preferredResultCommunicationMode = preferredresultcommunicationmode1;
		  	
		  	_informationAuthority = informationauthority1;
		  	
		  	_isDefaultContactPoint = isdefaultcontactpoint1;
		  	
		  	_telephoneNumbers = telephonenumbers1;
		  	
		  	_addresses = addresses1;
		  	
		  	_emailAddresses = emailaddresses1;
		  	
		  	_mergedInto = mergedinto1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.ExternalPractitioner Practitioner
	  	{
			
			get { return _practitioner; }
			
			
			 set { _practitioner = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual string Name
	  	{
			
			get { return _name; }
			
			
			 set { _name = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual string Description
	  	{
			
			get { return _description; }
			
			
			 set { _description = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.ResultCommunicationMode PreferredResultCommunicationMode
	  	{
			
			get { return _preferredResultCommunicationMode; }
			
			
			 set { _preferredResultCommunicationMode = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.InformationAuthorityEnum InformationAuthority
	  	{
			
			get { return _informationAuthority; }
			
			
			 set { _informationAuthority = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool IsDefaultContactPoint
	  	{
			
			get { return _isDefaultContactPoint; }
			
			
			 set { _isDefaultContactPoint = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValueCollection(typeof(ClearCanvas.Healthcare.TelephoneNumber))]
	  	public virtual IList<ClearCanvas.Healthcare.TelephoneNumber> TelephoneNumbers
	  	{
			
			get { return _telephoneNumbers; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValueCollection(typeof(ClearCanvas.Healthcare.Address))]
	  	public virtual IList<ClearCanvas.Healthcare.Address> Addresses
	  	{
			
			get { return _addresses; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValueCollection(typeof(ClearCanvas.Healthcare.EmailAddress))]
	  	public virtual IList<ClearCanvas.Healthcare.EmailAddress> EmailAddresses
	  	{
			
			get { return _emailAddresses; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool Deactivated
	  	{
			
			get { return _deactivated; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.ExternalPractitionerContactPoint MergedInto
	  	{
			
			get { return _mergedInto; }
			
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
