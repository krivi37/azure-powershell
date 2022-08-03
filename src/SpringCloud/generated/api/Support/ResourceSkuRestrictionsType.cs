// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support
{

    /// <summary>Gets the type of restrictions. Possible values include: 'Location', 'Zone'</summary>
    public partial struct ResourceSkuRestrictionsType :
        System.IEquatable<ResourceSkuRestrictionsType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType Location = @"Location";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType Zone = @"Zone";

        /// <summary>
        /// the value for an instance of the <see cref="ResourceSkuRestrictionsType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResourceSkuRestrictionsType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceSkuRestrictionsType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ResourceSkuRestrictionsType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResourceSkuRestrictionsType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResourceSkuRestrictionsType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResourceSkuRestrictionsType && Equals((ResourceSkuRestrictionsType)obj);
        }

        /// <summary>Returns hashCode for enum ResourceSkuRestrictionsType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="ResourceSkuRestrictionsType"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResourceSkuRestrictionsType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResourceSkuRestrictionsType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResourceSkuRestrictionsType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceSkuRestrictionsType" />.</param>

        public static implicit operator ResourceSkuRestrictionsType(string value)
        {
            return new ResourceSkuRestrictionsType(value);
        }

        /// <summary>Implicit operator to convert ResourceSkuRestrictionsType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResourceSkuRestrictionsType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResourceSkuRestrictionsType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType e1, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResourceSkuRestrictionsType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType e1, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ResourceSkuRestrictionsType e2)
        {
            return e2.Equals(e1);
        }
    }
}