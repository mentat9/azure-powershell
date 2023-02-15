// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>Peering Service</summary>
    public partial class PeeringService :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringService,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.Resource();

        /// <summary>The ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 5)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>The list of connected agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string[] LogAnalyticWorkspacePropertyConnectedAgent { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyConnectedAgent; }

        /// <summary>The Workspace Key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string LogAnalyticWorkspacePropertyKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyKey; }

        /// <summary>The Workspace ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string LogAnalyticWorkspacePropertyWorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyWorkspaceId; }

        /// <summary>Internal Acessors for LogAnalyticWorkspacePropertyConnectedAgent</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal.LogAnalyticWorkspacePropertyConnectedAgent { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyConnectedAgent; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyConnectedAgent = value; }

        /// <summary>Internal Acessors for LogAnalyticWorkspacePropertyKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal.LogAnalyticWorkspacePropertyKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyKey = value; }

        /// <summary>Internal Acessors for LogAnalyticWorkspacePropertyWorkspaceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal.LogAnalyticWorkspacePropertyWorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyWorkspaceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticWorkspacePropertyWorkspaceId = value; }

        /// <summary>Internal Acessors for LogAnalyticsWorkspaceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.ILogAnalyticsWorkspaceProperties Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal.LogAnalyticsWorkspaceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticsWorkspaceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).LogAnalyticsWorkspaceProperty = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceProperties Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.PeeringServiceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceSku Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.PeeringServiceSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name; }

        /// <summary>The location (state/province) of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 2)]
        public string PeeringServiceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).PeeringServiceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).PeeringServiceLocation = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceProperties _property;

        /// <summary>The properties that define a peering service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.PeeringServiceProperties()); set => this._property = value; }

        /// <summary>The name of the service provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 3)]
        public string Provider { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).PeeringServiceProvider; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).PeeringServiceProvider = value ?? null; }

        /// <summary>
        /// The backup peering (Microsoft/service provider) location to be used for customer traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string ProviderBackupPeeringLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).ProviderBackupPeeringLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).ProviderBackupPeeringLocation = value ?? null; }

        /// <summary>
        /// The primary peering (Microsoft/service provider) location to be used for customer traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string ProviderPrimaryPeeringLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).ProviderPrimaryPeeringLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).ProviderPrimaryPeeringLocation = value ?? null; }

        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 4)]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 1)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceSku _sku;

        /// <summary>The SKU that defines the type of the peering service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.PeeringServiceSku()); set => this._sku = value; }

        /// <summary>The name of the peering service SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceSkuInternal)Sku).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceTags _tag;

        /// <summary>The resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.PeeringServiceTags()); set => this._tag = value; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PeeringService" /> instance.</summary>
        public PeeringService()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Peering Service
    public partial interface IPeeringService :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource
    {
        /// <summary>The location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The list of connected agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of connected agents.",
        SerializedName = @"connectedAgents",
        PossibleTypes = new [] { typeof(string) })]
        string[] LogAnalyticWorkspacePropertyConnectedAgent { get;  }
        /// <summary>The Workspace Key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Workspace Key.",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticWorkspacePropertyKey { get;  }
        /// <summary>The Workspace ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Workspace ID.",
        SerializedName = @"workspaceID",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticWorkspacePropertyWorkspaceId { get;  }
        /// <summary>The location (state/province) of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location (state/province) of the customer.",
        SerializedName = @"peeringServiceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PeeringServiceLocation { get; set; }
        /// <summary>The name of the service provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the service provider.",
        SerializedName = @"peeringServiceProvider",
        PossibleTypes = new [] { typeof(string) })]
        string Provider { get; set; }
        /// <summary>
        /// The backup peering (Microsoft/service provider) location to be used for customer traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The backup peering (Microsoft/service provider) location to be used for customer traffic.",
        SerializedName = @"providerBackupPeeringLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderBackupPeeringLocation { get; set; }
        /// <summary>
        /// The primary peering (Microsoft/service provider) location to be used for customer traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The primary peering (Microsoft/service provider) location to be used for customer traffic.",
        SerializedName = @"providerPrimaryPeeringLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderPrimaryPeeringLocation { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The name of the peering service SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the peering service SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>The resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceTags Tag { get; set; }

    }
    /// Peering Service
    internal partial interface IPeeringServiceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal
    {
        /// <summary>The location of the resource.</summary>
        string Location { get; set; }
        /// <summary>The list of connected agents.</summary>
        string[] LogAnalyticWorkspacePropertyConnectedAgent { get; set; }
        /// <summary>The Workspace Key.</summary>
        string LogAnalyticWorkspacePropertyKey { get; set; }
        /// <summary>The Workspace ID.</summary>
        string LogAnalyticWorkspacePropertyWorkspaceId { get; set; }
        /// <summary>The Log Analytics Workspace Properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.ILogAnalyticsWorkspaceProperties LogAnalyticsWorkspaceProperty { get; set; }
        /// <summary>The location (state/province) of the customer.</summary>
        string PeeringServiceLocation { get; set; }
        /// <summary>The properties that define a peering service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceProperties Property { get; set; }
        /// <summary>The name of the service provider.</summary>
        string Provider { get; set; }
        /// <summary>
        /// The backup peering (Microsoft/service provider) location to be used for customer traffic.
        /// </summary>
        string ProviderBackupPeeringLocation { get; set; }
        /// <summary>
        /// The primary peering (Microsoft/service provider) location to be used for customer traffic.
        /// </summary>
        string ProviderPrimaryPeeringLocation { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The SKU that defines the type of the peering service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceSku Sku { get; set; }
        /// <summary>The name of the peering service SKU.</summary>
        string SkuName { get; set; }
        /// <summary>The resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceTags Tag { get; set; }

    }
}