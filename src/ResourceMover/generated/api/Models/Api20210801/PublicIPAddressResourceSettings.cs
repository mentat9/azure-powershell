// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Extensions;

    /// <summary>Defines the public IP address resource settings.</summary>
    public partial class PublicIPAddressResourceSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IPublicIPAddressResourceSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IPublicIPAddressResourceSettingsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettings"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettings __resourceSettings = new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.ResourceSettings();

        /// <summary>Backing field for <see cref="DomainNameLabel" /> property.</summary>
        private string _domainNameLabel;

        /// <summary>Gets or sets the domain name label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public string DomainNameLabel { get => this._domainNameLabel; set => this._domainNameLabel = value; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>Gets or sets the fully qualified domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; set => this._fqdn = value; }

        /// <summary>Backing field for <see cref="PublicIPAllocationMethod" /> property.</summary>
        private string _publicIPAllocationMethod;

        /// <summary>Gets or sets public IP allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public string PublicIPAllocationMethod { get => this._publicIPAllocationMethod; set => this._publicIPAllocationMethod = value; }

        /// <summary>
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettingsInternal)__resourceSettings).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettingsInternal)__resourceSettings).ResourceType = value ; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>Gets or sets public IP sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; set => this._sku = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IPublicIPAddressResourceSettingsTags _tag;

        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IPublicIPAddressResourceSettingsTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.PublicIPAddressResourceSettingsTags()); set => this._tag = value; }

        /// <summary>Gets or sets the target Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Inherited)]
        public string TargetResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettingsInternal)__resourceSettings).TargetResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettingsInternal)__resourceSettings).TargetResourceName = value ; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private string _zone;

        /// <summary>Gets or sets public IP zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public string Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Creates an new <see cref="PublicIPAddressResourceSettings" /> instance.</summary>
        public PublicIPAddressResourceSettings()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceSettings), __resourceSettings);
            await eventListener.AssertObjectIsValid(nameof(__resourceSettings), __resourceSettings);
        }
    }
    /// Defines the public IP address resource settings.
    public partial interface IPublicIPAddressResourceSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettings
    {
        /// <summary>Gets or sets the domain name label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the domain name label.",
        SerializedName = @"domainNameLabel",
        PossibleTypes = new [] { typeof(string) })]
        string DomainNameLabel { get; set; }
        /// <summary>Gets or sets the fully qualified domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the fully qualified domain name.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get; set; }
        /// <summary>Gets or sets public IP allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets public IP allocation method.",
        SerializedName = @"publicIpAllocationMethod",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPAllocationMethod { get; set; }
        /// <summary>Gets or sets public IP sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets public IP sku.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get; set; }
        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IPublicIPAddressResourceSettingsTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IPublicIPAddressResourceSettingsTags Tag { get; set; }
        /// <summary>Gets or sets public IP zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets public IP zones.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        string Zone { get; set; }

    }
    /// Defines the public IP address resource settings.
    internal partial interface IPublicIPAddressResourceSettingsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IResourceSettingsInternal
    {
        /// <summary>Gets or sets the domain name label.</summary>
        string DomainNameLabel { get; set; }
        /// <summary>Gets or sets the fully qualified domain name.</summary>
        string Fqdn { get; set; }
        /// <summary>Gets or sets public IP allocation method.</summary>
        string PublicIPAllocationMethod { get; set; }
        /// <summary>Gets or sets public IP sku.</summary>
        string Sku { get; set; }
        /// <summary>Gets or sets the Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IPublicIPAddressResourceSettingsTags Tag { get; set; }
        /// <summary>Gets or sets public IP zones.</summary>
        string Zone { get; set; }

    }
}