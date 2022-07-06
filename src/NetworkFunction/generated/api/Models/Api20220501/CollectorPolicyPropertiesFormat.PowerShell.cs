// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.PowerShell;

    /// <summary>Collection policy properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(CollectorPolicyPropertiesFormatTypeConverter))]
    public partial class CollectorPolicyPropertiesFormat
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicyPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CollectorPolicyPropertiesFormat(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IngestionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionPolicyPropertiesFormat) content.GetValueForProperty("IngestionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicy, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IngestionPolicyPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("EmissionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).EmissionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat[]) content.GetValueForProperty("EmissionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).EmissionPolicy, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.EmissionPoliciesPropertiesFormatTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("IngestionPolicyIngestionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType?) content.GetValueForProperty("IngestionPolicyIngestionType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType.CreateFrom);
            }
            if (content.Contains("IngestionPolicyIngestionSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionSource = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat[]) content.GetValueForProperty("IngestionPolicyIngestionSource",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionSource, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IngestionSourcesPropertiesFormatTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicyPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CollectorPolicyPropertiesFormat(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IngestionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionPolicyPropertiesFormat) content.GetValueForProperty("IngestionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicy, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IngestionPolicyPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("EmissionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).EmissionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat[]) content.GetValueForProperty("EmissionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).EmissionPolicy, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.EmissionPoliciesPropertiesFormatTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("IngestionPolicyIngestionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType?) content.GetValueForProperty("IngestionPolicyIngestionType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType.CreateFrom);
            }
            if (content.Contains("IngestionPolicyIngestionSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionSource = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat[]) content.GetValueForProperty("IngestionPolicyIngestionSource",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)this).IngestionPolicyIngestionSource, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IngestionSourcesPropertiesFormatTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicyPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CollectorPolicyPropertiesFormat(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicyPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CollectorPolicyPropertiesFormat(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CollectorPolicyPropertiesFormat" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CollectorPolicyPropertiesFormat" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Collection policy properties.
    [System.ComponentModel.TypeConverter(typeof(CollectorPolicyPropertiesFormatTypeConverter))]
    public partial interface ICollectorPolicyPropertiesFormat

    {

    }
}