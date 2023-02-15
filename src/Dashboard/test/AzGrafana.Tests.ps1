if(($null -eq $TestName) -or ($TestName -contains 'AzGrafana'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'AzGrafana.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'AzGrafana' {
    It 'CreateExpanded' {
        {
            $config = New-AzGrafana -GrafanaName $env.grafanaName1 -ResourceGroupName $env.resourceGroup -ApiKey Enabled -AutoGeneratedDomainNameLabelScope 'TenantReuse' -DeterministicOutboundIP 'Enabled' -IdentityType 'SystemAssigned' -Location $env.location -PublicNetworkAccess 'Enabled' -SkuName Standard -ZoneRedundancy 'Enabled' -Tag @{"Environment"="Dev"}
            $config.Name | Should -Be $env.grafanaName1
            $config = New-AzGrafana -GrafanaName $env.grafanaName2 -ResourceGroupName $env.resourceGroup -ApiKey Enabled -AutoGeneratedDomainNameLabelScope 'TenantReuse' -DeterministicOutboundIP 'Enabled' -IdentityType 'SystemAssigned' -Location $env.location -PublicNetworkAccess 'Enabled' -SkuName Standard -ZoneRedundancy 'Enabled' -Tag @{"Environment"="Dev"}
            $config.Name | Should -Be $env.grafanaName2
        } | Should -Not -Throw
    }

    It 'List' {
        {
            $config = Get-AzGrafana
            $config.Count | Should -BeGreaterThan 0
        } | Should -Not -Throw
    }

    It 'Get' {
        {
            $config = Get-AzGrafana -ResourceGroupName $env.resourceGroup -GrafanaName $env.grafanaName1
            $config.Name | Should -Be $env.grafanaName1
        } | Should -Not -Throw
    }

    It 'List1' {
        {
            $config = Get-AzGrafana -ResourceGroupName $env.resourceGroup
            $config.Count | Should -BeGreaterThan 0
        } | Should -Not -Throw
    }

    It 'UpdateExpanded' {
        {
            $config = Update-AzGrafana -ResourceGroupName $env.resourceGroup -GrafanaName $env.grafanaName2 -ApiKey Enabled -DeterministicOutboundIP 'Enabled' -IdentityType 'SystemAssigned' -PublicNetworkAccess 'Enabled' -ZoneRedundancy 'Enabled' -Tag @{"Environment"="Dev"}
            $config.Name | Should -Be $env.grafanaName2
        } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' {
        {
            $config = Get-AzGrafana -ResourceGroupName $env.resourceGroup -GrafanaName $env.grafanaName1
            $config = Update-AzGrafana -InputObject $config -ApiKey Enabled -DeterministicOutboundIP 'Enabled' -IdentityType 'SystemAssigned' -PublicNetworkAccess 'Enabled' -ZoneRedundancy 'Enabled' -Tag @{"Environment"="Dev"}
            $config.Name | Should -Be $env.grafanaName1
        } | Should -Not -Throw
    }

    It 'Delete' {
        {
            Remove-AzGrafana -ResourceGroupName $env.resourceGroup -GrafanaName $env.grafanaName1
        } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' {
        {
            $config = Get-AzGrafana -ResourceGroupName $env.resourceGroup -GrafanaName $env.grafanaName2
            Remove-AzGrafana -InputObject $config
        } | Should -Not -Throw
    }
}
