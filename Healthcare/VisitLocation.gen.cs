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
    /// VisitLocation component
    /// </summary>
	public sealed partial class VisitLocation : ValueObject, IEquatable<VisitLocation>, IAuditFormattable
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.Location _location;
	  	
	  	private string _room;
	  	
	  	private string _bed;
	  	
	  	private ClearCanvas.Healthcare.VisitLocationRole _role;
	  	
	  	private DateTime? _startTime;
	  	
	  	private DateTime? _endTime;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public VisitLocation()
	  	{
		 	
		  	
		  	CustomInitialize();
	  	}

		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public VisitLocation(ClearCanvas.Healthcare.Location location1, string room1, string bed1, ClearCanvas.Healthcare.VisitLocationRole role1, DateTime? starttime1, DateTime? endtime1)
	  	{
		  	CustomInitialize();

			
		  	_location = location1;
		  	
		  	_room = room1;
		  	
		  	_bed = bed1;
		  	
		  	_role = role1;
		  	
		  	_startTime = starttime1;
		  	
		  	_endTime = endtime1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public ClearCanvas.Healthcare.Location Location
	  	{
			
			get { return _location; }
			
			
			set { _location = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(100)]
	  	public string Room
	  	{
			
			get { return _room; }
			
			
			set { _room = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(100)]
	  	public string Bed
	  	{
			
			get { return _bed; }
			
			
			set { _bed = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public ClearCanvas.Healthcare.VisitLocationRole Role
	  	{
			
			get { return _role; }
			
			
			set { _role = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public DateTime? StartTime
	  	{
			
			get { return _startTime; }
			
			
			set { _startTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public DateTime? EndTime
	  	{
			
			get { return _endTime; }
			
			
			set { _endTime = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	  	
	  	#region IEquatable methods
	  	
	  	public bool Equals(VisitLocation that)
		{
			return (that != null) &&
			
				EqualityUtils<ClearCanvas.Healthcare.Location>.AreEqual(this._location, that._location) &&
			
				EqualityUtils<string>.AreEqual(this._room, that._room) &&
			
				EqualityUtils<string>.AreEqual(this._bed, that._bed) &&
			
				EqualityUtils<ClearCanvas.Healthcare.VisitLocationRole>.AreEqual(this._role, that._role) &&
			
				EqualityUtils<DateTime?>.AreEqual(this._startTime, that._startTime) &&
			
				EqualityUtils<DateTime?>.AreEqual(this._endTime, that._endTime) &&
			
				true;
		}
	  	
	  	#endregion
	  	
	  	#region Object overrides
	  	
	  	public override bool Equals(object that)
		{
			return this.Equals(that as VisitLocation);
		}
		
		public override int GetHashCode()
		{
			return
	  	
				(_location == default(ClearCanvas.Healthcare.Location) ? 0 : _location.GetHashCode()) ^
	  	
				(_room == default(string) ? 0 : _room.GetHashCode()) ^
	  	
				(_bed == default(string) ? 0 : _bed.GetHashCode()) ^
	  	
				(_role == default(ClearCanvas.Healthcare.VisitLocationRole) ? 0 : _role.GetHashCode()) ^
	  	
				(_startTime == default(DateTime?) ? 0 : _startTime.GetHashCode()) ^
	  	
				(_endTime == default(DateTime?) ? 0 : _endTime.GetHashCode()) ^
	  	
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
			VisitLocation clone = new VisitLocation();
		
		
	  		clone._location = this._location;
		
	  		clone._room = this._room;
		
	  		clone._bed = this._bed;
		
	  		clone._role = this._role;
		
	  		clone._startTime = this._startTime;
		
	  		clone._endTime = this._endTime;
		
			return clone;
        }
		
		#region IAuditFormattable Members

		void IAuditFormattable.Write(IObjectWriter writer)
		{
			
		  	writer.WriteProperty("Location", _location);
		  	
		  	writer.WriteProperty("Room", _room);
		  	
		  	writer.WriteProperty("Bed", _bed);
		  	
		  	writer.WriteProperty("Role", _role);
		  	
		  	writer.WriteProperty("StartTime", _startTime);
		  	
		  	writer.WriteProperty("EndTime", _endTime);
		  	
		}

		#endregion
	}
}
