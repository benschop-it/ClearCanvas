﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Healthcare.Workflow.Reporting {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class ReportingWorkflowSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ReportingWorkflowSettings defaultInstance = ((ReportingWorkflowSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ReportingWorkflowSettings())));
        
        public static ReportingWorkflowSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Scheduling delay (in seconds) before a report is published following verification.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Scheduling delay (in seconds) before a report is published following verification" +
            ".")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public uint PublicationDelay {
            get {
                return ((uint)(this["PublicationDelay"]));
            }
        }
    }
}
