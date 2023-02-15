// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the origin.</summary>
    public partial class AfdOriginUpdatePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal
    {

        /// <summary>Backing field for <see cref="AzureOrigin" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference _azureOrigin;

        /// <summary>Resource reference to the Azure origin resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference AzureOrigin { get => (this._azureOrigin = this._azureOrigin ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReference()); set => this._azureOrigin = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string AzureOriginId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReferenceInternal)AzureOrigin).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReferenceInternal)AzureOrigin).Id = value ?? null; }

        /// <summary>Backing field for <see cref="EnabledState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? _enabledState;

        /// <summary>
        /// Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled
        /// if there is a single enabled backend in single enabled backend pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? EnabledState { get => this._enabledState; set => this._enabledState = value; }

        /// <summary>Backing field for <see cref="EnforceCertificateNameCheck" /> property.</summary>
        private bool? _enforceCertificateNameCheck;

        /// <summary>Whether to enable certificate name check at origin level</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public bool? EnforceCertificateNameCheck { get => this._enforceCertificateNameCheck; set => this._enforceCertificateNameCheck = value; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Backing field for <see cref="HttpPort" /> property.</summary>
        private int? _httpPort;

        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? HttpPort { get => this._httpPort; set => this._httpPort = value; }

        /// <summary>Backing field for <see cref="HttpsPort" /> property.</summary>
        private int? _httpsPort;

        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? HttpsPort { get => this._httpsPort; set => this._httpsPort = value; }

        /// <summary>Internal Acessors for AzureOrigin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal.AzureOrigin { get => (this._azureOrigin = this._azureOrigin ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReference()); set { {_azureOrigin = value;} } }

        /// <summary>Internal Acessors for OriginGroupName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal.OriginGroupName { get => this._originGroupName; set { {_originGroupName = value;} } }

        /// <summary>Internal Acessors for SharedPrivateLinkResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal.SharedPrivateLinkResource { get => (this._sharedPrivateLinkResource = this._sharedPrivateLinkResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SharedPrivateLinkResourceProperties()); set { {_sharedPrivateLinkResource = value;} } }

        /// <summary>Internal Acessors for SharedPrivateLinkResourcePrivateLink</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal.SharedPrivateLinkResourcePrivateLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).PrivateLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).PrivateLink = value; }

        /// <summary>Backing field for <see cref="OriginGroupName" /> property.</summary>
        private string _originGroupName;

        /// <summary>The name of the origin group which contains this origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string OriginGroupName { get => this._originGroupName; }

        /// <summary>Backing field for <see cref="OriginHostHeader" /> property.</summary>
        private string _originHostHeader;

        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string OriginHostHeader { get => this._originHostHeader; set => this._originHostHeader = value; }

        /// <summary>Backing field for <see cref="Priority" /> property.</summary>
        private int? _priority;

        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? Priority { get => this._priority; set => this._priority = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).PrivateLinkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).PrivateLinkId = value ?? null; }

        /// <summary>Backing field for <see cref="SharedPrivateLinkResource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourceProperties _sharedPrivateLinkResource;

        /// <summary>The properties of the private link resource for private origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourceProperties SharedPrivateLinkResource { get => (this._sharedPrivateLinkResource = this._sharedPrivateLinkResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SharedPrivateLinkResourceProperties()); set => this._sharedPrivateLinkResource = value; }

        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string SharedPrivateLinkResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).GroupId = value ?? null; }

        /// <summary>The location of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string SharedPrivateLinkResourcePrivateLinkLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).PrivateLinkLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).PrivateLinkLocation = value ?? null; }

        /// <summary>
        /// The request message for requesting approval of the shared private link resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string SharedPrivateLinkResourceRequestMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).RequestMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).RequestMessage = value ?? null; }

        /// <summary>
        /// Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus? SharedPrivateLinkResourceStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal)SharedPrivateLinkResource).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus)""); }

        /// <summary>Backing field for <see cref="Weight" /> property.</summary>
        private int? _weight;

        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? Weight { get => this._weight; set => this._weight = value; }

        /// <summary>Creates an new <see cref="AfdOriginUpdatePropertiesParameters" /> instance.</summary>
        public AfdOriginUpdatePropertiesParameters()
        {

        }
    }
    /// The JSON object that contains the properties of the origin.
    public partial interface IAfdOriginUpdatePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string AzureOriginId { get; set; }
        /// <summary>
        /// Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled
        /// if there is a single enabled backend in single enabled backend pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled if there is a single enabled backend in single enabled backend pool.",
        SerializedName = @"enabledState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? EnabledState { get; set; }
        /// <summary>Whether to enable certificate name check at origin level</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to enable certificate name check at origin level",
        SerializedName = @"enforceCertificateNameCheck",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnforceCertificateNameCheck { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the HTTP port. Must be between 1 and 65535.",
        SerializedName = @"httpPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the HTTPS port. Must be between 1 and 65535.",
        SerializedName = @"httpsPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpsPort { get; set; }
        /// <summary>The name of the origin group which contains this origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the origin group which contains this origin.",
        SerializedName = @"originGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string OriginGroupName { get;  }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint",
        SerializedName = @"originHostHeader",
        PossibleTypes = new [] { typeof(string) })]
        string OriginHostHeader { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int? Priority { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkId { get; set; }
        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group id from the provider of resource the shared private link resource is for.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string SharedPrivateLinkResourceGroupId { get; set; }
        /// <summary>The location of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the shared private link resource",
        SerializedName = @"privateLinkLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SharedPrivateLinkResourcePrivateLinkLocation { get; set; }
        /// <summary>
        /// The request message for requesting approval of the shared private link resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request message for requesting approval of the shared private link resource.",
        SerializedName = @"requestMessage",
        PossibleTypes = new [] { typeof(string) })]
        string SharedPrivateLinkResourceRequestMessage { get; set; }
        /// <summary>
        /// Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus? SharedPrivateLinkResourceStatus { get; set; }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Weight of the origin in given origin group for load balancing. Must be between 1 and 1000",
        SerializedName = @"weight",
        PossibleTypes = new [] { typeof(int) })]
        int? Weight { get; set; }

    }
    /// The JSON object that contains the properties of the origin.
    internal partial interface IAfdOriginUpdatePropertiesParametersInternal

    {
        /// <summary>Resource reference to the Azure origin resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference AzureOrigin { get; set; }
        /// <summary>Resource ID.</summary>
        string AzureOriginId { get; set; }
        /// <summary>
        /// Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled
        /// if there is a single enabled backend in single enabled backend pool.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? EnabledState { get; set; }
        /// <summary>Whether to enable certificate name check at origin level</summary>
        bool? EnforceCertificateNameCheck { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        int? HttpsPort { get; set; }
        /// <summary>The name of the origin group which contains this origin.</summary>
        string OriginGroupName { get; set; }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        string OriginHostHeader { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        int? Priority { get; set; }
        /// <summary>Resource ID.</summary>
        string PrivateLinkId { get; set; }
        /// <summary>The properties of the private link resource for private origin.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourceProperties SharedPrivateLinkResource { get; set; }
        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for.
        /// </summary>
        string SharedPrivateLinkResourceGroupId { get; set; }
        /// <summary>The resource id of the resource the shared private link resource is for.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference SharedPrivateLinkResourcePrivateLink { get; set; }
        /// <summary>The location of the shared private link resource</summary>
        string SharedPrivateLinkResourcePrivateLinkLocation { get; set; }
        /// <summary>
        /// The request message for requesting approval of the shared private link resource.
        /// </summary>
        string SharedPrivateLinkResourceRequestMessage { get; set; }
        /// <summary>
        /// Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus? SharedPrivateLinkResourceStatus { get; set; }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        int? Weight { get; set; }

    }
}