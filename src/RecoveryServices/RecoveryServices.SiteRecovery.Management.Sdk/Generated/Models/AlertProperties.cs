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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of an alert.
    /// </summary>
    public partial class AlertProperties
    {
        /// <summary>
        /// Initializes a new instance of the AlertProperties class.
        /// </summary>
        public AlertProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertProperties class.
        /// </summary>
        /// <param name="sendToOwners">A value indicating whether to send email
        /// to subscription administrator.</param>
        /// <param name="customEmailAddresses">The custom email address for
        /// sending emails.</param>
        /// <param name="locale">The locale for the email notification.</param>
        public AlertProperties(string sendToOwners = default(string), IList<string> customEmailAddresses = default(IList<string>), string locale = default(string))
        {
            SendToOwners = sendToOwners;
            CustomEmailAddresses = customEmailAddresses;
            Locale = locale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether to send email to
        /// subscription administrator.
        /// </summary>
        [JsonProperty(PropertyName = "sendToOwners")]
        public string SendToOwners { get; set; }

        /// <summary>
        /// Gets or sets the custom email address for sending emails.
        /// </summary>
        [JsonProperty(PropertyName = "customEmailAddresses")]
        public IList<string> CustomEmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets the locale for the email notification.
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

    }
}
