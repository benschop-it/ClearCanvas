﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Layout.Basic {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class LayoutSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static LayoutSettings defaultInstance = ((LayoutSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LayoutSettings())));
        
        public static LayoutSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Per-modality image box and tile configuration(s) used to layout the viewer when it is first opened, based on the loaded study.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Per-modality image box and tile configuration(s) used to layout the viewer when i" +
            "t is first opened, based on the loaded study.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Xml.XmlDocument LayoutSettingsXml {
            get {
                return ((global::System.Xml.XmlDocument)(this["LayoutSettingsXml"]));
            }
            set {
                this["LayoutSettingsXml"] = value;
            }
        }
    }
}
