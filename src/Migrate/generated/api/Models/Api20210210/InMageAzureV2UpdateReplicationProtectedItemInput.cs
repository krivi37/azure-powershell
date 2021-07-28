namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMage Azure V2 input to update replication protected item.</summary>
    public partial class InMageAzureV2UpdateReplicationProtectedItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInput __updateReplicationProtectedItemProviderInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UpdateReplicationProtectedItemProviderInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)__updateReplicationProtectedItemProviderInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)__updateReplicationProtectedItemProviderInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryAzureV1ResourceGroupId" /> property.</summary>
        private string _recoveryAzureV1ResourceGroupId;

        /// <summary>The recovery Azure resource group Id for classic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryAzureV1ResourceGroupId { get => this._recoveryAzureV1ResourceGroupId; set => this._recoveryAzureV1ResourceGroupId = value; }

        /// <summary>Backing field for <see cref="RecoveryAzureV2ResourceGroupId" /> property.</summary>
        private string _recoveryAzureV2ResourceGroupId;

        /// <summary>The recovery Azure resource group Id for resource manager deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryAzureV2ResourceGroupId { get => this._recoveryAzureV2ResourceGroupId; set => this._recoveryAzureV2ResourceGroupId = value; }

        /// <summary>Backing field for <see cref="SqlServerLicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? _sqlServerLicenseType;

        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get => this._sqlServerLicenseType; set => this._sqlServerLicenseType = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilityZone" /> property.</summary>
        private string _targetAvailabilityZone;

        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilityZone { get => this._targetAvailabilityZone; set => this._targetAvailabilityZone = value; }

        /// <summary>Backing field for <see cref="TargetManagedDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetManagedDiskTags _targetManagedDiskTag;

        /// <summary>The tags for the target managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetManagedDiskTags TargetManagedDiskTag { get => (this._targetManagedDiskTag = this._targetManagedDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2UpdateReplicationProtectedItemInputTargetManagedDiskTags()); set => this._targetManagedDiskTag = value; }

        /// <summary>Backing field for <see cref="TargetNicTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags _targetNicTag;

        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags TargetNicTag { get => (this._targetNicTag = this._targetNicTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags()); set => this._targetNicTag = value; }

        /// <summary>Backing field for <see cref="TargetProximityPlacementGroupId" /> property.</summary>
        private string _targetProximityPlacementGroupId;

        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProximityPlacementGroupId { get => this._targetProximityPlacementGroupId; set => this._targetProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="TargetVMTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetVMTags _targetVMTag;

        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetVMTags TargetVMTag { get => (this._targetVMTag = this._targetVMTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2UpdateReplicationProtectedItemInputTargetVMTags()); set => this._targetVMTag = value; }

        /// <summary>Backing field for <see cref="UseManagedDisk" /> property.</summary>
        private string _useManagedDisk;

        /// <summary>A value indicating whether managed disks should be used during failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string UseManagedDisk { get => this._useManagedDisk; set => this._useManagedDisk = value; }

        /// <summary>
        /// Creates an new <see cref="InMageAzureV2UpdateReplicationProtectedItemInput" /> instance.
        /// </summary>
        public InMageAzureV2UpdateReplicationProtectedItemInput()
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
            await eventListener.AssertNotNull(nameof(__updateReplicationProtectedItemProviderInput), __updateReplicationProtectedItemProviderInput);
            await eventListener.AssertObjectIsValid(nameof(__updateReplicationProtectedItemProviderInput), __updateReplicationProtectedItemProviderInput);
        }
    }
    /// InMage Azure V2 input to update replication protected item.
    public partial interface IInMageAzureV2UpdateReplicationProtectedItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInput
    {
        /// <summary>The recovery Azure resource group Id for classic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery Azure resource group Id for classic deployment.",
        SerializedName = @"recoveryAzureV1ResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAzureV1ResourceGroupId { get; set; }
        /// <summary>The recovery Azure resource group Id for resource manager deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery Azure resource group Id for resource manager deployment.",
        SerializedName = @"recoveryAzureV2ResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAzureV2ResourceGroupId { get; set; }
        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SQL Server license type.",
        SerializedName = @"sqlServerLicenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability zone.",
        SerializedName = @"targetAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilityZone { get; set; }
        /// <summary>The tags for the target managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target managed disks.",
        SerializedName = @"targetManagedDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetManagedDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetManagedDiskTags TargetManagedDiskTag { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target NICs.",
        SerializedName = @"targetNicTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target proximity placement group Id.",
        SerializedName = @"targetProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM tags.",
        SerializedName = @"targetVmTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetVMTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetVMTags TargetVMTag { get; set; }
        /// <summary>A value indicating whether managed disks should be used during failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether managed disks should be used during failover.",
        SerializedName = @"useManagedDisks",
        PossibleTypes = new [] { typeof(string) })]
        string UseManagedDisk { get; set; }

    }
    /// InMage Azure V2 input to update replication protected item.
    internal partial interface IInMageAzureV2UpdateReplicationProtectedItemInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal
    {
        /// <summary>The recovery Azure resource group Id for classic deployment.</summary>
        string RecoveryAzureV1ResourceGroupId { get; set; }
        /// <summary>The recovery Azure resource group Id for resource manager deployment.</summary>
        string RecoveryAzureV2ResourceGroupId { get; set; }
        /// <summary>The SQL Server license type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary>The target availability zone.</summary>
        string TargetAvailabilityZone { get; set; }
        /// <summary>The tags for the target managed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetManagedDiskTags TargetManagedDiskTag { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target VM tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetVMTags TargetVMTag { get; set; }
        /// <summary>A value indicating whether managed disks should be used during failover.</summary>
        string UseManagedDisk { get; set; }

    }
}