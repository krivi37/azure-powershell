namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm protected disk details.</summary>
    public partial class InMageRcmProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="CapacityInByte" /> property.</summary>
        private long? _capacityInByte;

        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? CapacityInByte { get => this._capacityInByte; }

        /// <summary>Backing field for <see cref="DataPendingAtSourceAgentInMb" /> property.</summary>
        private double? _dataPendingAtSourceAgentInMb;

        /// <summary>The data pending at source agent in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? DataPendingAtSourceAgentInMb { get => this._dataPendingAtSourceAgentInMb; }

        /// <summary>Backing field for <see cref="DataPendingInLogDataStoreInMb" /> property.</summary>
        private double? _dataPendingInLogDataStoreInMb;

        /// <summary>The data pending in log data store in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? DataPendingInLogDataStoreInMb { get => this._dataPendingInLogDataStoreInMb; }

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; }

        /// <summary>Backing field for <see cref="DiskName" /> property.</summary>
        private string _diskName;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskName { get => this._diskName; }

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? _diskType;

        /// <summary>The disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get => this._diskType; set => this._diskType = value; }

        /// <summary>Backing field for <see cref="IrDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails _irDetail;

        /// <summary>The initial replication details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails IrDetail { get => (this._irDetail = this._irDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmSyncDetails()); set => this._irDetail = value; }

        /// <summary>The bytes transferred in last 15 minutes from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? IrDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).Last15MinutesTransferredByte; }

        /// <summary>The time of the last data transfer from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string IrDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).LastDataTransferTimeUtc; }

        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string IrDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).LastRefreshTime; }

        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? IrDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProcessedByte; }

        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? IrDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProgressHealth; }

        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? IrDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProgressPercentage; }

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string IrDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).StartTime; }

        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? IrDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).TransferredByte; }

        /// <summary>Backing field for <see cref="IsInitialReplicationComplete" /> property.</summary>
        private string _isInitialReplicationComplete;

        /// <summary>A value indicating whether initial replication is complete or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsInitialReplicationComplete { get => this._isInitialReplicationComplete; }

        /// <summary>Backing field for <see cref="IsOSDisk" /> property.</summary>
        private string _isOSDisk;

        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsOSDisk { get => this._isOSDisk; }

        /// <summary>Backing field for <see cref="LogStorageAccountId" /> property.</summary>
        private string _logStorageAccountId;

        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountId { get => this._logStorageAccountId; }

        /// <summary>Internal Acessors for CapacityInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.CapacityInByte { get => this._capacityInByte; set { {_capacityInByte = value;} } }

        /// <summary>Internal Acessors for DataPendingAtSourceAgentInMb</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.DataPendingAtSourceAgentInMb { get => this._dataPendingAtSourceAgentInMb; set { {_dataPendingAtSourceAgentInMb = value;} } }

        /// <summary>Internal Acessors for DataPendingInLogDataStoreInMb</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.DataPendingInLogDataStoreInMb { get => this._dataPendingInLogDataStoreInMb; set { {_dataPendingInLogDataStoreInMb = value;} } }

        /// <summary>Internal Acessors for DiskEncryptionSetId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.DiskEncryptionSetId { get => this._diskEncryptionSetId; set { {_diskEncryptionSetId = value;} } }

        /// <summary>Internal Acessors for DiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.DiskId { get => this._diskId; set { {_diskId = value;} } }

        /// <summary>Internal Acessors for DiskName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.DiskName { get => this._diskName; set { {_diskName = value;} } }

        /// <summary>Internal Acessors for IrDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetail { get => (this._irDetail = this._irDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmSyncDetails()); set { {_irDetail = value;} } }

        /// <summary>Internal Acessors for IrDetailLast15MinutesTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).Last15MinutesTransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).Last15MinutesTransferredByte = value; }

        /// <summary>Internal Acessors for IrDetailLastDataTransferTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).LastDataTransferTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).LastDataTransferTimeUtc = value; }

        /// <summary>Internal Acessors for IrDetailLastRefreshTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).LastRefreshTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).LastRefreshTime = value; }

        /// <summary>Internal Acessors for IrDetailProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProcessedByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProcessedByte = value; }

        /// <summary>Internal Acessors for IrDetailProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProgressHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProgressHealth = value; }

        /// <summary>Internal Acessors for IrDetailProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProgressPercentage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).ProgressPercentage = value; }

        /// <summary>Internal Acessors for IrDetailStartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).StartTime = value; }

        /// <summary>Internal Acessors for IrDetailTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IrDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).TransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)IrDetail).TransferredByte = value; }

        /// <summary>Internal Acessors for IsInitialReplicationComplete</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IsInitialReplicationComplete { get => this._isInitialReplicationComplete; set { {_isInitialReplicationComplete = value;} } }

        /// <summary>Internal Acessors for IsOSDisk</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.IsOSDisk { get => this._isOSDisk; set { {_isOSDisk = value;} } }

        /// <summary>Internal Acessors for LogStorageAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.LogStorageAccountId { get => this._logStorageAccountId; set { {_logStorageAccountId = value;} } }

        /// <summary>Internal Acessors for ResyncDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetail { get => (this._resyncDetail = this._resyncDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmSyncDetails()); set { {_resyncDetail = value;} } }

        /// <summary>Internal Acessors for ResyncDetailLast15MinutesTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).Last15MinutesTransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).Last15MinutesTransferredByte = value; }

        /// <summary>Internal Acessors for ResyncDetailLastDataTransferTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).LastDataTransferTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).LastDataTransferTimeUtc = value; }

        /// <summary>Internal Acessors for ResyncDetailLastRefreshTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).LastRefreshTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).LastRefreshTime = value; }

        /// <summary>Internal Acessors for ResyncDetailProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProcessedByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProcessedByte = value; }

        /// <summary>Internal Acessors for ResyncDetailProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProgressHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProgressHealth = value; }

        /// <summary>Internal Acessors for ResyncDetailProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProgressPercentage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProgressPercentage = value; }

        /// <summary>Internal Acessors for ResyncDetailStartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).StartTime = value; }

        /// <summary>Internal Acessors for ResyncDetailTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.ResyncDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).TransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).TransferredByte = value; }

        /// <summary>Internal Acessors for SeedManagedDiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.SeedManagedDiskId { get => this._seedManagedDiskId; set { {_seedManagedDiskId = value;} } }

        /// <summary>Internal Acessors for TargetManagedDiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetailsInternal.TargetManagedDiskId { get => this._targetManagedDiskId; set { {_targetManagedDiskId = value;} } }

        /// <summary>Backing field for <see cref="ResyncDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails _resyncDetail;

        /// <summary>The resync details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails ResyncDetail { get => (this._resyncDetail = this._resyncDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmSyncDetails()); set => this._resyncDetail = value; }

        /// <summary>The bytes transferred in last 15 minutes from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? ResyncDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).Last15MinutesTransferredByte; }

        /// <summary>The time of the last data transfer from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResyncDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).LastDataTransferTimeUtc; }

        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResyncDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).LastRefreshTime; }

        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? ResyncDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProcessedByte; }

        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ResyncDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProgressHealth; }

        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? ResyncDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).ProgressPercentage; }

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResyncDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).StartTime; }

        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? ResyncDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetailsInternal)ResyncDetail).TransferredByte; }

        /// <summary>Backing field for <see cref="SeedManagedDiskId" /> property.</summary>
        private string _seedManagedDiskId;

        /// <summary>The ARM Id of the seed managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SeedManagedDiskId { get => this._seedManagedDiskId; }

        /// <summary>Backing field for <see cref="TargetManagedDiskId" /> property.</summary>
        private string _targetManagedDiskId;

        /// <summary>The ARM Id of the target managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetManagedDiskId { get => this._targetManagedDiskId; }

        /// <summary>Creates an new <see cref="InMageRcmProtectedDiskDetails" /> instance.</summary>
        public InMageRcmProtectedDiskDetails()
        {

        }
    }
    /// InMageRcm protected disk details.
    public partial interface IInMageRcmProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk capacity in bytes.",
        SerializedName = @"capacityInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityInByte { get;  }
        /// <summary>The data pending at source agent in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The data pending at source agent in MB.",
        SerializedName = @"dataPendingAtSourceAgentInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? DataPendingAtSourceAgentInMb { get;  }
        /// <summary>The data pending in log data store in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The data pending in log data store in MB.",
        SerializedName = @"dataPendingInLogDataStoreInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? DataPendingInLogDataStoreInMb { get;  }
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The DiskEncryptionSet ARM Id.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get;  }
        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk Id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get;  }
        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk name.",
        SerializedName = @"diskName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskName { get;  }
        /// <summary>The disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk type.",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The bytes transferred in last 15 minutes from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The bytes transferred in last 15 minutes from source VM to azure.",
        SerializedName = @"last15MinutesTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? IrDetailLast15MinutesTransferredByte { get;  }
        /// <summary>The time of the last data transfer from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of the last data transfer from source VM to azure.",
        SerializedName = @"lastDataTransferTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string IrDetailLastDataTransferTimeUtc { get;  }
        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last refresh time.",
        SerializedName = @"lastRefreshTime",
        PossibleTypes = new [] { typeof(string) })]
        string IrDetailLastRefreshTime { get;  }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.",
        SerializedName = @"processedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? IrDetailProcessedByte { get;  }
        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The progress health.",
        SerializedName = @"progressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? IrDetailProgressHealth { get;  }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Progress in percentage. Progress percentage is calculated based on processed bytes.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? IrDetailProgressPercentage { get;  }
        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string IrDetailStartTime { get;  }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The transferred bytes from source VM to azure for the disk.",
        SerializedName = @"transferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? IrDetailTransferredByte { get;  }
        /// <summary>A value indicating whether initial replication is complete or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether initial replication is complete or not.",
        SerializedName = @"isInitialReplicationComplete",
        PossibleTypes = new [] { typeof(string) })]
        string IsInitialReplicationComplete { get;  }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the disk is the OS disk.",
        SerializedName = @"isOSDisk",
        PossibleTypes = new [] { typeof(string) })]
        string IsOSDisk { get;  }
        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The log storage account ARM Id.",
        SerializedName = @"logStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountId { get;  }
        /// <summary>The bytes transferred in last 15 minutes from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The bytes transferred in last 15 minutes from source VM to azure.",
        SerializedName = @"last15MinutesTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncDetailLast15MinutesTransferredByte { get;  }
        /// <summary>The time of the last data transfer from source VM to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of the last data transfer from source VM to azure.",
        SerializedName = @"lastDataTransferTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncDetailLastDataTransferTimeUtc { get;  }
        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last refresh time.",
        SerializedName = @"lastRefreshTime",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncDetailLastRefreshTime { get;  }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.",
        SerializedName = @"processedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncDetailProcessedByte { get;  }
        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The progress health.",
        SerializedName = @"progressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ResyncDetailProgressHealth { get;  }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Progress in percentage. Progress percentage is calculated based on processed bytes.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ResyncDetailProgressPercentage { get;  }
        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncDetailStartTime { get;  }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The transferred bytes from source VM to azure for the disk.",
        SerializedName = @"transferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncDetailTransferredByte { get;  }
        /// <summary>The ARM Id of the seed managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the seed managed disk.",
        SerializedName = @"seedManagedDiskId",
        PossibleTypes = new [] { typeof(string) })]
        string SeedManagedDiskId { get;  }
        /// <summary>The ARM Id of the target managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the target managed disk.",
        SerializedName = @"targetManagedDiskId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetManagedDiskId { get;  }

    }
    /// InMageRcm protected disk details.
    internal partial interface IInMageRcmProtectedDiskDetailsInternal

    {
        /// <summary>The disk capacity in bytes.</summary>
        long? CapacityInByte { get; set; }
        /// <summary>The data pending at source agent in MB.</summary>
        double? DataPendingAtSourceAgentInMb { get; set; }
        /// <summary>The data pending in log data store in MB.</summary>
        double? DataPendingInLogDataStoreInMb { get; set; }
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>The disk Id.</summary>
        string DiskId { get; set; }
        /// <summary>The disk name.</summary>
        string DiskName { get; set; }
        /// <summary>The disk type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The initial replication details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails IrDetail { get; set; }
        /// <summary>The bytes transferred in last 15 minutes from source VM to azure.</summary>
        long? IrDetailLast15MinutesTransferredByte { get; set; }
        /// <summary>The time of the last data transfer from source VM to azure.</summary>
        string IrDetailLastDataTransferTimeUtc { get; set; }
        /// <summary>The last refresh time.</summary>
        string IrDetailLastRefreshTime { get; set; }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.
        /// </summary>
        long? IrDetailProcessedByte { get; set; }
        /// <summary>The progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? IrDetailProgressHealth { get; set; }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        int? IrDetailProgressPercentage { get; set; }
        /// <summary>The start time.</summary>
        string IrDetailStartTime { get; set; }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        long? IrDetailTransferredByte { get; set; }
        /// <summary>A value indicating whether initial replication is complete or not.</summary>
        string IsInitialReplicationComplete { get; set; }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        string IsOSDisk { get; set; }
        /// <summary>The log storage account ARM Id.</summary>
        string LogStorageAccountId { get; set; }
        /// <summary>The resync details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmSyncDetails ResyncDetail { get; set; }
        /// <summary>The bytes transferred in last 15 minutes from source VM to azure.</summary>
        long? ResyncDetailLast15MinutesTransferredByte { get; set; }
        /// <summary>The time of the last data transfer from source VM to azure.</summary>
        string ResyncDetailLastDataTransferTimeUtc { get; set; }
        /// <summary>The last refresh time.</summary>
        string ResyncDetailLastRefreshTime { get; set; }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes.
        /// </summary>
        long? ResyncDetailProcessedByte { get; set; }
        /// <summary>The progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ResyncDetailProgressHealth { get; set; }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        int? ResyncDetailProgressPercentage { get; set; }
        /// <summary>The start time.</summary>
        string ResyncDetailStartTime { get; set; }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        long? ResyncDetailTransferredByte { get; set; }
        /// <summary>The ARM Id of the seed managed disk.</summary>
        string SeedManagedDiskId { get; set; }
        /// <summary>The ARM Id of the target managed disk.</summary>
        string TargetManagedDiskId { get; set; }

    }
}