// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    public partial class IdentityUserAssignedIdentities :
        Sample.API.Runtime.IAssociativeArray<Sample.API.Models.IUserAssignedIdentitiesValue>
    {
        protected global::System.Collections.Generic.Dictionary<global::System.String,Sample.API.Models.IUserAssignedIdentitiesValue> __additionalProperties = new global::System.Collections.Generic.Dictionary<global::System.String,Sample.API.Models.IUserAssignedIdentitiesValue>();

        global::System.Collections.Generic.IDictionary<global::System.String,Sample.API.Models.IUserAssignedIdentitiesValue> Sample.API.Runtime.IAssociativeArray<Sample.API.Models.IUserAssignedIdentitiesValue>.AdditionalProperties { get => __additionalProperties; }

        int Sample.API.Runtime.IAssociativeArray<Sample.API.Models.IUserAssignedIdentitiesValue>.Count { get => __additionalProperties.Count; }

        global::System.Collections.Generic.IEnumerable<global::System.String> Sample.API.Runtime.IAssociativeArray<Sample.API.Models.IUserAssignedIdentitiesValue>.Keys { get => __additionalProperties.Keys; }

        global::System.Collections.Generic.IEnumerable<Sample.API.Models.IUserAssignedIdentitiesValue> Sample.API.Runtime.IAssociativeArray<Sample.API.Models.IUserAssignedIdentitiesValue>.Values { get => __additionalProperties.Values; }

        public Sample.API.Models.IUserAssignedIdentitiesValue this[global::System.String index] { get => __additionalProperties[index]; set => __additionalProperties[index] = value; }

        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(global::System.String key, Sample.API.Models.IUserAssignedIdentitiesValue value) => __additionalProperties.Add( key, value);

        public void Clear() => __additionalProperties.Clear();

        /// <param name="key"></param>
        public bool ContainsKey(global::System.String key) => __additionalProperties.ContainsKey( key);

        /// <param name="source"></param>
        public void CopyFrom(global::System.Collections.IDictionary source)
        {
            if (null != source)
            {
                foreach( var property in  Sample.API.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<Sample.API.Models.IUserAssignedIdentitiesValue>( property.Value));
                    }
                }
            }
        }

        /// <param name="source"></param>
        public void CopyFrom(global::System.Management.Automation.PSObject source)
        {
            if (null != source)
            {
                foreach( var property in  Sample.API.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<Sample.API.Models.IUserAssignedIdentitiesValue>( property.Value));
                    }
                }
            }
        }

        /// <param name="key"></param>
        public bool Remove(global::System.String key) => __additionalProperties.Remove( key);

        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool TryGetValue(global::System.String key, out Sample.API.Models.IUserAssignedIdentitiesValue value) => __additionalProperties.TryGetValue( key, out value);

        /// <param name="source"></param>

        public static implicit operator global::System.Collections.Generic.Dictionary<global::System.String,Sample.API.Models.IUserAssignedIdentitiesValue>(Sample.API.Models.IdentityUserAssignedIdentities source) => source.__additionalProperties;
    }
}