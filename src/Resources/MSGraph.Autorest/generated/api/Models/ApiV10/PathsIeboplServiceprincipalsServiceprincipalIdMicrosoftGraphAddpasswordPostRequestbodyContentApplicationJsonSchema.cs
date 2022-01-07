// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    public partial class PathsIeboplServiceprincipalsServiceprincipalIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IPathsIeboplServiceprincipalsServiceprincipalIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IPathsIeboplServiceprincipalsServiceprincipalIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="PasswordCredential" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential _passwordCredential;

        /// <summary>passwordCredential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential PasswordCredential { get => (this._passwordCredential = this._passwordCredential ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphPasswordCredential()); set => this._passwordCredential = value; }

        /// <summary>
        /// Creates an new <see cref="PathsIeboplServiceprincipalsServiceprincipalIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema"
        /// /> instance.
        /// </summary>
        public PathsIeboplServiceprincipalsServiceprincipalIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsIeboplServiceprincipalsServiceprincipalIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>passwordCredential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"passwordCredential",
        SerializedName = @"passwordCredential",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential PasswordCredential { get; set; }

    }
    internal partial interface IPathsIeboplServiceprincipalsServiceprincipalIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchemaInternal

    {
        /// <summary>passwordCredential</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential PasswordCredential { get; set; }

    }
}