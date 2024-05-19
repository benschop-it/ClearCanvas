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
    internal sealed partial class DefaultPatientReconciliationSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DefaultPatientReconciliationSettings defaultInstance = ((DefaultPatientReconciliationSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DefaultPatientReconciliationSettings())));
        
        public static DefaultPatientReconciliationSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Rules XML document used to massage the patient ID after searching for prior studies, essentially allowing patients with different patient IDs to be merged together in the viewer context menu.  **BE EXTREMELY CAREFUL** if you are going to modify this setting.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute(@"Rules XML document used to massage the patient ID after searching for prior studies, essentially allowing patients with different patient IDs to be merged together in the viewer context menu.  **BE EXTREMELY CAREFUL** if you are going to modify this setting.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<patient-reconciliation-rules />")]
        public global::System.Xml.XmlDocument PatientReconciliationRulesXml {
            get {
                return ((global::System.Xml.XmlDocument)(this["PatientReconciliationRulesXml"]));
            }
        }
        
        /// <summary>
        /// Rules XML document used to massage the patient ID before searching for prior studies.  **BE EXTREMELY CAREFUL** if you are going to modify this setting.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Rules XML document used to massage the patient ID before searching for prior stud" +
            "ies.  **BE EXTREMELY CAREFUL** if you are going to modify this setting.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<search-reconciliation-rules />")]
        public global::System.Xml.XmlDocument SearchReconciliationRulesXml {
            get {
                return ((global::System.Xml.XmlDocument)(this["SearchReconciliationRulesXml"]));
            }
        }
    }
}
