// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>Vendor network function properties.</summary>
    public partial class VendorNetworkFunctionPropertiesFormat
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorNetworkFunctionPropertiesFormat.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorNetworkFunctionPropertiesFormat.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorNetworkFunctionPropertiesFormat FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json ? new VendorNetworkFunctionPropertiesFormat(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VendorNetworkFunctionPropertiesFormat" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VendorNetworkFunctionPropertiesFormat" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._vendorProvisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._vendorProvisioningState.ToString()) : null, "vendorProvisioningState" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._skuName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._skuName.ToString()) : null, "skuName" ,container.Add );
            }
            AddIf( null != (((object)this._skuType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._skuType.ToString()) : null, "skuType" ,container.Add );
            if (null != this._networkFunctionVendorConfiguration)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.XNodeArray();
                foreach( var __x in this._networkFunctionVendorConfiguration )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("networkFunctionVendorConfigurations",__w);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject into a new instance of <see cref="VendorNetworkFunctionPropertiesFormat" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VendorNetworkFunctionPropertiesFormat(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_vendorProvisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("vendorProvisioningState"), out var __jsonVendorProvisioningState) ? (string)__jsonVendorProvisioningState : (string)VendorProvisioningState;}
            {_skuName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("skuName"), out var __jsonSkuName) ? (string)__jsonSkuName : (string)SkuName;}
            {_skuType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("skuType"), out var __jsonSkuType) ? (string)__jsonSkuType : (string)SkuType;}
            {_networkFunctionVendorConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonArray>("networkFunctionVendorConfigurations"), out var __jsonNetworkFunctionVendorConfigurations) ? If( __jsonNetworkFunctionVendorConfigurations as Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionVendorConfiguration[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionVendorConfiguration) (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionVendorConfiguration.FromJson(__u) )) ))() : null : NetworkFunctionVendorConfiguration;}
            AfterFromJson(json);
        }
    }
}