// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Filters to list items that can be backed up.
    /// </summary>
    public partial class BMSWorkloadItemQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BMSWorkloadItemQueryObject class.
        /// </summary>
        public BMSWorkloadItemQueryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BMSWorkloadItemQueryObject class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type. Possible
        /// values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
        /// 'DefaultBackup'</param>
        /// <param name="workloadItemType">Workload Item type. Possible values
        /// include: 'Invalid', 'SQLInstance', 'SQLDataBase', 'SAPHanaSystem',
        /// 'SAPHanaDatabase', 'SAPAseSystem', 'SAPAseDatabase',
        /// 'SAPHanaDBInstance'</param>
        /// <param name="workloadType">Workload type. Possible values include:
        /// 'Invalid', 'VM', 'FileFolder', 'AzureSqlDb', 'SQLDB', 'Exchange',
        /// 'Sharepoint', 'VMwareVM', 'SystemState', 'Client',
        /// 'GenericDataSource', 'SQLDataBase', 'AzureFileShare',
        /// 'SAPHanaDatabase', 'SAPAseDatabase', 'SAPHanaDBInstance'</param>
        /// <param name="protectionStatus">Backup status query parameter.
        /// Possible values include: 'Invalid', 'NotProtected', 'Protecting',
        /// 'Protected', 'ProtectionFailed'</param>
        public BMSWorkloadItemQueryObject(string backupManagementType = default(string), string workloadItemType = default(string), string workloadType = default(string), string protectionStatus = default(string))
        {
            BackupManagementType = backupManagementType;
            WorkloadItemType = workloadItemType;
            WorkloadType = workloadType;
            ProtectionStatus = protectionStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup management type. Possible values include:
        /// 'Invalid', 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql', 'AzureStorage', 'AzureWorkload', 'DefaultBackup'
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets workload Item type. Possible values include:
        /// 'Invalid', 'SQLInstance', 'SQLDataBase', 'SAPHanaSystem',
        /// 'SAPHanaDatabase', 'SAPAseSystem', 'SAPAseDatabase',
        /// 'SAPHanaDBInstance'
        /// </summary>
        [JsonProperty(PropertyName = "workloadItemType")]
        public string WorkloadItemType { get; set; }

        /// <summary>
        /// Gets or sets workload type. Possible values include: 'Invalid',
        /// 'VM', 'FileFolder', 'AzureSqlDb', 'SQLDB', 'Exchange',
        /// 'Sharepoint', 'VMwareVM', 'SystemState', 'Client',
        /// 'GenericDataSource', 'SQLDataBase', 'AzureFileShare',
        /// 'SAPHanaDatabase', 'SAPAseDatabase', 'SAPHanaDBInstance'
        /// </summary>
        [JsonProperty(PropertyName = "workloadType")]
        public string WorkloadType { get; set; }

        /// <summary>
        /// Gets or sets backup status query parameter. Possible values
        /// include: 'Invalid', 'NotProtected', 'Protecting', 'Protected',
        /// 'ProtectionFailed'
        /// </summary>
        [JsonProperty(PropertyName = "protectionStatus")]
        public string ProtectionStatus { get; set; }

    }
}
