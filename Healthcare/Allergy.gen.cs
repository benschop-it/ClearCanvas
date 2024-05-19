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
    /// Allergy component
    /// </summary>
	public sealed partial class Allergy : ValueObject, IEquatable<Allergy>, IAuditFormattable
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.AllergyAllergenTypeEnum _allergenType;
	  	
	  	private string _allergenDescription;
	  	
	  	private ClearCanvas.Healthcare.AllergySeverityEnum _severity;
	  	
	  	private string _reaction;
	  	
	  	private ClearCanvas.Healthcare.AllergySensitivityTypeEnum _sensitivityType;
	  	
	  	private DateTime? _onsetTime;
	  	
	  	private DateTime? _reportedTime;
	  	
	  	private ClearCanvas.Healthcare.PersonName _reporter;
	  	
	  	private ClearCanvas.Healthcare.PersonRelationshipTypeEnum _reporterRelationshipType;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public Allergy()
	  	{
		 	
		  	_reporter = new ClearCanvas.Healthcare.PersonName();
		  	
		  	
		  	CustomInitialize();
	  	}

		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public Allergy(ClearCanvas.Healthcare.AllergyAllergenTypeEnum allergentype1, string allergendescription1, ClearCanvas.Healthcare.AllergySeverityEnum severity1, string reaction1, ClearCanvas.Healthcare.AllergySensitivityTypeEnum sensitivitytype1, DateTime? onsettime1, DateTime? reportedtime1, ClearCanvas.Healthcare.PersonName reporter1, ClearCanvas.Healthcare.PersonRelationshipTypeEnum reporterrelationshiptype1)
	  	{
		  	CustomInitialize();

			
		  	_allergenType = allergentype1;
		  	
		  	_allergenDescription = allergendescription1;
		  	
		  	_severity = severity1;
		  	
		  	_reaction = reaction1;
		  	
		  	_sensitivityType = sensitivitytype1;
		  	
		  	_onsetTime = onsettime1;
		  	
		  	_reportedTime = reportedtime1;
		  	
		  	_reporter = reporter1;
		  	
		  	_reporterRelationshipType = reporterrelationshiptype1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public ClearCanvas.Healthcare.AllergyAllergenTypeEnum AllergenType
	  	{
			
			get { return _allergenType; }
			
			
			set { _allergenType = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(255)]
	  	public string AllergenDescription
	  	{
			
			get { return _allergenDescription; }
			
			
			set { _allergenDescription = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public ClearCanvas.Healthcare.AllergySeverityEnum Severity
	  	{
			
			get { return _severity; }
			
			
			set { _severity = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(255)]
	  	public string Reaction
	  	{
			
			get { return _reaction; }
			
			
			set { _reaction = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public ClearCanvas.Healthcare.AllergySensitivityTypeEnum SensitivityType
	  	{
			
			get { return _sensitivityType; }
			
			
			set { _sensitivityType = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public DateTime? OnsetTime
	  	{
			
			get { return _onsetTime; }
			
			
			set { _onsetTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public DateTime? ReportedTime
	  	{
			
			get { return _reportedTime; }
			
			
			set { _reportedTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[EmbeddedValue]
	  	public ClearCanvas.Healthcare.PersonName Reporter
	  	{
			
			get { return _reporter; }
			
			
			set { _reporter = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public ClearCanvas.Healthcare.PersonRelationshipTypeEnum ReporterRelationshipType
	  	{
			
			get { return _reporterRelationshipType; }
			
			
			set { _reporterRelationshipType = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	  	
	  	#region IEquatable methods
	  	
	  	public bool Equals(Allergy that)
		{
			return (that != null) &&
			
				EqualityUtils<ClearCanvas.Healthcare.AllergyAllergenTypeEnum>.AreEqual(this._allergenType, that._allergenType) &&
			
				EqualityUtils<string>.AreEqual(this._allergenDescription, that._allergenDescription) &&
			
				EqualityUtils<ClearCanvas.Healthcare.AllergySeverityEnum>.AreEqual(this._severity, that._severity) &&
			
				EqualityUtils<string>.AreEqual(this._reaction, that._reaction) &&
			
				EqualityUtils<ClearCanvas.Healthcare.AllergySensitivityTypeEnum>.AreEqual(this._sensitivityType, that._sensitivityType) &&
			
				EqualityUtils<DateTime?>.AreEqual(this._onsetTime, that._onsetTime) &&
			
				EqualityUtils<DateTime?>.AreEqual(this._reportedTime, that._reportedTime) &&
			
				EqualityUtils<ClearCanvas.Healthcare.PersonName>.AreEqual(this._reporter, that._reporter) &&
			
				EqualityUtils<ClearCanvas.Healthcare.PersonRelationshipTypeEnum>.AreEqual(this._reporterRelationshipType, that._reporterRelationshipType) &&
			
				true;
		}
	  	
	  	#endregion
	  	
	  	#region Object overrides
	  	
	  	public override bool Equals(object that)
		{
			return this.Equals(that as Allergy);
		}
		
		public override int GetHashCode()
		{
			return
	  	
				(_allergenType == default(ClearCanvas.Healthcare.AllergyAllergenTypeEnum) ? 0 : _allergenType.GetHashCode()) ^
	  	
				(_allergenDescription == default(string) ? 0 : _allergenDescription.GetHashCode()) ^
	  	
				(_severity == default(ClearCanvas.Healthcare.AllergySeverityEnum) ? 0 : _severity.GetHashCode()) ^
	  	
				(_reaction == default(string) ? 0 : _reaction.GetHashCode()) ^
	  	
				(_sensitivityType == default(ClearCanvas.Healthcare.AllergySensitivityTypeEnum) ? 0 : _sensitivityType.GetHashCode()) ^
	  	
				(_onsetTime == default(DateTime?) ? 0 : _onsetTime.GetHashCode()) ^
	  	
				(_reportedTime == default(DateTime?) ? 0 : _reportedTime.GetHashCode()) ^
	  	
				(_reporter == default(ClearCanvas.Healthcare.PersonName) ? 0 : _reporter.GetHashCode()) ^
	  	
				(_reporterRelationshipType == default(ClearCanvas.Healthcare.PersonRelationshipTypeEnum) ? 0 : _reporterRelationshipType.GetHashCode()) ^
	  	
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
			Allergy clone = new Allergy();
		
			clone._reporter = (this._reporter == default(ClearCanvas.Healthcare.PersonName)) ? default(ClearCanvas.Healthcare.PersonName) : (ClearCanvas.Healthcare.PersonName)this._reporter.Clone();
		
		
	  		clone._allergenType = this._allergenType;
		
	  		clone._allergenDescription = this._allergenDescription;
		
	  		clone._severity = this._severity;
		
	  		clone._reaction = this._reaction;
		
	  		clone._sensitivityType = this._sensitivityType;
		
	  		clone._onsetTime = this._onsetTime;
		
	  		clone._reportedTime = this._reportedTime;
		
	  		clone._reporterRelationshipType = this._reporterRelationshipType;
		
			return clone;
        }
		
		#region IAuditFormattable Members

		void IAuditFormattable.Write(IObjectWriter writer)
		{
			
		  	writer.WriteProperty("AllergenType", _allergenType);
		  	
		  	writer.WriteProperty("AllergenDescription", _allergenDescription);
		  	
		  	writer.WriteProperty("Severity", _severity);
		  	
		  	writer.WriteProperty("Reaction", _reaction);
		  	
		  	writer.WriteProperty("SensitivityType", _sensitivityType);
		  	
		  	writer.WriteProperty("OnsetTime", _onsetTime);
		  	
		  	writer.WriteProperty("ReportedTime", _reportedTime);
		  	
		  	writer.WriteProperty("Reporter", _reporter);
		  	
		  	writer.WriteProperty("ReporterRelationshipType", _reporterRelationshipType);
		  	
		}

		#endregion
	}
}
