// This file is machine generated - changes will be lost.
using ClearCanvas.Enterprise.Core;
using ClearCanvas.Enterprise.Core.Modelling;


namespace ClearCanvas.Enterprise.Authentication
{

    /// <summary>
    /// UserAccountTypeEnum enumeration
    /// </summary>
	[UniqueKey("Code", new [] { "Code" })]
	[UniqueKey("Value", new [] { "Value" })]
    public partial class UserAccountTypeEnum : EnumValue
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		protected UserAccountTypeEnum()
		{
		}
		
		/// <summary>
		/// Constructor for creating dummy values during unit testing. Not for production use.
		/// </summary>
		public UserAccountTypeEnum(string code, string value, string description)
			:base(code, value, description)
		{
		}
    }
}