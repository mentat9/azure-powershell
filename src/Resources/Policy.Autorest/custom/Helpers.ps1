
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

# split policy ids into usable parts (only used internally in this file)
function parsePolicyId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy definition
    param($resourceId, $typeName)

    # validate args
    if (!$resourceId) {
        throw 'parsePolicyId(resourceId, typeName) argument error: resourceId must be provided.'
    }

    if (!$typeName) {
        # extract typename
        $temp = $resourceId -split '/providers/Microsoft.Authorization/'
        if ($temp.Length -lt 2) {
            throw 'parsePolicy(resourceId, typeName) argument error: resourceId is not a Microsoft.Authorization resource type'
        }

        $typeName = ($temp[1] -split '/')[0]
    }

    if (!$typeName) {
        throw 'parsePolicyId(resourceId, typeName) argument error: unable to find type name.'
    }

    $mark = "/providers/microsoft.authorization/$($typeName)/"
    $parts = $resourceId -split $mark
    $name = ''
    if ($parts.Length -gt 1) {
        $name = $parts[1]
    }

    $scope = $parts[0]
    $subId = ''
    $mgName = ''
    $rgName = ''
    $type = 'none'

    if ($scope -eq '') {
        $type = 'builtin'
    }
    elseif ($scope -like '/providers/Microsoft.Management/managementGroups/*') {
        $type = 'mgname'
        $mgName = ($scope -split '/providers/Microsoft.Management/managementGroups/')[1]
    }
    elseif ($scope -like '/subscriptions/*/resourceGroups/*/*') {
        $type = 'resource'
        $temp = ($scope -split '/subscriptions/')[1]
        $temp = ($temp -split '/resourceGroups/')
        $subId = $temp[0]
        $temp = ($temp[1] -split '/providers/')
        $rgName = $temp[0]
        $resource = $temp[1]
    }
    elseif ($scope -like '/subscriptions/*/resourceGroups/*') {
        $type = 'rgname'
        $temp = ($scope -split '/subscriptions/')[1]
        $temp = ($temp -split '/resourceGroups/')
        $subId = $temp[0]
        $rgName = $temp[1]
    }
    elseif ($scope -like '/subscriptions/*') {
        $type = 'subId'
        $subId = ($scope -split '/subscriptions/')[1]
    }

    return @{
        ScopeType = $type
        SubscriptionId = $subId
        ManagementGroupName = $mgName
        ResourceGroupName = $rgName
        Resource = $resource
        Name = $name
        Scope = $scope
        TypeName = $typeName
    }
}

# split policy definition resourceId into its parts (used externally)
function ParsePolicyDefinitionId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy definition
    param($ResourceId)

    parsePolicyId $ResourceId 'policyDefinitions'
}

# split policy set definition resourceId into its parts
function ParsePolicySetDefinitionId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy set definition
    param($ResourceId)

    parsePolicyId $ResourceId 'policySetDefinitions'
}

# split policy assignment resourceId into its parts
function ParsePolicyAssignmentId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy set definition
    param($ResourceId)

    parsePolicyId $ResourceId 'policyAssignments'
}

# split policy assignment resourceId into its parts
function ParsePolicyExemptionId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy set definition
    param($resourceId)

    parsePolicyId $ResourceId 'policyExemptions'
}

# Convert input parameter value to hashtable type expected by the autorest serializers
function ConvertParameterArray
{
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param ($InputObject)

    if ($InputObject -is [array])
    {
        $collection = @(
            foreach ($object in $InputObject) { ConvertParameterArray $object }
        )

        Write-Output -NoEnumerate $collection
    }
    elseif ($InputObject -is [hashtable])
    {
        return $InputObject
    }
    elseif ($InputObject -is [PSObject])
    {
        $hash = @{}

        foreach ($property in $InputObject.PSObject.Properties)
        {
            $hash[$property.Name] = (ConvertParameterArray $property.Value).PSObject.BaseObject
        }

        $hash
    }
    else {
        return $InputObject
    }
}

