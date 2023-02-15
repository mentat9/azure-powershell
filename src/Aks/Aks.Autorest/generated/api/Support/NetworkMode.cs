// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Support
{

    /// <summary>Network mode used for building Kubernetes network.</summary>
    public partial struct NetworkMode :
        System.IEquatable<NetworkMode>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode Bridge = @"bridge";

        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode Transparent = @"transparent";

        /// <summary>the value for an instance of the <see cref="NetworkMode" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to NetworkMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NetworkMode" />.</param>
        internal static object CreateFrom(object value)
        {
            return new NetworkMode(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type NetworkMode</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type NetworkMode (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is NetworkMode && Equals((NetworkMode)obj);
        }

        /// <summary>Returns hashCode for enum NetworkMode</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="NetworkMode"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private NetworkMode(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for NetworkMode</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to NetworkMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NetworkMode" />.</param>

        public static implicit operator NetworkMode(string value)
        {
            return new NetworkMode(value);
        }

        /// <summary>Implicit operator to convert NetworkMode to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="NetworkMode" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum NetworkMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum NetworkMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.NetworkMode e2)
        {
            return e2.Equals(e1);
        }
    }
}