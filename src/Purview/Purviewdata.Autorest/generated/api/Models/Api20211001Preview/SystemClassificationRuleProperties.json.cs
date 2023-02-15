// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class SystemClassificationRuleProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISystemClassificationRuleProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISystemClassificationRuleProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISystemClassificationRuleProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json ? new SystemClassificationRuleProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject into a new instance of <see cref="SystemClassificationRuleProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemClassificationRuleProperties(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNumber>("version"), out var __jsonVersion) ? (int?)__jsonVersion : Version;}
            {_classificationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString>("classificationName"), out var __jsonClassificationName) ? (string)__jsonClassificationName : (string)ClassificationName;}
            {_ruleStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString>("ruleStatus"), out var __jsonRuleStatus) ? (string)__jsonRuleStatus : (string)RuleStatus;}
            {_createdAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString>("createdAt"), out var __jsonCreatedAt) ? global::System.DateTime.TryParse((string)__jsonCreatedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedAtValue) ? __jsonCreatedAtValue : CreatedAt : CreatedAt;}
            {_lastModifiedAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString>("lastModifiedAt"), out var __jsonLastModifiedAt) ? global::System.DateTime.TryParse((string)__jsonLastModifiedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedAtValue) ? __jsonLastModifiedAtValue : LastModifiedAt : LastModifiedAt;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemClassificationRuleProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemClassificationRuleProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._version ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNumber((int)this._version) : null, "version" ,container.Add );
            }
            AddIf( null != (((object)this._classificationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(this._classificationName.ToString()) : null, "classificationName" ,container.Add );
            AddIf( null != (((object)this._ruleStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(this._ruleStatus.ToString()) : null, "ruleStatus" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._createdAt ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(this._createdAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "createdAt" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastModifiedAt ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(this._lastModifiedAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModifiedAt" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}