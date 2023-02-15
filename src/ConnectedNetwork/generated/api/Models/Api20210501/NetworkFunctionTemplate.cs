// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>The network function template.</summary>
    public partial class NetworkFunctionTemplate :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplate,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplateInternal
    {

        /// <summary>Backing field for <see cref="NetworkFunctionRoleConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration[] _networkFunctionRoleConfiguration;

        /// <summary>An array of network function role definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration[] NetworkFunctionRoleConfiguration { get => this._networkFunctionRoleConfiguration; set => this._networkFunctionRoleConfiguration = value; }

        /// <summary>Creates an new <see cref="NetworkFunctionTemplate" /> instance.</summary>
        public NetworkFunctionTemplate()
        {

        }
    }
    /// The network function template.
    public partial interface INetworkFunctionTemplate :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>An array of network function role definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of network function role definitions.",
        SerializedName = @"networkFunctionRoleConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration[] NetworkFunctionRoleConfiguration { get; set; }

    }
    /// The network function template.
    internal partial interface INetworkFunctionTemplateInternal

    {
        /// <summary>An array of network function role definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration[] NetworkFunctionRoleConfiguration { get; set; }

    }
}