﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Client.Workflow {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class ReportingSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ReportingSettings defaultInstance = ((ReportingSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ReportingSettings())));
        
        public static ReportingSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Indicates whether the application allows multiple reporting workspaces to be open at the same time.  This may cause problems if the Report Editor in use depends on singleton resources such as an audio input device.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Indicates whether the application allows multiple reporting workspaces to be open" +
            " at the same time.  This may cause problems if the Report Editor in use depends " +
            "on singleton resources such as an audio input device.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowMultipleReportingWorkspaces {
            get {
                return ((bool)(this["AllowMultipleReportingWorkspaces"]));
            }
        }
        
        /// <summary>
        /// A comma separated list of staff types used to filter the Supervisor lookup field.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("A comma separated list of staff types used to filter the Supervisor lookup field." +
            "")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PRAD")]
        public string SupervisorStaffTypeFilters {
            get {
                return ((string)(this["SupervisorStaffTypeFilters"]));
            }
        }
        
        /// <summary>
        /// Stores user default supervisor.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Stores user default supervisor.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SupervisorID {
            get {
                return ((string)(this["SupervisorID"]));
            }
            set {
                this["SupervisorID"] = value;
            }
        }
        
        /// <summary>
        /// Indicates if a default supervisor should be automatically loaded if it is not yet specified.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Indicates if a default supervisor should be automatically loaded if it is not yet" +
            " specified.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShouldApplyDefaultSupervisor {
            get {
                return ((bool)(this["ShouldApplyDefaultSupervisor"]));
            }
            set {
                this["ShouldApplyDefaultSupervisor"] = value;
            }
        }
        
        /// <summary>
        /// Specifies whether patient images should be opened when opening a reporting component.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether patient images should be opened when opening a reporting compon" +
            "ent.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShouldOpenImages {
            get {
                return ((bool)(this["ShouldOpenImages"]));
            }
            set {
                this["ShouldOpenImages"] = value;
            }
        }
        
        /// <summary>
        /// Specifies the name of the initially selected tab.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies the name of the initially selected tab.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string InitiallySelectedTabPageName {
            get {
                return ((string)(this["InitiallySelectedTabPageName"]));
            }
            set {
                this["InitiallySelectedTabPageName"] = value;
            }
        }
        
        /// <summary>
        /// The number of items to keep in the &quot;Next Item&quot; queue.  A higher value means fewer trips to the server, but also the possibility that higher priority items will not be seen by the user as quickly.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The number of items to keep in the \"Next Item\" queue.  A higher value means fewer" +
            " trips to the server, but also the possibility that higher priority items will n" +
            "ot be seen by the user as quickly.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int NextItemQueueCacheSize {
            get {
                return ((int)(this["NextItemQueueCacheSize"]));
            }
        }
    }
}
