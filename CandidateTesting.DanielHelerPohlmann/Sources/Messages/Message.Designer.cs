﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CandidateTesting.DanielHelerPohlmann.Sources.Messages {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Message {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Message() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CandidateTesting.DanielHelerPohlmann.Sources.Messages.Message", typeof(Message).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloaded {0} of {1} bytes ({2}).
        /// </summary>
        public static string Downloaded {
            get {
                return ResourceManager.GetString("Downloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloaded of file {0} completed, total bytes {1}.
        /// </summary>
        public static string DownloadSucess {
            get {
                return ResourceManager.GetString("DownloadSucess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Conversion error, line {0} message: {1}.
        /// </summary>
        public static string ErrorConvert {
            get {
                return ResourceManager.GetString("ErrorConvert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Download: {0}.
        /// </summary>
        public static string ErrorDownload {
            get {
                return ResourceManager.GetString("ErrorDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finish Conversion in {0} milisecond.
        /// </summary>
        public static string FinishConvert {
            get {
                return ResourceManager.GetString("FinishConvert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finish Download in {0} milisecond.
        /// </summary>
        public static string FinishDownload {
            get {
                return ResourceManager.GetString("FinishDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format body log invalid line {0}.
        /// </summary>
        public static string InvalidLogLineFormat {
            get {
                return ResourceManager.GetString("InvalidLogLineFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Second parameter args start exe is not a valid path and file name.
        /// </summary>
        public static string PathIsNotValid {
            get {
                return ResourceManager.GetString("PathIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program ended.
        /// </summary>
        public static string ProgramEnded {
            get {
                return ResourceManager.GetString("ProgramEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program started.
        /// </summary>
        public static string ProgramStarted {
            get {
                return ResourceManager.GetString("ProgramStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Convert to {0} lines.
        /// </summary>
        public static string ProgressConvert {
            get {
                return ResourceManager.GetString("ProgressConvert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Conversion.
        /// </summary>
        public static string StarConvert {
            get {
                return ResourceManager.GetString("StarConvert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Download.
        /// </summary>
        public static string StartDownload {
            get {
                return ResourceManager.GetString("StartDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Conversion completed, total of lines {0}.
        /// </summary>
        public static string SucessConvert {
            get {
                return ResourceManager.GetString("SucessConvert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First parameter args start exe is not a valid url.
        /// </summary>
        public static string UrlIsNotValid {
            get {
                return ResourceManager.GetString("UrlIsNotValid", resourceCulture);
            }
        }
    }
}
