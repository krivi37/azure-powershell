// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>
    /// Customer creates a Contact Profile Resource, which will contain all of the configurations required for scheduling a contact.
    /// </summary>
    public partial class ContactProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.TrackedResource();

        /// <summary>Auto-tracking configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.AutoTrackingConfiguration? AutoTrackingConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).AutoTrackingConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).AutoTrackingConfiguration = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.AutoTrackingConfiguration)""); }

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string Etag { get => this._etag; }

        /// <summary>
        /// ARM resource identifier of the Event Hub used for telemetry. Requires granting Orbital Resource Provider the rights to
        /// send telemetry into the hub.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string EventHubUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).EventHubUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).EventHubUri = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Id; }

        /// <summary>
        /// Links of the Contact Profile. Describes RF links, modem processing, and IP endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileLink[] Link { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).Link; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).Link = value ?? null /* arrayOf */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 1)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for NetworkConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesNetworkConfiguration Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileInternal.NetworkConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).NetworkConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).NetworkConfiguration = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesProperties Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ContactProfilesProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>
        /// Minimum viable elevation for the contact in decimal degrees. Used for listing the available contacts with a spacecraft
        /// at a given ground station.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? MinimumElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).MinimumElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).MinimumElevationDegree = value ?? default(float); }

        /// <summary>
        /// Minimum viable contact duration in ISO 8601 format. Used for listing the available contacts with a spacecraft at a given
        /// ground station.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string MinimumViableContactDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).MinimumViableContactDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).MinimumViableContactDuration = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class
        /// C subnet, and should not have any IP created in it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string NetworkConfigurationSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).NetworkConfigurationSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).NetworkConfigurationSubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesProperties _property;

        /// <summary>Properties of the contact profile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ContactProfilesProperties()); set => this._property = value; }

        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 2)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 3)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="ContactProfile" /> instance.</summary>
        public ContactProfile()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Customer creates a Contact Profile Resource, which will contain all of the configurations required for scheduling a contact.
    public partial interface IContactProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResource
    {
        /// <summary>Auto-tracking configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Auto-tracking configuration.",
        SerializedName = @"autoTrackingConfiguration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.AutoTrackingConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.AutoTrackingConfiguration? AutoTrackingConfiguration { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>
        /// ARM resource identifier of the Event Hub used for telemetry. Requires granting Orbital Resource Provider the rights to
        /// send telemetry into the hub.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource identifier of the Event Hub used for telemetry. Requires granting Orbital Resource Provider the rights to send telemetry into the hub.",
        SerializedName = @"eventHubUri",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubUri { get; set; }
        /// <summary>
        /// Links of the Contact Profile. Describes RF links, modem processing, and IP endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Links of the Contact Profile. Describes RF links, modem processing, and IP endpoints.",
        SerializedName = @"links",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileLink) })]
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileLink[] Link { get; set; }
        /// <summary>
        /// Minimum viable elevation for the contact in decimal degrees. Used for listing the available contacts with a spacecraft
        /// at a given ground station.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum viable elevation for the contact in decimal degrees. Used for listing the available contacts with a spacecraft at a given ground station.",
        SerializedName = @"minimumElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? MinimumElevationDegree { get; set; }
        /// <summary>
        /// Minimum viable contact duration in ISO 8601 format. Used for listing the available contacts with a spacecraft at a given
        /// ground station.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum viable contact duration in ISO 8601 format. Used for listing the available contacts with a spacecraft at a given ground station.",
        SerializedName = @"minimumViableContactDuration",
        PossibleTypes = new [] { typeof(string) })]
        string MinimumViableContactDuration { get; set; }
        /// <summary>
        /// ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class
        /// C subnet, and should not have any IP created in it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class C subnet, and should not have any IP created in it.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkConfigurationSubnetId { get; set; }
        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current state of the resource's creation, deletion, or modification.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }

    }
    /// Customer creates a Contact Profile Resource, which will contain all of the configurations required for scheduling a contact.
    internal partial interface IContactProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResourceInternal
    {
        /// <summary>Auto-tracking configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.AutoTrackingConfiguration? AutoTrackingConfiguration { get; set; }

        string AzureAsyncOperation { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>
        /// ARM resource identifier of the Event Hub used for telemetry. Requires granting Orbital Resource Provider the rights to
        /// send telemetry into the hub.
        /// </summary>
        string EventHubUri { get; set; }
        /// <summary>
        /// Links of the Contact Profile. Describes RF links, modem processing, and IP endpoints.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileLink[] Link { get; set; }
        /// <summary>
        /// Minimum viable elevation for the contact in decimal degrees. Used for listing the available contacts with a spacecraft
        /// at a given ground station.
        /// </summary>
        float? MinimumElevationDegree { get; set; }
        /// <summary>
        /// Minimum viable contact duration in ISO 8601 format. Used for listing the available contacts with a spacecraft at a given
        /// ground station.
        /// </summary>
        string MinimumViableContactDuration { get; set; }
        /// <summary>Network configuration of customer virtual network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesPropertiesNetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary>
        /// ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class
        /// C subnet, and should not have any IP created in it.
        /// </summary>
        string NetworkConfigurationSubnetId { get; set; }
        /// <summary>Properties of the contact profile resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfilesProperties Property { get; set; }
        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        string ProvisioningState { get; set; }

    }
}