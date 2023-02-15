// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>An app cloneability criterion.</summary>
    public partial class SiteCloneabilityCriterion :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISiteCloneabilityCriterion,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISiteCloneabilityCriterionInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of criterion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of criterion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="SiteCloneabilityCriterion" /> instance.</summary>
        public SiteCloneabilityCriterion()
        {

        }
    }
    /// An app cloneability criterion.
    public partial interface ISiteCloneabilityCriterion :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        /// <summary>Description of criterion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of criterion.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Name of criterion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of criterion.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// An app cloneability criterion.
    internal partial interface ISiteCloneabilityCriterionInternal

    {
        /// <summary>Description of criterion.</summary>
        string Description { get; set; }
        /// <summary>Name of criterion.</summary>
        string Name { get; set; }

    }
}