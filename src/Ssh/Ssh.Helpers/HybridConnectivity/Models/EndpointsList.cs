// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.HybridConnectivity.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of endpoints.
    /// </summary>
    public partial class EndpointsList
    {
        /// <summary>
        /// Initializes a new instance of the EndpointsList class.
        /// </summary>
        public EndpointsList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointsList class.
        /// </summary>
        /// <param name="nextLink">The link used to get the next page of
        /// endpoints list.</param>
        /// <param name="value">The list of endpoint.</param>
        public EndpointsList(string nextLink = default(string), IList<EndpointResource> value = default(IList<EndpointResource>))
        {
            NextLink = nextLink;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the link used to get the next page of endpoints list.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or sets the list of endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<EndpointResource> Value { get; set; }

    }
}
