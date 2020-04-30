// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The essential information related to the peer's ASN.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSPeerAsn
    {
        /// <summary>
        /// Initializes a new instance of the PSPeerAsn class.
        /// </summary>
        public PSPeerAsn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSPeerAsn class.
        /// </summary>
        /// <param name="peerAsnProperty">The Autonomous System Number (ASN) of
        /// the peer.</param>
        /// <param name="peerContactDetail">The contact details of the
        /// peer.</param>
        /// <param name="peerName">The name of the peer.</param>
        /// <param name="validationState">The validation state of the ASN
        /// associated with the peer. Possible values include: 'None',
        /// 'Pending', 'Approved', 'Failed'</param>
        /// <param name="errorMessage">The error message for the validation
        /// state</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        public PSPeerAsn(int? peerAsnProperty = default(int?), IList<PSContactDetail> peerContactDetail = default(IList<PSContactDetail>), string peerName = default(string), string validationState = default(string), string errorMessage = default(string), string name = default(string), string id = default(string), string type = default(string))
        {
            PeerAsnProperty = peerAsnProperty;
            PeerContactDetail = peerContactDetail;
            PeerName = peerName;
            ValidationState = validationState;
            ErrorMessage = errorMessage;
            Name = name;
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Autonomous System Number (ASN) of the peer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerAsnProperty")]
        public int? PeerAsnProperty { get; set; }

        /// <summary>
        /// Gets or sets the contact details of the peer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerContactDetail")]
        public IList<PSContactDetail> PeerContactDetail { get; set; }

        /// <summary>
        /// Gets or sets the name of the peer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerName")]
        public string PeerName { get; set; }

        /// <summary>
        /// Gets or sets the validation state of the ASN associated with the
        /// peer. Possible values include: 'None', 'Pending', 'Approved',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.validationState")]
        public string ValidationState { get; set; }

        /// <summary>
        /// Gets the error message for the validation state
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
