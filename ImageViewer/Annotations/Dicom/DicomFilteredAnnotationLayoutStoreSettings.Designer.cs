﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Annotations.Dicom {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class DicomFilteredAnnotationLayoutStoreSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DicomFilteredAnnotationLayoutStoreSettings defaultInstance = ((DicomFilteredAnnotationLayoutStoreSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DicomFilteredAnnotationLayoutStoreSettings())));
        
        public static DicomFilteredAnnotationLayoutStoreSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// XML document stores the identifier of the text overlay configuration for each modality.  The actual configurations are stored in the AnnotationLayoutSettings.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document stores the identifier of the text overlay configuration for each mod" +
            "ality.  The actual configurations are stored in the AnnotationLayoutSettings.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DicomFilteredAnnotationLayoutStoreDefaults.xml")]
        public string FilteredLayoutSettingsXml {
            get {
                return ((string)(this["FilteredLayoutSettingsXml"]));
            }
            set {
                this["FilteredLayoutSettingsXml"] = value;
            }
        }
    }
}
