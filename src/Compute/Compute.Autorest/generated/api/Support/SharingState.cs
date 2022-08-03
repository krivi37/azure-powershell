// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Support
{

    /// <summary>The sharing state of the gallery, which only appears in the response.</summary>
    public partial struct SharingState :
        System.IEquatable<SharingState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState InProgress = @"InProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState Unknown = @"Unknown";

        /// <summary>the value for an instance of the <see cref="SharingState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SharingState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SharingState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SharingState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SharingState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SharingState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SharingState && Equals((SharingState)obj);
        }

        /// <summary>Returns hashCode for enum SharingState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SharingState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SharingState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SharingState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SharingState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SharingState" />.</param>

        public static implicit operator SharingState(string value)
        {
            return new SharingState(value);
        }

        /// <summary>Implicit operator to convert SharingState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SharingState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SharingState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState e1, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SharingState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState e1, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState e2)
        {
            return e2.Equals(e1);
        }
    }
}