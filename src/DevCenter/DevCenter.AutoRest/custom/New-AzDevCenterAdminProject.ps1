
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
Creates or updates a project.
.Description
Creates or updates a project.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProject
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProject
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IProject>: Represents a project resource.
  Location <String>: The geo-location where the resource lives
  [Tag <ITrackedResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [Description <String>]: Description of the project.
  [DevCenterId <String>]: Resource Id of an associated DevCenter
  [MaxDevBoxesPerUser <Int32?>]: When specified, limits the maximum number of Dev Boxes a single user can create across all pools in the project. This will have no effect on existing Dev Boxes when reduced.

INPUTOBJECT <IDevCenterIdentity>: Identity Parameter
  [AttachedNetworkConnectionName <String>]: The name of the attached NetworkConnection.
  [CatalogName <String>]: The name of the Catalog.
  [DevBoxDefinitionName <String>]: The name of the Dev Box definition.
  [DevCenterName <String>]: The name of the devcenter.
  [EnvironmentTypeName <String>]: The name of the environment type.
  [GalleryName <String>]: The name of the gallery.
  [Id <String>]: Resource identity path
  [ImageName <String>]: The name of the image.
  [Location <String>]: The Azure region
  [NetworkConnectionName <String>]: Name of the Network Connection that can be applied to a Pool.
  [OperationId <String>]: The ID of an ongoing async operation
  [PoolName <String>]: Name of the pool.
  [ProjectName <String>]: The name of the project.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScheduleName <String>]: The name of the schedule that uniquely identifies it.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VersionName <String>]: The version of the image.
.Link
https://learn.microsoft.com/powershell/module/az.devcenter/new-azdevcenteradminproject
#>
function New-AzDevCenterAdminProject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProject])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Alias('ProjectName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the project.
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # Description of the project.
    ${Description},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # Resource Id of an associated DevCenter
    ${DevCenterId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.Int32]
    # When specified, limits the maximum number of Dev Boxes a single user can create across all pools in the project.
    # This will have no effect on existing Dev Boxes when reduced.
    ${MaxDevBoxesPerUser},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # The display name of the project.
    ${DisplayName},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    Az.DevCenter.internal\New-AzDevCenterAdminProject @PSBoundParameters
}

}
