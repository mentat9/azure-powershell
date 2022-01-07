// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001
{
    using Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.PowerShell;

    /// <summary>ACL for a private endpoint</summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointAclTypeConverter))]
    public partial class PrivateEndpointAcl
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.PrivateEndpointAcl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAcl" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAcl DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateEndpointAcl(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.PrivateEndpointAcl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAcl" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAcl DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateEndpointAcl(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateEndpointAcl" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAcl FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.PrivateEndpointAcl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateEndpointAcl(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAclInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAclInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Allow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Allow = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("Allow",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Allow, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            if (content.Contains("Deny"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Deny = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("Deny",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Deny, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.PrivateEndpointAcl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateEndpointAcl(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAclInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IPrivateEndpointAclInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Allow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Allow = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("Allow",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Allow, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            if (content.Contains("Deny"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Deny = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("Deny",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.INetworkAclInternal)this).Deny, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ACL for a private endpoint
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointAclTypeConverter))]
    public partial interface IPrivateEndpointAcl

    {

    }
}