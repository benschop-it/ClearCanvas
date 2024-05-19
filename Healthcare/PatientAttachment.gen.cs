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
    /// PatientAttachment component
    /// </summary>
	public sealed partial class PatientAttachment : ValueObject, IEquatable<PatientAttachment>, IAuditFormattable
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.PatientAttachmentCategoryEnum _category;
	  	
	  	private ClearCanvas.Healthcare.Staff _attachedBy;
	  	
	  	private DateTime _attachedTime;
	  	
	  	private ClearCanvas.Healthcare.AttachedDocument _document;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public PatientAttachment()
	  	{
		 	
		  	_attachedTime = Platform.Time;
		  	
		  	
		  	CustomInitialize();
	  	}

		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public PatientAttachment(ClearCanvas.Healthcare.PatientAttachmentCategoryEnum category1, ClearCanvas.Healthcare.Staff attachedby1, DateTime attachedtime1, ClearCanvas.Healthcare.AttachedDocument document1)
	  	{
		  	CustomInitialize();

			
		  	_category = category1;
		  	
		  	_attachedBy = attachedby1;
		  	
		  	_attachedTime = attachedtime1;
		  	
		  	_document = document1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
	  	public ClearCanvas.Healthcare.PatientAttachmentCategoryEnum Category
	  	{
			
			get { return _category; }
			
			
			set { _category = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public ClearCanvas.Healthcare.Staff AttachedBy
	  	{
			
			get { return _attachedBy; }
			
			
			set { _attachedBy = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public DateTime AttachedTime
	  	{
			
			get { return _attachedTime; }
			
			
			set { _attachedTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public ClearCanvas.Healthcare.AttachedDocument Document
	  	{
			
			get { return _document; }
			
			
			set { _document = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	  	
	  	#region IEquatable methods
	  	
	  	public bool Equals(PatientAttachment that)
		{
			return (that != null) &&
			
				EqualityUtils<ClearCanvas.Healthcare.PatientAttachmentCategoryEnum>.AreEqual(this._category, that._category) &&
			
				EqualityUtils<ClearCanvas.Healthcare.Staff>.AreEqual(this._attachedBy, that._attachedBy) &&
			
				EqualityUtils<DateTime>.AreEqual(this._attachedTime, that._attachedTime) &&
			
				EqualityUtils<ClearCanvas.Healthcare.AttachedDocument>.AreEqual(this._document, that._document) &&
			
				true;
		}
	  	
	  	#endregion
	  	
	  	#region Object overrides
	  	
	  	public override bool Equals(object that)
		{
			return this.Equals(that as PatientAttachment);
		}
		
		public override int GetHashCode()
		{
			return
	  	
				(_category == default(ClearCanvas.Healthcare.PatientAttachmentCategoryEnum) ? 0 : _category.GetHashCode()) ^
	  	
				(_attachedBy == default(ClearCanvas.Healthcare.Staff) ? 0 : _attachedBy.GetHashCode()) ^
	  	
				(_attachedTime == default(DateTime) ? 0 : _attachedTime.GetHashCode()) ^
	  	
				(_document == default(ClearCanvas.Healthcare.AttachedDocument) ? 0 : _document.GetHashCode()) ^
	  	
				0;
		}
				
	  	#endregion
	  	
	  	/// <summary>
	  	/// Returns a clone of this object.  A deep-copy is performed, so the clone will not share
	  	/// any mutable data with this object.
	  	/// NB. Note that collections are not currently supported.  If this object contains collections
	  	/// they will not be cloned.  It should be relatively easy to add collection support when the need arises.
	  	/// </summary>
        public override object Clone()
        {
			PatientAttachment clone = new PatientAttachment();
		
		
	  		clone._category = this._category;
		
	  		clone._attachedBy = this._attachedBy;
		
	  		clone._attachedTime = this._attachedTime;
		
	  		clone._document = this._document;
		
			return clone;
        }
		
		#region IAuditFormattable Members

		void IAuditFormattable.Write(IObjectWriter writer)
		{
			
		  	writer.WriteProperty("Category", _category);
		  	
		  	writer.WriteProperty("AttachedBy", _attachedBy);
		  	
		  	writer.WriteProperty("AttachedTime", _attachedTime);
		  	
		  	writer.WriteProperty("Document", _document);
		  	
		}

		#endregion
	}
}
