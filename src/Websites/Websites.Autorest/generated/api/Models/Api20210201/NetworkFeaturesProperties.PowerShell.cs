// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.PowerShell;

    /// <summary>NetworkFeatures resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkFeaturesPropertiesTypeConverter))]
    public partial class NetworkFeaturesProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NetworkFeaturesProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NetworkFeaturesProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NetworkFeaturesProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NetworkFeaturesProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NetworkFeaturesProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualNetworkConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IVnetInfo) content.GetValueForProperty("VirtualNetworkConnection",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.VnetInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualNetworkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName = (string) content.GetValueForProperty("VirtualNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName, global::System.Convert.ToString);
            }
            if (content.Contains("HybridConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnection = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRelayServiceConnectionEntity[]) content.GetValueForProperty("HybridConnection",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRelayServiceConnectionEntity>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RelayServiceConnectionEntityTypeConverter.ConvertFrom));
            }
            if (content.Contains("HybridConnectionsV2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2 = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IHybridConnection[]) content.GetValueForProperty("HybridConnectionsV2",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IHybridConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.HybridConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualNetworkConnectionVnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionVnetResourceId = (string) content.GetValueForProperty("VirtualNetworkConnectionVnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionVnetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionCertThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertThumbprint = (string) content.GetValueForProperty("VirtualNetworkConnectionCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionCertBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertBlob = (string) content.GetValueForProperty("VirtualNetworkConnectionCertBlob",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertBlob, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionRoute = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IVnetRoute[]) content.GetValueForProperty("VirtualNetworkConnectionRoute",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionRoute, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IVnetRoute>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.VnetRouteTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualNetworkConnectionResyncRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionResyncRequired = (bool?) content.GetValueForProperty("VirtualNetworkConnectionResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualNetworkConnectionDnsServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionDnsServer = (string) content.GetValueForProperty("VirtualNetworkConnectionDnsServer",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionDnsServer, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionIsSwift"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionIsSwift = (bool?) content.GetValueForProperty("VirtualNetworkConnectionIsSwift",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionIsSwift, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NetworkFeaturesProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualNetworkConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IVnetInfo) content.GetValueForProperty("VirtualNetworkConnection",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.VnetInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualNetworkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName = (string) content.GetValueForProperty("VirtualNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName, global::System.Convert.ToString);
            }
            if (content.Contains("HybridConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnection = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRelayServiceConnectionEntity[]) content.GetValueForProperty("HybridConnection",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRelayServiceConnectionEntity>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RelayServiceConnectionEntityTypeConverter.ConvertFrom));
            }
            if (content.Contains("HybridConnectionsV2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2 = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IHybridConnection[]) content.GetValueForProperty("HybridConnectionsV2",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IHybridConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.HybridConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualNetworkConnectionVnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionVnetResourceId = (string) content.GetValueForProperty("VirtualNetworkConnectionVnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionVnetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionCertThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertThumbprint = (string) content.GetValueForProperty("VirtualNetworkConnectionCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionCertBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertBlob = (string) content.GetValueForProperty("VirtualNetworkConnectionCertBlob",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionCertBlob, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionRoute = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IVnetRoute[]) content.GetValueForProperty("VirtualNetworkConnectionRoute",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionRoute, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IVnetRoute>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.VnetRouteTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualNetworkConnectionResyncRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionResyncRequired = (bool?) content.GetValueForProperty("VirtualNetworkConnectionResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualNetworkConnectionDnsServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionDnsServer = (string) content.GetValueForProperty("VirtualNetworkConnectionDnsServer",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionDnsServer, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkConnectionIsSwift"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionIsSwift = (bool?) content.GetValueForProperty("VirtualNetworkConnectionIsSwift",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionIsSwift, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// NetworkFeatures resource specific properties
    [System.ComponentModel.TypeConverter(typeof(NetworkFeaturesPropertiesTypeConverter))]
    public partial interface INetworkFeaturesProperties

    {

    }
}