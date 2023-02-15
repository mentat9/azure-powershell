
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
Creates or updates a Service Bus queue.
This operation is idempotent.
.Description
Creates or updates a Service Bus queue.
This operation is idempotent.
.Example
New-AzServiceBusQueue -ResourceGroupName myResourceGroup -NamespaceName myNamespace -Name myQueue -AutoDeleteOnIdle (New-TimeSpan -Days 1 -Minutes 3 -Seconds 4) -DefaultMessageTimeToLive (New-TimeSpan -Days 5) -EnablePartitioning

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.ISbQueue
.Link
https://learn.microsoft.com/powershell/module/az.servicebus/new-azservicebusqueue
#>
function New-AzServiceBusQueue {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.ISbQueue])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('QueueName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Path')]
    [System.String]
    # The queue name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Path')]
    [System.String]
    # The namespace name
    ${NamespaceName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Path')]
    [System.String]
    # Name of the Resource group within the Azure subscription.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify a Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.TimeSpan]
    # Idle interval after which the queue is automatically deleted.
    # The minimum duration is 5 minutes.
    ${AutoDeleteOnIdle},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A value that indicates whether this queue has dead letter support when a message expires.
    ${DeadLetteringOnMessageExpiration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.TimeSpan]
    # This is the duration after which the message expires, starting from when the message is sent to Service Bus.
    # This is the default value used when TimeToLive is not set on a message itself.
    ${DefaultMessageTimeToLive},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.TimeSpan]
    # Defines the duration of the duplicate detection history.
    # The default value is 10 minutes.
    ${DuplicateDetectionHistoryTimeWindow},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Value that indicates whether server-side batched operations are enabled.
    ${EnableBatchedOperations},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A value that indicates whether Express Entities are enabled.
    # An express queue holds a message in memory temporarily before writing it to persistent storage.
    ${EnableExpress},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A value that indicates whether the queue is to be partitioned across multiple message brokers.
    ${EnablePartitioning},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.String]
    # Queue/Topic name to forward the Dead Letter message
    ${ForwardDeadLetteredMessagesTo},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.String]
    # Queue/Topic name to forward the messages
    ${ForwardTo},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.TimeSpan]
    # Timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers.
    # The maximum value for LockDuration is 5 minutes; the default value is 1 minute.
    ${LockDuration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Int32]
    # The maximum delivery count.
    # A message is automatically deadlettered after this number of deliveries.
    # default value is 10.
    ${MaxDeliveryCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Int64]
    # Maximum size (in KB) of the message payload that can be accepted by the queue.
    # This property is only used in Premium today and default is 1024.
    ${MaxMessageSizeInKilobytes},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Int32]
    # The maximum size of the queue in megabytes, which is the size of memory allocated for the queue.
    # Default is 1024.
    ${MaxSizeInMegabytes},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A value indicating if this queue requires duplicate detection.
    ${RequiresDuplicateDetection},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A value that indicates whether the queue supports the concept of sessions.
    ${RequiresSession},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.EntityStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.EntityStatus]
    # Enumerates the possible values for the status of a messaging entity.
    ${Status},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
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
            [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateExpanded = 'Az.ServiceBus.private\New-AzServiceBusQueue_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
