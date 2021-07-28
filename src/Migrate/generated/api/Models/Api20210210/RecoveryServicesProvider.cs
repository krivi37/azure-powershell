namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Provider details.</summary>
    public partial class RecoveryServicesProvider :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProvider,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.Resource();

        /// <summary>The scenarios allowed on this provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] AllowedScenario { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AllowedScenario; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AllowedScenario = value ?? null /* arrayOf */; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailAadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailAadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailAudience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetailTenantId = value ?? null; }

        /// <summary>The Bios Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string BiosId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).BiosId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).BiosId = value ?? null; }

        /// <summary>A value indicating whether DRA is responsive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ConnectionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ConnectionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ConnectionStatus = value ?? null; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailAadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailAadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailAudience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetailTenantId = value ?? null; }

        /// <summary>The DRA Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DraIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DraIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DraIdentifier = value ?? null; }

        /// <summary>The fabric friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string FabricFriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).FabricFriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).FabricFriendlyName = value ?? null; }

        /// <summary>Type of the site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string FabricType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).FabricType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).FabricType = value ?? null; }

        /// <summary>Friendly name of the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).FriendlyName = value ?? null; }

        /// <summary>The recovery services provider health error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).HealthErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).HealthErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; }

        /// <summary>Time when last heartbeat was sent by the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastHeartBeat { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).LastHeartBeat; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).LastHeartBeat = value ?? default(global::System.DateTime); }

        /// <summary>Resource Location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>The machine Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).MachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).MachineId = value ?? null; }

        /// <summary>The machine name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MachineName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).MachineName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).MachineName = value ?? null; }

        /// <summary>Internal Acessors for AuthenticationIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderInternal.AuthenticationIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).AuthenticationIdentityDetail = value; }

        /// <summary>Internal Acessors for DataPlaneAuthenticationIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderInternal.DataPlaneAuthenticationIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).DataPlaneAuthenticationIdentityDetail = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryServicesProviderProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProviderVersionDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderInternal.ProviderVersionDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetail = value; }

        /// <summary>Internal Acessors for ResourceAccessIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderInternal.ResourceAccessIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetail = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderProperties _property;

        /// <summary>Provider properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryServicesProviderProperties()); set => this._property = value; }

        /// <summary>Number of protected VMs currently managed by the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? ProtectedItemCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProtectedItemCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProtectedItemCount = value ?? default(int); }

        /// <summary>The provider version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersion = value ?? null; }

        /// <summary>Version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? ProviderVersionDetailExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetailExpiryDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetailExpiryDate = value ?? default(global::System.DateTime); }

        /// <summary>A value indicating whether security update required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus? ProviderVersionDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetailStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetailStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus)""); }

        /// <summary>The agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderVersionDetailVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetailVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionDetailVersion = value ?? null; }

        /// <summary>Expiry date of the version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? ProviderVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionExpiryDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionExpiryDate = value ?? default(global::System.DateTime); }

        /// <summary>DRA version status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderVersionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ProviderVersionState = value ?? null; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailAadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailAadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailAudience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ResourceAccessIdentityDetailTenantId = value ?? null; }

        /// <summary>The fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ServerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ServerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal)Property).ServerVersion = value ?? null; }

        /// <summary>Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="RecoveryServicesProvider" /> instance.</summary>
        public RecoveryServicesProvider()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Provider details.
    public partial interface IRecoveryServicesProvider :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource
    {
        /// <summary>The scenarios allowed on this provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scenarios allowed on this provider.",
        SerializedName = @"allowedScenarios",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedScenario { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityDetailAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityDetailApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityDetailAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityDetailObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityDetailTenantId { get; set; }
        /// <summary>The Bios Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Bios Id.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get; set; }
        /// <summary>A value indicating whether DRA is responsive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether DRA is responsive.",
        SerializedName = @"connectionStatus",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionStatus { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityDetailAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityDetailApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityDetailAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityDetailObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityDetailTenantId { get; set; }
        /// <summary>The DRA Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DRA Id.",
        SerializedName = @"draIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string DraIdentifier { get; set; }
        /// <summary>The fabric friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fabric friendly name.",
        SerializedName = @"fabricFriendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FabricFriendlyName { get; set; }
        /// <summary>Type of the site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the site.",
        SerializedName = @"fabricType",
        PossibleTypes = new [] { typeof(string) })]
        string FabricType { get; set; }
        /// <summary>Friendly name of the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of the DRA.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>The recovery services provider health error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery services provider health error details.",
        SerializedName = @"healthErrorDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthErrorDetail { get; set; }
        /// <summary>Time when last heartbeat was sent by the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time when last heartbeat was sent by the DRA.",
        SerializedName = @"lastHeartBeat",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastHeartBeat { get; set; }
        /// <summary>The machine Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The machine Id.",
        SerializedName = @"machineId",
        PossibleTypes = new [] { typeof(string) })]
        string MachineId { get; set; }
        /// <summary>The machine name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The machine name.",
        SerializedName = @"machineName",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }
        /// <summary>Number of protected VMs currently managed by the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of protected VMs currently managed by the DRA.",
        SerializedName = @"protectedItemCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ProtectedItemCount { get; set; }
        /// <summary>The provider version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provider version.",
        SerializedName = @"providerVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderVersion { get; set; }
        /// <summary>Version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version expiry date.",
        SerializedName = @"expiryDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ProviderVersionDetailExpiryDate { get; set; }
        /// <summary>A value indicating whether security update required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether security update required.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus? ProviderVersionDetailStatus { get; set; }
        /// <summary>The agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The agent version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderVersionDetailVersion { get; set; }
        /// <summary>Expiry date of the version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expiry date of the version.",
        SerializedName = @"providerVersionExpiryDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ProviderVersionExpiryDate { get; set; }
        /// <summary>DRA version status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DRA version status.",
        SerializedName = @"providerVersionState",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderVersionState { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityDetailAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityDetailApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityDetailAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityDetailObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityDetailTenantId { get; set; }
        /// <summary>The fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fabric provider.",
        SerializedName = @"serverVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ServerVersion { get; set; }

    }
    /// Provider details.
    internal partial interface IRecoveryServicesProviderInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal
    {
        /// <summary>The scenarios allowed on this provider.</summary>
        string[] AllowedScenario { get; set; }
        /// <summary>The authentication identity details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails AuthenticationIdentityDetail { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string AuthenticationIdentityDetailAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string AuthenticationIdentityDetailApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string AuthenticationIdentityDetailAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string AuthenticationIdentityDetailObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string AuthenticationIdentityDetailTenantId { get; set; }
        /// <summary>The Bios Id.</summary>
        string BiosId { get; set; }
        /// <summary>A value indicating whether DRA is responsive.</summary>
        string ConnectionStatus { get; set; }
        /// <summary>The data plane authentication identity details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails DataPlaneAuthenticationIdentityDetail { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string DataPlaneAuthenticationIdentityDetailAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityDetailApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityDetailAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityDetailObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityDetailTenantId { get; set; }
        /// <summary>The DRA Id.</summary>
        string DraIdentifier { get; set; }
        /// <summary>The fabric friendly name.</summary>
        string FabricFriendlyName { get; set; }
        /// <summary>Type of the site.</summary>
        string FabricType { get; set; }
        /// <summary>Friendly name of the DRA.</summary>
        string FriendlyName { get; set; }
        /// <summary>The recovery services provider health error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthErrorDetail { get; set; }
        /// <summary>Time when last heartbeat was sent by the DRA.</summary>
        global::System.DateTime? LastHeartBeat { get; set; }
        /// <summary>The machine Id.</summary>
        string MachineId { get; set; }
        /// <summary>The machine name.</summary>
        string MachineName { get; set; }
        /// <summary>Provider properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderProperties Property { get; set; }
        /// <summary>Number of protected VMs currently managed by the DRA.</summary>
        int? ProtectedItemCount { get; set; }
        /// <summary>The provider version.</summary>
        string ProviderVersion { get; set; }
        /// <summary>The provider version details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetails ProviderVersionDetail { get; set; }
        /// <summary>Version expiry date.</summary>
        global::System.DateTime? ProviderVersionDetailExpiryDate { get; set; }
        /// <summary>A value indicating whether security update required.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus? ProviderVersionDetailStatus { get; set; }
        /// <summary>The agent version.</summary>
        string ProviderVersionDetailVersion { get; set; }
        /// <summary>Expiry date of the version.</summary>
        global::System.DateTime? ProviderVersionExpiryDate { get; set; }
        /// <summary>DRA version status.</summary>
        string ProviderVersionState { get; set; }
        /// <summary>The resource access identity details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails ResourceAccessIdentityDetail { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string ResourceAccessIdentityDetailAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string ResourceAccessIdentityDetailApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string ResourceAccessIdentityDetailAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string ResourceAccessIdentityDetailObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string ResourceAccessIdentityDetailTenantId { get; set; }
        /// <summary>The fabric provider.</summary>
        string ServerVersion { get; set; }

    }
}