# convert various input formats to policy-formatted hashtable suitable for autorest serializers
function ConvertParameterObject
{
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param ($InputObject)

    if (!$InputObject)
    {
        return $InputObject
    }
    elseif ($InputObject -is [hashtable])
    {
        # traverse hash table to ensure nested values are all processed
        $returnValue = @{}
        foreach ($key in $InputObject.Keys) {
            $returnValue[$key] = (ConvertParameterObject $InputObject[$key])
        }

        return $returnValue
    }
    elseif ($InputObject -is [array])
    {
        return @{ value = [array](ConvertParameterArray -InputObject $InputObject) }
    }
    elseif ($InputObject -is [PSObject])
    {
        $returnValue = @{}

        foreach ($property in $InputObject.PSObject.Properties) {
            $returnValue[$property.Name] = (ConvertParameterObject $property.Value).PSObject.BaseObject
        }

        return $returnValue
    }
    else {
        return @{ value = $InputObject }
    }
}

# Convert output hashtable object output by autorest serializers to PSCustomObject format for legacy support
function ConvertObjectToPSObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param($InputObject)

    if ($null -eq $InputObject) {
        return [PSCustomObject]$null
    }

    if ($InputObject -is [array]) {
        return ,@(foreach ($obj in $InputObject) { ConvertObjectToPSObject $obj })
    }

    if (!$InputObject.ToJsonString) {
        return [PSCustomObject]$InputObject
    }

    $jsonString = $InputObject.ToJsonString()
    if ($jsonString -is [array]) {
        $jsonString = "[$([System.String]::Join(',', $jsonString))]"
    }

    ConvertFrom-Json $jsonString -Depth 100
}

function GetPSObjectProperty {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param (
        [PSObject]$PropertyObject,
        [string]$PropertyPath
    )

    $propertyNames = $PropertyPath.Split('.')
    $tmpObject = $PropertyObject
    foreach ($propertyName in $propertyNames)
    {
        $propertyInfo = $tmpObject.PSObject.Properties[$propertyName]
        if ($propertyInfo)
        {
            if ($propertyInfo.Value -is [PSObject])
            {
                $tmpObject = [PSObject]$propertyInfo.Value
                continue
            }

            return $propertyInfo.Value
        }
    }

    return $tmpObject
}

# tests whether the given string is a Uri
function Test-Uri {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param([string]$Value)

    $uri = ''
    [System.Uri]::TryCreate($Value, [System.UriKind]::Absolute, [ref]$uri)
}

# issues a GET to the given address and returns the contents
function Get-UriContent {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param([string]$UriAddress)

    $response = Invoke-WebRequest $UriAddress -DisableKeepAlive -Method Get
    if ($response.StatusCode -eq 200) {
        return $response.Content
    }
}

# if the given string is a file path or URI, returns the contents of the file or web page
# otherwise returns the original string
function GetFileUriOrStringParameterValue {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param([string]$parameterValue)

    if (Test-Path $parameterValue) {
        Get-Content $parameterValue | Out-String
    }
    else {
        if (Test-Uri $parameterValue) {
            Get-UriContent $parameterValue
        }
        else {
            $parameterValue
        }
    }
}

function ResolvePolicyParameter {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$ParameterName,
        [string]$ParameterValue,
        [bool]$Debug = $false
    )

    $policy = GetFileUriOrStringParameterValue $ParameterValue
    if ($debug) {
        Write-Host -ForegroundColor Cyan "Parameter ${ParameterName}:" $policy
    }

    $policyParameter = ConvertFrom-Json -Depth 100 -AsHashtable $policy
    if ($policyParameter.properties) {
        return $policyParameter.properties
    } else {
        return $policyParameter
    }
}

