// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>Pricing information about the SKU</summary>
    public partial class CatalogMsrp :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICatalogMsrp,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICatalogMsrpInternal
    {

        /// <summary>Backing field for <see cref="P1Y" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice _p1Y;

        /// <summary>Amount in pricing currency. Tax not included.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice P1Y { get => (this._p1Y = this._p1Y ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.Price()); set => this._p1Y = value; }

        /// <summary>Creates an new <see cref="CatalogMsrp" /> instance.</summary>
        public CatalogMsrp()
        {

        }
    }
    /// Pricing information about the SKU
    public partial interface ICatalogMsrp :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>Amount in pricing currency. Tax not included.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Amount in pricing currency. Tax not included.",
        SerializedName = @"p1Y",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice P1Y { get; set; }

    }
    /// Pricing information about the SKU
    internal partial interface ICatalogMsrpInternal

    {
        /// <summary>Amount in pricing currency. Tax not included.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice P1Y { get; set; }

    }
}