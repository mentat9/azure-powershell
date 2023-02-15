
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
For a given subscriptions list, the API will return a map of collections and the related subscriptions from the supplied list.
.Description
For a given subscriptions list, the API will return a map of collections and the related subscriptions from the supplied list.
.Example
PS C:\>  $res = Get-AzMarketplaceCollectionToSubscriptionMapping -PrivateStoreId a260d38c-96cf-492d-a340-404d0c4b3ad6 -Payload @{SubscriptionId = "53425a7b-4ac1-4729-8340-e1da5046212c"}
PS C:\> $res.keys
e58535dc-1be3-4d2c-904c-1f97984ebe5d
fdb889a1-cf3e-49f0-95b8-2bb012fa01f1

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollectionsToSubscriptionsMappingPayload
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollectionsToSubscriptionsMappingResponseProperties
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IMarketplaceIdentity>: Identity Parameter
  [AdminRequestApprovalId <String>]: The admin request approval ID to get create or update
  [CollectionId <String>]: The collection ID
  [Id <String>]: Resource identity path
  [OfferId <String>]: The offer ID to update or delete
  [PrivateStoreId <String>]: The store ID - must use the tenant ID
  [RequestApprovalId <String>]: The request approval ID to get create or update

PAYLOAD <ICollectionsToSubscriptionsMappingPayload>: The subscriptions list to get the related collections
  [SubscriptionId <String[]>]: Subscriptions ids list
.Link
https://learn.microsoft.com/powershell/module/az.marketplace/get-azmarketplacecollectiontosubscriptionmapping
#>
function Get-AzMarketplaceCollectionToSubscriptionMapping {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollectionsToSubscriptionsMappingResponseProperties])]
[CmdletBinding(DefaultParameterSetName='CollectionsExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Collections', Mandatory)]
    [Parameter(ParameterSetName='CollectionsExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [System.String]
    # The store ID - must use the tenant ID
    ${PrivateStoreId},

    [Parameter(ParameterSetName='CollectionsViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CollectionsViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Collections', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CollectionsViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollectionsToSubscriptionsMappingPayload]
    # The subscriptions list to get the related collections
    # To construct, see NOTES section for PAYLOAD properties and create a hash table.
    ${Payload},

    [Parameter(ParameterSetName='CollectionsExpanded')]
    [Parameter(ParameterSetName='CollectionsViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscriptions ids list
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
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
        $mapping = @{
            Collections = 'Az.Marketplace.private\Get-AzMarketplaceCollectionToSubscriptionMapping_Collections';
            CollectionsExpanded = 'Az.Marketplace.private\Get-AzMarketplaceCollectionToSubscriptionMapping_CollectionsExpanded';
            CollectionsViaIdentity = 'Az.Marketplace.private\Get-AzMarketplaceCollectionToSubscriptionMapping_CollectionsViaIdentity';
            CollectionsViaIdentityExpanded = 'Az.Marketplace.private\Get-AzMarketplaceCollectionToSubscriptionMapping_CollectionsViaIdentityExpanded';
        }
        if (('CollectionsExpanded', 'CollectionsViaIdentityExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
