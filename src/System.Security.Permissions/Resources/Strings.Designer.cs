﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System { 
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal partial class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Security.Permissions.Resources.Strings", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to Collection must not be empty..
        /// </summary>
        internal static string Arg_EmptyCollection {
            get {
                return ResourceManager.GetString("Arg_EmptyCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attribute names must be unique..
        /// </summary>
        internal static string Argument_AttributeNamesMustBeUnique {
            get {
                return ResourceManager.GetString("Argument_AttributeNamesMustBeUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Improper types in collection..
        /// </summary>
        internal static string Argument_ImproperType {
            get {
                return ResourceManager.GetString("Argument_ImproperType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid element name &apos;{0}&apos;..
        /// </summary>
        internal static string Argument_InvalidElementName {
            get {
                return ResourceManager.GetString("Argument_InvalidElementName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid element tag &apos;{0}&apos;..
        /// </summary>
        internal static string Argument_InvalidElementTag {
            get {
                return ResourceManager.GetString("Argument_InvalidElementTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid element text &apos;{0}&apos;..
        /// </summary>
        internal static string Argument_InvalidElementText {
            get {
                return ResourceManager.GetString("Argument_InvalidElementText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid element value &apos;{0}&apos;..
        /// </summary>
        internal static string Argument_InvalidElementValue {
            get {
                return ResourceManager.GetString("Argument_InvalidElementValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid permission state..
        /// </summary>
        internal static string Argument_InvalidPermissionState {
            get {
                return ResourceManager.GetString("Argument_InvalidPermissionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Xml - can only parse elements of version one..
        /// </summary>
        internal static string Argument_InvalidXMLBadVersion {
            get {
                return ResourceManager.GetString("Argument_InvalidXMLBadVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;elem&apos; was not a permission element..
        /// </summary>
        internal static string Argument_NotAPermissionElement {
            get {
                return ResourceManager.GetString("Argument_NotAPermissionElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation on type &apos;{0}&apos; attempted with target of incorrect type..
        /// </summary>
        internal static string Argument_WrongType {
            get {
                return ResourceManager.GetString("Argument_WrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot have a null child..
        /// </summary>
        internal static string ArgumentNull_Child {
            get {
                return ResourceManager.GetString("ArgumentNull_Child", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of sub-authorities must not exceed {0}..
        /// </summary>
        internal static string IdentityReference_InvalidNumberOfSubauthorities {
            get {
                return ResourceManager.GetString("IdentityReference_InvalidNumberOfSubauthorities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SIDs with revision other than &apos;1&apos; are not supported..
        /// </summary>
        internal static string IdentityReference_InvalidSidRevision {
            get {
                return ResourceManager.GetString("IdentityReference_InvalidSidRevision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request for principal permission failed..
        /// </summary>
        internal static string Security_PrincipalPermission {
            get {
                return ResourceManager.GetString("Security_PrincipalPermission", resourceCulture);
            }
        }
    }
}