namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input definition for test failover.</summary>
    public partial class TestFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputInternal
    {

        /// <summary>Test failover direction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string FailoverDirection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).FailoverDirection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).FailoverDirection = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TestFailoverInputProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputInternal.ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).ProviderSpecificDetail = value; }

        /// <summary>The id of the network to be used for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string NetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).NetworkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).NetworkId = value ?? null; }

        /// <summary>Network type to be used for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string NetworkType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).NetworkType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).NetworkType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputProperties _property;

        /// <summary>Test failover input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TestFailoverInputProperties()); set => this._property = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).ProviderSpecificDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputPropertiesInternal)Property).ProviderSpecificDetailInstanceType = value ?? null; }

        /// <summary>Creates an new <see cref="TestFailoverInput" /> instance.</summary>
        public TestFailoverInput()
        {

        }
    }
    /// Input definition for test failover.
    public partial interface ITestFailoverInput :
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
    /// Input definition for test failover.
    internal partial interface ITestFailoverInputInternal

    {
        /// <summary>Test failover direction.</summary>
        string FailoverDirection { get; set; }
        /// <summary>The id of the network to be used for test failover.</summary>
        string NetworkId { get; set; }
        /// <summary>Network type to be used for test failover.</summary>
        string NetworkType { get; set; }
        /// <summary>Test failover input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverInputProperties Property { get; set; }
        /// <summary>Provider specific settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }

    }
}