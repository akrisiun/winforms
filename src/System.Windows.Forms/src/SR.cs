// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Resources;

namespace System
{ 
    internal static partial class SR
    {
        //static ResourceManager _resourceManager;
        //public static ResourceManager ResourceManager { get
        //    {
        //        _resourceManager = _resourceManager ?? new ResourceManager(typeof(SR));
        //        return _resourceManager;
        //    }
        //}

        ///// <summary>
        /////   Returns the cached ResourceManager instance used by this class.
        ///// </summary>
        //[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        //internal static global::System.Resources.ResourceManager ResourceManager
        //{
        //    get
        //    {
        //        if (object.ReferenceEquals(resourceMan, null))
        //        {
        //            global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Windows.Forms.Resources.SR", typeof(SR).Assembly);
        //            resourceMan = temp;
        //        }
        //        return resourceMan;
        //    }
        //}


        public static object GetObject(string name)
        {
            object resourceObject = null;
            try { resourceObject = ResourceManager.GetObject(name); }
            catch (MissingManifestResourceException) { }
            return resourceObject;
        }

        public static string GetString(string name)
        {
            string resourceObject = null;
            try
            { resourceObject = ResourceManager.GetString(name); }
            catch (MissingManifestResourceException) { }
            return resourceObject ?? name;
        }

        public static string GetResourceString(string Description) => GetString(Description) ?? Description;

        public static string GetResourceStringNull(string Description) { 
            string resourceObject = null;
            try
            { resourceObject = ResourceManager.GetString(Description); }
            catch (MissingManifestResourceException) { }
            return resourceObject;
        }
    }
}
