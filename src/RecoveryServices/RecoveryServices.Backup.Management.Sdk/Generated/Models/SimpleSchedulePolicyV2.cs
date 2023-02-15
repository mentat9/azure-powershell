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
    /// The V2 policy schedule for IaaS that supports hourly backups.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SimpleSchedulePolicyV2")]
    public partial class SimpleSchedulePolicyV2 : SchedulePolicy
    {
        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicyV2 class.
        /// </summary>
        public SimpleSchedulePolicyV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicyV2 class.
        /// </summary>
        /// <param name="scheduleRunFrequency">Frequency of the schedule
        /// operation of this policy. Possible values include: 'Invalid',
        /// 'Daily', 'Weekly', 'Hourly'</param>
        /// <param name="hourlySchedule">hourly schedule of this policy</param>
        /// <param name="dailySchedule">Daily schedule of this policy</param>
        /// <param name="weeklySchedule">Weekly schedule of this policy</param>
        public SimpleSchedulePolicyV2(string scheduleRunFrequency = default(string), HourlySchedule hourlySchedule = default(HourlySchedule), DailySchedule dailySchedule = default(DailySchedule), WeeklySchedule weeklySchedule = default(WeeklySchedule))
        {
            ScheduleRunFrequency = scheduleRunFrequency;
            HourlySchedule = hourlySchedule;
            DailySchedule = dailySchedule;
            WeeklySchedule = weeklySchedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frequency of the schedule operation of this policy.
        /// Possible values include: 'Invalid', 'Daily', 'Weekly', 'Hourly'
        /// </summary>
        [JsonProperty(PropertyName = "scheduleRunFrequency")]
        public string ScheduleRunFrequency { get; set; }

        /// <summary>
        /// Gets or sets hourly schedule of this policy
        /// </summary>
        [JsonProperty(PropertyName = "hourlySchedule")]
        public HourlySchedule HourlySchedule { get; set; }

        /// <summary>
        /// Gets or sets daily schedule of this policy
        /// </summary>
        [JsonProperty(PropertyName = "dailySchedule")]
        public DailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Gets or sets weekly schedule of this policy
        /// </summary>
        [JsonProperty(PropertyName = "weeklySchedule")]
        public WeeklySchedule WeeklySchedule { get; set; }

    }
}
