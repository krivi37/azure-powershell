namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Provider specific input for InMage test failover.</summary>
    public partial class InMageTestFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageTestFailoverInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageTestFailoverInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput __testFailoverProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TestFailoverProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)__testFailoverProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)__testFailoverProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointId" /> property.</summary>
        private string _recoveryPointId;

        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryPointId { get => this._recoveryPointId; set => this._recoveryPointId = value; }

        /// <summary>Backing field for <see cref="RecoveryPointType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType? _recoveryPointType;

        /// <summary>
        /// The recovery point type. Values from LatestTime, LatestTag or Custom. In the case of custom, the recovery point provided
        /// by RecoveryPointId will be used. In the other two cases, recovery point id will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType? RecoveryPointType { get => this._recoveryPointType; set => this._recoveryPointType = value; }

        /// <summary>Creates an new <see cref="InMageTestFailoverInput" /> instance.</summary>
        public InMageTestFailoverInput()
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
            await eventListener.AssertNotNull(nameof(__testFailoverProviderSpecificInput), __testFailoverProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__testFailoverProviderSpecificInput), __testFailoverProviderSpecificInput);
        }
    }
    /// Provider specific input for InMage test failover.
    public partial interface IInMageTestFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput
    {
        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed.",
        SerializedName = @"recoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointId { get; set; }
        /// <summary>
        /// The recovery point type. Values from LatestTime, LatestTag or Custom. In the case of custom, the recovery point provided
        /// by RecoveryPointId will be used. In the other two cases, recovery point id will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point type. Values from LatestTime, LatestTag or Custom. In the case of custom, the recovery point provided by RecoveryPointId will be used. In the other two cases, recovery point id will be ignored.",
        SerializedName = @"recoveryPointType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType? RecoveryPointType { get; set; }

    }
    /// Provider specific input for InMage test failover.
    internal partial interface IInMageTestFailoverInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal
    {
        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        string RecoveryPointId { get; set; }
        /// <summary>
        /// The recovery point type. Values from LatestTime, LatestTag or Custom. In the case of custom, the recovery point provided
        /// by RecoveryPointId will be used. In the other two cases, recovery point id will be ignored.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType? RecoveryPointType { get; set; }

    }
}