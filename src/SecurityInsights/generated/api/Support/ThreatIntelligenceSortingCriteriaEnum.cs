// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>Sorting order (ascending/descending/unsorted).</summary>
    public partial struct ThreatIntelligenceSortingCriteriaEnum :
        System.IEquatable<ThreatIntelligenceSortingCriteriaEnum>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum Ascending = @"ascending";

        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum Descending = @"descending";

        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum Unsorted = @"unsorted";

        /// <summary>
        /// the value for an instance of the <see cref="ThreatIntelligenceSortingCriteriaEnum" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ThreatIntelligenceSortingCriteriaEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ThreatIntelligenceSortingCriteriaEnum" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ThreatIntelligenceSortingCriteriaEnum(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ThreatIntelligenceSortingCriteriaEnum</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type ThreatIntelligenceSortingCriteriaEnum (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ThreatIntelligenceSortingCriteriaEnum && Equals((ThreatIntelligenceSortingCriteriaEnum)obj);
        }

        /// <summary>Returns hashCode for enum ThreatIntelligenceSortingCriteriaEnum</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="ThreatIntelligenceSortingCriteriaEnum"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ThreatIntelligenceSortingCriteriaEnum(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ThreatIntelligenceSortingCriteriaEnum</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ThreatIntelligenceSortingCriteriaEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ThreatIntelligenceSortingCriteriaEnum" />.</param>

        public static implicit operator ThreatIntelligenceSortingCriteriaEnum(string value)
        {
            return new ThreatIntelligenceSortingCriteriaEnum(value);
        }

        /// <summary>Implicit operator to convert ThreatIntelligenceSortingCriteriaEnum to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ThreatIntelligenceSortingCriteriaEnum" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ThreatIntelligenceSortingCriteriaEnum</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ThreatIntelligenceSortingCriteriaEnum</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ThreatIntelligenceSortingCriteriaEnum e2)
        {
            return e2.Equals(e1);
        }
    }
}