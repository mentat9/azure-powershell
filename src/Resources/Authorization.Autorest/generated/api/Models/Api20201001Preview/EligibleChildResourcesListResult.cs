// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Extensions;

    /// <summary>Eligible child resources list operation result.</summary>
    public partial class EligibleChildResourcesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResourcesListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResourcesListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResource[] _value;

        /// <summary>Eligible child resource list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="EligibleChildResourcesListResult" /> instance.</summary>
        public EligibleChildResourcesListResult()
        {

        }
    }
    /// Eligible child resources list operation result.
    public partial interface IEligibleChildResourcesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to use for getting the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Eligible child resource list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Eligible child resource list.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResource[] Value { get; set; }

    }
    /// Eligible child resources list operation result.
    internal partial interface IEligibleChildResourcesListResultInternal

    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>Eligible child resource list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResource[] Value { get; set; }

    }
}