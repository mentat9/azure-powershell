// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.PowerShell;

    /// <summary>The definition of a query.</summary>
    [System.ComponentModel.TypeConverter(typeof(QueryDefinitionTypeConverter))]
    public partial class QueryDefinition
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinition" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new QueryDefinition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinition" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new QueryDefinition(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="QueryDefinition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="QueryDefinition" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal QueryDefinition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TimePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriod = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryTimePeriod) content.GetValueForProperty("TimePeriod",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriod, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryTimePeriodTypeConverter.ConvertFrom);
            }
            if (content.Contains("Dataset"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Dataset = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDataset) content.GetValueForProperty("Dataset",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Dataset, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDatasetTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExportType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExportType.CreateFrom);
            }
            if (content.Contains("Timeframe"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Timeframe = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.TimeframeType) content.GetValueForProperty("Timeframe",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Timeframe, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.TimeframeType.CreateFrom);
            }
            if (content.Contains("TimePeriodFrom"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodFrom = (global::System.DateTime) content.GetValueForProperty("TimePeriodFrom",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodFrom, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TimePeriodTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodTo = (global::System.DateTime) content.GetValueForProperty("TimePeriodTo",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodTo, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DatasetConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDatasetConfiguration) content.GetValueForProperty("DatasetConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetConfiguration, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDatasetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasetGranularity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGranularity = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType?) content.GetValueForProperty("DatasetGranularity",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGranularity, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType.CreateFrom);
            }
            if (content.Contains("DatasetAggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetAggregation = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDatasetAggregation) content.GetValueForProperty("DatasetAggregation",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetAggregation, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDatasetAggregationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasetGrouping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGrouping = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryGrouping[]) content.GetValueForProperty("DatasetGrouping",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGrouping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryGrouping>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryGroupingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DatasetFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetFilter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryFilter) content.GetValueForProperty("DatasetFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetFilter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).ConfigurationColumn = (string[]) content.GetValueForProperty("ConfigurationColumn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).ConfigurationColumn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal QueryDefinition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TimePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriod = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryTimePeriod) content.GetValueForProperty("TimePeriod",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriod, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryTimePeriodTypeConverter.ConvertFrom);
            }
            if (content.Contains("Dataset"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Dataset = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDataset) content.GetValueForProperty("Dataset",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Dataset, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDatasetTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExportType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExportType.CreateFrom);
            }
            if (content.Contains("Timeframe"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Timeframe = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.TimeframeType) content.GetValueForProperty("Timeframe",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).Timeframe, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.TimeframeType.CreateFrom);
            }
            if (content.Contains("TimePeriodFrom"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodFrom = (global::System.DateTime) content.GetValueForProperty("TimePeriodFrom",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodFrom, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TimePeriodTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodTo = (global::System.DateTime) content.GetValueForProperty("TimePeriodTo",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).TimePeriodTo, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DatasetConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDatasetConfiguration) content.GetValueForProperty("DatasetConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetConfiguration, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDatasetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasetGranularity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGranularity = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType?) content.GetValueForProperty("DatasetGranularity",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGranularity, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType.CreateFrom);
            }
            if (content.Contains("DatasetAggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetAggregation = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDatasetAggregation) content.GetValueForProperty("DatasetAggregation",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetAggregation, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryDatasetAggregationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasetGrouping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGrouping = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryGrouping[]) content.GetValueForProperty("DatasetGrouping",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetGrouping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryGrouping>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryGroupingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DatasetFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetFilter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryFilter) content.GetValueForProperty("DatasetFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).DatasetFilter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.QueryFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).ConfigurationColumn = (string[]) content.GetValueForProperty("ConfigurationColumn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryDefinitionInternal)this).ConfigurationColumn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The definition of a query.
    [System.ComponentModel.TypeConverter(typeof(QueryDefinitionTypeConverter))]
    public partial interface IQueryDefinition

    {

    }
}