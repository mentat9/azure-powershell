// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901
{
    using Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.PowerShell;

    /// <summary>The updatable properties of the TagRule.</summary>
    [System.ComponentModel.TypeConverter(typeof(TagRuleUpdateTypeConverter))]
    public partial class TagRuleUpdate
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.TagRuleUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TagRuleUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.TagRuleUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TagRuleUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TagRuleUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="TagRuleUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.TagRuleUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TagRuleUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRule = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ILogRules) content.GetValueForProperty("LogRule",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRule, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.LogRulesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MetricRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRule = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IMetricRules) content.GetValueForProperty("MetricRule",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRule, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.MetricRulesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogRuleFilteringTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleFilteringTag = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag[]) content.GetValueForProperty("LogRuleFilteringTag",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleFilteringTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.FilteringTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetricRuleFilteringTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRuleFilteringTag = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag[]) content.GetValueForProperty("MetricRuleFilteringTag",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRuleFilteringTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.FilteringTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("LogRuleSendAadLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendAadLog = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendAadLogsStatus?) content.GetValueForProperty("LogRuleSendAadLog",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendAadLog, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendAadLogsStatus.CreateFrom);
            }
            if (content.Contains("LogRuleSendSubscriptionLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendSubscriptionLog = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendSubscriptionLogsStatus?) content.GetValueForProperty("LogRuleSendSubscriptionLog",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendSubscriptionLog, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendSubscriptionLogsStatus.CreateFrom);
            }
            if (content.Contains("LogRuleSendActivityLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendActivityLog = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendActivityLogsStatus?) content.GetValueForProperty("LogRuleSendActivityLog",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendActivityLog, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendActivityLogsStatus.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.TagRuleUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TagRuleUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRule = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ILogRules) content.GetValueForProperty("LogRule",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRule, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.LogRulesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MetricRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRule = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IMetricRules) content.GetValueForProperty("MetricRule",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRule, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.MetricRulesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogRuleFilteringTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleFilteringTag = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag[]) content.GetValueForProperty("LogRuleFilteringTag",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleFilteringTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.FilteringTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetricRuleFilteringTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRuleFilteringTag = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag[]) content.GetValueForProperty("MetricRuleFilteringTag",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).MetricRuleFilteringTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.FilteringTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("LogRuleSendAadLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendAadLog = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendAadLogsStatus?) content.GetValueForProperty("LogRuleSendAadLog",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendAadLog, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendAadLogsStatus.CreateFrom);
            }
            if (content.Contains("LogRuleSendSubscriptionLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendSubscriptionLog = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendSubscriptionLogsStatus?) content.GetValueForProperty("LogRuleSendSubscriptionLog",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendSubscriptionLog, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendSubscriptionLogsStatus.CreateFrom);
            }
            if (content.Contains("LogRuleSendActivityLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendActivityLog = (Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendActivityLogsStatus?) content.GetValueForProperty("LogRuleSendActivityLog",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRuleUpdateInternal)this).LogRuleSendActivityLog, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendActivityLogsStatus.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The updatable properties of the TagRule.
    [System.ComponentModel.TypeConverter(typeof(TagRuleUpdateTypeConverter))]
    public partial interface ITagRuleUpdate

    {

    }
}