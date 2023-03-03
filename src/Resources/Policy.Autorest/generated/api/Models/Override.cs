// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>The policy property value override.</summary>
    public partial class Override :
        Sample.API.Models.IOverride,
        Sample.API.Models.IOverrideInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Sample.API.Support.OverrideKind? _kind;

        /// <summary>The override kind.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Support.OverrideKind? Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Backing field for <see cref="Selectors" /> property.</summary>
        private Sample.API.Models.ISelector[] _selectors;

        /// <summary>The list of the selector expressions.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Models.ISelector[] Selectors { get => this._selectors; set => this._selectors = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value to override the policy property.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="Override" /> instance.</summary>
        public Override()
        {

        }
    }
    /// The policy property value override.
    public partial interface IOverride :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>The override kind.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The override kind.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Sample.API.Support.OverrideKind) })]
        Sample.API.Support.OverrideKind? Kind { get; set; }
        /// <summary>The list of the selector expressions.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the selector expressions.",
        SerializedName = @"selectors",
        PossibleTypes = new [] { typeof(Sample.API.Models.ISelector) })]
        Sample.API.Models.ISelector[] Selectors { get; set; }
        /// <summary>The value to override the policy property.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value to override the policy property.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// The policy property value override.
    internal partial interface IOverrideInternal

    {
        /// <summary>The override kind.</summary>
        Sample.API.Support.OverrideKind? Kind { get; set; }
        /// <summary>The list of the selector expressions.</summary>
        Sample.API.Models.ISelector[] Selectors { get; set; }
        /// <summary>The value to override the policy property.</summary>
        string Value { get; set; }

    }
}