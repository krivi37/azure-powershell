namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm policy creation input.</summary>
    public partial class InMageRcmPolicyCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmPolicyCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmPolicyCreationInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput __policyProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PolicyProviderSpecificInput();

        /// <summary>Backing field for <see cref="AppConsistentFrequencyInMinute" /> property.</summary>
        private int? _appConsistentFrequencyInMinute;

        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? AppConsistentFrequencyInMinute { get => this._appConsistentFrequencyInMinute; set => this._appConsistentFrequencyInMinute = value; }

        /// <summary>Backing field for <see cref="CrashConsistentFrequencyInMinute" /> property.</summary>
        private int? _crashConsistentFrequencyInMinute;

        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? CrashConsistentFrequencyInMinute { get => this._crashConsistentFrequencyInMinute; set => this._crashConsistentFrequencyInMinute = value; }

        /// <summary>Backing field for <see cref="EnableMultiVMSync" /> property.</summary>
        private string _enableMultiVMSync;

        /// <summary>A value indicating whether multi-VM sync has to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string EnableMultiVMSync { get => this._enableMultiVMSync; set => this._enableMultiVMSync = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal)__policyProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal)__policyProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointHistoryInMinute" /> property.</summary>
        private int? _recoveryPointHistoryInMinute;

        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? RecoveryPointHistoryInMinute { get => this._recoveryPointHistoryInMinute; set => this._recoveryPointHistoryInMinute = value; }

        /// <summary>Creates an new <see cref="InMageRcmPolicyCreationInput" /> instance.</summary>
        public InMageRcmPolicyCreationInput()
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
            await eventListener.AssertNotNull(nameof(__policyProviderSpecificInput), __policyProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__policyProviderSpecificInput), __policyProviderSpecificInput);
        }
    }
    /// InMageRcm policy creation input.
    public partial interface IInMageRcmPolicyCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput
    {
        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app consistent snapshot frequency (in minutes).",
        SerializedName = @"appConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The crash consistent snapshot frequency (in minutes).",
        SerializedName = @"crashConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>A value indicating whether multi-VM sync has to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether multi-VM sync has to be enabled.",
        SerializedName = @"enableMultiVmSync",
        PossibleTypes = new [] { typeof(string) })]
        string EnableMultiVMSync { get; set; }
        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The duration in minutes until which the recovery points need to be stored.",
        SerializedName = @"recoveryPointHistoryInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryPointHistoryInMinute { get; set; }

    }
    /// InMageRcm policy creation input.
    internal partial interface IInMageRcmPolicyCreationInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal
    {
        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>A value indicating whether multi-VM sync has to be enabled.</summary>
        string EnableMultiVMSync { get; set; }
        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        int? RecoveryPointHistoryInMinute { get; set; }

    }
}