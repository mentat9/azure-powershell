// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>settings for security policy patterns to match</summary>
    public partial class SecurityPolicyWebApplicationFirewallAssociation :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyWebApplicationFirewallAssociation,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyWebApplicationFirewallAssociationInternal
    {

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IActivatedResourceReference[] _domain;

        /// <summary>List of domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IActivatedResourceReference[] Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Backing field for <see cref="PatternsToMatch" /> property.</summary>
        private string[] _patternsToMatch;

        /// <summary>List of paths</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string[] PatternsToMatch { get => this._patternsToMatch; set => this._patternsToMatch = value; }

        /// <summary>
        /// Creates an new <see cref="SecurityPolicyWebApplicationFirewallAssociation" /> instance.
        /// </summary>
        public SecurityPolicyWebApplicationFirewallAssociation()
        {

        }
    }
    /// settings for security policy patterns to match
    public partial interface ISecurityPolicyWebApplicationFirewallAssociation :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>List of domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of domains.",
        SerializedName = @"domains",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IActivatedResourceReference) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IActivatedResourceReference[] Domain { get; set; }
        /// <summary>List of paths</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of paths",
        SerializedName = @"patternsToMatch",
        PossibleTypes = new [] { typeof(string) })]
        string[] PatternsToMatch { get; set; }

    }
    /// settings for security policy patterns to match
    internal partial interface ISecurityPolicyWebApplicationFirewallAssociationInternal

    {
        /// <summary>List of domains.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IActivatedResourceReference[] Domain { get; set; }
        /// <summary>List of paths</summary>
        string[] PatternsToMatch { get; set; }

    }
}