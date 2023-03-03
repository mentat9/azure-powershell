//// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "HostGroup", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSHostGroup))]
    public partial class NewAzureRmDedicatedHostGroup : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.Name, VerbsCommon.New))
                {
                    string resourceGroupName = this.ResourceGroupName;
                    string hostGroupName = this.Name;
                    DedicatedHostGroup parameters = new DedicatedHostGroup();
                    parameters.Location = this.Location;
                    parameters.PlatformFaultDomainCount = this.PlatformFaultDomain;

                    if (this.IsParameterBound(c => c.Zone))
                    {
                        parameters.Zones = this.Zone;
                    }

                    if (this.IsParameterBound(c => c.SupportAutomaticPlacement))
                    {
                        parameters.SupportAutomaticPlacement = this.SupportAutomaticPlacement;
                    }

                    if (this.IsParameterBound(c => c.Tag))
                    {
                        parameters.Tags = this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value);
                    }

                    if (this.EnableUltraSSD.IsPresent)
                    {
                        if (parameters.AdditionalCapabilities == null)
                        {
                            parameters.AdditionalCapabilities = new DedicatedHostGroupPropertiesAdditionalCapabilities();
                        }
                        parameters.AdditionalCapabilities.UltraSSDEnabled = true;
                    }

                    var result = DedicatedHostGroupsClient.CreateOrUpdate(resourceGroupName, hostGroupName, parameters);
                    var psObject = new PSHostGroup();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<DedicatedHostGroup, PSHostGroup>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Alias("HostGroupName")]
        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            Position = 2,
            Mandatory = true)]
        [LocationCompleter("Microsoft.Compute/hostGroups/hosts")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = true)]
        public int PlatformFaultDomain { get; set; }

        [Parameter(
            Mandatory = false)]
        public string[] Zone { get; set; }

        [Parameter(
            Mandatory = false)]
        public bool SupportAutomaticPlacement { get; set; }

        [Parameter(
            Mandatory = false)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The flag that enables or disables a capability to have UltraSSD Enabled Virtual Machines on Dedicated Hosts of the Dedicated Host Group. For the Virtual Machines to be UltraSSD Enabled, UltraSSDEnabled flag for the resource needs to be set true as well. Please refer to https://learn.microsoft.com/en-us/azure/virtual-machines/disks-enable-ultra-ssd for more details on Ultra SSD feature. The ultraSSDEnabled setting can only be enabled for Host Groups that are created as zonal.")]
        public SwitchParameter EnableUltraSSD { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
    }
}
