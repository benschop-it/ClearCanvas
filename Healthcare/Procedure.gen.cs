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
    /// Procedure entity
    /// </summary>
	
	public  partial class Procedure : ClearCanvas.Enterprise.Core.Entity
	{
       	#region Private fields
       	
		
	  	private ClearCanvas.Healthcare.Order _order;
	  	
	  	private ClearCanvas.Healthcare.ProcedureType _type;
	  	
	  	private string _number;
	  	
	  	private ISet<ClearCanvas.Healthcare.ProcedureStep> _procedureSteps;
	  	
	  	private DateTime? _scheduledStartTime;
	  	
	  	private int _scheduledDuration;
	  	
	  	private DateTime? _scheduledEndTime;
	  	
	  	private ClearCanvas.Healthcare.SchedulingCodeEnum _schedulingCode;
	  	
	  	private DateTime? _startTime;
	  	
	  	private DateTime? _endTime;
	  	
	  	private ClearCanvas.Healthcare.ProcedureStatus _status;
	  	
	  	private ClearCanvas.Healthcare.Facility _performingFacility;
	  	
	  	private ClearCanvas.Healthcare.Department _performingDepartment;
	  	
	  	private ClearCanvas.Healthcare.Laterality _laterality;
	  	
	  	private bool _portable;
	  	
	  	private ClearCanvas.Healthcare.ProcedureCheckIn _procedureCheckIn;
	  	
	  	private ClearCanvas.Healthcare.ImageAvailability _imageAvailability;
	  	
	  	private bool _downtimeRecoveryMode;
	  	
	  	private string _studyInstanceUID;
	  	
	  	private ISet<ClearCanvas.Healthcare.Report> _reports;
	  	
	  	private ISet<ClearCanvas.Healthcare.Protocol> _protocols;
	  	
	  	private ClearCanvas.Healthcare.Procedure _ghostOf;
	  	
	  	
	  	#endregion
	  	
	  	#region Constructors
	  	
	  	/// <summary>
	  	/// Default no-args constructor required by NHibernate
	  	/// </summary>
	  	public Procedure()
	  	{
		 	
		  	_procedureSteps = new HashSet<ClearCanvas.Healthcare.ProcedureStep>();
		  	
		  	_reports = new HashSet<ClearCanvas.Healthcare.Report>();
		  	
		  	_protocols = new HashSet<ClearCanvas.Healthcare.Protocol>();
		  	
		  	
		  	CustomInitialize();
	  	}
                
		
	  	/// <summary>
	  	/// All fields constructor
	  	/// </summary>
	  	public Procedure(ClearCanvas.Healthcare.Order order1, ClearCanvas.Healthcare.ProcedureType type1, string number1, ISet<ClearCanvas.Healthcare.ProcedureStep> proceduresteps1, DateTime? scheduledstarttime1, int scheduledduration1, DateTime? scheduledendtime1, ClearCanvas.Healthcare.SchedulingCodeEnum schedulingcode1, DateTime? starttime1, DateTime? endtime1, ClearCanvas.Healthcare.ProcedureStatus status1, ClearCanvas.Healthcare.Facility performingfacility1, ClearCanvas.Healthcare.Department performingdepartment1, ClearCanvas.Healthcare.Laterality laterality1, bool portable1, ClearCanvas.Healthcare.ProcedureCheckIn procedurecheckin1, ClearCanvas.Healthcare.ImageAvailability imageavailability1, bool downtimerecoverymode1, string studyinstanceuid1, ISet<ClearCanvas.Healthcare.Report> reports1, ISet<ClearCanvas.Healthcare.Protocol> protocols1, ClearCanvas.Healthcare.Procedure ghostof1)
			:base()
	  	{
		  	CustomInitialize();

			
		  	_order = order1;
		  	
		  	_type = type1;
		  	
		  	_number = number1;
		  	
		  	_procedureSteps = proceduresteps1;
		  	
		  	_scheduledStartTime = scheduledstarttime1;
		  	
		  	_scheduledDuration = scheduledduration1;
		  	
		  	_scheduledEndTime = scheduledendtime1;
		  	
		  	_schedulingCode = schedulingcode1;
		  	
		  	_startTime = starttime1;
		  	
		  	_endTime = endtime1;
		  	
		  	_status = status1;
		  	
		  	_performingFacility = performingfacility1;
		  	
		  	_performingDepartment = performingdepartment1;
		  	
		  	_laterality = laterality1;
		  	
		  	_portable = portable1;
		  	
		  	_procedureCheckIn = procedurecheckin1;
		  	
		  	_imageAvailability = imageavailability1;
		  	
		  	_downtimeRecoveryMode = downtimerecoverymode1;
		  	
		  	_studyInstanceUID = studyinstanceuid1;
		  	
		  	_reports = reports1;
		  	
		  	_protocols = protocols1;
		  	
		  	_ghostOf = ghostof1;
		  	
	  	}
		
                
	  	#endregion
	  	
	  	#region Public Properties
	  	
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.Order Order
	  	{
			
			get { return _order; }
			
			
			 set { _order = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.ProcedureType Type
	  	{
			
			get { return _type; }
			
			
			 set { _type = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(20)]
	  	public virtual string Number
	  	{
			
			get { return _number; }
			
			
			 set { _number = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Healthcare.ProcedureStep> ProcedureSteps
	  	{
			
			get { return _procedureSteps; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? ScheduledStartTime
	  	{
			
			get { return _scheduledStartTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual int ScheduledDuration
	  	{
			
			get { return _scheduledDuration; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual DateTime? ScheduledEndTime
	  	{
			
			get { return _scheduledEndTime; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.SchedulingCodeEnum SchedulingCode
	  	{
			
			get { return _schedulingCode; }
			
			
			 set { _schedulingCode = value; }
			
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
	  	public virtual ClearCanvas.Healthcare.ProcedureStatus Status
	  	{
			
			get { return _status; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.Facility PerformingFacility
	  	{
			
			get { return _performingFacility; }
			
			
			 set { _performingFacility = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.Department PerformingDepartment
	  	{
			
			get { return _performingDepartment; }
			
			
			 set { _performingDepartment = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.Laterality Laterality
	  	{
			
			get { return _laterality; }
			
			
			 set { _laterality = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual bool Portable
	  	{
			
			get { return _portable; }
			
			
			 set { _portable = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.ProcedureCheckIn ProcedureCheckIn
	  	{
			
			get { return _procedureCheckIn; }
			
			
			 set { _procedureCheckIn = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual ClearCanvas.Healthcare.ImageAvailability ImageAvailability
	  	{
			
			get { return _imageAvailability; }
			
			
			 set { _imageAvailability = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
	  	public virtual bool DowntimeRecoveryMode
	  	{
			
			get { return _downtimeRecoveryMode; }
			
			
			 set { _downtimeRecoveryMode = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
		[Required]
		[Length(64)]
	  	public virtual string StudyInstanceUID
	  	{
			
			get { return _studyInstanceUID; }
			
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Healthcare.Report> Reports
	  	{
			
			get { return _reports; }
			
			
			protected set { _reports = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ISet<ClearCanvas.Healthcare.Protocol> Protocols
	  	{
			
			get { return _protocols; }
			
			
			protected set { _protocols = value; }
			
	  	}
		
	  	
		
		
		[PersistentProperty]
	  	public virtual ClearCanvas.Healthcare.Procedure GhostOf
	  	{
			
			get { return _ghostOf; }
			
			
			 set { _ghostOf = value; }
			
	  	}
		
	  	
	  	
	  	#endregion
	}
}
