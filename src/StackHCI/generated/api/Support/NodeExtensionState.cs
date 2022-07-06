// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support
{

    /// <summary>State of Arc Extension in this node.</summary>
    public partial struct NodeExtensionState :
        System.IEquatable<NodeExtensionState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Connected = @"Connected";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Deleted = @"Deleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Disconnected = @"Disconnected";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Error = @"Error";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Moving = @"Moving";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState Updating = @"Updating";

        /// <summary>the value for an instance of the <see cref="NodeExtensionState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to NodeExtensionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NodeExtensionState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new NodeExtensionState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type NodeExtensionState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type NodeExtensionState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is NodeExtensionState && Equals((NodeExtensionState)obj);
        }

        /// <summary>Returns hashCode for enum NodeExtensionState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="NodeExtensionState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private NodeExtensionState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for NodeExtensionState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to NodeExtensionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NodeExtensionState" />.</param>

        public static implicit operator NodeExtensionState(string value)
        {
            return new NodeExtensionState(value);
        }

        /// <summary>Implicit operator to convert NodeExtensionState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="NodeExtensionState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum NodeExtensionState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState e1, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum NodeExtensionState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState e1, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.NodeExtensionState e2)
        {
            return e2.Equals(e1);
        }
    }
}