// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.PowerShell;

    /// <summary>Microsoft Teams channel definition</summary>
    [System.ComponentModel.TypeConverter(typeof(MSTeamsChannelTypeConverter))]
    public partial class MSTeamsChannel
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.MSTeamsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MSTeamsChannel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.MSTeamsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MSTeamsChannel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MSTeamsChannel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MSTeamsChannel" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.MSTeamsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MSTeamsChannel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.MSTeamsChannelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("EnableCalling"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).EnableCalling = (bool?) content.GetValueForProperty("EnableCalling",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).EnableCalling, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CallingWebhook"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).CallingWebhook = (string) content.GetValueForProperty("CallingWebhook",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).CallingWebhook, global::System.Convert.ToString);
            }
            if (content.Contains("IsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IsEnabled = (bool) content.GetValueForProperty("IsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IncomingCallRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IncomingCallRoute = (string) content.GetValueForProperty("IncomingCallRoute",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IncomingCallRoute, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentEnvironment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).DeploymentEnvironment = (string) content.GetValueForProperty("DeploymentEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).DeploymentEnvironment, global::System.Convert.ToString);
            }
            if (content.Contains("AcceptedTerm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).AcceptedTerm = (bool?) content.GetValueForProperty("AcceptedTerm",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).AcceptedTerm, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.MSTeamsChannel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MSTeamsChannel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.MSTeamsChannelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("EnableCalling"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).EnableCalling = (bool?) content.GetValueForProperty("EnableCalling",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).EnableCalling, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CallingWebhook"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).CallingWebhook = (string) content.GetValueForProperty("CallingWebhook",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).CallingWebhook, global::System.Convert.ToString);
            }
            if (content.Contains("IsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IsEnabled = (bool) content.GetValueForProperty("IsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IncomingCallRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IncomingCallRoute = (string) content.GetValueForProperty("IncomingCallRoute",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).IncomingCallRoute, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentEnvironment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).DeploymentEnvironment = (string) content.GetValueForProperty("DeploymentEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).DeploymentEnvironment, global::System.Convert.ToString);
            }
            if (content.Contains("AcceptedTerm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).AcceptedTerm = (bool?) content.GetValueForProperty("AcceptedTerm",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IMSTeamsChannelInternal)this).AcceptedTerm, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Microsoft Teams channel definition
    [System.ComponentModel.TypeConverter(typeof(MSTeamsChannelTypeConverter))]
    public partial interface IMSTeamsChannel

    {

    }
}