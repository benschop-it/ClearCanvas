// This file is machine generated - changes will be lost.
using ClearCanvas.Enterprise.Core;
using ClearCanvas.Enterprise.Core.Modelling;


namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// PatientAttachmentCategoryEnum enumeration
    /// </summary>
	[UniqueKey("Code", new [] { "Code" })]
	[UniqueKey("Value", new [] { "Value" })]
    public partial class PatientAttachmentCategoryEnum : EnumValue
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		protected PatientAttachmentCategoryEnum()
		{
		}
		
		/// <summary>
		/// Constructor for creating dummy values during unit testing. Not for production use.
		/// </summary>
		public PatientAttachmentCategoryEnum(string code, string value, string description)
			:base(code, value, description)
		{
		}
    }
}