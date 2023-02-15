
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
Updates the properties of an existing order item.
.Description
Updates the properties of an existing order item.
.Example
PS C:\> $contactDetail = New-AzEdgeOrderContactDetailsObject -ContactName "ContactName2" -EmailList @("emailId") -Phone Phone
PS C:\> $DebugPreference = "Continue"
# You can use `$DebugPreference = "Continue"`, with any example/usecase to get exact details of error in below format when update command fails.
# {
#   "Error": {
#     "Code": "StaticValidationGenericCountryCodeHasInvalidLength",
#     "Message": "The attribute country code does not meet length constraints.\r\nEnter a value with 2 characters for country code.",
#     "Details": [
#       null
#     ],
#     "Target": null
#   }
# } 
PS C:\> $updatedOrderItem = Update-AzEdgeOrderItem -Name "examplePowershell" -ResourceGroupName "resourceGroupName" -SubscriptionId SubscriptionId -ForwardAddressContactDetail $contactDetail

PS C:\> $updatedOrderItem.ForwardAddressContactDetail | fl

ContactName    : ContactName2
EmailList      : {useremailId}
Mobile         :
Phone          : 1234567891
PhoneExtension :

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IEdgeOrderIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FORWARDADDRESSCONTACTDETAIL <IContactDetails>: Contact details for the address
  ContactName <String>: Contact name of the person.
  EmailList <String[]>: List of Email-ids to be notified about job progress.
  Phone <String>: Phone number of the contact person.
  [Mobile <String>]: Mobile number of the contact person.
  [PhoneExtension <String>]: Phone extension number of the contact person.

FORWARDADDRESSSHIPPINGADDRESS <IShippingAddress>: Shipping details for the address
  Country <String>: Name of the Country.
  StreetAddress1 <String>: Street Address line 1.
  [AddressType <AddressType?>]: Type of address.
  [City <String>]: Name of the City.
  [CompanyName <String>]: Name of the company.
  [PostalCode <String>]: Postal code.
  [StateOrProvince <String>]: Name of the State or Province.
  [StreetAddress2 <String>]: Street Address line 2.
  [StreetAddress3 <String>]: Street Address line 3.
  [ZipExtendedCode <String>]: Extended Zip Code.

INPUTOBJECT <IEdgeOrderIdentity>: Identity Parameter
  [AddressName <String>]: The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
  [Id <String>]: Resource identity path
  [Location <String>]: The name of Azure region.
  [OrderItemName <String>]: The name of the order item
  [OrderName <String>]: The name of the order
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.

PREFERENCE <IPreferences>: Customer preference.
  [EncryptionPreference <IEncryptionPreferences>]: Preferences related to the Encryption.
    [DoubleEncryptionStatus <DoubleEncryptionStatus?>]: Double encryption status as entered by the customer. It is compulsory to give this parameter if the 'Deny' or 'Disabled' policy is configured.
  [ManagementResourcePreference <IManagementResourcePreferences>]: Preferences related to the Management resource.
    [PreferredManagementResourceId <String>]: Customer preferred Management resource ARM ID
  [NotificationPreference <INotificationPreference[]>]: Notification preferences.
    SendNotification <Boolean>: Notification is required or not.
    StageName <NotificationStageName>: Name of the stage.
  [TransportPreference <ITransportPreferences>]: Preferences related to the shipment logistics of the order.
    PreferredShipmentType <TransportShipmentTypes>: Indicates Shipment Logistics type that the customer preferred.
.Link
https://learn.microsoft.com/powershell/module/az.edgeorder/update-azedgeorderitem
#>
function Update-AzEdgeOrderItem {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemResource])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('OrderItemName')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Path')]
    [System.String]
    # The name of the order item
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IEdgeOrderIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails]
    # Contact details for the address
    # To construct, see NOTES section for FORWARDADDRESSCONTACTDETAIL properties and create a hash table.
    ${ForwardAddressContactDetail},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress]
    # Shipping details for the address
    # To construct, see NOTES section for FORWARDADDRESSSHIPPINGADDRESS properties and create a hash table.
    ${ForwardAddressShippingAddress},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String[]]
    # Additional notification email list.
    ${NotificationEmailList},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences]
    # Customer preference.
    # To construct, see NOTES section for PREFERENCE properties and create a hash table.
    ${Preference},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemUpdateParameterTags]))]
    [System.Collections.Hashtable]
    # The list of key value pairs that describe the resource.
    # These tags can be used in viewing and grouping this resource (across resource groups).
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
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
            UpdateExpanded = 'Az.EdgeOrder.private\Update-AzEdgeOrderItem_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.EdgeOrder.private\Update-AzEdgeOrderItem_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
