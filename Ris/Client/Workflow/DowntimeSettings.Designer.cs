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
    internal sealed partial class DowntimeSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DowntimeSettings defaultInstance = ((DowntimeSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DowntimeSettings())));
        
        public static DowntimeSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Comma separated list of staff types to filter transcriptionist lookup.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Comma separated list of staff types to filter transcriptionist lookup.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("STRA")]
        public string ReportEntryTranscriptionistStaffTypeFilters {
            get {
                return ((string)(this["ReportEntryTranscriptionistStaffTypeFilters"]));
            }
        }
        
        /// <summary>
        /// Comma separated list of staff types to filter Interpreter lookup.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Comma separated list of staff types to filter Interpreter lookup.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PRAD, PRAR")]
        public string ReportEntryRadiologistStaffTypeFilters {
            get {
                return ((string)(this["ReportEntryRadiologistStaffTypeFilters"]));
            }
        }
    }
}
