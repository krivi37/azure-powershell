namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Process server details.</summary>
    public partial class ProcessServerDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal
    {

        /// <summary>Backing field for <see cref="AvailableMemoryInByte" /> property.</summary>
        private long? _availableMemoryInByte;

        /// <summary>The available memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? AvailableMemoryInByte { get => this._availableMemoryInByte; }

        /// <summary>Backing field for <see cref="AvailableSpaceInByte" /> property.</summary>
        private long? _availableSpaceInByte;

        /// <summary>The available disk space.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? AvailableSpaceInByte { get => this._availableSpaceInByte; }

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>The process server Bios Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; }

        /// <summary>Backing field for <see cref="DiskUsageStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? _diskUsageStatus;

        /// <summary>The disk usage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? DiskUsageStatus { get => this._diskUsageStatus; }

        /// <summary>Backing field for <see cref="FabricObjectId" /> property.</summary>
        private string _fabricObjectId;

        /// <summary>The fabric object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricObjectId { get => this._fabricObjectId; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>The process server Fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; }

        /// <summary>Backing field for <see cref="FreeSpacePercentage" /> property.</summary>
        private double? _freeSpacePercentage;

        /// <summary>The free disk space percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? FreeSpacePercentage { get => this._freeSpacePercentage; }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? _health;

        /// <summary>The health of the process server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? Health { get => this._health; }

        /// <summary>Backing field for <see cref="HealthError" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] _healthError;

        /// <summary>The health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthError { get => this._healthError; }

        /// <summary>Backing field for <see cref="HistoricHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? _historicHealth;

        /// <summary>The historic health of the process server based on the health in last 24 hours.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? HistoricHealth { get => this._historicHealth; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The process server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="LastHeartbeatUtc" /> property.</summary>
        private global::System.DateTime? _lastHeartbeatUtc;

        /// <summary>The last heartbeat received from the process server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastHeartbeatUtc { get => this._lastHeartbeatUtc; }

        /// <summary>Backing field for <see cref="MemoryUsagePercentage" /> property.</summary>
        private double? _memoryUsagePercentage;

        /// <summary>The memory usage percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? MemoryUsagePercentage { get => this._memoryUsagePercentage; }

        /// <summary>Backing field for <see cref="MemoryUsageStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? _memoryUsageStatus;

        /// <summary>The memory usage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? MemoryUsageStatus { get => this._memoryUsageStatus; }

        /// <summary>Internal Acessors for AvailableMemoryInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.AvailableMemoryInByte { get => this._availableMemoryInByte; set { {_availableMemoryInByte = value;} } }

        /// <summary>Internal Acessors for AvailableSpaceInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.AvailableSpaceInByte { get => this._availableSpaceInByte; set { {_availableSpaceInByte = value;} } }

        /// <summary>Internal Acessors for BiosId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.BiosId { get => this._biosId; set { {_biosId = value;} } }

        /// <summary>Internal Acessors for DiskUsageStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.DiskUsageStatus { get => this._diskUsageStatus; set { {_diskUsageStatus = value;} } }

        /// <summary>Internal Acessors for FabricObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.FabricObjectId { get => this._fabricObjectId; set { {_fabricObjectId = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for FreeSpacePercentage</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.FreeSpacePercentage { get => this._freeSpacePercentage; set { {_freeSpacePercentage = value;} } }

        /// <summary>Internal Acessors for Health</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for HealthError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.HealthError { get => this._healthError; set { {_healthError = value;} } }

        /// <summary>Internal Acessors for HistoricHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.HistoricHealth { get => this._historicHealth; set { {_historicHealth = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LastHeartbeatUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.LastHeartbeatUtc { get => this._lastHeartbeatUtc; set { {_lastHeartbeatUtc = value;} } }

        /// <summary>Internal Acessors for MemoryUsagePercentage</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.MemoryUsagePercentage { get => this._memoryUsagePercentage; set { {_memoryUsagePercentage = value;} } }

        /// <summary>Internal Acessors for MemoryUsageStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.MemoryUsageStatus { get => this._memoryUsageStatus; set { {_memoryUsageStatus = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for ProcessorUsagePercentage</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.ProcessorUsagePercentage { get => this._processorUsagePercentage; set { {_processorUsagePercentage = value;} } }

        /// <summary>Internal Acessors for ProcessorUsageStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.ProcessorUsageStatus { get => this._processorUsageStatus; set { {_processorUsageStatus = value;} } }

        /// <summary>Internal Acessors for SystemLoad</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.SystemLoad { get => this._systemLoad; set { {_systemLoad = value;} } }

        /// <summary>Internal Acessors for SystemLoadStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.SystemLoadStatus { get => this._systemLoadStatus; set { {_systemLoadStatus = value;} } }

        /// <summary>Internal Acessors for ThroughputInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.ThroughputInByte { get => this._throughputInByte; set { {_throughputInByte = value;} } }

        /// <summary>Internal Acessors for ThroughputStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.ThroughputStatus { get => this._throughputStatus; set { {_throughputStatus = value;} } }

        /// <summary>Internal Acessors for ThroughputUploadPendingDataInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.ThroughputUploadPendingDataInByte { get => this._throughputUploadPendingDataInByte; set { {_throughputUploadPendingDataInByte = value;} } }

        /// <summary>Internal Acessors for TotalMemoryInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.TotalMemoryInByte { get => this._totalMemoryInByte; set { {_totalMemoryInByte = value;} } }

        /// <summary>Internal Acessors for TotalSpaceInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.TotalSpaceInByte { get => this._totalSpaceInByte; set { {_totalSpaceInByte = value;} } }

        /// <summary>Internal Acessors for UsedMemoryInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.UsedMemoryInByte { get => this._usedMemoryInByte; set { {_usedMemoryInByte = value;} } }

        /// <summary>Internal Acessors for UsedSpaceInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.UsedSpaceInByte { get => this._usedSpaceInByte; set { {_usedSpaceInByte = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The process server name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="ProcessorUsagePercentage" /> property.</summary>
        private double? _processorUsagePercentage;

        /// <summary>The processor usage percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? ProcessorUsagePercentage { get => this._processorUsagePercentage; }

        /// <summary>Backing field for <see cref="ProcessorUsageStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? _processorUsageStatus;

        /// <summary>The processor usage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? ProcessorUsageStatus { get => this._processorUsageStatus; }

        /// <summary>Backing field for <see cref="SystemLoad" /> property.</summary>
        private long? _systemLoad;

        /// <summary>The system load.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? SystemLoad { get => this._systemLoad; }

        /// <summary>Backing field for <see cref="SystemLoadStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? _systemLoadStatus;

        /// <summary>The system load status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? SystemLoadStatus { get => this._systemLoadStatus; }

        /// <summary>Backing field for <see cref="ThroughputInByte" /> property.</summary>
        private long? _throughputInByte;

        /// <summary>The throughput in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ThroughputInByte { get => this._throughputInByte; }

        /// <summary>Backing field for <see cref="ThroughputStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? _throughputStatus;

        /// <summary>The throughput status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? ThroughputStatus { get => this._throughputStatus; }

        /// <summary>Backing field for <see cref="ThroughputUploadPendingDataInByte" /> property.</summary>
        private long? _throughputUploadPendingDataInByte;

        /// <summary>The uploading pending data in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ThroughputUploadPendingDataInByte { get => this._throughputUploadPendingDataInByte; }

        /// <summary>Backing field for <see cref="TotalMemoryInByte" /> property.</summary>
        private long? _totalMemoryInByte;

        /// <summary>The total memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? TotalMemoryInByte { get => this._totalMemoryInByte; }

        /// <summary>Backing field for <see cref="TotalSpaceInByte" /> property.</summary>
        private long? _totalSpaceInByte;

        /// <summary>The total disk space.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? TotalSpaceInByte { get => this._totalSpaceInByte; }

        /// <summary>Backing field for <see cref="UsedMemoryInByte" /> property.</summary>
        private long? _usedMemoryInByte;

        /// <summary>The used memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? UsedMemoryInByte { get => this._usedMemoryInByte; }

        /// <summary>Backing field for <see cref="UsedSpaceInByte" /> property.</summary>
        private long? _usedSpaceInByte;

        /// <summary>The used disk space.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? UsedSpaceInByte { get => this._usedSpaceInByte; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="ProcessServerDetails" /> instance.</summary>
        public ProcessServerDetails()
        {

        }
    }
    /// Process server details.
    public partial interface IProcessServerDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The available memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The available memory.",
        SerializedName = @"availableMemoryInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? AvailableMemoryInByte { get;  }
        /// <summary>The available disk space.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The available disk space.",
        SerializedName = @"availableSpaceInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? AvailableSpaceInByte { get;  }
        /// <summary>The process server Bios Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The process server Bios Id.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get;  }
        /// <summary>The disk usage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk usage status.",
        SerializedName = @"diskUsageStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? DiskUsageStatus { get;  }
        /// <summary>The fabric object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fabric object Id.",
        SerializedName = @"fabricObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectId { get;  }
        /// <summary>The process server Fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The process server Fqdn.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get;  }
        /// <summary>The free disk space percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The free disk space percentage.",
        SerializedName = @"freeSpacePercentage",
        PossibleTypes = new [] { typeof(double) })]
        double? FreeSpacePercentage { get;  }
        /// <summary>The health of the process server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The health of the process server.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? Health { get;  }
        /// <summary>The health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The health errors.",
        SerializedName = @"healthErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthError { get;  }
        /// <summary>The historic health of the process server based on the health in last 24 hours.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The historic health of the process server based on the health in last 24 hours.",
        SerializedName = @"historicHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? HistoricHealth { get;  }
        /// <summary>The process server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The process server Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The last heartbeat received from the process server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last heartbeat received from the process server.",
        SerializedName = @"lastHeartbeatUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastHeartbeatUtc { get;  }
        /// <summary>The memory usage percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The memory usage percentage.",
        SerializedName = @"memoryUsagePercentage",
        PossibleTypes = new [] { typeof(double) })]
        double? MemoryUsagePercentage { get;  }
        /// <summary>The memory usage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The memory usage status.",
        SerializedName = @"memoryUsageStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? MemoryUsageStatus { get;  }
        /// <summary>The process server name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The process server name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The processor usage percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The processor usage percentage.",
        SerializedName = @"processorUsagePercentage",
        PossibleTypes = new [] { typeof(double) })]
        double? ProcessorUsagePercentage { get;  }
        /// <summary>The processor usage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The processor usage status.",
        SerializedName = @"processorUsageStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? ProcessorUsageStatus { get;  }
        /// <summary>The system load.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The system load.",
        SerializedName = @"systemLoad",
        PossibleTypes = new [] { typeof(long) })]
        long? SystemLoad { get;  }
        /// <summary>The system load status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The system load status.",
        SerializedName = @"systemLoadStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? SystemLoadStatus { get;  }
        /// <summary>The throughput in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The throughput in bytes.",
        SerializedName = @"throughputInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ThroughputInByte { get;  }
        /// <summary>The throughput status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The throughput status.",
        SerializedName = @"throughputStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? ThroughputStatus { get;  }
        /// <summary>The uploading pending data in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The uploading pending data in bytes.",
        SerializedName = @"throughputUploadPendingDataInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ThroughputUploadPendingDataInByte { get;  }
        /// <summary>The total memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The total memory.",
        SerializedName = @"totalMemoryInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalMemoryInByte { get;  }
        /// <summary>The total disk space.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The total disk space.",
        SerializedName = @"totalSpaceInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalSpaceInByte { get;  }
        /// <summary>The used memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The used memory.",
        SerializedName = @"usedMemoryInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? UsedMemoryInByte { get;  }
        /// <summary>The used disk space.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The used disk space.",
        SerializedName = @"usedSpaceInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? UsedSpaceInByte { get;  }
        /// <summary>The version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// Process server details.
    internal partial interface IProcessServerDetailsInternal

    {
        /// <summary>The available memory.</summary>
        long? AvailableMemoryInByte { get; set; }
        /// <summary>The available disk space.</summary>
        long? AvailableSpaceInByte { get; set; }
        /// <summary>The process server Bios Id.</summary>
        string BiosId { get; set; }
        /// <summary>The disk usage status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? DiskUsageStatus { get; set; }
        /// <summary>The fabric object Id.</summary>
        string FabricObjectId { get; set; }
        /// <summary>The process server Fqdn.</summary>
        string Fqdn { get; set; }
        /// <summary>The free disk space percentage.</summary>
        double? FreeSpacePercentage { get; set; }
        /// <summary>The health of the process server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? Health { get; set; }
        /// <summary>The health errors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthError { get; set; }
        /// <summary>The historic health of the process server based on the health in last 24 hours.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth? HistoricHealth { get; set; }
        /// <summary>The process server Id.</summary>
        string Id { get; set; }
        /// <summary>The last heartbeat received from the process server.</summary>
        global::System.DateTime? LastHeartbeatUtc { get; set; }
        /// <summary>The memory usage percentage.</summary>
        double? MemoryUsagePercentage { get; set; }
        /// <summary>The memory usage status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? MemoryUsageStatus { get; set; }
        /// <summary>The process server name.</summary>
        string Name { get; set; }
        /// <summary>The processor usage percentage.</summary>
        double? ProcessorUsagePercentage { get; set; }
        /// <summary>The processor usage status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? ProcessorUsageStatus { get; set; }
        /// <summary>The system load.</summary>
        long? SystemLoad { get; set; }
        /// <summary>The system load status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? SystemLoadStatus { get; set; }
        /// <summary>The throughput in bytes.</summary>
        long? ThroughputInByte { get; set; }
        /// <summary>The throughput status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus? ThroughputStatus { get; set; }
        /// <summary>The uploading pending data in bytes.</summary>
        long? ThroughputUploadPendingDataInByte { get; set; }
        /// <summary>The total memory.</summary>
        long? TotalMemoryInByte { get; set; }
        /// <summary>The total disk space.</summary>
        long? TotalSpaceInByte { get; set; }
        /// <summary>The used memory.</summary>
        long? UsedMemoryInByte { get; set; }
        /// <summary>The used disk space.</summary>
        long? UsedSpaceInByte { get; set; }
        /// <summary>The version.</summary>
        string Version { get; set; }

    }
}