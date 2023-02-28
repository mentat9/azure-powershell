// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container pairing update input.
    /// </summary>
    public partial class UpdateProtectionContainerMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateProtectionContainerMappingInput class.
        /// </summary>
        public UpdateProtectionContainerMappingInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateProtectionContainerMappingInput class.
        /// </summary>
        /// <param name="properties">Update protection container mapping input
        /// properties.</param>
        public UpdateProtectionContainerMappingInput(UpdateProtectionContainerMappingInputProperties properties = default(UpdateProtectionContainerMappingInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets update protection container mapping input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public UpdateProtectionContainerMappingInputProperties Properties { get; set; }

    }
}
