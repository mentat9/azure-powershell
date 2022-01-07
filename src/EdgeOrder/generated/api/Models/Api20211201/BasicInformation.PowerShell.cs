// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.PowerShell;

    /// <summary>Basic information for any product system</summary>
    [System.ComponentModel.TypeConverter(typeof(BasicInformationTypeConverter))]
    public partial class BasicInformation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BasicInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BasicInformation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).Description = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescription) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).Description, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.DescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("CostInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICostInformation) content.GetValueForProperty("CostInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.CostInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation) content.GetValueForProperty("AvailabilityInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ImageInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).ImageInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[]) content.GetValueForProperty("ImageInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).ImageInformation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ImageInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("HierarchyInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).HierarchyInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation) content.GetValueForProperty("HierarchyInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).HierarchyInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.HierarchyInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DescriptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionType = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType?) content.GetValueForProperty("DescriptionType",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionType, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType.CreateFrom);
            }
            if (content.Contains("DescriptionShortDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionShortDescription = (string) content.GetValueForProperty("DescriptionShortDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionShortDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionLongDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLongDescription = (string) content.GetValueForProperty("DescriptionLongDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLongDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionKeyword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionKeyword = (string[]) content.GetValueForProperty("DescriptionKeyword",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionKeyword, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionAttribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionAttribute = (string[]) content.GetValueForProperty("DescriptionAttribute",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionAttribute, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLink = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[]) content.GetValueForProperty("DescriptionLink",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLink, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.LinkTypeConverter.ConvertFrom));
            }
            if (content.Contains("AvailabilityInformationAvailabilityStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationAvailabilityStage = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage?) content.GetValueForProperty("AvailabilityInformationAvailabilityStage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationAvailabilityStage, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage.CreateFrom);
            }
            if (content.Contains("AvailabilityInformationDisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReason = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason?) content.GetValueForProperty("AvailabilityInformationDisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReason, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason.CreateFrom);
            }
            if (content.Contains("CostInformationBillingMeterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingMeterDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[]) content.GetValueForProperty("CostInformationBillingMeterDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingMeterDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BillingMeterDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CostInformationBillingInfoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingInfoUrl = (string) content.GetValueForProperty("CostInformationBillingInfoUrl",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingInfoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityInformationDisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReasonMessage = (string) content.GetValueForProperty("AvailabilityInformationDisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReasonMessage, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BasicInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BasicInformation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).Description = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescription) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).Description, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.DescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("CostInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICostInformation) content.GetValueForProperty("CostInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.CostInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation) content.GetValueForProperty("AvailabilityInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ImageInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).ImageInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[]) content.GetValueForProperty("ImageInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).ImageInformation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ImageInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("HierarchyInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).HierarchyInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation) content.GetValueForProperty("HierarchyInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).HierarchyInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.HierarchyInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DescriptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionType = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType?) content.GetValueForProperty("DescriptionType",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionType, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType.CreateFrom);
            }
            if (content.Contains("DescriptionShortDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionShortDescription = (string) content.GetValueForProperty("DescriptionShortDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionShortDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionLongDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLongDescription = (string) content.GetValueForProperty("DescriptionLongDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLongDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionKeyword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionKeyword = (string[]) content.GetValueForProperty("DescriptionKeyword",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionKeyword, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionAttribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionAttribute = (string[]) content.GetValueForProperty("DescriptionAttribute",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionAttribute, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLink = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[]) content.GetValueForProperty("DescriptionLink",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).DescriptionLink, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.LinkTypeConverter.ConvertFrom));
            }
            if (content.Contains("AvailabilityInformationAvailabilityStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationAvailabilityStage = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage?) content.GetValueForProperty("AvailabilityInformationAvailabilityStage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationAvailabilityStage, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage.CreateFrom);
            }
            if (content.Contains("AvailabilityInformationDisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReason = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason?) content.GetValueForProperty("AvailabilityInformationDisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReason, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason.CreateFrom);
            }
            if (content.Contains("CostInformationBillingMeterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingMeterDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[]) content.GetValueForProperty("CostInformationBillingMeterDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingMeterDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BillingMeterDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CostInformationBillingInfoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingInfoUrl = (string) content.GetValueForProperty("CostInformationBillingInfoUrl",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).CostInformationBillingInfoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityInformationDisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReasonMessage = (string) content.GetValueForProperty("AvailabilityInformationDisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)this).AvailabilityInformationDisabledReasonMessage, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BasicInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BasicInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BasicInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BasicInformation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BasicInformation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Basic information for any product system
    [System.ComponentModel.TypeConverter(typeof(BasicInformationTypeConverter))]
    public partial interface IBasicInformation

    {

    }
}