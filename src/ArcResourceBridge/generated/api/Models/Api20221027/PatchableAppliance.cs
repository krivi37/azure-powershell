// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Extensions;

    /// <summary>The Appliances patchable resource definition.</summary>
    public partial class PatchableAppliance :
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IPatchableAppliance,
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IPatchableApplianceInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IPatchableApplianceTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IPatchableApplianceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.PatchableApplianceTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="PatchableAppliance" /> instance.</summary>
        public PatchableAppliance()
        {

        }
    }
    /// The Appliances patchable resource definition.
    public partial interface IPatchableAppliance :
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IPatchableApplianceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IPatchableApplianceTags Tag { get; set; }

    }
    /// The Appliances patchable resource definition.
    internal partial interface IPatchableApplianceInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IPatchableApplianceTags Tag { get; set; }

    }
}