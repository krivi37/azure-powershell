namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The properties of an add provider request.</summary>
    public partial class AddRecoveryServicesProviderInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AuthenticationIdentityInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput _authenticationIdentityInput;

        /// <summary>The identity provider input for DRA authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput AuthenticationIdentityInput { get => (this._authenticationIdentityInput = this._authenticationIdentityInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set => this._authenticationIdentityInput = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).AadAuthority = value ; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).ApplicationId = value ; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).Audience = value ; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).ObjectId = value ; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)AuthenticationIdentityInput).TenantId = value ; }

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>The Bios Id of the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; set => this._biosId = value; }

        /// <summary>Backing field for <see cref="DataPlaneAuthenticationIdentityInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput _dataPlaneAuthenticationIdentityInput;

        /// <summary>The identity provider input for data plane authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput DataPlaneAuthenticationIdentityInput { get => (this._dataPlaneAuthenticationIdentityInput = this._dataPlaneAuthenticationIdentityInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set => this._dataPlaneAuthenticationIdentityInput = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).AadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).ApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).Audience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).ObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)DataPlaneAuthenticationIdentityInput).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="MachineId" /> property.</summary>
        private string _machineId;

        /// <summary>The Id of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MachineId { get => this._machineId; set => this._machineId = value; }

        /// <summary>Backing field for <see cref="MachineName" /> property.</summary>
        private string _machineName;

        /// <summary>The name of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MachineName { get => this._machineName; set => this._machineName = value; }

        /// <summary>Internal Acessors for AuthenticationIdentityInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal.AuthenticationIdentityInput { get => (this._authenticationIdentityInput = this._authenticationIdentityInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set { {_authenticationIdentityInput = value;} } }

        /// <summary>Internal Acessors for DataPlaneAuthenticationIdentityInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal.DataPlaneAuthenticationIdentityInput { get => (this._dataPlaneAuthenticationIdentityInput = this._dataPlaneAuthenticationIdentityInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set { {_dataPlaneAuthenticationIdentityInput = value;} } }

        /// <summary>Internal Acessors for ResourceAccessIdentityInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal.ResourceAccessIdentityInput { get => (this._resourceAccessIdentityInput = this._resourceAccessIdentityInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set { {_resourceAccessIdentityInput = value;} } }

        /// <summary>Backing field for <see cref="ResourceAccessIdentityInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput _resourceAccessIdentityInput;

        /// <summary>The identity provider input for resource access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput ResourceAccessIdentityInput { get => (this._resourceAccessIdentityInput = this._resourceAccessIdentityInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set => this._resourceAccessIdentityInput = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).AadAuthority = value ; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).ApplicationId = value ; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).Audience = value ; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).ObjectId = value ; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)ResourceAccessIdentityInput).TenantId = value ; }

        /// <summary>
        /// Creates an new <see cref="AddRecoveryServicesProviderInputProperties" /> instance.
        /// </summary>
        public AddRecoveryServicesProviderInputProperties()
        {

        }
    }
    /// The properties of an add provider request.
    public partial interface IAddRecoveryServicesProviderInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Bios Id of the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Bios Id of the machine.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityInputAadAuthority { get; set; }
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
        string DataPlaneAuthenticationIdentityInputApplicationId { get; set; }
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
        string DataPlaneAuthenticationIdentityInputAudience { get; set; }
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
        string DataPlaneAuthenticationIdentityInputObjectId { get; set; }
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
        string DataPlaneAuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Id of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the machine where the provider is getting added.",
        SerializedName = @"machineId",
        PossibleTypes = new [] { typeof(string) })]
        string MachineId { get; set; }
        /// <summary>The name of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the machine where the provider is getting added.",
        SerializedName = @"machineName",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityInputTenantId { get; set; }

    }
    /// The properties of an add provider request.
    internal partial interface IAddRecoveryServicesProviderInputPropertiesInternal

    {
        /// <summary>The identity provider input for DRA authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput AuthenticationIdentityInput { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string AuthenticationIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string AuthenticationIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string AuthenticationIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string AuthenticationIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string AuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Bios Id of the machine.</summary>
        string BiosId { get; set; }
        /// <summary>The identity provider input for data plane authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput DataPlaneAuthenticationIdentityInput { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string DataPlaneAuthenticationIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Id of the machine where the provider is getting added.</summary>
        string MachineId { get; set; }
        /// <summary>The name of the machine where the provider is getting added.</summary>
        string MachineName { get; set; }
        /// <summary>The identity provider input for resource access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput ResourceAccessIdentityInput { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string ResourceAccessIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputTenantId { get; set; }

    }
}