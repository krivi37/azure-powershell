namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input definition for test failover input properties.</summary>
    public partial class TestFailoverInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FailoverDirection" /> property.</summary>
        private string _failoverDirection;

        /// <summary>Test failover direction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FailoverDirection { get => this._failoverDirection; set => this._failoverDirection = value; }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal.ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TestFailoverProviderSpecificInput()); set { {_providerSpecificDetail = value;} } }

        /// <summary>Backing field for <see cref="NetworkId" /> property.</summary>
        private string _networkId;

        /// <summary>The id of the network to be used for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NetworkId { get => this._networkId; set => this._networkId = value; }

        /// <summary>Backing field for <see cref="NetworkType" /> property.</summary>
        private string _networkType;

        /// <summary>Network type to be used for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NetworkType { get => this._networkType; set => this._networkType = value; }

        /// <summary>Backing field for <see cref="ProviderSpecificDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput _providerSpecificDetail;

        /// <summary>Provider specific settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TestFailoverProviderSpecificInput()); set => this._providerSpecificDetail = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)ProviderSpecificDetail).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)ProviderSpecificDetail).InstanceType = value ?? null; }

        /// <summary>Creates an new <see cref="TestFailoverInputProperties" /> instance.</summary>
        public TestFailoverInputProperties()
        {

        }
    }
    /// Input definition for test failover input properties.
    public partial interface ITestFailoverInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Test failover direction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Test failover direction.",
        SerializedName = @"failoverDirection",
        PossibleTypes = new [] { typeof(string) })]
        string FailoverDirection { get; set; }
        /// <summary>The id of the network to be used for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the network to be used for test failover.",
        SerializedName = @"networkId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkId { get; set; }
        /// <summary>Network type to be used for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Network type to be used for test failover.",
        SerializedName = @"networkType",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkType { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }

    }
    /// Input definition for test failover input properties.
    internal partial interface ITestFailoverInputPropertiesInternal

    {
        /// <summary>Test failover direction.</summary>
        string FailoverDirection { get; set; }
        /// <summary>The id of the network to be used for test failover.</summary>
        string NetworkId { get; set; }
        /// <summary>Network type to be used for test failover.</summary>
        string NetworkType { get; set; }
        /// <summary>Provider specific settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }

    }
}