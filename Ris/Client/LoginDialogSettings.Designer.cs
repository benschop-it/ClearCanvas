﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Client {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class LoginDialogSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static LoginDialogSettings defaultInstance = ((LoginDialogSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LoginDialogSettings())));
        
        public static LoginDialogSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Last working facility selected at this workstation
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Last working facility selected at this workstation")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedFacility {
            get {
                return ((string)(this["SelectedFacility"]));
            }
            set {
                this["SelectedFacility"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point DialogScreenLocation {
            get {
                return ((global::System.Drawing.Point)(this["DialogScreenLocation"]));
            }
            set {
                this["DialogScreenLocation"] = value;
            }
        }
    }
}
