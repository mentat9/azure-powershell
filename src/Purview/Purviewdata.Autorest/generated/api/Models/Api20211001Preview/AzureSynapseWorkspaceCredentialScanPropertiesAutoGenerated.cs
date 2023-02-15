// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class AzureSynapseWorkspaceCredentialScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSynapseWorkspaceCredentialScanPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSynapseWorkspaceCredentialScanPropertiesAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanProperties __expandingResourceScanProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ExpandingResourceScanProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).Collection = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CollectionLastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CollectionReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CollectionReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CollectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CollectionType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IConnectedVia ConnectedVia { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ConnectedVia; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ConnectedVia = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ConnectedViaReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ConnectedViaReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ConnectedViaReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference Credential { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).Credential; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).Credential = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CredentialReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).CredentialReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).CredentialReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType? CredentialType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).CredentialType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).CredentialType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType)""); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).LastModifiedAt; }

        /// <summary>Internal Acessors for CollectionLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CollectionLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CollectionLastModifiedAt = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).CreatedAt = value; }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).LastModifiedAt = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesResourceTypes ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal)__expandingResourceScanProperties).ResourceType = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ScanRulesetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ScanRulesetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ScanRulesetName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType? ScanRulesetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ScanRulesetType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).ScanRulesetType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType)""); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public int? Worker { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).Worker; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__expandingResourceScanProperties).Worker = value ?? default(int); }

        /// <summary>
        /// Creates an new <see cref="AzureSynapseWorkspaceCredentialScanPropertiesAutoGenerated" /> instance.
        /// </summary>
        public AzureSynapseWorkspaceCredentialScanPropertiesAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__expandingResourceScanProperties), __expandingResourceScanProperties);
            await eventListener.AssertObjectIsValid(nameof(__expandingResourceScanProperties), __expandingResourceScanProperties);
        }
    }
    public partial interface IAzureSynapseWorkspaceCredentialScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanProperties
    {

    }
    internal partial interface IAzureSynapseWorkspaceCredentialScanPropertiesAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesInternal
    {

    }
}