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
    /// Order entity
    /// </summary>
	
	public  partial class Order : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.Patient _patient;
	  	
	  	private ClearCanvas.Healthcare.Visit _visit;
	  	
	  	private string _placerNumber;
	  	
	  	private string _accessionNumber;
	  	
	  	private ClearCanvas.Healthcare.DiagnosticService _diagnosticService;
	  	
	  	private DateTime _enteredTime;
	  	
	  	private ClearCanvas.Healthcare.Staff _enteredBy;
	  	
	  	private string _enteredComment;
	  	
	  	private DateTime? _schedulingRequestTime;
	  	
	  	private DateTime? _scheduledStartTime;
	  	
	  	private DateTime? _startTime;
	  	
	  	private DateTime? _endTime;
	  	
	  	private ClearCanvas.Healthcare.ExternalPractitioner _orderingPractitioner;
	  	
	  	private ClearCanvas.Healthcare.Facility _orderingFacility;
	  	
	  	private Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> _procedures;
	  	
	  	private Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> _ghostProcedures;
	  	
	  	private IList<ClearCanvas.Healthcare.ResultRecipient> _resultRecipients;
	  	
	  	private IList<ClearCanvas.Healthcare.OrderAttachment> _attachments;
	  	
	  	private string _reasonForStudy;
	  	
	  	private ClearCanvas.Healthcare.OrderPriority _priority;
	  	
	  	private int _priorityRank;
	  	
	  	private ClearCanvas.Healthcare.OrderStatus _status;
	  	
	  	private ClearCanvas.Healthcare.OrderCancelInfo _cancelInfo;
	  	
	  	private ClearCanvas.Healthcare.OrderMergeInfo _mergeInfo;
	  	
	  	private Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Order> _mergeSourceOrders;
	  	
	  	private IDictionary<string, string> _extendedProperties;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public Order()
	  	{
		 	
		  	_enteredTime = Platform.Time;
		  	
		  	_procedures = new HashedSet<ClearCanvas.Healthcare.Procedure>();
		  	
		  	_ghostProcedures = new HashedSet<ClearCanvas.Healthcare.Procedure>();
		  	
		  	_resultRecipients = new List<ClearCanvas.Healthcare.ResultRecipient>();
		  	
		  	_attachments = new List<ClearCanvas.Healthcare.OrderAttachment>();
		  	
		  	_cancelInfo = new ClearCanvas.Healthcare.OrderCancelInfo();
		  	
		  	_mergeInfo = new ClearCanvas.Healthcare.OrderMergeInfo();
		  	
		  	_mergeSourceOrders = new HashedSet<ClearCanvas.Healthcare.Order>();
		  	
		  	_extendedProperties = new Dictionary<string, string>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public Order(ClearCanvas.Healthcare.Patient patient1, ClearCanvas.Healthcare.Visit visit1, string placernumber1, string accessionnumber1, ClearCanvas.Healthcare.DiagnosticService diagnosticservice1, DateTime enteredtime1, ClearCanvas.Healthcare.Staff enteredby1, string enteredcomment1, DateTime? schedulingrequesttime1, DateTime? scheduledstarttime1, DateTime? starttime1, DateTime? endtime1, ClearCanvas.Healthcare.ExternalPractitioner orderingpractitioner1, ClearCanvas.Healthcare.Facility orderingfacility1, Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> procedures1, Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> ghostprocedures1, IList<ClearCanvas.Healthcare.ResultRecipient> resultrecipients1, IList<ClearCanvas.Healthcare.OrderAttachment> attachments1, string reasonforstudy1, ClearCanvas.Healthcare.OrderPriority priority1, int priorityrank1, ClearCanvas.Healthcare.OrderStatus status1, ClearCanvas.Healthcare.OrderCancelInfo cancelinfo1, ClearCanvas.Healthcare.OrderMergeInfo mergeinfo1, Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Order> mergesourceorders1, IDictionary<string, string> extendedproperties1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_patient = patient1;
		  	
		  	_visit = visit1;
		  	
		  	_placerNumber = placernumber1;
		  	
		  	_accessionNumber = accessionnumber1;
		  	
		  	_diagnosticService = diagnosticservice1;
		  	
		  	_enteredTime = enteredtime1;
		  	
		  	_enteredBy = enteredby1;
		  	
		  	_enteredComment = enteredcomment1;
		  	
		  	_schedulingRequestTime = schedulingrequesttime1;
		  	
		  	_scheduledStartTime = scheduledstarttime1;
		  	
		  	_startTime = starttime1;
		  	
		  	_endTime = endtime1;
		  	
		  	_orderingPractitioner = orderingpractitioner1;
		  	
		  	_orderingFacility = orderingfacility1;
		  	
		  	_procedures = procedures1;
		  	
		  	_ghostProcedures = ghostprocedures1;
		  	
		  	_resultRecipients = resultrecipients1;
		  	
		  	_attachments = attachments1;
		  	
		  	_reasonForStudy = reasonforstudy1;
		  	
		  	_priority = priority1;
		  	
		  	_priorityRank = priorityrank1;
		  	
		  	_status = status1;
		  	
		  	_cancelInfo = cancelinfo1;
		  	
		  	_mergeInfo = mergeinfo1;
		  	
		  	_mergeSourceOrders = mergesourceorders1;
		  	
		  	_extendedProperties = extendedproperties1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.Patient Patient
	  	{
			
			get { return _patient; }
			
			
			 set { _patient = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.Visit Visit
	  	{
			
			get { return _visit; }
			
			
			 set { _visit = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(30)]
	  	public virtual string PlacerNumber
	  	{
			
			get { return _placerNumber; }
			
			
			 set { _placerNumber = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(30)]
		[Unique]
	  	public virtual string AccessionNumber
	  	{
			
			get { return _accessionNumber; }
			
			
			 set { _accessionNumber = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.DiagnosticService DiagnosticService
	  	{
			
			get { return _diagnosticService; }
			
			
			 set { _diagnosticService = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual DateTime EnteredTime
	  	{
			
			get { return _enteredTime; }
			
			
			 set { _enteredTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.Staff EnteredBy
	  	{
			
			get { return _enteredBy; }
			
			
			 set { _enteredBy = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual string EnteredComment
	  	{
			
			get { return _enteredComment; }
			
			
			 set { _enteredComment = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? SchedulingRequestTime
	  	{
			
			get { return _schedulingRequestTime; }
			
			
			 set { _schedulingRequestTime = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? ScheduledStartTime
	  	{
			
			get { return _scheduledStartTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? StartTime
	  	{
			
			get { return _startTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? EndTime
	  	{
			
			get { return _endTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.ExternalPractitioner OrderingPractitioner
	  	{
			
			get { return _orderingPractitioner; }
			
			
			 set { _orderingPractitioner = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.Facility OrderingFacility
	  	{
			
			get { return _orderingFacility; }
			
			
			 set { _orderingFacility = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Procedure> Procedures
	  	{
			
			get { return _procedures; }
			
			
			protected set { _procedures = value; }
			
	  	}
		
	  	
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValueCollection(typeof(ClearCanvas.Healthcare.ResultRecipient))]
	  	public virtual IList<ClearCanvas.Healthcare.ResultRecipient> ResultRecipients
	  	{
			
			get { return _resultRecipients; }
			
			
			protected set { _resultRecipients = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValueCollection(typeof(ClearCanvas.Healthcare.OrderAttachment))]
	  	public virtual IList<ClearCanvas.Healthcare.OrderAttachment> Attachments
	  	{
			
			get { return _attachments; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Length(400)]
	  	public virtual string ReasonForStudy
	  	{
			
			get { return _reasonForStudy; }
			
			
			 set { _reasonForStudy = value; }
			
	  	}
		
	  	
		
	  	
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.OrderStatus Status
	  	{
			
			get { return _status; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValue]
	  	public virtual ClearCanvas.Healthcare.OrderCancelInfo CancelInfo
	  	{
			
			get { return _cancelInfo; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[EmbeddedValue]
	  	public virtual ClearCanvas.Healthcare.OrderMergeInfo MergeInfo
	  	{
			
			get { return _mergeInfo; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual Iesi.Collections.Generic.ISet<ClearCanvas.Healthcare.Order> MergeSourceOrders
	  	{
			
			get { return _mergeSourceOrders; }
			
			
			protected set { _mergeSourceOrders = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[ExtendedPropertiesCollection]
	  	public virtual IDictionary<string, string> ExtendedProperties
	  	{
			
			get { return _extendedProperties; }
			
			
			protected set { _extendedProperties = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
