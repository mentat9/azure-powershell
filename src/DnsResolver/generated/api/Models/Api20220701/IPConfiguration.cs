// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    /// <summary>IP configuration.</summary>
    public partial class IPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.IIPConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.IIPConfigurationInternal
    {

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.ISubResource Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.IIPConfigurationInternal.Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.SubResource()); set { {_subnet = value;} } }

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private string _privateIPAddress;

        /// <summary>Private IP address of the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public string PrivateIPAddress { get => this._privateIPAddress; set => this._privateIPAddress = value; }

        /// <summary>Backing field for <see cref="PrivateIPAllocationMethod" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.IPAllocationMethod? _privateIPAllocationMethod;

        /// <summary>Private IP address allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.IPAllocationMethod? PrivateIPAllocationMethod { get => this._privateIPAllocationMethod; set => this._privateIPAllocationMethod = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.ISubResource _subnet;

        /// <summary>The reference to the subnet bound to the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.ISubResource Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.SubResource()); set => this._subnet = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.ISubResourceInternal)Subnet).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.ISubResourceInternal)Subnet).Id = value ; }

        /// <summary>Creates an new <see cref="IPConfiguration" /> instance.</summary>
        public IPConfiguration()
        {

        }
    }
    /// IP configuration.
    public partial interface IIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IJsonSerializable
    {
        /// <summary>Private IP address of the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Private IP address of the IP configuration.",
        SerializedName = @"privateIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddress { get; set; }
        /// <summary>Private IP address allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Private IP address allocation method.",
        SerializedName = @"privateIpAllocationMethod",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.IPAllocationMethod) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }

    }
    /// IP configuration.
    internal partial interface IIPConfigurationInternal

    {
        /// <summary>Private IP address of the IP configuration.</summary>
        string PrivateIPAddress { get; set; }
        /// <summary>Private IP address allocation method.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary>The reference to the subnet bound to the IP configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20220701.ISubResource Subnet { get; set; }
        /// <summary>Resource ID.</summary>
        string SubnetId { get; set; }

    }
}