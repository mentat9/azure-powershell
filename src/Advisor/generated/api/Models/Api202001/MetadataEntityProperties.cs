// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Extensions;

    /// <summary>The metadata entity properties</summary>
    public partial class MetadataEntityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IMetadataEntityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IMetadataEntityPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApplicableScenario" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Scenario[] _applicableScenario;

        /// <summary>The list of scenarios applicable to this metadata entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Scenario[] ApplicableScenario { get => this._applicableScenario; set => this._applicableScenario = value; }

        /// <summary>Backing field for <see cref="DependsOn" /> property.</summary>
        private string[] _dependsOn;

        /// <summary>The list of keys on which this entity depends on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string[] DependsOn { get => this._dependsOn; set => this._dependsOn = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="SupportedValue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IMetadataSupportedValueDetail[] _supportedValue;

        /// <summary>The list of supported values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IMetadataSupportedValueDetail[] SupportedValue { get => this._supportedValue; set => this._supportedValue = value; }

        /// <summary>Creates an new <see cref="MetadataEntityProperties" /> instance.</summary>
        public MetadataEntityProperties()
        {

        }
    }
    /// The metadata entity properties
    public partial interface IMetadataEntityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.IJsonSerializable
    {
        /// <summary>The list of scenarios applicable to this metadata entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of scenarios applicable to this metadata entity.",
        SerializedName = @"applicableScenarios",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Scenario) })]
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Scenario[] ApplicableScenario { get; set; }
        /// <summary>The list of keys on which this entity depends on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of keys on which this entity depends on.",
        SerializedName = @"dependsOn",
        PossibleTypes = new [] { typeof(string) })]
        string[] DependsOn { get; set; }
        /// <summary>The display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The list of supported values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of supported values.",
        SerializedName = @"supportedValues",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IMetadataSupportedValueDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IMetadataSupportedValueDetail[] SupportedValue { get; set; }

    }
    /// The metadata entity properties
    internal partial interface IMetadataEntityPropertiesInternal

    {
        /// <summary>The list of scenarios applicable to this metadata entity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.Scenario[] ApplicableScenario { get; set; }
        /// <summary>The list of keys on which this entity depends on.</summary>
        string[] DependsOn { get; set; }
        /// <summary>The display name.</summary>
        string DisplayName { get; set; }
        /// <summary>The list of supported values.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IMetadataSupportedValueDetail[] SupportedValue { get; set; }

    }
}