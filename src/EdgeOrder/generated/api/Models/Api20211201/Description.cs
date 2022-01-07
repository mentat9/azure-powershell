// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Description related properties of a product system.</summary>
    public partial class Description :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescription,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescriptionInternal
    {

        /// <summary>Backing field for <see cref="Attribute" /> property.</summary>
        private string[] _attribute;

        /// <summary>Attributes for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string[] Attribute { get => this._attribute; }

        /// <summary>Backing field for <see cref="Keyword" /> property.</summary>
        private string[] _keyword;

        /// <summary>Keywords for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string[] Keyword { get => this._keyword; }

        /// <summary>Backing field for <see cref="Link" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] _link;

        /// <summary>Links for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] Link { get => this._link; }

        /// <summary>Backing field for <see cref="LongDescription" /> property.</summary>
        private string _longDescription;

        /// <summary>Long description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string LongDescription { get => this._longDescription; }

        /// <summary>Internal Acessors for Attribute</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescriptionInternal.Attribute { get => this._attribute; set { {_attribute = value;} } }

        /// <summary>Internal Acessors for Keyword</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescriptionInternal.Keyword { get => this._keyword; set { {_keyword = value;} } }

        /// <summary>Internal Acessors for Link</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescriptionInternal.Link { get => this._link; set { {_link = value;} } }

        /// <summary>Internal Acessors for LongDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescriptionInternal.LongDescription { get => this._longDescription; set { {_longDescription = value;} } }

        /// <summary>Internal Acessors for ShortDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescriptionInternal.ShortDescription { get => this._shortDescription; set { {_shortDescription = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescriptionInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="ShortDescription" /> property.</summary>
        private string _shortDescription;

        /// <summary>Short description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string ShortDescription { get => this._shortDescription; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? _type;

        /// <summary>Type of description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? Type { get => this._type; }

        /// <summary>Creates an new <see cref="Description" /> instance.</summary>
        public Description()
        {

        }
    }
    /// Description related properties of a product system.
    public partial interface IDescription :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Attributes for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Attributes for the product system.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(string) })]
        string[] Attribute { get;  }
        /// <summary>Keywords for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Keywords for the product system.",
        SerializedName = @"keywords",
        PossibleTypes = new [] { typeof(string) })]
        string[] Keyword { get;  }
        /// <summary>Links for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Links for the product system.",
        SerializedName = @"links",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] Link { get;  }
        /// <summary>Long description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Long description of the product system.",
        SerializedName = @"longDescription",
        PossibleTypes = new [] { typeof(string) })]
        string LongDescription { get;  }
        /// <summary>Short description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Short description of the product system.",
        SerializedName = @"shortDescription",
        PossibleTypes = new [] { typeof(string) })]
        string ShortDescription { get;  }
        /// <summary>Type of description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Type of description.",
        SerializedName = @"descriptionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? Type { get;  }

    }
    /// Description related properties of a product system.
    internal partial interface IDescriptionInternal

    {
        /// <summary>Attributes for the product system.</summary>
        string[] Attribute { get; set; }
        /// <summary>Keywords for the product system.</summary>
        string[] Keyword { get; set; }
        /// <summary>Links for the product system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] Link { get; set; }
        /// <summary>Long description of the product system.</summary>
        string LongDescription { get; set; }
        /// <summary>Short description of the product system.</summary>
        string ShortDescription { get; set; }
        /// <summary>Type of description.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? Type { get; set; }

    }
}