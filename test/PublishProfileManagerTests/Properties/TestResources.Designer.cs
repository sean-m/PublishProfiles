﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PublishProfileManagerTests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PublishProfileManagerTests.Properties.TestResources", typeof(TestResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;WebPublishMethod&gt;FileSystem&lt;/WebPublishMethod&gt;
        ///    &lt;LastUsedBuildConfiguration&gt;Release&lt;/LastUsedBuildConfiguration&gt;
        ///    &lt;LastUsedPlatform&gt;Any CPU&lt;/LastUsedPlatform&gt;
        ///    &lt;PublishUrl&gt;bin\Release\Publish&lt;/PublishUrl&gt;
        ///    &lt;DeleteExistingFiles&gt;False&lt;/DeleteExistingFiles&gt;
        ///  &lt;/PropertyGroup&gt;
        ///&lt;/Project&gt;.
        /// </summary>
        internal static string FileSystemPublishProfile {
            get {
                return ResourceManager.GetString("FileSystemPublishProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;WebPublishMethod&gt;FTP&lt;/WebPublishMethod&gt;
        ///    &lt;LastUsedBuildConfiguration&gt;&lt;/LastUsedBuildConfiguration&gt;
        ///    &lt;LastUsedPlatform&gt;&lt;/LastUsedPlatform&gt;
        ///    &lt;SiteUrlToLaunchAfterPublish&gt;&lt;/SiteUrlToLaunchAfterPublish&gt;
        ///    &lt;LaunchSiteAfterPublish&gt;&lt;/LaunchSiteAfterPublish&gt;
        ///    &lt;publishUrl&gt;&lt;/publishUrl&gt;
        ///    &lt;DeleteExistingFiles&gt;&lt;/DeleteExistingFiles&gt;
        ///    &lt;FtpPas [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FTPPublishProfile {
            get {
                return ResourceManager.GetString("FTPPublishProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;WebPublishMethod&gt;MSDeploy&lt;/WebPublishMethod&gt;
        ///    &lt;LastUsedBuildConfiguration&gt;Release&lt;/LastUsedBuildConfiguration&gt;
        ///    &lt;LastUsedPlatform&gt;Any CPU&lt;/LastUsedPlatform&gt;
        ///    &lt;SiteUrlToLaunchAfterPublish&gt;http://webappvramaktest.azurewebsites.net&lt;/SiteUrlToLaunchAfterPublish&gt;
        ///    &lt;LaunchSiteAfterPublish&gt;True&lt;/LaunchSiteAfterPublish&gt;
        ///    &lt;MSDeployServiceURL&gt;web [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MsDeployFromPublishSettings {
            get {
                return ResourceManager.GetString("MsDeployFromPublishSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;WebPublishMethod&gt;Package&lt;/WebPublishMethod&gt;
        ///    &lt;LastUsedBuildConfiguration&gt;Release&lt;/LastUsedBuildConfiguration&gt;
        ///    &lt;LastUsedPlatform&gt;Any CPU&lt;/LastUsedPlatform&gt;
        ///    &lt;PackageLocation&gt;bin\Release\PackageOutput.zip&lt;/PackageLocation&gt;
        ///    &lt;DeployIisAppPath&gt;Default Web Site&lt;/DeployIisAppPath&gt;
        ///  &lt;/PropertyGroup&gt;
        ///&lt;/Project&gt;.
        /// </summary>
        internal static string MSDeployPackagePublishProfile {
            get {
                return ResourceManager.GetString("MSDeployPackagePublishProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;WebPublishMethod&gt;MSDeploy&lt;/WebPublishMethod&gt;
        ///    &lt;LastUsedBuildConfiguration&gt;Release&lt;/LastUsedBuildConfiguration&gt;
        ///    &lt;LastUsedPlatform&gt;Any CPU&lt;/LastUsedPlatform&gt;
        ///    &lt;SiteUrlToLaunchAfterPublish&gt;https://webappwithdb.azurewebsites.net&lt;/SiteUrlToLaunchAfterPublish&gt;
        ///    &lt;LaunchSiteAfterPublish&gt;true&lt;/LaunchSiteAfterPublish&gt;
        ///    &lt;MSDeployServiceURL&gt;webapp [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MSDeployPublishProfile {
            get {
                return ResourceManager.GetString("MSDeployPublishProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;publishData&gt;&lt;publishProfile profileName=&quot;webappvramaktest - Web Deploy&quot; publishMethod=&quot;MSDeploy&quot; publishUrl=&quot;webappvramaktest.scm.azurewebsites.net:443&quot; msdeploySite=&quot;webappvramaktest&quot; userName=&quot;$webappvramaktest&quot; userPWD=&quot;Password&quot; destinationAppUrl=&quot;http://webappvramaktest.azurewebsites.net&quot; SQLServerDBConnectionString=&quot;&quot; mySQLDBConnectionString=&quot;&quot; hostingProviderForumLink=&quot;&quot; controlPanelLink=&quot;http://windows.azure.com&quot; webSystem=&quot;WebSites&quot;&gt;&lt;databases /&gt;&lt;/publishProfile&gt;&lt;publishProfile profileName=&quot;webapp [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PublishSettings {
            get {
                return ResourceManager.GetString("PublishSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;EncryptedPassword&gt;AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA67JjYD5L5U2w7zSpvgBv8QAAAAACAAAAAAADZgAAwAAAABAAAACcVImtpIEtiw15CLTHBNPWAAAAAASAAACgAAAAEAAAAE44G7blkYFavD7ShhHajGAYAAAA56nEhQZ/trcwBNh8NeUdlbs+zL8AM17kFAAAAIQcL8wcxNC5Onjd9e9mJASXUZlA&lt;/EncryptedPassword&gt;
        ///  &lt;/PropertyGroup&gt;
        ///&lt;/Project&gt;.
        /// </summary>
        internal static string UserProfileWithEncryptedPassword {
            get {
                return ResourceManager.GetString("UserProfileWithEncryptedPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup /&gt;
        ///&lt;/Project&gt;.
        /// </summary>
        internal static string userpublishprofile {
            get {
                return ResourceManager.GetString("userpublishprofile", resourceCulture);
            }
        }
    }
}