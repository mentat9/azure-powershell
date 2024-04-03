# setup the Pester environment for policy backcompat tests
. (Join-Path $PSScriptRoot 'Common.ps1') 'Backcompat-PolicyAssignmentUserAssignedIdentity'

Describe 'Backcompat-PolicyAssignmentUserAssignedIdentity' {

    BeforeAll {
        # setup
        $rgName = $env.rgName
        $rgScope = $env.rgScope
        $policyName = Get-ResourceName
        $testPA = Get-ResourceName
        $test2 = Get-ResourceName
        $location = $env.location
        
        # make a new resource group and policy definition
        $policy = New-AzPolicyDefinition -Name $policyName -Policy "$testFilesFolder\SamplePolicyDefinition.json" -Description $description -BackwardCompatible
        $userAssignedIdentityId = $env.userAssignedIdentityId
        # assign the policy definition with user MSI to the resource group
        $actual = New-AzPolicyAssignment -Name $testPA -PolicyDefinition $policy -Scope $rgScope -Description $description -IdentityType "UserAssigned" -IdentityId $userassignedidentityid -Location $location -BackwardCompatible
    }

    It 'make a policy assignment at RG scope with user assigned MSI' {
        {
            # get the assignment back and validate
            $expected = Get-AzPolicyAssignment -Name $testPA -Scope $rgScope -BackwardCompatible
            Assert-AreEqual $expected.Name $actual.Name
            Assert-AreEqual Microsoft.Authorization/policyAssignments $actual.ResourceType
            Assert-AreEqual $expected.PolicyAssignmentId $actual.PolicyAssignmentId
            Assert-AreEqual $expected.Properties.PolicyDefinitionId $policy.PolicyDefinitionId
            Assert-AreEqual $expected.Properties.Scope $rgScope
            Assert-AreEqual "UserAssigned" $expected.Identity.IdentityType

            # looks like format of userassigned identities changed in the newer spec: adjusting the test to conform to the new format
            $actualuserassignedidentitieshashtable = $expected.Identity.UserAssignedIdentities.AdditionalProperties
            $actualuserassignedidentityid = $($actualuserassignedidentitieshashtable.keys)
            $actualuserassignedidentityresource = $($actualuserassignedidentitieshashtable.values)[0]
            Assert-AreEqual $actualuserassignedidentityid $userassignedidentityid
            Assert-NotNull ($actualuserassignedidentityresource.PrincipalId)
            Assert-NotNull ($actualuserassignedidentityresource.ClientId)
            Assert-AreEqual $location $actual.Location
            Assert-AreEqual $expected.Location $actual.Location
        } | Should -Not -Throw
    }

    It 'get policy assignment with user assigned MSI by Id' {
        {
            # get it back by id and validate
            $actualById = Get-AzPolicyAssignment -Id $actual.ResourceId -BackwardCompatible
            Assert-AreEqual $actual.ResourceId $actualById.ResourceId
            Assert-AreEqual "UserAssigned" $actualById.Identity.IdentityType

            $actualbyiduserassignedidentityresource = $($actual.Identity.UserAssignedIdentities.AdditionalProperties.values)[0]
            Assert-NotNull($actualbyiduserassignedidentityresource.PrincipalId)
            Assert-NotNull($actualbyiduserassignedidentityresource.ClientId)
            Assert-AreEqual $location $actualById.Location
        } | Should -Not -Throw
    }

    It 'update policy assignment with user assigned MSI' {
        {
            # update the policy assignment, validate it still has an identity
            $setResult = Set-AzPolicyAssignment -Id $actual.ResourceId -DisplayName "testDisplay" -BackwardCompatible
            Assert-AreEqual "testDisplay" $setResult.Properties.DisplayName
            Assert-AreEqual "UserAssigned" $setResult.Identity.IdentityType
            $setresultuserassignedidentityresource = $($setresult.Identity.UserAssignedIdentities.AdditionalProperties.values)[0]
            Assert-NotNull($setresultuserassignedidentityresource.PrincipalId)
            Assert-NotNull($setresultuserassignedidentityresource.ClientId)
            Assert-AreEqual $location $setResult.Location
        } | Should -Not -Throw
    }

    It 'make another policy assignment without MSI then add MSI' {
        {
            # make another policy assignment without an identity
            $withoutIdentityResult = New-AzPolicyAssignment -Name $test2 -Scope $rgScope -PolicyDefinition $policy -Description $description -BackwardCompatible
            Assert-Null($withoutIdentityResult.Identity)
            Assert-Null($withoutIdentityResult.Location)

            # add an identity to the new assignment using the SET cmdlet
            $setResult = Set-AzPolicyAssignment -Id $withoutIdentityResult.ResourceId -IdentityType "UserAssigned" -IdentityId $userassignedidentityid -Location $location -BackwardCompatible
            Assert-AreEqual "UserAssigned" $setResult.Identity.IdentityType
            $setresultuserassignedidentityresource = $($setresult.Identity.UserAssignedIdentities.AdditionalProperties.values)[0]
            Assert-NotNull($setresultuserassignedidentityresource.PrincipalId)
            Assert-NotNull($setresultuserassignedidentityresource.ClientId)
            Assert-AreEqual $location $setResult.Location
        } | Should -Not -Throw
    }

    It 'list policy assignments with user assigned MSI' {
        {
            # verify identity is returned in collection GET
            $list = Get-AzPolicyAssignment -Scope $rgScope -BackwardCompatible | Where-Object{ $_.Name -in @($testPA, $test2) }
            $userassignedidentityobject = ($list.Identity.UserAssignedIdentities | Select -Unique)    
            Assert-AreEqual "UserAssigned" ($list.Identity.IdentityType | Select -Unique)
            Assert-AreEqual 1 @(($($userassignedidentityobject.AdditionalProperties.values)[0]).PrincipalId | Select -Unique).Count
            Assert-AreEqual 1 @(($($userassignedidentityobject.AdditionalProperties.values)[0]).ClientId | Select -Unique).Count
            Assert-AreEqual $location ($list.Location | Select -Unique)
        } | Should -Not -Throw
    }

    AfterAll {
        # clean up
        $remove = Remove-AzPolicyAssignment -Name $testPA -Scope $rgScope -BackwardCompatible
        $remove = (Remove-AzPolicyAssignment -Name $test2 -Scope $rgScope -BackwardCompatible) -and $remove
        $remove = (Remove-AzPolicyDefinition -Name $policyName -Force -BackwardCompatible) -and $remove
        Assert-AreEqual True $remove

        Write-Host -ForegroundColor Magenta "Cleanup complete."
    }
}
