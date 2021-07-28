namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMwareCbt provider specific settings.</summary>
    public partial class VMwareCbtMigrationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettings"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettings __migrationProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.MigrationProviderSpecificSettings();

        /// <summary>Backing field for <see cref="DataMoverRunAsAccountId" /> property.</summary>
        private string _dataMoverRunAsAccountId;

        /// <summary>The data mover run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DataMoverRunAsAccountId { get => this._dataMoverRunAsAccountId; }

        /// <summary>Backing field for <see cref="FirmwareType" /> property.</summary>
        private string _firmwareType;

        /// <summary>The firmware type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FirmwareType { get => this._firmwareType; }

        /// <summary>Backing field for <see cref="InitialSeedingProgressPercentage" /> property.</summary>
        private int? _initialSeedingProgressPercentage;

        /// <summary>The initial seeding progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? InitialSeedingProgressPercentage { get => this._initialSeedingProgressPercentage; }

        /// <summary>Backing field for <see cref="InitialSeedingRetryCount" /> property.</summary>
        private long? _initialSeedingRetryCount;

        /// <summary>The initial seeding retry count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? InitialSeedingRetryCount { get => this._initialSeedingRetryCount; }

        /// <summary>Gets the instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettingsInternal)__migrationProviderSpecificSettings).InstanceType; }

        /// <summary>Backing field for <see cref="LastRecoveryPointId" /> property.</summary>
        private string _lastRecoveryPointId;

        /// <summary>The last recovery point Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LastRecoveryPointId { get => this._lastRecoveryPointId; }

        /// <summary>Backing field for <see cref="LastRecoveryPointReceived" /> property.</summary>
        private global::System.DateTime? _lastRecoveryPointReceived;

        /// <summary>The last recovery point received time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastRecoveryPointReceived { get => this._lastRecoveryPointReceived; }

        /// <summary>Backing field for <see cref="LicenseType" /> property.</summary>
        private string _licenseType;

        /// <summary>License Type of the VM to be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LicenseType { get => this._licenseType; set => this._licenseType = value; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettingsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettingsInternal)__migrationProviderSpecificSettings).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettingsInternal)__migrationProviderSpecificSettings).InstanceType = value; }

        /// <summary>Internal Acessors for DataMoverRunAsAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.DataMoverRunAsAccountId { get => this._dataMoverRunAsAccountId; set { {_dataMoverRunAsAccountId = value;} } }

        /// <summary>Internal Acessors for FirmwareType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.FirmwareType { get => this._firmwareType; set { {_firmwareType = value;} } }

        /// <summary>Internal Acessors for InitialSeedingProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.InitialSeedingProgressPercentage { get => this._initialSeedingProgressPercentage; set { {_initialSeedingProgressPercentage = value;} } }

        /// <summary>Internal Acessors for InitialSeedingRetryCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.InitialSeedingRetryCount { get => this._initialSeedingRetryCount; set { {_initialSeedingRetryCount = value;} } }

        /// <summary>Internal Acessors for LastRecoveryPointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.LastRecoveryPointId { get => this._lastRecoveryPointId; set { {_lastRecoveryPointId = value;} } }

        /// <summary>Internal Acessors for LastRecoveryPointReceived</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.LastRecoveryPointReceived { get => this._lastRecoveryPointReceived; set { {_lastRecoveryPointReceived = value;} } }

        /// <summary>Internal Acessors for MigrationProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.MigrationProgressPercentage { get => this._migrationProgressPercentage; set { {_migrationProgressPercentage = value;} } }

        /// <summary>Internal Acessors for MigrationRecoveryPointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.MigrationRecoveryPointId { get => this._migrationRecoveryPointId; set { {_migrationRecoveryPointId = value;} } }

        /// <summary>Internal Acessors for OSType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.OSType { get => this._oSType; set { {_oSType = value;} } }

        /// <summary>Internal Acessors for ResyncProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.ResyncProgressPercentage { get => this._resyncProgressPercentage; set { {_resyncProgressPercentage = value;} } }

        /// <summary>Internal Acessors for ResyncRequired</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.ResyncRequired { get => this._resyncRequired; set { {_resyncRequired = value;} } }

        /// <summary>Internal Acessors for ResyncRetryCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.ResyncRetryCount { get => this._resyncRetryCount; set { {_resyncRetryCount = value;} } }

        /// <summary>Internal Acessors for ResyncState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.ResyncState { get => this._resyncState; set { {_resyncState = value;} } }

        /// <summary>Internal Acessors for SnapshotRunAsAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.SnapshotRunAsAccountId { get => this._snapshotRunAsAccountId; set { {_snapshotRunAsAccountId = value;} } }

        /// <summary>Internal Acessors for TargetGeneration</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.TargetGeneration { get => this._targetGeneration; set { {_targetGeneration = value;} } }

        /// <summary>Internal Acessors for TargetLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.TargetLocation { get => this._targetLocation; set { {_targetLocation = value;} } }

        /// <summary>Internal Acessors for VmwareMachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsInternal.VmwareMachineId { get => this._vmwareMachineId; set { {_vmwareMachineId = value;} } }

        /// <summary>Backing field for <see cref="MigrationProgressPercentage" /> property.</summary>
        private int? _migrationProgressPercentage;

        /// <summary>The migration progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? MigrationProgressPercentage { get => this._migrationProgressPercentage; }

        /// <summary>Backing field for <see cref="MigrationRecoveryPointId" /> property.</summary>
        private string _migrationRecoveryPointId;

        /// <summary>The recovery point Id to which the VM was migrated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MigrationRecoveryPointId { get => this._migrationRecoveryPointId; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The type of the OS on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; }

        /// <summary>Backing field for <see cref="PerformAutoResync" /> property.</summary>
        private string _performAutoResync;

        /// <summary>A value indicating whether auto resync is to be done.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PerformAutoResync { get => this._performAutoResync; set => this._performAutoResync = value; }

        /// <summary>Backing field for <see cref="ProtectedDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtProtectedDiskDetails[] _protectedDisk;

        /// <summary>The list of protected disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtProtectedDiskDetails[] ProtectedDisk { get => this._protectedDisk; set => this._protectedDisk = value; }

        /// <summary>Backing field for <see cref="ResyncProgressPercentage" /> property.</summary>
        private int? _resyncProgressPercentage;

        /// <summary>The resync progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ResyncProgressPercentage { get => this._resyncProgressPercentage; }

        /// <summary>Backing field for <see cref="ResyncRequired" /> property.</summary>
        private string _resyncRequired;

        /// <summary>A value indicating whether resync is required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResyncRequired { get => this._resyncRequired; }

        /// <summary>Backing field for <see cref="ResyncRetryCount" /> property.</summary>
        private long? _resyncRetryCount;

        /// <summary>The resync retry count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncRetryCount { get => this._resyncRetryCount; }

        /// <summary>Backing field for <see cref="ResyncState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? _resyncState;

        /// <summary>The resync state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get => this._resyncState; }

        /// <summary>Backing field for <see cref="SeedDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsSeedDiskTags _seedDiskTag;

        /// <summary>The tags for the seed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsSeedDiskTags SeedDiskTag { get => (this._seedDiskTag = this._seedDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtMigrationDetailsSeedDiskTags()); set => this._seedDiskTag = value; }

        /// <summary>Backing field for <see cref="SnapshotRunAsAccountId" /> property.</summary>
        private string _snapshotRunAsAccountId;

        /// <summary>The snapshot run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SnapshotRunAsAccountId { get => this._snapshotRunAsAccountId; }

        /// <summary>Backing field for <see cref="SqlServerLicenseType" /> property.</summary>
        private string _sqlServerLicenseType;

        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SqlServerLicenseType { get => this._sqlServerLicenseType; set => this._sqlServerLicenseType = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilitySetId" /> property.</summary>
        private string _targetAvailabilitySetId;

        /// <summary>The target availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilitySetId { get => this._targetAvailabilitySetId; set => this._targetAvailabilitySetId = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilityZone" /> property.</summary>
        private string _targetAvailabilityZone;

        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilityZone { get => this._targetAvailabilityZone; set => this._targetAvailabilityZone = value; }

        /// <summary>
        /// Backing field for <see cref="TargetBootDiagnosticsStorageAccountId" /> property.
        /// </summary>
        private string _targetBootDiagnosticsStorageAccountId;

        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetBootDiagnosticsStorageAccountId { get => this._targetBootDiagnosticsStorageAccountId; set => this._targetBootDiagnosticsStorageAccountId = value; }

        /// <summary>Backing field for <see cref="TargetDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetDiskTags _targetDiskTag;

        /// <summary>The tags for the target disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetDiskTags TargetDiskTag { get => (this._targetDiskTag = this._targetDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtMigrationDetailsTargetDiskTags()); set => this._targetDiskTag = value; }

        /// <summary>Backing field for <see cref="TargetGeneration" /> property.</summary>
        private string _targetGeneration;

        /// <summary>The target generation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetGeneration { get => this._targetGeneration; }

        /// <summary>Backing field for <see cref="TargetLocation" /> property.</summary>
        private string _targetLocation;

        /// <summary>The target location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetLocation { get => this._targetLocation; }

        /// <summary>Backing field for <see cref="TargetNetworkId" /> property.</summary>
        private string _targetNetworkId;

        /// <summary>The target network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetNetworkId { get => this._targetNetworkId; set => this._targetNetworkId = value; }

        /// <summary>Backing field for <see cref="TargetNicTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetNicTags _targetNicTag;

        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetNicTags TargetNicTag { get => (this._targetNicTag = this._targetNicTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtMigrationDetailsTargetNicTags()); set => this._targetNicTag = value; }

        /// <summary>Backing field for <see cref="TargetProximityPlacementGroupId" /> property.</summary>
        private string _targetProximityPlacementGroupId;

        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProximityPlacementGroupId { get => this._targetProximityPlacementGroupId; set => this._targetProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="TargetResourceGroupId" /> property.</summary>
        private string _targetResourceGroupId;

        /// <summary>The target resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetResourceGroupId { get => this._targetResourceGroupId; set => this._targetResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetVMName" /> property.</summary>
        private string _targetVMName;

        /// <summary>Target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMName { get => this._targetVMName; set => this._targetVMName = value; }

        /// <summary>Backing field for <see cref="TargetVMSize" /> property.</summary>
        private string _targetVMSize;

        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMSize { get => this._targetVMSize; set => this._targetVMSize = value; }

        /// <summary>Backing field for <see cref="TargetVMTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetVmtags _targetVMTag;

        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetVmtags TargetVMTag { get => (this._targetVMTag = this._targetVMTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtMigrationDetailsTargetVmtags()); set => this._targetVMTag = value; }

        /// <summary>Backing field for <see cref="VMNic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtNicDetails[] _vMNic;

        /// <summary>The network details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtNicDetails[] VMNic { get => this._vMNic; set => this._vMNic = value; }

        /// <summary>Backing field for <see cref="VmwareMachineId" /> property.</summary>
        private string _vmwareMachineId;

        /// <summary>The ARM Id of the VM discovered in VMware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VmwareMachineId { get => this._vmwareMachineId; }

        /// <summary>Creates an new <see cref="VMwareCbtMigrationDetails" /> instance.</summary>
        public VMwareCbtMigrationDetails()
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
            await eventListener.AssertNotNull(nameof(__migrationProviderSpecificSettings), __migrationProviderSpecificSettings);
            await eventListener.AssertObjectIsValid(nameof(__migrationProviderSpecificSettings), __migrationProviderSpecificSettings);
        }
    }
    /// VMwareCbt provider specific settings.
    public partial interface IVMwareCbtMigrationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettings
    {
        /// <summary>The data mover run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The data mover run as account Id.",
        SerializedName = @"dataMoverRunAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string DataMoverRunAsAccountId { get;  }
        /// <summary>The firmware type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The firmware type.",
        SerializedName = @"firmwareType",
        PossibleTypes = new [] { typeof(string) })]
        string FirmwareType { get;  }
        /// <summary>The initial seeding progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial seeding progress percentage.",
        SerializedName = @"initialSeedingProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? InitialSeedingProgressPercentage { get;  }
        /// <summary>The initial seeding retry count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial seeding retry count.",
        SerializedName = @"initialSeedingRetryCount",
        PossibleTypes = new [] { typeof(long) })]
        long? InitialSeedingRetryCount { get;  }
        /// <summary>The last recovery point Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last recovery point Id.",
        SerializedName = @"lastRecoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string LastRecoveryPointId { get;  }
        /// <summary>The last recovery point received time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last recovery point received time.",
        SerializedName = @"lastRecoveryPointReceived",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastRecoveryPointReceived { get;  }
        /// <summary>License Type of the VM to be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"License Type of the VM to be used.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(string) })]
        string LicenseType { get; set; }
        /// <summary>The migration progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The migration progress percentage.",
        SerializedName = @"migrationProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? MigrationProgressPercentage { get;  }
        /// <summary>The recovery point Id to which the VM was migrated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The recovery point Id to which the VM was migrated.",
        SerializedName = @"migrationRecoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationRecoveryPointId { get;  }
        /// <summary>The type of the OS on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the OS on the VM.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get;  }
        /// <summary>A value indicating whether auto resync is to be done.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether auto resync is to be done.",
        SerializedName = @"performAutoResync",
        PossibleTypes = new [] { typeof(string) })]
        string PerformAutoResync { get; set; }
        /// <summary>The list of protected disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of protected disks.",
        SerializedName = @"protectedDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtProtectedDiskDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtProtectedDiskDetails[] ProtectedDisk { get; set; }
        /// <summary>The resync progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync progress percentage.",
        SerializedName = @"resyncProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ResyncProgressPercentage { get;  }
        /// <summary>A value indicating whether resync is required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether resync is required.",
        SerializedName = @"resyncRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncRequired { get;  }
        /// <summary>The resync retry count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync retry count.",
        SerializedName = @"resyncRetryCount",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncRetryCount { get;  }
        /// <summary>The resync state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync state.",
        SerializedName = @"resyncState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get;  }
        /// <summary>The tags for the seed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the seed disks.",
        SerializedName = @"seedDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsSeedDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsSeedDiskTags SeedDiskTag { get; set; }
        /// <summary>The snapshot run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The snapshot run as account Id.",
        SerializedName = @"snapshotRunAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string SnapshotRunAsAccountId { get;  }
        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SQL Server license type.",
        SerializedName = @"sqlServerLicenseType",
        PossibleTypes = new [] { typeof(string) })]
        string SqlServerLicenseType { get; set; }
        /// <summary>The target availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability set Id.",
        SerializedName = @"targetAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability zone.",
        SerializedName = @"targetAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilityZone { get; set; }
        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target boot diagnostics storage account ARM Id.",
        SerializedName = @"targetBootDiagnosticsStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary>The tags for the target disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target disks.",
        SerializedName = @"targetDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetDiskTags TargetDiskTag { get; set; }
        /// <summary>The target generation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target generation.",
        SerializedName = @"targetGeneration",
        PossibleTypes = new [] { typeof(string) })]
        string TargetGeneration { get;  }
        /// <summary>The target location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target location.",
        SerializedName = @"targetLocation",
        PossibleTypes = new [] { typeof(string) })]
        string TargetLocation { get;  }
        /// <summary>The target network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target network Id.",
        SerializedName = @"targetNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetNetworkId { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target NICs.",
        SerializedName = @"targetNicTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetNicTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetNicTags TargetNicTag { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target proximity placement group Id.",
        SerializedName = @"targetProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target resource group Id.",
        SerializedName = @"targetResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGroupId { get; set; }
        /// <summary>Target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target VM name.",
        SerializedName = @"targetVmName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMName { get; set; }
        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM size.",
        SerializedName = @"targetVmSize",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMSize { get; set; }
        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM tags.",
        SerializedName = @"targetVmTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetVmtags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetVmtags TargetVMTag { get; set; }
        /// <summary>The network details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network details.",
        SerializedName = @"vmNics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtNicDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtNicDetails[] VMNic { get; set; }
        /// <summary>The ARM Id of the VM discovered in VMware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the VM discovered in VMware.",
        SerializedName = @"vmwareMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string VmwareMachineId { get;  }

    }
    /// VMwareCbt provider specific settings.
    internal partial interface IVMwareCbtMigrationDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationProviderSpecificSettingsInternal
    {
        /// <summary>The data mover run as account Id.</summary>
        string DataMoverRunAsAccountId { get; set; }
        /// <summary>The firmware type.</summary>
        string FirmwareType { get; set; }
        /// <summary>The initial seeding progress percentage.</summary>
        int? InitialSeedingProgressPercentage { get; set; }
        /// <summary>The initial seeding retry count.</summary>
        long? InitialSeedingRetryCount { get; set; }
        /// <summary>The last recovery point Id.</summary>
        string LastRecoveryPointId { get; set; }
        /// <summary>The last recovery point received time.</summary>
        global::System.DateTime? LastRecoveryPointReceived { get; set; }
        /// <summary>License Type of the VM to be used.</summary>
        string LicenseType { get; set; }
        /// <summary>The migration progress percentage.</summary>
        int? MigrationProgressPercentage { get; set; }
        /// <summary>The recovery point Id to which the VM was migrated.</summary>
        string MigrationRecoveryPointId { get; set; }
        /// <summary>The type of the OS on the VM.</summary>
        string OSType { get; set; }
        /// <summary>A value indicating whether auto resync is to be done.</summary>
        string PerformAutoResync { get; set; }
        /// <summary>The list of protected disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtProtectedDiskDetails[] ProtectedDisk { get; set; }
        /// <summary>The resync progress percentage.</summary>
        int? ResyncProgressPercentage { get; set; }
        /// <summary>A value indicating whether resync is required.</summary>
        string ResyncRequired { get; set; }
        /// <summary>The resync retry count.</summary>
        long? ResyncRetryCount { get; set; }
        /// <summary>The resync state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get; set; }
        /// <summary>The tags for the seed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsSeedDiskTags SeedDiskTag { get; set; }
        /// <summary>The snapshot run as account Id.</summary>
        string SnapshotRunAsAccountId { get; set; }
        /// <summary>The SQL Server license type.</summary>
        string SqlServerLicenseType { get; set; }
        /// <summary>The target availability set Id.</summary>
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        string TargetAvailabilityZone { get; set; }
        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary>The tags for the target disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetDiskTags TargetDiskTag { get; set; }
        /// <summary>The target generation.</summary>
        string TargetGeneration { get; set; }
        /// <summary>The target location.</summary>
        string TargetLocation { get; set; }
        /// <summary>The target network Id.</summary>
        string TargetNetworkId { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetNicTags TargetNicTag { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group Id.</summary>
        string TargetResourceGroupId { get; set; }
        /// <summary>Target VM name.</summary>
        string TargetVMName { get; set; }
        /// <summary>The target VM size.</summary>
        string TargetVMSize { get; set; }
        /// <summary>The target VM tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtMigrationDetailsTargetVmtags TargetVMTag { get; set; }
        /// <summary>The network details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtNicDetails[] VMNic { get; set; }
        /// <summary>The ARM Id of the VM discovered in VMware.</summary>
        string VmwareMachineId { get; set; }

    }
}