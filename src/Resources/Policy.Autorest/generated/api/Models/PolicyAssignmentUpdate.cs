// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>The policy assignment for Patch request.</summary>
    public partial class PolicyAssignmentUpdate :
        Sample.API.Models.IPolicyAssignmentUpdate,
        Sample.API.Models.IPolicyAssignmentUpdateInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Sample.API.Models.IIdentity _identity;

        /// <summary>The managed identity associated with the policy assignment.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.IIdentity Identity { get => (this._identity = this._identity ?? new Sample.API.Models.Identity()); set => this._identity = value; }

        /// <summary>
        /// The principal ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Sample.API.Models.IIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Sample.API.Models.IIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Support.ResourceIdentityType? IdentityType { get => ((Sample.API.Models.IIdentityInternal)Identity).Type; set => ((Sample.API.Models.IIdentityInternal)Identity).Type = value ?? ((Sample.API.Support.ResourceIdentityType)""); }

        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Models.IIdentityUserAssignedIdentities IdentityUserAssignedIdentities { get => ((Sample.API.Models.IIdentityInternal)Identity).UserAssignedIdentities; set => ((Sample.API.Models.IIdentityInternal)Identity).UserAssignedIdentities = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>
        /// The location of the policy assignment. Only required when utilizing managed identity.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>The policy property value override.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Models.IOverride[] Overrides { get => ((Sample.API.Models.IPolicyAssignmentUpdatePropertiesInternal)Properties).Overrides; set => ((Sample.API.Models.IPolicyAssignmentUpdatePropertiesInternal)Properties).Overrides = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Sample.API.Models.IPolicyAssignmentUpdateProperties _properties;

        /// <summary>The policy assignment properties for Patch request.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.IPolicyAssignmentUpdateProperties Properties { get => (this._properties = this._properties ?? new Sample.API.Models.PolicyAssignmentUpdateProperties()); set => this._properties = value; }

        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Models.IResourceSelector[] ResourceSelectors { get => ((Sample.API.Models.IPolicyAssignmentUpdatePropertiesInternal)Properties).ResourceSelectors; set => ((Sample.API.Models.IPolicyAssignmentUpdatePropertiesInternal)Properties).ResourceSelectors = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Identity</summary>
        Sample.API.Models.IIdentity Sample.API.Models.IPolicyAssignmentUpdateInternal.Identity { get => (this._identity = this._identity ?? new Sample.API.Models.Identity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Sample.API.Models.IPolicyAssignmentUpdateInternal.IdentityPrincipalId { get => ((Sample.API.Models.IIdentityInternal)Identity).PrincipalId; set => ((Sample.API.Models.IIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Sample.API.Models.IPolicyAssignmentUpdateInternal.IdentityTenantId { get => ((Sample.API.Models.IIdentityInternal)Identity).TenantId; set => ((Sample.API.Models.IIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Properties</summary>
        Sample.API.Models.IPolicyAssignmentUpdateProperties Sample.API.Models.IPolicyAssignmentUpdateInternal.Properties { get => (this._properties = this._properties ?? new Sample.API.Models.PolicyAssignmentUpdateProperties()); set { {_properties = value;} } }

        /// <summary>Creates an new <see cref="PolicyAssignmentUpdate" /> instance.</summary>
        public PolicyAssignmentUpdate()
        {

        }
    }
    /// The policy assignment for Patch request.
    public partial interface IPolicyAssignmentUpdate :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The principal ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal ID of the resource identity.  This property will only be provided for a system assigned identity",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of the resource identity.  This property will only be provided for a system assigned identity",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity type. This is the only required field when adding a system or user assigned identity to a resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Sample.API.Support.ResourceIdentityType) })]
        Sample.API.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Sample.API.Models.IIdentityUserAssignedIdentities) })]
        Sample.API.Models.IIdentityUserAssignedIdentities IdentityUserAssignedIdentities { get; set; }
        /// <summary>
        /// The location of the policy assignment. Only required when utilizing managed identity.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the policy assignment. Only required when utilizing managed identity.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The policy property value override.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy property value override.",
        SerializedName = @"overrides",
        PossibleTypes = new [] { typeof(Sample.API.Models.IOverride) })]
        Sample.API.Models.IOverride[] Overrides { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource selector list to filter policies by resource properties.",
        SerializedName = @"resourceSelectors",
        PossibleTypes = new [] { typeof(Sample.API.Models.IResourceSelector) })]
        Sample.API.Models.IResourceSelector[] ResourceSelectors { get; set; }

    }
    /// The policy assignment for Patch request.
    internal partial interface IPolicyAssignmentUpdateInternal

    {
        /// <summary>The managed identity associated with the policy assignment.</summary>
        Sample.API.Models.IIdentity Identity { get; set; }
        /// <summary>
        /// The principal ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        Sample.API.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Sample.API.Models.IIdentityUserAssignedIdentities IdentityUserAssignedIdentities { get; set; }
        /// <summary>
        /// The location of the policy assignment. Only required when utilizing managed identity.
        /// </summary>
        string Location { get; set; }
        /// <summary>The policy property value override.</summary>
        Sample.API.Models.IOverride[] Overrides { get; set; }
        /// <summary>The policy assignment properties for Patch request.</summary>
        Sample.API.Models.IPolicyAssignmentUpdateProperties Properties { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        Sample.API.Models.IResourceSelector[] ResourceSelectors { get; set; }

    }
}