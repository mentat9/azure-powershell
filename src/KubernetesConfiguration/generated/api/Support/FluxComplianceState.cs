// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support
{

    /// <summary>Compliance state of the cluster object.</summary>
    public partial struct FluxComplianceState :
        System.IEquatable<FluxComplianceState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState Compliant = @"Compliant";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState NonCompliant = @"Non-Compliant";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState Pending = @"Pending";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState Suspended = @"Suspended";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState Unknown = @"Unknown";

        /// <summary>the value for an instance of the <see cref="FluxComplianceState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FluxComplianceState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FluxComplianceState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FluxComplianceState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FluxComplianceState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FluxComplianceState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FluxComplianceState && Equals((FluxComplianceState)obj);
        }

        /// <summary>Creates an instance of the <see cref="FluxComplianceState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FluxComplianceState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FluxComplianceState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FluxComplianceState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FluxComplianceState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FluxComplianceState" />.</param>

        public static implicit operator FluxComplianceState(string value)
        {
            return new FluxComplianceState(value);
        }

        /// <summary>Implicit operator to convert FluxComplianceState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FluxComplianceState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FluxComplianceState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState e1, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FluxComplianceState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState e1, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.FluxComplianceState e2)
        {
            return e2.Equals(e1);
        }
    }
}