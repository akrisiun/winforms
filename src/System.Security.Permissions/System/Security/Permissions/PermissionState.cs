// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Permissions
{
    using System.Security.Permissions.Internal;
    
    [Serializable]
    internal enum PermissionState2
    {
        None = PermissionState.None,
        Unrestricted = PermissionState.Unrestricted
    }
}

namespace System.Security.Permissions.Internal
{
    [Serializable]
    public enum PermissionState
    {
        None = 0,
        Unrestricted = 1,
    }
}
