<!-- region Generated -->
# Policy
This directory contains the PowerShell module for the Policy service.

---
## Status
[![Policy](https://img.shields.io/powershellgallery/v/Policy.svg?style=flat-square&label=Policy "Policy")](https://www.powershellgallery.com/packages/Policy/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Policy`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
# Please specify the commit id that includes your features to make sure generated codes stable.
#branch: 314f28163917b9cfc527f7776b5e4a1dea69d295
#require:
# readme.azure.noprofile.md is the common configuration file
#  - $(this-folder)/../readme.azure.noprofile.md
input-file:
# You need to specify your swagger files here.
  - https://github.com/Azure/azure-rest-api-specs/tree/main/specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/policyDefinitions.json
  - https://github.com/Azure/azure-rest-api-specs/tree/main/specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/policySetDefinitions.json
  - https://github.com/Azure/azure-rest-api-specs/tree/main/specification/resources/resource-manager/Microsoft.Authorization/stable/2022-06-01/policyAssignments.json
# If the swagger has not been put in the repo, you may uncomment the following line and refer to it locally
# - (this-folder)/relative-path-to-your-swagger 

# For new RP, the version is 0.1.0
module-version: 0.1.0
# Normally, title is the service name
title: Policy
subject-prefix: AzPolicy

# If there are post APIs for some kinds of actions in the RP, you may need to 
# uncomment following line to support viaIdentity for these post APIs
# identity-correction-for-post: true

directive:
  # Following is two common directive which are normally required in all the RPs
  # 1. Remove the unexpanded parameter set
  # 2. For New-* cmdlets, ViaIdentity is not required, so CreateViaIdentityExpanded is removed as well
  - where:
      variant: ^Create$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^Update$|^UpdateViaIdentity$
    remove: true
  # Remove the set-* cmdlet
#  - where:
#      verb: Set
#    remove: true

```