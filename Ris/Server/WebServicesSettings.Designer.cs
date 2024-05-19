﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Server {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class WebServicesSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static WebServicesSettings defaultInstance = ((WebServicesSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new WebServicesSettings())));
        
        public static WebServicesSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Base URL on which web services are hosted.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Base URL on which web services are hosted.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("net.tcp://localhost:8000/")]
        public string BaseUrl {
            get {
                return ((string)(this["BaseUrl"]));
            }
        }
        
        /// <summary>
        /// Indicates whether exception details should be transmitted to the client.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Indicates whether exception details should be transmitted to the client.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SendExceptionDetailToClient {
            get {
                return ((bool)(this["SendExceptionDetailToClient"]));
            }
        }
        
        /// <summary>
        /// Specifies the name of the service configuration class.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies the name of the service configuration class.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ClearCanvas.Enterprise.Common.ServiceConfiguration.Server.NetTcpConfiguration, Cl" +
            "earCanvas.Enterprise.Common")]
        public string ConfigurationClass {
            get {
                return ((string)(this["ConfigurationClass"]));
            }
        }
        
        /// <summary>
        /// Specifies the max received message size in bytes.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies the max received message size in bytes.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000000")]
        public int MaxReceivedMessageSize {
            get {
                return ((int)(this["MaxReceivedMessageSize"]));
            }
        }
        
        /// <summary>
        /// Indicates whether to enable performance logging.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Indicates whether to enable performance logging.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnablePerformanceLogging {
            get {
                return ((bool)(this["EnablePerformanceLogging"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public string ConfigurationServiceResponseCachingEnabled {
            get {
                return ((string)(this["ConfigurationServiceResponseCachingEnabled"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Security.Cryptography.X509Certificates.X509FindType CertificateFindType {
            get {
                return ((global::System.Security.Cryptography.X509Certificates.X509FindType)(this["CertificateFindType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("My")]
        public global::System.Security.Cryptography.X509Certificates.StoreName CertificateStoreName {
            get {
                return ((global::System.Security.Cryptography.X509Certificates.StoreName)(this["CertificateStoreName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LocalMachine")]
        public global::System.Security.Cryptography.X509Certificates.StoreLocation CertificateStoreLocation {
            get {
                return ((global::System.Security.Cryptography.X509Certificates.StoreLocation)(this["CertificateStoreLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CertificateCustomFindValue {
            get {
                return ((string)(this["CertificateCustomFindValue"]));
            }
        }
    }
}
