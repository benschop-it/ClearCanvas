﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Application.Services {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class WorklistSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static WorklistSettings defaultInstance = ((WorklistSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new WorklistSettings())));
        
        public static WorklistSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Maximum number of worklists that can be owned by an individual user.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Maximum number of worklists that can be owned by an individual user.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MaxPersonalOwnedWorklists {
            get {
                return ((int)(this["MaxPersonalOwnedWorklists"]));
            }
        }
        
        /// <summary>
        /// Maximum number of worklists that can be owned by a staff group.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Maximum number of worklists that can be owned by a staff group.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int MaxGroupOwnedWorklists {
            get {
                return ((int)(this["MaxGroupOwnedWorklists"]));
            }
        }
        
        /// <summary>
        /// Specifies whether item count caching is enabled for user-independent worklists.  Caching occurs on server and is shared among all users.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether item count caching is enabled for user-independent worklists.  " +
            "Caching occurs on server and is shared among all users.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UserIndependentWorklistItemCountCachingEnabled {
            get {
                return ((bool)(this["UserIndependentWorklistItemCountCachingEnabled"]));
            }
        }
        
        /// <summary>
        /// Specifies item count caching time-to-live for user-independent worklists. 
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies item count caching time-to-live for user-independent worklists. ")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int UserIndependentWorklistItemCountCachingTimeToLiveSeconds {
            get {
                return ((int)(this["UserIndependentWorklistItemCountCachingTimeToLiveSeconds"]));
            }
        }
        
        /// <summary>
        /// Specifies whether item count caching is enabled for user-dependent worklists.  Caching occurs on client because it is specific to each user.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether item count caching is enabled for user-dependent worklists.  Ca" +
            "ching occurs on client because it is specific to each user.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UserDependentWorklistItemCountCachingEnabled {
            get {
                return ((bool)(this["UserDependentWorklistItemCountCachingEnabled"]));
            }
        }
        
        /// <summary>
        /// Specifies item count caching time-to-live for user-dependent worklists. 
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies item count caching time-to-live for user-dependent worklists. ")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int UserDependentWorklistItemCountCachingTimeToLiveSeconds {
            get {
                return ((int)(this["UserDependentWorklistItemCountCachingTimeToLiveSeconds"]));
            }
        }
    }
}
