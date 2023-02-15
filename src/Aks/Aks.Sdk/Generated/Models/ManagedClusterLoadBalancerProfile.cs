// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Profile of the managed cluster load balancer.
    /// </summary>
    public partial class ManagedClusterLoadBalancerProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterLoadBalancerProfile
        /// class.
        /// </summary>
        public ManagedClusterLoadBalancerProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterLoadBalancerProfile
        /// class.
        /// </summary>
        /// <param name="managedOutboundIPs">Desired managed outbound IPs for
        /// the cluster load balancer.</param>
        /// <param name="outboundIPPrefixes">Desired outbound IP Prefix
        /// resources for the cluster load balancer.</param>
        /// <param name="outboundIPs">Desired outbound IP resources for the
        /// cluster load balancer.</param>
        /// <param name="effectiveOutboundIPs">The effective outbound IP
        /// resources of the cluster load balancer.</param>
        /// <param name="allocatedOutboundPorts">The desired number of
        /// allocated SNAT ports per VM. Allowed values are in the range of 0
        /// to 64000 (inclusive). The default value is 0 which results in Azure
        /// dynamically allocating ports.</param>
        /// <param name="idleTimeoutInMinutes">Desired outbound flow idle
        /// timeout in minutes. Allowed values are in the range of 4 to 120
        /// (inclusive). The default value is 30 minutes.</param>
        /// <param name="enableMultipleStandardLoadBalancers">Enable multiple
        /// standard load balancers per AKS cluster or not.</param>
        public ManagedClusterLoadBalancerProfile(ManagedClusterLoadBalancerProfileManagedOutboundIPs managedOutboundIPs = default(ManagedClusterLoadBalancerProfileManagedOutboundIPs), ManagedClusterLoadBalancerProfileOutboundIPPrefixes outboundIPPrefixes = default(ManagedClusterLoadBalancerProfileOutboundIPPrefixes), ManagedClusterLoadBalancerProfileOutboundIPs outboundIPs = default(ManagedClusterLoadBalancerProfileOutboundIPs), IList<ResourceReference> effectiveOutboundIPs = default(IList<ResourceReference>), int? allocatedOutboundPorts = default(int?), int? idleTimeoutInMinutes = default(int?), bool? enableMultipleStandardLoadBalancers = default(bool?))
        {
            ManagedOutboundIPs = managedOutboundIPs;
            OutboundIPPrefixes = outboundIPPrefixes;
            OutboundIPs = outboundIPs;
            EffectiveOutboundIPs = effectiveOutboundIPs;
            AllocatedOutboundPorts = allocatedOutboundPorts;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableMultipleStandardLoadBalancers = enableMultipleStandardLoadBalancers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets desired managed outbound IPs for the cluster load
        /// balancer.
        /// </summary>
        [JsonProperty(PropertyName = "managedOutboundIPs")]
        public ManagedClusterLoadBalancerProfileManagedOutboundIPs ManagedOutboundIPs { get; set; }

        /// <summary>
        /// Gets or sets desired outbound IP Prefix resources for the cluster
        /// load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "outboundIPPrefixes")]
        public ManagedClusterLoadBalancerProfileOutboundIPPrefixes OutboundIPPrefixes { get; set; }

        /// <summary>
        /// Gets or sets desired outbound IP resources for the cluster load
        /// balancer.
        /// </summary>
        [JsonProperty(PropertyName = "outboundIPs")]
        public ManagedClusterLoadBalancerProfileOutboundIPs OutboundIPs { get; set; }

        /// <summary>
        /// Gets or sets the effective outbound IP resources of the cluster
        /// load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveOutboundIPs")]
        public IList<ResourceReference> EffectiveOutboundIPs { get; set; }

        /// <summary>
        /// Gets or sets the desired number of allocated SNAT ports per VM.
        /// Allowed values are in the range of 0 to 64000 (inclusive). The
        /// default value is 0 which results in Azure dynamically allocating
        /// ports.
        /// </summary>
        [JsonProperty(PropertyName = "allocatedOutboundPorts")]
        public int? AllocatedOutboundPorts { get; set; }

        /// <summary>
        /// Gets or sets desired outbound flow idle timeout in minutes. Allowed
        /// values are in the range of 4 to 120 (inclusive). The default value
        /// is 30 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets enable multiple standard load balancers per AKS
        /// cluster or not.
        /// </summary>
        [JsonProperty(PropertyName = "enableMultipleStandardLoadBalancers")]
        public bool? EnableMultipleStandardLoadBalancers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ManagedOutboundIPs != null)
            {
                ManagedOutboundIPs.Validate();
            }
            if (AllocatedOutboundPorts != null)
            {
                if (AllocatedOutboundPorts > 64000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "AllocatedOutboundPorts", 64000);
                }
                if (AllocatedOutboundPorts < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "AllocatedOutboundPorts", 0);
                }
            }
            if (IdleTimeoutInMinutes != null)
            {
                if (IdleTimeoutInMinutes > 120)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "IdleTimeoutInMinutes", 120);
                }
                if (IdleTimeoutInMinutes < 4)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "IdleTimeoutInMinutes", 4);
                }
            }
        }
    }
}
