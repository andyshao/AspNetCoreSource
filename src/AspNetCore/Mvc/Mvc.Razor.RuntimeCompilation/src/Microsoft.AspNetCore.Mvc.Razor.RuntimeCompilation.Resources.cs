// <auto-generated>
using System.Reflection;


namespace Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>One or more compilation failures occurred:</summary>
        internal static string CompilationFailed => GetResourceString("CompilationFailed");
        /// <summary>One or more compilation references may be missing. If you're seeing this in a published application, set '{0}' to true in your project file to ensure files in the refs directory are published.</summary>
        internal static string Compilation_MissingReferences => GetResourceString("Compilation_MissingReferences");
        /// <summary>One or more compilation references may be missing. If you're seeing this in a published application, set '{0}' to true in your project file to ensure files in the refs directory are published.</summary>
        internal static string FormatCompilation_MissingReferences(object p0)
           => string.Format(Culture, GetResourceString("Compilation_MissingReferences"), p0);

        /// <summary>'{0}.{1}' must not be empty. At least one '{2}' is required to locate a view for rendering.</summary>
        internal static string FileProvidersAreRequired => GetResourceString("FileProvidersAreRequired");
        /// <summary>'{0}.{1}' must not be empty. At least one '{2}' is required to locate a view for rendering.</summary>
        internal static string FormatFileProvidersAreRequired(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("FileProvidersAreRequired"), p0, p1, p2);

        /// <summary>Generated Code</summary>
        internal static string GeneratedCodeFileName => GetResourceString("GeneratedCodeFileName");
        /// <summary>The debug type specified in the dependency context could be parsed. The debug type value '{0}' is not supported.</summary>
        internal static string UnsupportedDebugInformationFormat => GetResourceString("UnsupportedDebugInformationFormat");
        /// <summary>The debug type specified in the dependency context could be parsed. The debug type value '{0}' is not supported.</summary>
        internal static string FormatUnsupportedDebugInformationFormat(object p0)
           => string.Format(Culture, GetResourceString("UnsupportedDebugInformationFormat"), p0);


    }
}
