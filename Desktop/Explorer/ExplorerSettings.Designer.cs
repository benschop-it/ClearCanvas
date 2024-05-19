﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Desktop.Explorer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class ExplorerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ExplorerSettings defaultInstance = ((ExplorerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ExplorerSettings())));
        
        public static ExplorerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// User option to specify whether or not the Explorer should be shown in a shelf.  When false, it is shown in a workspace.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("User option to specify whether or not the Explorer should be shown in a shelf.  W" +
            "hen false, it is shown in a workspace.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LaunchAsShelf {
            get {
                return ((bool)(this["LaunchAsShelf"]));
            }
            set {
                this["LaunchAsShelf"] = value;
            }
        }
        
        /// <summary>
        /// User option to launch the Explorer when the application starts up.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("User option to launch the Explorer when the application starts up.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LaunchAtStartup {
            get {
                return ((bool)(this["LaunchAtStartup"]));
            }
            set {
                this["LaunchAtStartup"] = value;
            }
        }
    }
}
