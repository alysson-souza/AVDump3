﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AVDump3CL {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Lang {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Lang() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AVDump3CL.Lang", typeof(Lang).Assembly);
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
        ///   Looks up a localized string similar to Circular buffer size for hashing.
        /// </summary>
        internal static string BufferLengthDescription {
            get {
                return ResourceManager.GetString("BufferLengthDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --BufferLength=&lt;Size in MiB&gt;.
        /// </summary>
        internal static string BufferLengthExample {
            get {
                return ResourceManager.GetString("BufferLengthExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets the maximal number of files which will be processed concurrently.
        ///First param (max) sets a global limit. (path,max) pairs sets limits per path..
        /// </summary>
        internal static string ConcurrentDescription {
            get {
                return ResourceManager.GetString("ConcurrentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --Concurrent=&lt;max&gt;[:&lt;path1&gt;,&lt;max1&gt;;&lt;path2&gt;,&lt;max2&gt;;...].
        /// </summary>
        internal static string ConcurrentExample {
            get {
                return ResourceManager.GetString("ConcurrentExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select consumers to use. Use without arguments to list available consumers.
        /// </summary>
        internal static string ConsumersDescription {
            get {
                return ResourceManager.GetString("ConsumersDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --Consumers=&lt;ConsumerName1&gt;[,&lt;ConsumerName2&gt;,...].
        /// </summary>
        internal static string ConsumersExample {
            get {
                return ResourceManager.GetString("ConsumersExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Searches the filename for the calculated CRC32 hash. If not present or different a line with the caluclated hash and the full path of the file is appended to the specified path
        ///The regex pattern should contain the placeholder &quot;&lt;CRC32&gt;&quot; which is replaced by the calculated hash prior matching.
        /// </summary>
        internal static string CRC32ErrorDescription {
            get {
                return ResourceManager.GetString("CRC32ErrorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --CRC32Error=&lt;Filepath&gt;:&lt;RegexPattern&gt;.
        /// </summary>
        internal static string CRC32ErrorExample {
            get {
                return ResourceManager.GetString("CRC32ErrorExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Will set --SkipLogPath and --ProcessedLogPath to the specified filepath.
        /// </summary>
        internal static string DoneLogPathDescription {
            get {
                return ResourceManager.GetString("DoneLogPathDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --DoneLogPath=&lt;Filepath&gt;.
        /// </summary>
        internal static string DoneLogPathExample {
            get {
                return ResourceManager.GetString("DoneLogPathExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --ErrorDirectory=&lt;DirectoryPath&gt;.
        /// </summary>
        internal static string ErrorDirectoryDescription {
            get {
                return ResourceManager.GetString("ErrorDirectoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If --SaveErrors is specified the error files will be placed in the specified path.
        /// </summary>
        internal static string ErrorDirectoryExample {
            get {
                return ResourceManager.GetString("ErrorDirectoryExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logs the filepath if the detected extension does not match the actual extension.
        /// </summary>
        internal static string ExtensionDifferencePathDescription {
            get {
                return ResourceManager.GetString("ExtensionDifferencePathDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --EDPath=extdiff.txt.
        /// </summary>
        internal static string ExtensionDifferencePathExample {
            get {
                return ResourceManager.GetString("ExtensionDifferencePathExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cursor position of the console will not be explicitly set. This option will disable most progress output.
        /// </summary>
        internal static string ForwardConsoleCursorOnlyDescription {
            get {
                return ResourceManager.GetString("ForwardConsoleCursorOnlyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --ForwardConsoleCursorOnly.
        /// </summary>
        internal static string ForwardConsoleCursorOnlyExample {
            get {
                return ResourceManager.GetString("ForwardConsoleCursorOnlyExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hides buffer bars.
        /// </summary>
        internal static string HideBuffersDescription {
            get {
                return ResourceManager.GetString("HideBuffersDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --HideBuffers.
        /// </summary>
        internal static string HideBuffersExample {
            get {
                return ResourceManager.GetString("HideBuffersExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hides file progress.
        /// </summary>
        internal static string HideFileProgressDescription {
            get {
                return ResourceManager.GetString("HideFileProgressDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --HideFileProgress.
        /// </summary>
        internal static string HideFileProgressExample {
            get {
                return ResourceManager.GetString("HideFileProgressExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hides total progress.
        /// </summary>
        internal static string HideTotalProgressDescription {
            get {
                return ResourceManager.GetString("HideTotalProgressDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --HideTotalProgress.
        /// </summary>
        internal static string HideTotalProgressExample {
            get {
                return ResourceManager.GetString("HideTotalProgressExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Various places may include personal data. Currently this only affects error files, which will then include the full filepath.
        /// </summary>
        internal static string IncludePersonalDataDescription {
            get {
                return ResourceManager.GetString("IncludePersonalDataDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --IncludePersonalData.
        /// </summary>
        internal static string IncludePersonalDataExample {
            get {
                return ResourceManager.GetString("IncludePersonalDataExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use Memory as the DataSource for HashSpeed testing. Overrides any FileDiscovery Settings!.
        /// </summary>
        internal static string NullStreamTestDescription {
            get {
                return ResourceManager.GetString("NullStreamTestDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --NullStreamTest=&lt;StreamCount&gt;:&lt;StreamLength in MiB&gt;:&lt;ParallelStreamCount&gt;.
        /// </summary>
        internal static string NullStreamTestExample {
            get {
                return ResourceManager.GetString("NullStreamTestExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pause console before exiting.
        /// </summary>
        internal static string PauseBeforeExitDescription {
            get {
                return ResourceManager.GetString("PauseBeforeExitDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --PauseBeforeExit.
        /// </summary>
        internal static string PauseBeforeExitExample {
            get {
                return ResourceManager.GetString("PauseBeforeExitExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Print calculated hashes in hexadecimal format to console.
        /// </summary>
        internal static string PrintHashesDescription {
            get {
                return ResourceManager.GetString("PrintHashesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --PrintHashes.
        /// </summary>
        internal static string PrintHashesExample {
            get {
                return ResourceManager.GetString("PrintHashesExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Print generated reports to console.
        /// </summary>
        internal static string PrintReportsDescription {
            get {
                return ResourceManager.GetString("PrintReportsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --PrintReports.
        /// </summary>
        internal static string PrintReportsExample {
            get {
                return ResourceManager.GetString("PrintReportsExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Appends the full filepath to the specified path.
        /// </summary>
        internal static string ProcessedLogPathDescription {
            get {
                return ResourceManager.GetString("ProcessedLogPathDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --ProcessedLogPath=&lt;Filepath&gt;.
        /// </summary>
        internal static string ProcessedLogPathExample {
            get {
                return ResourceManager.GetString("ProcessedLogPathExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recursively descent into Subdirectories.
        /// </summary>
        internal static string RecursiveDescription {
            get {
                return ResourceManager.GetString("RecursiveDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --Recursive.
        /// </summary>
        internal static string RecursiveExample {
            get {
                return ResourceManager.GetString("RecursiveExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reports will be saved to the specified directory.
        /// </summary>
        internal static string ReportDirectoryDescription {
            get {
                return ResourceManager.GetString("ReportDirectoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --ReportDirectory=&lt;Directory&gt;.
        /// </summary>
        internal static string ReportDirectoryExample {
            get {
                return ResourceManager.GetString("ReportDirectoryExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reports will be saved/appended to the specified filename
        ///The following placeholders can be used: &lt;FileName&gt;, &lt;FileNameWithoutExtension&gt;, &lt;FileExtension&gt;, &lt;ReportName&gt;, ReportFileExtension.
        /// </summary>
        internal static string ReportFileNameDescription {
            get {
                return ResourceManager.GetString("ReportFileNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --ReportFileName=&lt;FileName&gt;.
        /// </summary>
        internal static string ReportFileNameExample {
            get {
                return ResourceManager.GetString("ReportFileNameExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select reports to use. Use without arguments to list available reports.
        /// </summary>
        internal static string ReportsDescription {
            get {
                return ResourceManager.GetString("ReportsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --Reports.
        /// </summary>
        internal static string ReportsExample {
            get {
                return ResourceManager.GetString("ReportsExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Errors occuring during program execution will be saved to disk.
        /// </summary>
        internal static string SaveErrorsDescription {
            get {
                return ResourceManager.GetString("SaveErrorsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --SaveErrors.
        /// </summary>
        internal static string SaveErrorsExample {
            get {
                return ResourceManager.GetString("SaveErrorsExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays the time taken to calculate progression stats and drawing to console.
        /// </summary>
        internal static string ShowDisplayJitterDescription {
            get {
                return ResourceManager.GetString("ShowDisplayJitterDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --ShowDisplayJitter.
        /// </summary>
        internal static string ShowDisplayJitterExample {
            get {
                return ResourceManager.GetString("ShowDisplayJitterExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skip the environment element in error files.
        /// </summary>
        internal static string SkipEnvironmentElementDescription {
            get {
                return ResourceManager.GetString("SkipEnvironmentElementDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --SkipEnvironmentElement.
        /// </summary>
        internal static string SkipEnvironmentElementExample {
            get {
                return ResourceManager.GetString("SkipEnvironmentElementExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filepaths contained in the specified file will not be processed.
        /// </summary>
        internal static string SkipLogPathDescription {
            get {
                return ResourceManager.GetString("SkipLogPathDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --SkipLogPath=&lt;FilePath&gt;.
        /// </summary>
        internal static string SkipLogPathExample {
            get {
                return ResourceManager.GetString("SkipLogPathExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only/Don&apos;t Process files with selected Extensions.
        /// </summary>
        internal static string WithExtensionsDescription {
            get {
                return ResourceManager.GetString("WithExtensionsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --WithExtensions=[-]&lt;Extension1&gt;[,&lt;Extension2&gt;,...].
        /// </summary>
        internal static string WithExtensionsExample {
            get {
                return ResourceManager.GetString("WithExtensionsExample", resourceCulture);
            }
        }
    }
}
