﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Configuration.ServerTree {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class ServerTreeSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ServerTreeSettings defaultInstance = ((ServerTreeSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ServerTreeSettings())));
        
        public static ServerTreeSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Currently a list of servers shared between all users, although that may change in the future.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Currently a list of servers shared between all users, although that may change in" +
            " the future.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::ClearCanvas.ImageViewer.Configuration.ServerTree.StoredServerGroup SharedServers {
            get {
                return ((global::ClearCanvas.ImageViewer.Configuration.ServerTree.StoredServerGroup)(this["SharedServers"]));
            }
        }
    }
}