function ResolvePolicyMetadataParameter {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        $MetadataValue,
        [bool]$Debug = $false
    )

    if ($metadataValue -is [hashtable]) {
        return $metadataValue
    }

    if ([System.String]::IsNullOrEmpty($metadataValue)) {
        return $metadataValue
    }

    $metadata = (GetFileUriOrStringParameterValue $metadataValue).Trim()
    if ($debug) {
        Write-Host -ForegroundColor Cyan Metadata: $metadata
    }

    if ($metadata -like '@{*') {
        # probably a PSCustomObject, try converting to hashtable
        return (Invoke-Expression($metadata.Replace('=',"='").Replace(';',"';").Replace('}',"'}")))
    }

    # otherwise it should be a JSON string
    if ($metadata -like '{*}') {
        return $metadata | ConvertFrom-Json -Depth 100 -AsHashtable
    }

    throw "Unrecognized metadata format - value: [$($metadataValue)], type: [$($metadataValue.GetType())]"
}

# construct the full Id of a resource given the various parts (only used internally in this file)
function resolvePolicyArtifact {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$name,
        [string]$subscriptionId,
        [string]$managementGroupName,
        [string]$id,
        [string]$typeName
    )

    $type = 'none'
    $scope = ''
    $scopeType = 'none'
    $scopeName = ''
    $fullScope = ''
    $resourceId = '<invalid>'
    $resourceGroupName = ''

    if ($id -and !$subscriptionId -and !$managementGroupName) {
        $resolved = parsePolicyId $id $typeName
        $fullScope = $resolved.Scope
        $scopeType = $resolved.ScopeType
        switch ($scopeType) {
            'subId' {
                $scope = $resolved.SubscriptionId
                $scopeName = "subscription $($scope)"
                $subscriptionId = $resolved.SubscriptionId
            }
            'mgName' {
                $scope = $resolved.ManagementGroupName
                $scopeName = "management group $($scope)"
                $managementGroupName = $resolved.ManagementGroupName
            }
            'rgname' {
                $scope = $resolved.ResourceGroupName
                $scopeName = "resource group $($scope)"
                $subscriptionId = $resolved.SubscriptionId
                $resourceGroupName = $resolved.ResourceGroupName
            }
            'resource' {
                $scope = $resolved.Resource
                $scopeName = "resource id $($scope)"
                $subscriptionId = $resolved.SubscriptionId
                $resourceGroupName = $resolved.ResourceGroupName
            }
            'none' {
                $scope = $resolved.Scope
                $scopeName = "scope $($scope)"
            }
        }

        $name = $resolved.Name
        $resourceId = $id
    } else {
        if ($name) {
            if ($managementGroupName) {
                $type = 'mgName'
                $scope = $managementGroupName
                $scopeType = 'mgName'
                $scopeName = "management group $($scope)"
                $fullScope = "/providers/Microsoft.Management/managementGroups/$($managementGroupName)"
                $resourceId = "$($fullScope)/providers/Microsoft.Authorization/$($typeName)/$($name)"
            } else {
                if (!$subscriptionId) {
                    $type = 'name'
                    $subscriptionId = (Get-SubscriptionId)
                } else {
                    $type = 'subId'
                }

                $scope = $subscriptionId
                $scopeType = 'subId'
                $scopeName = "subscription $($scope)"
                $fullScope = "/subscriptions/$($subscriptionId)"
                $resourceId = "$($fullScope)/providers/Microsoft.Authorization/$($typeName)/$($name)"
            }
        }
    }

    return @{
        Type = $type;
        Scope = $scope;
        ScopeType = $scopeType
        ScopeName = $scopeName;
        FullScope = $fullScope;
        Name = $name;
        SubscriptionId = $subscriptionId
        ResourceGroupName = $resourceGroupName
        ManagementGroupName = $managementGroupName
        ResourceId = $resourceId
    }
}

function ResolvePolicyDefinition {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$SubscriptionId,
        [string]$ManagementGroupName,
        [string]$Id
    )

    resolvePolicyArtifact $Name $SubscriptionId $ManagementGroupName $Id 'policyDefinitions'
}

