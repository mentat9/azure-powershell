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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WeekOfMonth.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WeekOfMonth
    {
        [EnumMember(Value = "First")]
        First,
        [EnumMember(Value = "Second")]
        Second,
        [EnumMember(Value = "Third")]
        Third,
        [EnumMember(Value = "Fourth")]
        Fourth,
        [EnumMember(Value = "Last")]
        Last,
        [EnumMember(Value = "Invalid")]
        Invalid
    }
    internal static class WeekOfMonthEnumExtension
    {
        internal static string ToSerializedValue(this WeekOfMonth? value)
        {
            return value == null ? null : ((WeekOfMonth)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WeekOfMonth value)
        {
            switch( value )
            {
                case WeekOfMonth.First:
                    return "First";
                case WeekOfMonth.Second:
                    return "Second";
                case WeekOfMonth.Third:
                    return "Third";
                case WeekOfMonth.Fourth:
                    return "Fourth";
                case WeekOfMonth.Last:
                    return "Last";
                case WeekOfMonth.Invalid:
                    return "Invalid";
            }
            return null;
        }

        internal static WeekOfMonth? ParseWeekOfMonth(this string value)
        {
            switch( value )
            {
                case "First":
                    return WeekOfMonth.First;
                case "Second":
                    return WeekOfMonth.Second;
                case "Third":
                    return WeekOfMonth.Third;
                case "Fourth":
                    return WeekOfMonth.Fourth;
                case "Last":
                    return WeekOfMonth.Last;
                case "Invalid":
                    return WeekOfMonth.Invalid;
            }
            return null;
        }
    }
}
