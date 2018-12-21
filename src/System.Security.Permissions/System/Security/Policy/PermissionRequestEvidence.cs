// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Policy
{
    [Serializable]
    public sealed partial class PermissionRequestEvidence2 : EvidenceBase
    {
        public PermissionRequestEvidence2(PermissionSet request, PermissionSet optional, PermissionSet denied) { }
        public PermissionSet DeniedPermissions { get { return default(PermissionSet); } }
        public PermissionSet OptionalPermissions { get { return default(PermissionSet); } }
        public PermissionSet RequestedPermissions { get { return default(PermissionSet); } }
        public PermissionRequestEvidence2 Copy() { return default(PermissionRequestEvidence2); }

        public override string ToString() => base.ToString();
    }
}
