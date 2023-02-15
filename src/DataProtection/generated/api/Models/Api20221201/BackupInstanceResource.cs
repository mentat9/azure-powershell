// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>BackupInstance Resource</summary>
    public partial class BackupInstanceResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstanceResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResource __dppProxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.DppProxyResource();

        /// <summary>Proxy Resource Id represents the complete path to the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Type = value; }

        /// <summary>Proxy Resource name associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance _property;

        /// <summary>BackupInstanceResource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.BackupInstance()); set => this._property = value; }

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).SystemData; }

        /// <summary>Proxy Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// Proxy Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal)__dppProxyResource).Type; }

        /// <summary>Creates an new <see cref="BackupInstanceResource" /> instance.</summary>
        public BackupInstanceResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dppProxyResource), __dppProxyResource);
            await eventListener.AssertObjectIsValid(nameof(__dppProxyResource), __dppProxyResource);
        }
    }
    /// BackupInstance Resource
    public partial interface IBackupInstanceResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResource
    {
        /// <summary>BackupInstanceResource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BackupInstanceResource properties",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance Property { get; set; }

    }
    /// BackupInstance Resource
    internal partial interface IBackupInstanceResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppProxyResourceInternal
    {
        /// <summary>BackupInstanceResource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IBackupInstance Property { get; set; }

    }
}