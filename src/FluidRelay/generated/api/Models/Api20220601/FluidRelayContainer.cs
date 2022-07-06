// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Extensions;

    /// <summary>A FluidRelay Container.</summary>
    public partial class FluidRelayContainer :
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainer,
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.Resource();

        /// <summary>The creation time of this resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.FormatTable(Index = 1)]
        public global::System.DateTime? CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).CreationTime; }

        /// <summary>The frsContainerId for this container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public string FrsContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).FrsContainerId; }

        /// <summary>The Fluid tenantId for this container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public string FrsTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).FrsTenantId; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>Last time when user access this resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.FormatTable(Index = 2)]
        public global::System.DateTime? LastAccessTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).LastAccessTime; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).CreationTime = value; }

        /// <summary>Internal Acessors for FrsContainerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal.FrsContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).FrsContainerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).FrsContainerId = value; }

        /// <summary>Internal Acessors for FrsTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal.FrsTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).FrsTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).FrsTenantId = value; }

        /// <summary>Internal Acessors for LastAccessTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal.LastAccessTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).LastAccessTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).LastAccessTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerProperties Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.FluidRelayContainerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.FluidRelayContainerProperties()); }

        /// <summary>Provision states for FluidRelay RP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.FormatTable(Index = 3)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemData _systemData;

        /// <summary>
        /// System meta data for this resource, including creation and modification information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="FluidRelayContainer" /> instance.</summary>
        public FluidRelayContainer()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A FluidRelay Container.
    public partial interface IFluidRelayContainer :
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResource
    {
        /// <summary>The creation time of this resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The creation time of this resource",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationTime { get;  }
        /// <summary>The frsContainerId for this container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The frsContainerId for this container",
        SerializedName = @"frsContainerId",
        PossibleTypes = new [] { typeof(string) })]
        string FrsContainerId { get;  }
        /// <summary>The Fluid tenantId for this container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Fluid tenantId for this container",
        SerializedName = @"frsTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string FrsTenantId { get;  }
        /// <summary>Last time when user access this resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Last time when user access this resource",
        SerializedName = @"lastAccessTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastAccessTime { get;  }
        /// <summary>Provision states for FluidRelay RP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provision states for FluidRelay RP",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// A FluidRelay Container.
    internal partial interface IFluidRelayContainerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.IResourceInternal
    {
        /// <summary>The creation time of this resource</summary>
        global::System.DateTime? CreationTime { get; set; }
        /// <summary>The frsContainerId for this container</summary>
        string FrsContainerId { get; set; }
        /// <summary>The Fluid tenantId for this container</summary>
        string FrsTenantId { get; set; }
        /// <summary>Last time when user access this resource</summary>
        global::System.DateTime? LastAccessTime { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayContainerProperties Property { get; set; }
        /// <summary>Provision states for FluidRelay RP</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// System meta data for this resource, including creation and modification information.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}