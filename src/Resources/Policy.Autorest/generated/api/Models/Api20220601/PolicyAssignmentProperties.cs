// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>The policy assignment properties.</summary>
    public partial class PolicyAssignmentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.IPolicyAssignmentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.IPolicyAssignmentPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>This message will be part of response in case of policy violation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the policy assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="EnforcementMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.EnforcementMode? _enforcementMode;

        /// <summary>
        /// The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.EnforcementMode? EnforcementMode { get => this._enforcementMode; set => this._enforcementMode = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny _metadata;

        /// <summary>
        /// The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Any()); set => this._metadata = value; }

        /// <summary>Internal Acessors for Scope</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.IPolicyAssignmentPropertiesInternal.Scope { get => this._scope; set { {_scope = value;} } }

        /// <summary>Backing field for <see cref="NonComplianceMessage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.INonComplianceMessage[] _nonComplianceMessage;

        /// <summary>The messages that describe why a resource is non-compliant with the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.INonComplianceMessage[] NonComplianceMessage { get => this._nonComplianceMessage; set => this._nonComplianceMessage = value; }

        /// <summary>Backing field for <see cref="NotScope" /> property.</summary>
        private string[] _notScope;

        /// <summary>The policy's excluded scopes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string[] NotScope { get => this._notScope; set => this._notScope = value; }

        /// <summary>Backing field for <see cref="Override" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IOverride[] _override;

        /// <summary>The policy property value override.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IOverride[] Override { get => this._override; set => this._override = value; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterValues _parameter;

        /// <summary>
        /// The parameter values for the assigned policy rule. The keys are the parameter names.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterValues Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.ParameterValues()); set => this._parameter = value; }

        /// <summary>Backing field for <see cref="PolicyDefinitionId" /> property.</summary>
        private string _policyDefinitionId;

        /// <summary>The ID of the policy definition or policy set definition being assigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string PolicyDefinitionId { get => this._policyDefinitionId; set => this._policyDefinitionId = value; }

        /// <summary>Backing field for <see cref="ResourceSelector" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[] _resourceSelector;

        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[] ResourceSelector { get => this._resourceSelector; set => this._resourceSelector = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The scope for the policy assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; }

        /// <summary>Creates an new <see cref="PolicyAssignmentProperties" /> instance.</summary>
        public PolicyAssignmentProperties()
        {

        }
    }
    /// The policy assignment properties.
    public partial interface IPolicyAssignmentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable
    {
        /// <summary>This message will be part of response in case of policy violation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This message will be part of response in case of policy violation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The display name of the policy assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the policy assignment.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.",
        SerializedName = @"enforcementMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.EnforcementMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.EnforcementMode? EnforcementMode { get; set; }
        /// <summary>
        /// The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny Metadata { get; set; }
        /// <summary>The messages that describe why a resource is non-compliant with the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The messages that describe why a resource is non-compliant with the policy.",
        SerializedName = @"nonComplianceMessages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.INonComplianceMessage) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.INonComplianceMessage[] NonComplianceMessage { get; set; }
        /// <summary>The policy's excluded scopes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy's excluded scopes.",
        SerializedName = @"notScopes",
        PossibleTypes = new [] { typeof(string) })]
        string[] NotScope { get; set; }
        /// <summary>The policy property value override.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The policy property value override.",
        SerializedName = @"overrides",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IOverride) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IOverride[] Override { get; set; }
        /// <summary>
        /// The parameter values for the assigned policy rule. The keys are the parameter names.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The parameter values for the assigned policy rule. The keys are the parameter names.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterValues) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterValues Parameter { get; set; }
        /// <summary>The ID of the policy definition or policy set definition being assigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the policy definition or policy set definition being assigned.",
        SerializedName = @"policyDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyDefinitionId { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource selector list to filter policies by resource properties.",
        SerializedName = @"resourceSelectors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[] ResourceSelector { get; set; }
        /// <summary>The scope for the policy assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The scope for the policy assignment.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get;  }

    }
    /// The policy assignment properties.
    internal partial interface IPolicyAssignmentPropertiesInternal

    {
        /// <summary>This message will be part of response in case of policy violation.</summary>
        string Description { get; set; }
        /// <summary>The display name of the policy assignment.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.EnforcementMode? EnforcementMode { get; set; }
        /// <summary>
        /// The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny Metadata { get; set; }
        /// <summary>The messages that describe why a resource is non-compliant with the policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.INonComplianceMessage[] NonComplianceMessage { get; set; }
        /// <summary>The policy's excluded scopes.</summary>
        string[] NotScope { get; set; }
        /// <summary>The policy property value override.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IOverride[] Override { get; set; }
        /// <summary>
        /// The parameter values for the assigned policy rule. The keys are the parameter names.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterValues Parameter { get; set; }
        /// <summary>The ID of the policy definition or policy set definition being assigned.</summary>
        string PolicyDefinitionId { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[] ResourceSelector { get; set; }
        /// <summary>The scope for the policy assignment.</summary>
        string Scope { get; set; }

    }
}