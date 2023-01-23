
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Update a MonitorResource
.Description
Update a MonitorResource
.Example
Update-AzDynatraceMonitor -ResourceGroupName dyobrg -Name dyob-pwsh02 -Tag @{'key' = 'test'}
.Example
Get-AzDynatraceMonitor -ResourceGroupName dyobrg -Name dyob-pwsh02 | Update-AzDynatraceMonitor -Tag @{'key' = 'test'}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IDynatraceObservabilityIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IMonitorResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDynatraceObservabilityIdentity>: Identity Parameter
  [ConfigurationName <String>]: Single Sign On Configuration Name
  [Id <String>]: Resource identity path
  [MonitorName <String>]: Monitor resource name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RuleSetName <String>]: Monitor resource name
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://learn.microsoft.com/powershell/module/az.dynatraceobservability/update-azdynatracemonitor
#>
function Update-AzDynatraceMonitor {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IMonitorResource])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('MonitorName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [System.String]
    # Monitor resource name
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IDynatraceObservabilityIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Account Id of the account this environment is linked to
    ${AccountId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Region in which the account is created
    ${AccountRegionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Id of the environment created
    ${EnvironmentId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Ingestion key of the environment
    ${EnvironmentIngestionKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Landing URL for Dynatrace environment
    ${EnvironmentLandingUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Ingestion endpoint used for sending logs
    ${EnvironmentLogsIngestionEndpoint},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # User id
    ${EnvironmentUserId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.MarketplaceSubscriptionStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.MarketplaceSubscriptionStatus]
    # Marketplace subscription status.
    ${MarketplaceSubscriptionStatus},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.MonitoringStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.MonitoringStatus]
    # Status of the monitor.
    ${MonitoringStatus},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # different billing cycles like MONTHLY/WEEKLY.
    # this could be enum
    ${PlanBillingCycle},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # plan id as published by Dynatrace
    ${PlanDetail},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.DateTime]
    # date when plan was applied
    ${PlanEffectiveDate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # different usage type like PAYG/COMMITTED.
    # this could be enum
    ${PlanUsageType},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String[]]
    # array of Aad(azure active directory) domains
    ${SingleSignOnAadDomain},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Version of the Dynatrace agent installed on the VM.
    ${SingleSignOnEnterpriseAppId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SingleSignOnStates])]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SingleSignOnStates]
    # State of Single Sign On
    ${SingleSignOnState},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # The login URL specific to this Dynatrace Environment
    ${SingleSignOnUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IMonitorResourceUpdateTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Country of the user
    ${UserCountry},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Email of the user used by Dynatrace for contacting them if needed
    ${UserEmailAddress},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # First Name of the user
    ${UserFirstName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Last Name of the user
    ${UserLastName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [System.String]
    # Phone number of the user used by Dynatrace for contacting them if needed
    ${UserPhoneNumber},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            UpdateExpanded = 'Az.DynatraceObservability.private\Update-AzDynatraceMonitor_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.DynatraceObservability.private\Update-AzDynatraceMonitor_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
