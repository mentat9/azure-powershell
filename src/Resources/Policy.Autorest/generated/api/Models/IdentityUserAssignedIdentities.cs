// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.498)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>
    /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
    /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    /// </summary>
    public partial class IdentityUserAssignedIdentities :
        Sample.API.Models.IIdentityUserAssignedIdentities,
        Sample.API.Models.IIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="IdentityUserAssignedIdentities" /> instance.</summary>
        public IdentityUserAssignedIdentities()
        {

        }
    }
    /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
    /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    public partial interface IIdentityUserAssignedIdentities :
        Sample.API.Runtime.IJsonSerializable,
        Sample.API.Runtime.IAssociativeArray<Sample.API.Models.IUserAssignedIdentitiesValue>
    {

    }
    /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
    /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    internal partial interface IIdentityUserAssignedIdentitiesInternal

    {

    }
}