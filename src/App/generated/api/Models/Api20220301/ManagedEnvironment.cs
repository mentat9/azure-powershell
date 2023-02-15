// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>An environment for hosting container apps</summary>
    public partial class ManagedEnvironment :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal,
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.TrackedResource();

        /// <summary>Logs destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string AppLogConfigurationDestination { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).AppLogConfigurationDestination; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).AppLogConfigurationDestination = value ?? null; }

        /// <summary>
        /// Application Insights connection string used by Dapr to export Service to Service communication telemetry
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string DaprAiConnectionString { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DaprAiConnectionString; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DaprAiConnectionString = value ?? null; }

        /// <summary>
        /// Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string DaprAiInstrumentationKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DaprAiInstrumentationKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DaprAiInstrumentationKey = value ?? null; }

        /// <summary>Default Domain Name for the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string DefaultDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DefaultDomain; }

        /// <summary>Any errors that occurred during deployment or deployment validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string DeploymentError { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DeploymentError; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.FormatTable(Index = 0)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Log analytics customer id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string LogAnalyticConfigurationCustomerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).LogAnalyticConfigurationCustomerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).LogAnalyticConfigurationCustomerId = value ?? null; }

        /// <summary>Log analytics customer key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string LogAnalyticConfigurationSharedKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).LogAnalyticConfigurationSharedKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).LogAnalyticConfigurationSharedKey = value ?? null; }

        /// <summary>Internal Acessors for AppLogConfigurationLogAnalyticsConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILogAnalyticsConfiguration Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.AppLogConfigurationLogAnalyticsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).AppLogConfigurationLogAnalyticsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).AppLogConfigurationLogAnalyticsConfiguration = value; }

        /// <summary>Internal Acessors for AppLogsConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppLogsConfiguration Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.AppLogsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).AppLogsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).AppLogsConfiguration = value; }

        /// <summary>Internal Acessors for DefaultDomain</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.DefaultDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DefaultDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DefaultDomain = value; }

        /// <summary>Internal Acessors for DeploymentError</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.DeploymentError { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DeploymentError; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).DeploymentError = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentProperties Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironmentProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for StaticIP</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.StaticIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).StaticIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).StaticIP = value; }

        /// <summary>Internal Acessors for VnetConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVnetConfiguration Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal.VnetConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfiguration = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.FormatTable(Index = 1)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentProperties _property;

        /// <summary>Managed environment resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironmentProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the Environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.FormatTable(Index = 2)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Static IP of the Environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string StaticIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).StaticIP; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)__trackedResource).Type; }

        /// <summary>
        /// CIDR notation IP range assigned to the Docker bridge, network. Must not overlap with any other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string VnetConfigurationDockerBridgeCidr { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationDockerBridgeCidr; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationDockerBridgeCidr = value ?? null; }

        /// <summary>
        /// Resource ID of a subnet for infrastructure components. This subnet must be in the same VNET as the subnet defined in runtimeSubnetId.
        /// Must not overlap with any other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string VnetConfigurationInfrastructureSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationInfrastructureSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationInfrastructureSubnetId = value ?? null; }

        /// <summary>
        /// Boolean indicating the environment only has an internal load balancer. These environments do not have a public static
        /// IP resource, must provide ControlPlaneSubnetResourceId and AppSubnetResourceId if enabling this property
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public bool? VnetConfigurationInternal { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationInternal; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationInternal = value ?? default(bool); }

        /// <summary>
        /// IP range in CIDR notation that can be reserved for environment infrastructure IP addresses. Must not overlap with any
        /// other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string VnetConfigurationPlatformReservedCidr { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationPlatformReservedCidr; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationPlatformReservedCidr = value ?? null; }

        /// <summary>
        /// An IP address from the IP range defined by platformReservedCidr that will be reserved for the internal DNS server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string VnetConfigurationPlatformReservedDnsIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationPlatformReservedDnsIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationPlatformReservedDnsIP = value ?? null; }

        /// <summary>
        /// Resource ID of a subnet that Container App containers are injected into. This subnet must be in the same VNET as the subnet
        /// defined in infrastructureSubnetId. Must not overlap with any other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public string VnetConfigurationRuntimeSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationRuntimeSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).VnetConfigurationRuntimeSubnetId = value ?? null; }

        /// <summary>Whether or not this Managed Environment is zone-redundant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.App.DoNotFormat]
        public bool? ZoneRedundant { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).ZoneRedundant; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentPropertiesInternal)Property).ZoneRedundant = value ?? default(bool); }

        /// <summary>Creates an new <see cref="ManagedEnvironment" /> instance.</summary>
        public ManagedEnvironment()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// An environment for hosting container apps
    public partial interface IManagedEnvironment :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResource
    {
        /// <summary>Logs destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Logs destination",
        SerializedName = @"destination",
        PossibleTypes = new [] { typeof(string) })]
        string AppLogConfigurationDestination { get; set; }
        /// <summary>
        /// Application Insights connection string used by Dapr to export Service to Service communication telemetry
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application Insights connection string used by Dapr to export Service to Service communication telemetry",
        SerializedName = @"daprAIConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string DaprAiConnectionString { get; set; }
        /// <summary>
        /// Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry",
        SerializedName = @"daprAIInstrumentationKey",
        PossibleTypes = new [] { typeof(string) })]
        string DaprAiInstrumentationKey { get; set; }
        /// <summary>Default Domain Name for the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Default Domain Name for the cluster",
        SerializedName = @"defaultDomain",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultDomain { get;  }
        /// <summary>Any errors that occurred during deployment or deployment validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Any errors that occurred during deployment or deployment validation",
        SerializedName = @"deploymentErrors",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentError { get;  }
        /// <summary>Log analytics customer id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Log analytics customer id",
        SerializedName = @"customerId",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticConfigurationCustomerId { get; set; }
        /// <summary>Log analytics customer key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Log analytics customer key",
        SerializedName = @"sharedKey",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticConfigurationSharedKey { get; set; }
        /// <summary>Provisioning state of the Environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the Environment.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState? ProvisioningState { get;  }
        /// <summary>Static IP of the Environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Static IP of the Environment",
        SerializedName = @"staticIp",
        PossibleTypes = new [] { typeof(string) })]
        string StaticIP { get;  }
        /// <summary>
        /// CIDR notation IP range assigned to the Docker bridge, network. Must not overlap with any other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CIDR notation IP range assigned to the Docker bridge, network. Must not overlap with any other provided IP ranges.",
        SerializedName = @"dockerBridgeCidr",
        PossibleTypes = new [] { typeof(string) })]
        string VnetConfigurationDockerBridgeCidr { get; set; }
        /// <summary>
        /// Resource ID of a subnet for infrastructure components. This subnet must be in the same VNET as the subnet defined in runtimeSubnetId.
        /// Must not overlap with any other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID of a subnet for infrastructure components. This subnet must be in the same VNET as the subnet defined in runtimeSubnetId. Must not overlap with any other provided IP ranges.",
        SerializedName = @"infrastructureSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string VnetConfigurationInfrastructureSubnetId { get; set; }
        /// <summary>
        /// Boolean indicating the environment only has an internal load balancer. These environments do not have a public static
        /// IP resource, must provide ControlPlaneSubnetResourceId and AppSubnetResourceId if enabling this property
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean indicating the environment only has an internal load balancer. These environments do not have a public static IP resource, must provide ControlPlaneSubnetResourceId and AppSubnetResourceId if enabling this property",
        SerializedName = @"internal",
        PossibleTypes = new [] { typeof(bool) })]
        bool? VnetConfigurationInternal { get; set; }
        /// <summary>
        /// IP range in CIDR notation that can be reserved for environment infrastructure IP addresses. Must not overlap with any
        /// other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP range in CIDR notation that can be reserved for environment infrastructure IP addresses. Must not overlap with any other provided IP ranges.",
        SerializedName = @"platformReservedCidr",
        PossibleTypes = new [] { typeof(string) })]
        string VnetConfigurationPlatformReservedCidr { get; set; }
        /// <summary>
        /// An IP address from the IP range defined by platformReservedCidr that will be reserved for the internal DNS server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @" An IP address from the IP range defined by platformReservedCidr that will be reserved for the internal DNS server.",
        SerializedName = @"platformReservedDnsIP",
        PossibleTypes = new [] { typeof(string) })]
        string VnetConfigurationPlatformReservedDnsIP { get; set; }
        /// <summary>
        /// Resource ID of a subnet that Container App containers are injected into. This subnet must be in the same VNET as the subnet
        /// defined in infrastructureSubnetId. Must not overlap with any other provided IP ranges.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID of a subnet that Container App containers are injected into. This subnet must be in the same VNET as the subnet defined in infrastructureSubnetId. Must not overlap with any other provided IP ranges.",
        SerializedName = @"runtimeSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string VnetConfigurationRuntimeSubnetId { get; set; }
        /// <summary>Whether or not this Managed Environment is zone-redundant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether or not this Managed Environment is zone-redundant.",
        SerializedName = @"zoneRedundant",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ZoneRedundant { get; set; }

    }
    /// An environment for hosting container apps
    internal partial interface IManagedEnvironmentInternal :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal
    {
        /// <summary>Logs destination</summary>
        string AppLogConfigurationDestination { get; set; }
        /// <summary>Log Analytics configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILogAnalyticsConfiguration AppLogConfigurationLogAnalyticsConfiguration { get; set; }
        /// <summary>
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only "log-analytics" is
        /// supported
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppLogsConfiguration AppLogsConfiguration { get; set; }
        /// <summary>
        /// Application Insights connection string used by Dapr to export Service to Service communication telemetry
        /// </summary>
        string DaprAiConnectionString { get; set; }
        /// <summary>
        /// Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry
        /// </summary>
        string DaprAiInstrumentationKey { get; set; }
        /// <summary>Default Domain Name for the cluster</summary>
        string DefaultDomain { get; set; }
        /// <summary>Any errors that occurred during deployment or deployment validation</summary>
        string DeploymentError { get; set; }
        /// <summary>Log analytics customer id</summary>
        string LogAnalyticConfigurationCustomerId { get; set; }
        /// <summary>Log analytics customer key</summary>
        string LogAnalyticConfigurationSharedKey { get; set; }
        /// <summary>Managed environment resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentProperties Property { get; set; }
        /// <summary>Provisioning state of the Environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState? ProvisioningState { get; set; }
        /// <summary>Static IP of the Environment</summary>
        string StaticIP { get; set; }
        /// <summary>Vnet configuration for the environment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVnetConfiguration VnetConfiguration { get; set; }
        /// <summary>
        /// CIDR notation IP range assigned to the Docker bridge, network. Must not overlap with any other provided IP ranges.
        /// </summary>
        string VnetConfigurationDockerBridgeCidr { get; set; }
        /// <summary>
        /// Resource ID of a subnet for infrastructure components. This subnet must be in the same VNET as the subnet defined in runtimeSubnetId.
        /// Must not overlap with any other provided IP ranges.
        /// </summary>
        string VnetConfigurationInfrastructureSubnetId { get; set; }
        /// <summary>
        /// Boolean indicating the environment only has an internal load balancer. These environments do not have a public static
        /// IP resource, must provide ControlPlaneSubnetResourceId and AppSubnetResourceId if enabling this property
        /// </summary>
        bool? VnetConfigurationInternal { get; set; }
        /// <summary>
        /// IP range in CIDR notation that can be reserved for environment infrastructure IP addresses. Must not overlap with any
        /// other provided IP ranges.
        /// </summary>
        string VnetConfigurationPlatformReservedCidr { get; set; }
        /// <summary>
        /// An IP address from the IP range defined by platformReservedCidr that will be reserved for the internal DNS server.
        /// </summary>
        string VnetConfigurationPlatformReservedDnsIP { get; set; }
        /// <summary>
        /// Resource ID of a subnet that Container App containers are injected into. This subnet must be in the same VNET as the subnet
        /// defined in infrastructureSubnetId. Must not overlap with any other provided IP ranges.
        /// </summary>
        string VnetConfigurationRuntimeSubnetId { get; set; }
        /// <summary>Whether or not this Managed Environment is zone-redundant.</summary>
        bool? ZoneRedundant { get; set; }

    }
}