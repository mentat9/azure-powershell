// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Backup Instance</summary>
    [System.ComponentModel.TypeConverter(typeof(BackupInstanceTypeConverter))]
    public partial class BackupInstance
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupInstance(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IProtectionStatusDetails) content.GetValueForProperty("ProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).CurrentProtectionState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CurrentProtectionState?) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).CurrentProtectionState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CurrentProtectionState.CreateFrom);
            }
            if (content.Contains("ProtectionErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ValidationType?) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ValidationType.CreateFrom);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupInstance(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IProtectionStatusDetails) content.GetValueForProperty("ProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).CurrentProtectionState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CurrentProtectionState?) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).CurrentProtectionState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CurrentProtectionState.CreateFrom);
            }
            if (content.Contains("ProtectionErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProtectionErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ValidationType?) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ValidationType.CreateFrom);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupInstance(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.BackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupInstance(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupInstance" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="BackupInstance" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Backup Instance
    [System.ComponentModel.TypeConverter(typeof(BackupInstanceTypeConverter))]
    public partial interface IBackupInstance

    {

    }
}