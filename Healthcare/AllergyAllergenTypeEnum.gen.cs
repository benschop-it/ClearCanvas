// This file is machine generated - changes will be lost.
using ClearCanvas.Enterprise.Core;
using ClearCanvas.Enterprise.Core.Modelling;


namespace ClearCanvas.Healthcare
{

    /// <summary>
    /// AllergyAllergenTypeEnum enumeration
    /// </summary>
	[UniqueKey("Code", new [] { "Code" })]
	[UniqueKey("Value", new [] { "Value" })]
    public partial class AllergyAllergenTypeEnum : EnumValue
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		protected AllergyAllergenTypeEnum()
		{
		}
		
		/// <summary>
		/// Constructor for creating dummy values during unit testing. Not for production use.
		/// </summary>
		public AllergyAllergenTypeEnum(string code, string value, string description)
			:base(code, value, description)
		{
		}
    }
}