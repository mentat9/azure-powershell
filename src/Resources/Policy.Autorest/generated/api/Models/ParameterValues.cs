// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>The parameter values for the policy rule. The keys are the parameter names.</summary>
    public partial class ParameterValues :
        Sample.API.Models.IParameterValues,
        Sample.API.Models.IParameterValuesInternal
    {

        /// <summary>Creates an new <see cref="ParameterValues" /> instance.</summary>
        public ParameterValues()
        {

        }
    }
    /// The parameter values for the policy rule. The keys are the parameter names.
    public partial interface IParameterValues :
        Sample.API.Runtime.IJsonSerializable,
        Sample.API.Runtime.IAssociativeArray<Sample.API.Models.IParameterValuesValue>
    {

    }
    /// The parameter values for the policy rule. The keys are the parameter names.
    internal partial interface IParameterValuesInternal

    {

    }
}