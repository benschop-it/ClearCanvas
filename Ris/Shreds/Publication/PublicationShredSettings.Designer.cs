﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Shreds.Publication {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class PublicationShredSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static PublicationShredSettings defaultInstance = ((PublicationShredSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new PublicationShredSettings())));
        
        public static PublicationShredSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Number of items to pull from queue per read
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of items to pull from queue per read")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int BatchSize {
            get {
                return ((int)(this["BatchSize"]));
            }
        }
        
        /// <summary>
        /// Number of seconds to sleep when queue is empty
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of seconds to sleep when queue is empty")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int EmptyQueueSleepTime {
            get {
                return ((int)(this["EmptyQueueSleepTime"]));
            }
        }
        
        /// <summary>
        /// Number of seconds that must elapse before a failed item is retried
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of seconds that must elapse before a failed item is retried")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public int FailedItemRetryDelay {
            get {
                return ((int)(this["FailedItemRetryDelay"]));
            }
        }
        
        /// <summary>
        /// Specifies whether publication of reports to HL7 peers is enabled.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether publication of reports to HL7 peers is enabled.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HL7PublicationEnabled {
            get {
                return ((bool)(this["HL7PublicationEnabled"]));
            }
        }
        
        /// <summary>
        /// Number of retries before an item is marked as failed. Set to -1 to retry indefinitely.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of retries before an item is marked as failed. Set to -1 to retry indefini" +
            "tely.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int HL7FailedItemRetryCount {
            get {
                return ((int)(this["HL7FailedItemRetryCount"]));
            }
        }
    }
}
