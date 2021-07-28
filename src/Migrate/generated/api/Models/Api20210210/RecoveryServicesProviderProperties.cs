namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery services provider properties.</summary>
    public partial class RecoveryServicesProviderProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AllowedScenario" /> property.</summary>
        private string[] _allowedScenario;

        /// <summary>The scenarios allowed on this provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] AllowedScenario { get => this._allowedScenario; set => this._allowedScenario = value; }

        /// <summary>Backing field for <see cref="AuthenticationIdentityDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails _authenticationIdentityDetail;

        /// <summary>The authentication identity details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails AuthenticationIdentityDetail { get => (this._authenticationIdentityDetail = this._authenticationIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderDetails()); set => this._authenticationIdentityDetail = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).AadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).ApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).Audience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).ObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityDetailTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)AuthenticationIdentityDetail).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>The Bios Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; set => this._biosId = value; }

        /// <summary>Backing field for <see cref="ConnectionStatus" /> property.</summary>
        private string _connectionStatus;

        /// <summary>A value indicating whether DRA is responsive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ConnectionStatus { get => this._connectionStatus; set => this._connectionStatus = value; }

        /// <summary>
        /// Backing field for <see cref="DataPlaneAuthenticationIdentityDetail" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails _dataPlaneAuthenticationIdentityDetail;

        /// <summary>The data plane authentication identity details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails DataPlaneAuthenticationIdentityDetail { get => (this._dataPlaneAuthenticationIdentityDetail = this._dataPlaneAuthenticationIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderDetails()); set => this._dataPlaneAuthenticationIdentityDetail = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).AadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).ApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).Audience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).ObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityDetailTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)DataPlaneAuthenticationIdentityDetail).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="DraIdentifier" /> property.</summary>
        private string _draIdentifier;

        /// <summary>The DRA Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DraIdentifier { get => this._draIdentifier; set => this._draIdentifier = value; }

        /// <summary>Backing field for <see cref="FabricFriendlyName" /> property.</summary>
        private string _fabricFriendlyName;

        /// <summary>The fabric friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricFriendlyName { get => this._fabricFriendlyName; set => this._fabricFriendlyName = value; }

        /// <summary>Backing field for <see cref="FabricType" /> property.</summary>
        private string _fabricType;

        /// <summary>Type of the site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricType { get => this._fabricType; set => this._fabricType = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="HealthErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] _healthErrorDetail;

        /// <summary>The recovery services provider health error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthErrorDetail { get => this._healthErrorDetail; set => this._healthErrorDetail = value; }

        /// <summary>Backing field for <see cref="LastHeartBeat" /> property.</summary>
        private global::System.DateTime? _lastHeartBeat;

        /// <summary>Time when last heartbeat was sent by the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastHeartBeat { get => this._lastHeartBeat; set => this._lastHeartBeat = value; }

        /// <summary>Backing field for <see cref="MachineId" /> property.</summary>
        private string _machineId;

        /// <summary>The machine Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MachineId { get => this._machineId; set => this._machineId = value; }

        /// <summary>Backing field for <see cref="MachineName" /> property.</summary>
        private string _machineName;

        /// <summary>The machine name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MachineName { get => this._machineName; set => this._machineName = value; }

        /// <summary>Internal Acessors for AuthenticationIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal.AuthenticationIdentityDetail { get => (this._authenticationIdentityDetail = this._authenticationIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderDetails()); set { {_authenticationIdentityDetail = value;} } }

        /// <summary>Internal Acessors for DataPlaneAuthenticationIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal.DataPlaneAuthenticationIdentityDetail { get => (this._dataPlaneAuthenticationIdentityDetail = this._dataPlaneAuthenticationIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderDetails()); set { {_dataPlaneAuthenticationIdentityDetail = value;} } }

        /// <summary>Internal Acessors for ProviderVersionDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal.ProviderVersionDetail { get => (this._providerVersionDetail = this._providerVersionDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VersionDetails()); set { {_providerVersionDetail = value;} } }

        /// <summary>Internal Acessors for ResourceAccessIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryServicesProviderPropertiesInternal.ResourceAccessIdentityDetail { get => (this._resourceAccessIdentityDetail = this._resourceAccessIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderDetails()); set { {_resourceAccessIdentityDetail = value;} } }

        /// <summary>Backing field for <see cref="ProtectedItemCount" /> property.</summary>
        private int? _protectedItemCount;

        /// <summary>Number of protected VMs currently managed by the DRA.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ProtectedItemCount { get => this._protectedItemCount; set => this._protectedItemCount = value; }

        /// <summary>Backing field for <see cref="ProviderVersion" /> property.</summary>
        private string _providerVersion;

        /// <summary>The provider version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProviderVersion { get => this._providerVersion; set => this._providerVersion = value; }

        /// <summary>Backing field for <see cref="ProviderVersionDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetails _providerVersionDetail;

        /// <summary>The provider version details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetails ProviderVersionDetail { get => (this._providerVersionDetail = this._providerVersionDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VersionDetails()); set => this._providerVersionDetail = value; }

        /// <summary>Version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? ProviderVersionDetailExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetailsInternal)ProviderVersionDetail).ExpiryDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetailsInternal)ProviderVersionDetail).ExpiryDate = value ?? default(global::System.DateTime); }

        /// <summary>A value indicating whether security update required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus? ProviderVersionDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetailsInternal)ProviderVersionDetail).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetailsInternal)ProviderVersionDetail).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus)""); }

        /// <summary>The agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderVersionDetailVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetailsInternal)ProviderVersionDetail).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVersionDetailsInternal)ProviderVersionDetail).Version = value ?? null; }

        /// <summary>Backing field for <see cref="ProviderVersionExpiryDate" /> property.</summary>
        private global::System.DateTime? _providerVersionExpiryDate;

        /// <summary>Expiry date of the version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? ProviderVersionExpiryDate { get => this._providerVersionExpiryDate; set => this._providerVersionExpiryDate = value; }

        /// <summary>Backing field for <see cref="ProviderVersionState" /> property.</summary>
        private string _providerVersionState;

        /// <summary>DRA version status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProviderVersionState { get => this._providerVersionState; set => this._providerVersionState = value; }

        /// <summary>Backing field for <see cref="ResourceAccessIdentityDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails _resourceAccessIdentityDetail;

        /// <summary>The resource access identity details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetails ResourceAccessIdentityDetail { get => (this._resourceAccessIdentityDetail = this._resourceAccessIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderDetails()); set => this._resourceAccessIdentityDetail = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).AadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).ApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).Audience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).ObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityDetailTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderDetailsInternal)ResourceAccessIdentityDetail).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="ServerVersion" /> property.</summary>
        private string _serverVersion;

        /// <summary>The fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ServerVersion { get => this._serverVersion; set => this._serverVersion = value; }

        /// <summary>Creates an new <see cref="RecoveryServicesProviderProperties" /> instance.</summary>
        public RecoveryServicesProviderProperties()
        {

        }
    }
    /// Recovery services provider properties.
    public partial interface IRecoveryServicesProviderProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
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
    /// Recovery services provider properties.
    internal partial interface IRecoveryServicesProviderPropertiesInternal

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