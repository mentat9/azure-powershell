// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>The policy set definition properties.</summary>
    public partial class PolicySetDefinitionProperties :
        Sample.API.Models.IPolicySetDefinitionProperties,
        Sample.API.Models.IPolicySetDefinitionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The policy set definition description.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the policy set definition.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Sample.API.Models.IAny _metadata;

        /// <summary>
        /// The policy set definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Models.IAny Metadata { get => (this._metadata = this._metadata ?? new Sample.API.Models.Any()); set => this._metadata = value; }

        /// <summary>Backing field for <see cref="Parameters" /> property.</summary>
        private Sample.API.Models.IParameterDefinitions _parameters;

        /// <summary>
        /// The policy set definition parameters that can be used in policy definition references.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Models.IParameterDefinitions Parameters { get => (this._parameters = this._parameters ?? new Sample.API.Models.ParameterDefinitions()); set => this._parameters = value; }

        /// <summary>Backing field for <see cref="PolicyDefinitionGroups" /> property.</summary>
        private Sample.API.Models.IPolicyDefinitionGroup[] _policyDefinitionGroups;

        /// <summary>
        /// The metadata describing groups of policy definition references within the policy set definition.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Models.IPolicyDefinitionGroup[] PolicyDefinitionGroups { get => this._policyDefinitionGroups; set => this._policyDefinitionGroups = value; }

        /// <summary>Backing field for <see cref="PolicyDefinitions" /> property.</summary>
        private Sample.API.Models.IPolicyDefinitionReference[] _policyDefinitions;

        /// <summary>An array of policy definition references.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Models.IPolicyDefinitionReference[] PolicyDefinitions { get => this._policyDefinitions; set => this._policyDefinitions = value; }

        /// <summary>Backing field for <see cref="PolicyType" /> property.</summary>
        private Sample.API.Support.PolicyType? _policyType;

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Support.PolicyType? PolicyType { get => this._policyType; set => this._policyType = value; }

        /// <summary>Creates an new <see cref="PolicySetDefinitionProperties" /> instance.</summary>
        public PolicySetDefinitionProperties()
        {

        }
    }
    /// The policy set definition properties.
    public partial interface IPolicySetDefinitionProperties :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>The policy set definition description.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy set definition description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The display name of the policy set definition.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the policy set definition.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// The policy set definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy set definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Sample.API.Models.IAny) })]
        Sample.API.Models.IAny Metadata { get; set; }
        /// <summary>
        /// The policy set definition parameters that can be used in policy definition references.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy set definition parameters that can be used in policy definition references.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Sample.API.Models.IParameterDefinitions) })]
        Sample.API.Models.IParameterDefinitions Parameters { get; set; }
        /// <summary>
        /// The metadata describing groups of policy definition references within the policy set definition.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The metadata describing groups of policy definition references within the policy set definition.",
        SerializedName = @"policyDefinitionGroups",
        PossibleTypes = new [] { typeof(Sample.API.Models.IPolicyDefinitionGroup) })]
        Sample.API.Models.IPolicyDefinitionGroup[] PolicyDefinitionGroups { get; set; }
        /// <summary>An array of policy definition references.</summary>
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"An array of policy definition references.",
        SerializedName = @"policyDefinitions",
        PossibleTypes = new [] { typeof(Sample.API.Models.IPolicyDefinitionReference) })]
        Sample.API.Models.IPolicyDefinitionReference[] PolicyDefinitions { get; set; }
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

    }
    /// The policy set definition properties.
    internal partial interface IPolicySetDefinitionPropertiesInternal

    {
        /// <summary>The policy set definition description.</summary>
        string Description { get; set; }
        /// <summary>The display name of the policy set definition.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// The policy set definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        Sample.API.Models.IAny Metadata { get; set; }
        /// <summary>
        /// The policy set definition parameters that can be used in policy definition references.
        /// </summary>
        Sample.API.Models.IParameterDefinitions Parameters { get; set; }
        /// <summary>
        /// The metadata describing groups of policy definition references within the policy set definition.
        /// </summary>
        Sample.API.Models.IPolicyDefinitionGroup[] PolicyDefinitionGroups { get; set; }
        /// <summary>An array of policy definition references.</summary>
        Sample.API.Models.IPolicyDefinitionReference[] PolicyDefinitions { get; set; }
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        Sample.API.Support.PolicyType? PolicyType { get; set; }

    }
}