function ResolvePolicySetDefinition {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$SubscriptionId,
        [string]$ManagementGroupName,
        [string]$Id
    )

    resolvePolicyArtifact $Name $SubscriptionId $ManagementGroupName $Id 'policySetDefinitions'
}

function ResolvePolicyAssignment {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$Scope,
        [string]$Id
    )

    if ($Id) {
        $resourceId = $Id
    }
    elseif ($Scope) {
        $resourceId = "$($Scope)/providers/Microsoft.Authorization/policyAssignments/$($Name)"
    }
    else {
        $resourceId = "/subscriptions/$($(Get-SubscriptionId))/providers/Microsoft.Authorization/policyAssignments/$($Name)"
    }

    resolvePolicyArtifact $null $null $null $resourceId 'policyAssignments'
}

function ResolvePolicyExemption {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$Scope,
        [string]$Id
    )

    if ($Id) {
        $resourceId = $Id
    }
    elseif ($Scope) {
        $resourceId = "$($Scope)/providers/Microsoft.Authorization/policyExemptions/$($Name)"
    }
    else {
        $resourceId = "/subscriptions/$($(Get-SubscriptionId))/providers/Microsoft.Authorization/policyExemptions/$($Name)"
    }

    resolvePolicyArtifact $null $null $null $resourceId 'policyExemptions'
}

function LocationCompleter(
    $commandName,
    $parameterName,
    $wordToComplete,
    $commandAst,
    $fakeBoundParameter
)
{
    if ($global:AzPSPolicyCachedLocations.Count -le 0) {
        $response = Invoke-AzRestMethod -Uri "https://management.azure.com/subscriptions/$($(Get-SubscriptionId))/locations?api-version=2022-12-01" -Method GET
        $global:AzPSPolicyCachedLocations = ($response.Content | ConvertFrom-Json -Depth 100).value | Sort-Object -Property name | Select-Object -ExpandProperty name
    }

    # If you see the following error, it means your context access has expired
    #   The given key 'AzureAttestationServiceEndpointSuffix' was not present in the dictionary.
    $global:AzPSPolicyCachedLocations | Where-Object { $_ -like "$wordToComplete*" }
}

function Get-SubscriptionId {
    (Utils\Get-SubscriptionIdTestSafe)
}

function Get-ExtraParameters
(
    $DefaultProfile,
    $Break,
    $HttpPipelineAppend,
    $HttpPipelinePrepend,
    $Proxy,
    $ProxyCredential,
    $ProxyUseDefaultCredentials
) {
    $parms = @{}
    if ($PSBoundParameters['DefaultProfile']) {
        $parms['DefaultProfile'] = $PSBoundParameters['DefaultProfile']
    }

    if ($PSBoundParameters['Break']) {
        $parms['Break'] = $PSBoundParameters['Break']
    }

    if ($PSBoundParameters['HttpPipelineAppend']) {
        $parms['HttpPipelineAppend'] = $PSBoundParameters['HttpPipelineAppend']
    }

    if ($PSBoundParameters['HttpPipelinePrepend']) {
        $parms['HttpPipelinePrepend'] = $PSBoundParameters['HttpPipelinePrepend']
    }

    if ($PSBoundParameters['Proxy']) {
        $parms['Proxy'] = $PSBoundParameters['Proxy']
    }

    if ($PSBoundParameters['ProxyCredential']) {
        $parms['ProxyCredential'] = $PSBoundParameters['ProxyCredential']
    }

    if ($PSBoundParameters['ProxyUseDefaultCredentials']) {
        $parms['ProxyUseDefaultCredentials'] = $PSBoundParameters['ProxyUseDefaultCredentials']
    }

    return $parms
}

# register the location completer for New-AzPolicyAssignment
Register-ArgumentCompleter -CommandName New-AzPolicyAssignment -ParameterName Location -ScriptBlock ${function:LocationCompleter}

# cache Azure locations to be used by the location completer (Get-AzLocation is not available in this context, need to use REST)
$global:AzPSPolicyCachedLocations = @()