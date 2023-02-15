
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
Creates or updates a Managed Environment used to host container apps.
.Description
Creates or updates a Managed Environment used to host container apps.
.Example
New-AzOperationalInsightsWorkspace -ResourceGroupName azpstest_gp -Name workspace-azpstestgp -Sku PerGB2018 -Location canadacentral -PublicNetworkAccessForIngestion "Enabled" -PublicNetworkAccessForQuery "Enabled"
$CustomId = (Get-AzOperationalInsightsWorkspace -ResourceGroupName azpstest_gp -Name workspace-azpstestgp).CustomerId
$SharedKey = (Get-AzOperationalInsightsWorkspaceSharedKey -ResourceGroupName azpstest_gp -Name workspace-azpstestgp).PrimarySharedKey

New-AzContainerAppManagedEnv -EnvName azps-env -ResourceGroupName azpstest_gp -Location canadacentral -AppLogConfigurationDestination "log-analytics" -LogAnalyticConfigurationCustomerId $CustomId -LogAnalyticConfigurationSharedKey $SharedKey -VnetConfigurationInternal:$false

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment
.Link
https://learn.microsoft.com/powershell/module/az.app/new-azcontainerappmanagedenv
#>
function New-AzContainerAppManagedEnv {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Path')]
    [System.String]
    # Name of the Environment.
    ${EnvName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # Logs destination
    ${AppLogConfigurationDestination},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # Application Insights connection string used by Dapr to export Service to Service communication telemetry
    ${DaprAiConnectionString},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry
    ${DaprAiInstrumentationKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # Log analytics customer id
    ${LogAnalyticConfigurationCustomerId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # Log analytics customer key
    ${LogAnalyticConfigurationSharedKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # CIDR notation IP range assigned to the Docker bridge, network.
    # Must not overlap with any other provided IP ranges.
    ${VnetConfigurationDockerBridgeCidr},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # Resource ID of a subnet for infrastructure components.
    # This subnet must be in the same VNET as the subnet defined in runtimeSubnetId.
    # Must not overlap with any other provided IP ranges.
    ${VnetConfigurationInfrastructureSubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Boolean indicating the environment only has an internal load balancer.
    # These environments do not have a public static IP resource, must provide ControlPlaneSubnetResourceId and AppSubnetResourceId if enabling this property
    ${VnetConfigurationInternal},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # IP range in CIDR notation that can be reserved for environment infrastructure IP addresses.
    # Must not overlap with any other provided IP ranges.
    ${VnetConfigurationPlatformReservedCidr},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # An IP address from the IP range defined by platformReservedCidr that will be reserved for the internal DNS server.
    ${VnetConfigurationPlatformReservedDnsIP},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.String]
    # Resource ID of a subnet that Container App containers are injected into.
    # This subnet must be in the same VNET as the subnet defined in infrastructureSubnetId.
    # Must not overlap with any other provided IP ranges.
    ${VnetConfigurationRuntimeSubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether or not this Managed Environment is zone-redundant.
    ${ZoneRedundant},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.App.Category('Runtime')]
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
            [Microsoft.Azure.PowerShell.Cmdlets.App.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateExpanded = 'Az.App.private\New-AzContainerAppManagedEnv_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.App.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
