namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input definition for unplanned failover input properties.</summary>
    public partial class UnplannedFailoverInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FailoverDirection" /> property.</summary>
        private string _failoverDirection;

        /// <summary>Failover direction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FailoverDirection { get => this._failoverDirection; set => this._failoverDirection = value; }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverInputPropertiesInternal.ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UnplannedFailoverProviderSpecificInput()); set { {_providerSpecificDetail = value;} } }

        /// <summary>Backing field for <see cref="ProviderSpecificDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInput _providerSpecificDetail;

        /// <summary>Provider specific settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInput ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UnplannedFailoverProviderSpecificInput()); set => this._providerSpecificDetail = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInputInternal)ProviderSpecificDetail).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInputInternal)ProviderSpecificDetail).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="SourceSiteOperation" /> property.</summary>
        private string _sourceSiteOperation;

        /// <summary>Source site operations status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SourceSiteOperation { get => this._sourceSiteOperation; set => this._sourceSiteOperation = value; }

        /// <summary>Creates an new <see cref="UnplannedFailoverInputProperties" /> instance.</summary>
        public UnplannedFailoverInputProperties()
        {

        }
    }
    /// Input definition for unplanned failover input properties.
    public partial interface IUnplannedFailoverInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Failover direction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Failover direction.",
        SerializedName = @"failoverDirection",
        PossibleTypes = new [] { typeof(string) })]
        string FailoverDirection { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>Source site operations status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source site operations status.",
        SerializedName = @"sourceSiteOperations",
        PossibleTypes = new [] { typeof(string) })]
        string SourceSiteOperation { get; set; }

    }
    /// Input definition for unplanned failover input properties.
    internal partial interface IUnplannedFailoverInputPropertiesInternal

    {
        /// <summary>Failover direction.</summary>
        string FailoverDirection { get; set; }
        /// <summary>Provider specific settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInput ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>Source site operations status.</summary>
        string SourceSiteOperation { get; set; }

    }
}