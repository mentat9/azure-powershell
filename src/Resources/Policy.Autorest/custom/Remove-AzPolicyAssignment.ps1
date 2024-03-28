
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
This operation deletes a policy assignment, given its name and the scope it was created in.
The scope of a policy assignment is the part of its ID preceding '/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
.Description
This operation deletes a policy assignment, given its name and the scope it was created in.
The scope of a policy assignment is the part of its ID preceding '/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
.Notes
## RELATED LINKS

[Get-AzPolicyAssignment](./Get-AzPolicyAssignment.md)

[New-AzPolicyAssignment](./New-AzPolicyAssignment.md)

[Update-AzPolicyAssignment](./Update-AzPolicyAssignment.md)
.Link
https://learn.microsoft.com/powershell/module/az.resources/remove-azpolicyassignment
#>
function Remove-AzPolicyAssignment {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Name', SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Name', Mandatory, ValueFromPipelineByPropertyName)]
    [ValidateNotNullOrEmpty()]
    [Alias('PolicyAssignmentName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The name of the policy assignment to delete.
    ${Name},

    [Parameter(ParameterSetName='Name', ValueFromPipelineByPropertyName)]
    [ValidateNotNullOrEmpty()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The scope of the policy assignment.
    # Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
    ${Scope},

    [Parameter(ParameterSetName='Id', Mandatory, ValueFromPipelineByPropertyName)]
    [ValidateNotNullOrEmpty()]
    [Alias('PolicyAssignmentId')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The ID of the policy assignment to delete.
    # Use the format '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
    ${Id},

    [Parameter(ParameterSetName='InputObject', Mandatory, ValueFromPipeline, ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [System.Management.Automation.SwitchParameter]
    # When $true, skip confirmation prompts
    ${Force},

    [Parameter()]
    [System.Management.Automation.SwitchParameter]
    # Causes cmdlet to return artifacts using legacy format placing policy-specific properties in a property bag object.
    ${BackwardCompatible} = $false,

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    # turn on console debug messages
    $writeln = ($PSCmdlet.MyInvocation.BoundParameters.Debug -as [bool]) -or ($PSCmdlet.MyInvocation.BoundParameters.Verbose -as [bool])

    if ($writeln) {
        Write-Host -ForegroundColor Cyan "begin:Remove-AzPolicyAssignment(" $PSBoundParameters ") - (ParameterSet: $($PSCmdlet.ParameterSetName))"
    }

    # make mapping table
    $mapping = @{
        Delete = 'Az.Policy.private\Remove-AzPolicyAssignment_Delete';
        Delete1 = 'Az.Policy.private\Remove-AzPolicyAssignment_Delete1';
        DeleteViaIdentity = 'Az.Policy.private\Remove-AzPolicyAssignment_DeleteViaIdentity';
        DeleteViaIdentity1 = 'Az.Policy.private\Remove-AzPolicyAssignment_DeleteViaIdentity1';
    }
}

process {
    if ($writeln) {
        Write-Host -ForegroundColor Cyan "process:Remove-AzPolicyAssignment(" $PSBoundParameters ") - (ParameterSet: $($PSCmdlet.ParameterSetName))"
    }

    # Id can be a parameter or from the input object
    if ($Id) {
        $thisId = $Id
    } else {
        $thisId = $_.Id
    }

    # construct confirmation prompt
    $resolved = ResolvePolicyAssignment $Name $Scope $thisId
    $result = $false

    # make a friendly prompt
    if ($thisId) {
        $target = $resolved.ResourceId
    }
    else {
        $target = "$($Name) from $($resolved.ScopeName)"
    }

    # apply Force to override confirmation, unless both are provided
    if ($Force -and !$Confirm) {
        $ConfirmPreference = 'None'
        $null = $PSBoundParameters.Remove('Force')
    }

    # use passthru for backward compatibility with previous SDK cmdlets: remove cmdlet always returned a value
    if ($PSBoundParameters.ContainsKey('PassThru')) {
        $BackwardCompatible = $PassThru
        $PSBoundParameters['PassThru'] = $PassThru
    }
    elseif ($BackwardCompatible) {
        $PSBoundParameters['PassThru'] = $BackwardCompatible
    }

    # remove non-generated parameters
    $null = $PSBoundParameters.Remove('BackwardCompatible')

    # remove the assignment if inputs resolve and user confirms
    if ($resolved.Scope -and $PSCmdlet.ShouldProcess($target)) {
        if ($Name) {
            $PSBoundParameters['Name'] = $Name
            $PSBoundParameters['Scope'] = $resolved.FullScope
            $calledParameterSet = 'Delete'
        }
        elseif ($Id) {
            $PSBoundParameters['Id'] = $Id
            $calledParameterSet = 'Delete1'
        }

        if ($writeln) {
            Write-Host -ForegroundColor Blue -> $mapping[$calledParameterSet]'(' $PSBoundParameters ')'
        }

        $cmdInfo = Get-Command -Name $mapping[$calledParameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $calledParameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$calledParameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $result = Invoke-Command -ScriptBlock $scriptCmd
    }

    # return result of remove
    if ($BackwardCompatible) {
        if ($result -is [boolean]) {
            $PSCmdlet.WriteObject($result)
        }
        else {
            # $result is the assignment instead of a boolean for some reason, so return constant $true
            $PSCmdlet.WriteObject($true)
        }
    }
}

end {
} 
}
