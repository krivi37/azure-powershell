// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>The build stage (init-container and container) resources in build pod.</summary>
    public partial class BuildStageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IBuildStageProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IBuildStagePropertiesInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IBuildStagePropertiesInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.KPackBuildStageProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IBuildStagePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of this build stage resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.KPackBuildStageProvisioningState? _status;

        /// <summary>The provisioning state of this build stage resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.KPackBuildStageProvisioningState? Status { get => this._status; }

        /// <summary>Creates an new <see cref="BuildStageProperties" /> instance.</summary>
        public BuildStageProperties()
        {

        }
    }
    /// The build stage (init-container and container) resources in build pod.
    public partial interface IBuildStageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>The name of this build stage resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of this build stage resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The provisioning state of this build stage resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of this build stage resource.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.KPackBuildStageProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.KPackBuildStageProvisioningState? Status { get;  }

    }
    /// The build stage (init-container and container) resources in build pod.
    internal partial interface IBuildStagePropertiesInternal

    {
        /// <summary>The name of this build stage resource.</summary>
        string Name { get; set; }
        /// <summary>The provisioning state of this build stage resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.KPackBuildStageProvisioningState? Status { get; set; }

    }
}