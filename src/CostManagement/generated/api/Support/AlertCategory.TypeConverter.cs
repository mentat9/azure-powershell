// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>Alert category</summary>
    public partial class AlertCategoryTypeConverter :
        global::System.Management.Automation.PSTypeConverter
    {

        /// <summary>
        /// Determines if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType"
        /// /> parameter.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType"
        /// /> parameter, otherwise <c>false</c>.
        /// </returns>
        public override bool CanConvertFrom(object sourceValue, global::System.Type destinationType) => true;

        /// <summary>
        /// Determines if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType"
        /// /> parameter.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType"
        /// /> parameter, otherwise <c>false</c>.
        /// </returns>
        public override bool CanConvertTo(object sourceValue, global::System.Type destinationType) => false;

        /// <summary>
        /// Converts the <paramref name="sourceValue" /> parameter to the <paramref name="destinationType" /> parameter using <paramref
        /// name="formatProvider" /> and <paramref name="ignoreCase" />
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>
        /// an instance of <see cref="AlertCategory" />, or <c>null</c> if there is no suitable conversion.
        /// </returns>
        public override object ConvertFrom(object sourceValue, global::System.Type destinationType, global::System.IFormatProvider formatProvider, bool ignoreCase) => AlertCategory.CreateFrom(sourceValue);

        /// <summary>NotImplemented -- this will return <c>null</c></summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>will always return <c>null</c>.</returns>
        public override object ConvertTo(object sourceValue, global::System.Type destinationType, global::System.IFormatProvider formatProvider, bool ignoreCase) => null;
    }
}