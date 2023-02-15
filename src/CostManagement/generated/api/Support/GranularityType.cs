// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>The granularity of rows in the forecast.</summary>
    public partial struct GranularityType :
        System.IEquatable<GranularityType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType Daily = @"Daily";

        /// <summary>the value for an instance of the <see cref="GranularityType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to GranularityType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GranularityType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new GranularityType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type GranularityType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type GranularityType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is GranularityType && Equals((GranularityType)obj);
        }

        /// <summary>Returns hashCode for enum GranularityType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="GranularityType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private GranularityType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for GranularityType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to GranularityType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GranularityType" />.</param>

        public static implicit operator GranularityType(string value)
        {
            return new GranularityType(value);
        }

        /// <summary>Implicit operator to convert GranularityType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="GranularityType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum GranularityType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum GranularityType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType e2)
        {
            return e2.Equals(e1);
        }
    }
}