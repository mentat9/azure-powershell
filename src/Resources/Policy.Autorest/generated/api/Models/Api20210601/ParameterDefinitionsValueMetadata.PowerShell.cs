// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.PowerShell;

    /// <summary>General metadata for the parameter.</summary>
    [System.ComponentModel.TypeConverter(typeof(ParameterDefinitionsValueMetadataTypeConverter))]
    public partial class ParameterDefinitionsValueMetadata
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.ParameterDefinitionsValueMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ParameterDefinitionsValueMetadata(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.ParameterDefinitionsValueMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ParameterDefinitionsValueMetadata(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ParameterDefinitionsValueMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ParameterDefinitionsValueMetadata" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.ParameterDefinitionsValueMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ParameterDefinitionsValueMetadata(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("StrongType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).StrongType = (string) content.GetValueForProperty("StrongType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).StrongType, global::System.Convert.ToString);
            }
            if (content.Contains("AssignPermission"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).AssignPermission = (bool?) content.GetValueForProperty("AssignPermission",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).AssignPermission, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            // this type is a dictionary; copy elements from source to here.
            CopyFrom(content);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.ParameterDefinitionsValueMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ParameterDefinitionsValueMetadata(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("StrongType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).StrongType = (string) content.GetValueForProperty("StrongType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).StrongType, global::System.Convert.ToString);
            }
            if (content.Contains("AssignPermission"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).AssignPermission = (bool?) content.GetValueForProperty("AssignPermission",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal)this).AssignPermission, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            // this type is a dictionary; copy elements from source to here.
            CopyFrom(content);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// General metadata for the parameter.
    [System.ComponentModel.TypeConverter(typeof(ParameterDefinitionsValueMetadataTypeConverter))]
    public partial interface IParameterDefinitionsValueMetadata

    {

    }
}