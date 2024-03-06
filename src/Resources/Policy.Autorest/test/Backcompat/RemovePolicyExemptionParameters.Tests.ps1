# setup the Pester environment for policy backcompat tests
. (Join-Path $PSScriptRoot 'Common.ps1') 'Backcompat-RemovePolicyExemptionParameters'

Describe 'Backcompat-RemovePolicyExemptionParameters' {

    BeforeAll {
        $goodScope = "/subscriptions/$subscriptionId"
        $goodId = "$goodScope/providers/Microsoft.Authorization/policyExemptions/$someName"
    }

    It 'no parameters' {
        {
            # validate with no parameters
            Assert-ThrowsContains { Remove-AzPolicyExemption } $missingParameters
        } | Should -Not -Throw
    }

    It 'parameter combinations starting with -Name' {
        {
            # validate parameter combinations starting with -Name
            $ok = Remove-AzPolicyExemption -Name $someName -Force -BackwardCompatible
            Assert-AreEqual True $ok
            $ok = Remove-AzPolicyExemption -Name $someName -Scope $goodScope -Force -BackwardCompatible
            Assert-AreEqual True $ok
            Assert-ThrowsContains { Remove-AzPolicyExemption -Name $someName -Id $someId } $parameterSetError
            Assert-ThrowsContains { Remove-AzPolicyExemption -Name $someName -Scope $someScope -Id $someId } $parameterSetError
        } | Should -Not -Throw
    }

    It 'parameter combinations starting with -Scope' {
        {
            # validate remaining parameter combinations starting with -Scope
            Assert-ThrowsContains { Remove-AzPolicyExemption -Scope $someScope } $missingParameters
            Assert-ThrowsContains { Remove-AzPolicyExemption -Scope $someScope -Id $someId } $parameterSetError
        } | Should -Not -Throw
    }

    It 'parameter combinations starting with -Id' {
        {
            # validate remaining parameter combinations starting with -Id
            $ok = Remove-AzPolicyExemption -Id $goodId -Force -BackwardCompatible
            Assert-AreEqual True $ok
        } | Should -Not -Throw
    }
}
