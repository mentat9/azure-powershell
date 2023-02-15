// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Extensions;

    /// <summary>Response for the ListTrafficCollectors API service call.</summary>
    public partial class AzureTrafficCollectorListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorListResult,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector[] _value;

        /// <summary>A list of Traffic Collector resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AzureTrafficCollectorListResult" /> instance.</summary>
        public AzureTrafficCollectorListResult()
        {

        }
    }
    /// Response for the ListTrafficCollectors API service call.
    public partial interface IAzureTrafficCollectorListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URL to get the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>A list of Traffic Collector resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of Traffic Collector resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector[] Value { get; set; }

    }
    /// Response for the ListTrafficCollectors API service call.
    internal partial interface IAzureTrafficCollectorListResultInternal

    {
        /// <summary>The URL to get the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>A list of Traffic Collector resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector[] Value { get; set; }

    }
}