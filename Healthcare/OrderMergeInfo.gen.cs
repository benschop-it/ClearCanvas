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
    /// OrderMergeInfo component
    /// </summary>
	public sealed partial class OrderMergeInfo : ValueObject, IEquatable<OrderMergeInfo>, IAuditFormattable
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.Staff _mergedBy;
	  	
	  	private DateTime? _mergedTime;
	  	
	  	private ClearCanvas.Healthcare.Order _mergeDestinationOrder;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public OrderMergeInfo()
	  	{
		 	
		  	
		  	CustomInitialize();
	  	}

		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public OrderMergeInfo(ClearCanvas.Healthcare.Staff mergedby1, DateTime? mergedtime1, ClearCanvas.Healthcare.Order mergedestinationorder1)
	  	{
		  	CustomInitialize();

			
		  	_mergedBy = mergedby1;
		  	
		  	_mergedTime = mergedtime1;
		  	
		  	_mergeDestinationOrder = mergedestinationorder1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
	  	public ClearCanvas.Healthcare.Staff MergedBy
	  	{
			
			get { return _mergedBy; }
			
			
			set { _mergedBy = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public DateTime? MergedTime
	  	{
			
			get { return _mergedTime; }
			
			
			set { _mergedTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public ClearCanvas.Healthcare.Order MergeDestinationOrder
	  	{
			
			get { return _mergeDestinationOrder; }
			
			
			set { _mergeDestinationOrder = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	  	
	  	#region IEquatable methods
	  	
	  	public bool Equals(OrderMergeInfo that)
		{
			return (that != null) &&
			
				EqualityUtils<ClearCanvas.Healthcare.Staff>.AreEqual(this._mergedBy, that._mergedBy) &&
			
				EqualityUtils<DateTime?>.AreEqual(this._mergedTime, that._mergedTime) &&
			
				EqualityUtils<ClearCanvas.Healthcare.Order>.AreEqual(this._mergeDestinationOrder, that._mergeDestinationOrder) &&
			
				true;
		}
	  	
	  	#endregion
	  	
	  	#region Object overrides
	  	
	  	public override bool Equals(object that)
		{
			return this.Equals(that as OrderMergeInfo);
		}
		
		public override int GetHashCode()
		{
			return
	  	
				(_mergedBy == default(ClearCanvas.Healthcare.Staff) ? 0 : _mergedBy.GetHashCode()) ^
	  	
				(_mergedTime == default(DateTime?) ? 0 : _mergedTime.GetHashCode()) ^
	  	
				(_mergeDestinationOrder == default(ClearCanvas.Healthcare.Order) ? 0 : _mergeDestinationOrder.GetHashCode()) ^
	  	
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
			OrderMergeInfo clone = new OrderMergeInfo();
		
		
	  		clone._mergedBy = this._mergedBy;
		
	  		clone._mergedTime = this._mergedTime;
		
	  		clone._mergeDestinationOrder = this._mergeDestinationOrder;
		
			return clone;
        }
		
		#region IAuditFormattable Members

		void IAuditFormattable.Write(IObjectWriter writer)
		{
			
		  	writer.WriteProperty("MergedBy", _mergedBy);
		  	
		  	writer.WriteProperty("MergedTime", _mergedTime);
		  	
		  	writer.WriteProperty("MergeDestinationOrder", _mergeDestinationOrder);
		  	
		}

		#endregion
	}
}
