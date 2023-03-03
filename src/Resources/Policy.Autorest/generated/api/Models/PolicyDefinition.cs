// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>The policy definition.</summary>
    public partial class PolicyDefinition :
        Sample.API.Models.IPolicyDefinition,
        Sample.API.Models.IPolicyDefinitionInternal
    {

        /// <summary>The policy definition description.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string Description { get => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Description; set => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Description = value ?? null; }

        /// <summary>The display name of the policy definition.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).DisplayName; set => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).DisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the policy definition.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>
        /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Models.IAny Metadata { get => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Metadata; set => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Metadata = value ?? null /* model class */; }

        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string Mode { get => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Mode; set => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Mode = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the policy definition.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Models.IParameterDefinitions Parameters { get => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Parameters; set => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).Parameters = value ?? null /* model class */; }

        /// <summary>The policy rule.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Models.IAny PolicyRule { get => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).PolicyRule; set => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).PolicyRule = value ?? null /* model class */; }

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Support.PolicyType? PolicyType { get => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).PolicyType; set => ((Sample.API.Models.IPolicyDefinitionPropertiesInternal)Properties).PolicyType = value ?? ((Sample.API.Support.PolicyType)""); }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Sample.API.Models.IPolicyDefinitionProperties _properties;

        /// <summary>The policy definition properties.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.IPolicyDefinitionProperties Properties { get => (this._properties = this._properties ?? new Sample.API.Models.PolicyDefinitionProperties()); set => this._properties = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Sample.API.Models.IPolicyDefinitionInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Sample.API.Models.IPolicyDefinitionInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Properties</summary>
        Sample.API.Models.IPolicyDefinitionProperties Sample.API.Models.IPolicyDefinitionInternal.Properties { get => (this._properties = this._properties ?? new Sample.API.Models.PolicyDefinitionProperties()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Sample.API.Models.ISystemData Sample.API.Models.IPolicyDefinitionInternal.SystemData { get => (this._systemData = this._systemData ?? new Sample.API.Models.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Sample.API.Models.IPolicyDefinitionInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Sample.API.Models.ISystemData _systemData;

        /// <summary>The system metadata relating to this resource.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Sample.API.Models.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Sample.API.Models.ISystemDataInternal)SystemData).CreatedAt; set => ((Sample.API.Models.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Sample.API.Models.ISystemDataInternal)SystemData).CreatedBy; set => ((Sample.API.Models.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Support.CreatedByType? SystemDataCreatedByType { get => ((Sample.API.Models.ISystemDataInternal)SystemData).CreatedByType; set => ((Sample.API.Models.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Sample.API.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Sample.API.Models.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Sample.API.Models.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Sample.API.Models.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Sample.API.Models.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Sample.API.Models.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Sample.API.Models.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Sample.API.Support.CreatedByType)""); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource (Microsoft.Authorization/policyDefinitions).</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="PolicyDefinition" /> instance.</summary>
        public PolicyDefinition()
        {

        }
    }
    /// The policy definition.
    public partial interface IPolicyDefinition :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>The policy definition description.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy definition description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The display name of the policy definition.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the policy definition.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The ID of the policy definition.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ID of the policy definition.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>
        /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Sample.API.Models.IAny) })]
        Sample.API.Models.IAny Metadata { get; set; }
        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        string Mode { get; set; }
        /// <summary>The name of the policy definition.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the policy definition.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The parameter definitions for parameters used in the policy rule. The keys are the parameter names.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Sample.API.Models.IParameterDefinitions) })]
        Sample.API.Models.IParameterDefinitions Parameters { get; set; }
        /// <summary>The policy rule.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy rule.",
        SerializedName = @"policyRule",
        PossibleTypes = new [] { typeof(Sample.API.Models.IAny) })]
        Sample.API.Models.IAny PolicyRule { get; set; }
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.",
        SerializedName = @"policyType",
        PossibleTypes = new [] { typeof(Sample.API.Support.PolicyType) })]
        Sample.API.Support.PolicyType? PolicyType { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Sample.API.Support.CreatedByType) })]
        Sample.API.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Sample.API.Support.CreatedByType) })]
        Sample.API.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the resource (Microsoft.Authorization/policyDefinitions).</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource (Microsoft.Authorization/policyDefinitions).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The policy definition.
    internal partial interface IPolicyDefinitionInternal

    {
        /// <summary>The policy definition description.</summary>
        string Description { get; set; }
        /// <summary>The display name of the policy definition.</summary>
        string DisplayName { get; set; }
        /// <summary>The ID of the policy definition.</summary>
        string Id { get; set; }
        /// <summary>
        /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        Sample.API.Models.IAny Metadata { get; set; }
        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        string Mode { get; set; }
        /// <summary>The name of the policy definition.</summary>
        string Name { get; set; }
        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        Sample.API.Models.IParameterDefinitions Parameters { get; set; }
        /// <summary>The policy rule.</summary>
        Sample.API.Models.IAny PolicyRule { get; set; }
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        Sample.API.Support.PolicyType? PolicyType { get; set; }
        /// <summary>The policy definition properties.</summary>
        Sample.API.Models.IPolicyDefinitionProperties Properties { get; set; }
        /// <summary>The system metadata relating to this resource.</summary>
        Sample.API.Models.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Sample.API.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Sample.API.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the resource (Microsoft.Authorization/policyDefinitions).</summary>
        string Type { get; set; }

    }
}