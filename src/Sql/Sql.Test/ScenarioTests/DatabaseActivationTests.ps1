# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
	.SYNOPSIS
	Test pasuing and resuming database.
#>
function Test-DatabasePauseResume
{
	# Setup
	$location = "southeastasia"
	$serverVersion = "12.0";
	$rg = Create-ResourceGroupForTest
	$server = Create-ServerForTest $rg $location

	# Create data warehouse database with all parameters.
	$databaseName = Get-DatabaseName
	$collationName = "SQL_Latin1_General_CP1_CI_AS"
	$maxSizeBytes = 250GB
	$dwdb = New-AzSqlDatabase -ResourceGroupName $rg.ResourceGroupName -ServerName $server.ServerName -DatabaseName $databaseName `
		-CollationName $collationName -MaxSizeBytes $maxSizeBytes -Edition DataWarehouse -RequestedServiceObjectiveName DW100c

	try
	{
		# Pause the database. Make sure the database specs remain the same and its Status is Paused.
		$dwdb2 = Suspend-AzSqlDatabase -ResourceGroupName $rg.ResourceGroupName -ServerName $server.ServerName -DatabaseName $dwdb.DatabaseName
		Assert-AreEqual $dwdb2.DatabaseName $databaseName
		Assert-AreEqual $dwdb2.MaxSizeBytes $maxSizeBytes
		Assert-AreEqual $dwdb2.Edition DataWarehouse
		Assert-AreEqual $dwdb2.CurrentServiceObjectiveName DW100c
		Assert-AreEqual $dwdb2.CollationName $collationName
		Assert-AreEqual $dwdb2.Status "Paused"
		
		# Resume the database. Make sure the database specs remain the same and its Status is Online.
		$job = Resume-AzSqlDatabase -ResourceGroupName $rg.ResourceGroupName -ServerName $server.ServerName -DatabaseName $dwdb.DatabaseName -AsJob
		$job | Wait-Job
		$dwdb3 = $job.Output

		Assert-AreEqual $dwdb3.DatabaseName $databaseName
		Assert-AreEqual $dwdb3.MaxSizeBytes $maxSizeBytes
		Assert-AreEqual $dwdb3.Edition DataWarehouse
		Assert-AreEqual $dwdb3.CurrentServiceObjectiveName DW100c
		Assert-AreEqual $dwdb3.CollationName $collationName
		Assert-AreEqual $dwdb3.Status "Online"
	}
	finally
	{
		Remove-ResourceGroupForTest $rg
	}
}

<#
	.SYNOPSIS
	Test pasuing and resuming database via piped cmdlets.
#>
function Test-DatabasePauseResumePiped
{
	# Setup
	$location = "westeurope"
	$serverVersion = "12.0";
	$rg = Create-ResourceGroupForTest

	try
	{
		$server = Create-ServerForTest $rg $location

		# Create data warehouse database with all parameters.
		$databaseName = Get-DatabaseName
		$collationName = "SQL_Latin1_General_CP1_CI_AS"
		$maxSizeBytes = 250GB
		$dwdb = New-AzSqlDatabase -ResourceGroupName $rg.ResourceGroupName -ServerName $server.ServerName -DatabaseName $databaseName `
			-CollationName $collationName -MaxSizeBytes $maxSizeBytes -Edition DataWarehouse -RequestedServiceObjectiveName DW100c -Force


		# Pause the database. Make sure the database specs remain the same and its Status is Paused.
		$job = $dwdb | Suspend-AzSqlDatabase -AsJob
		$job | Wait-Job
		$dwdb2 = $job.Output

		Assert-AreEqual $dwdb2.DatabaseName $databaseName
		Assert-AreEqual $dwdb2.MaxSizeBytes $maxSizeBytes
		Assert-AreEqual $dwdb2.Edition DataWarehouse
		Assert-AreEqual $dwdb2.CurrentServiceObjectiveName DW100c
		Assert-AreEqual $dwdb2.CollationName $collationName
		Assert-AreEqual $dwdb2.Status "Paused"
		
		# Resume the database. Make sure the database specs remain the same and its Status is Online.
		$dwdb3 = $dwdb2 | Resume-AzSqlDatabase
		Assert-AreEqual $dwdb3.DatabaseName $databaseName
		Assert-AreEqual $dwdb3.MaxSizeBytes $maxSizeBytes
		Assert-AreEqual $dwdb3.Edition DataWarehouse
		Assert-AreEqual $dwdb3.CurrentServiceObjectiveName DW100c
		Assert-AreEqual $dwdb3.CollationName $collationName
		Assert-AreEqual $dwdb3.Status "Online"
	}
	finally
	{
		Remove-ResourceGroupForTest $rg
	}
}