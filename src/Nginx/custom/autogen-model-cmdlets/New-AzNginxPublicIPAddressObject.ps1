
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
Create an in-memory object for NginxPublicIPAddress.
.Description
Create an in-memory object for NginxPublicIPAddress.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.NginxPublicIPAddress
.Link
https://learn.microsoft.com/powershell/module/az.Nginx/new-AzNginxPublicIPAddressObject
#>
function New-AzNginxPublicIPAddressObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.NginxPublicIPAddress')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter()]
        [string]
        $Id
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.NginxPublicIPAddress]::New()

        if ($PSBoundParameters.ContainsKey('Id')) {
            $Object.Id = $Id
        }
        return $Object
    }
}

