// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>A Machine Learning compute based on Azure Virtual Machines.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineTypeConverter))]
    public partial class VirtualMachine
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachine"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachine"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachine DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachine(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachine"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachine"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachine DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachine(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachine" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VirtualMachine" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachine FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachine"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachine(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType.CreateFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ModifiedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ModifiedOn = (global::System.DateTime?) content.GetValueForProperty("ModifiedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ModifiedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningError = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse[]) content.GetValueForProperty("ProvisioningError",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ErrorResponseTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsAttachedCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).IsAttachedCompute = (bool?) content.GetValueForProperty("IsAttachedCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).IsAttachedCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdministratorAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccount = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSshCredentials) content.GetValueForProperty("AdministratorAccount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccount, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachineSshCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("SshPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).SshPort = (int?) content.GetValueForProperty("SshPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).SshPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NotebookServerPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).NotebookServerPort = (int?) content.GetValueForProperty("NotebookServerPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).NotebookServerPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Address = (string) content.GetValueForProperty("Address",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Address, global::System.Convert.ToString);
            }
            if (content.Contains("IsNotebookInstanceCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute = (bool?) content.GetValueForProperty("IsNotebookInstanceCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdministratorAccountUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername = (string) content.GetValueForProperty("AdministratorAccountUsername",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword = (string) content.GetValueForProperty("AdministratorAccountPassword",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPublicKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData = (string) content.GetValueForProperty("AdministratorAccountPublicKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPrivateKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData = (string) content.GetValueForProperty("AdministratorAccountPrivateKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachineSchemaPropertiesTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachine"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachine(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType.CreateFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ModifiedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ModifiedOn = (global::System.DateTime?) content.GetValueForProperty("ModifiedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ModifiedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningError = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse[]) content.GetValueForProperty("ProvisioningError",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).ProvisioningError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ErrorResponseTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsAttachedCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).IsAttachedCompute = (bool?) content.GetValueForProperty("IsAttachedCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).IsAttachedCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IComputeInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdministratorAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccount = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSshCredentials) content.GetValueForProperty("AdministratorAccount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccount, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachineSshCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("SshPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).SshPort = (int?) content.GetValueForProperty("SshPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).SshPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NotebookServerPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).NotebookServerPort = (int?) content.GetValueForProperty("NotebookServerPort",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).NotebookServerPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Address = (string) content.GetValueForProperty("Address",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Address, global::System.Convert.ToString);
            }
            if (content.Contains("IsNotebookInstanceCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute = (bool?) content.GetValueForProperty("IsNotebookInstanceCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).IsNotebookInstanceCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdministratorAccountUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername = (string) content.GetValueForProperty("AdministratorAccountUsername",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword = (string) content.GetValueForProperty("AdministratorAccountPassword",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPublicKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData = (string) content.GetValueForProperty("AdministratorAccountPublicKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPublicKeyData, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorAccountPrivateKeyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData = (string) content.GetValueForProperty("AdministratorAccountPrivateKeyData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).AdministratorAccountPrivateKeyData, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IVirtualMachineSchemaInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.VirtualMachineSchemaPropertiesTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// A Machine Learning compute based on Azure Virtual Machines.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineTypeConverter))]
    public partial interface IVirtualMachine

    {

    }
}