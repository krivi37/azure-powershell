// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Exchange operation result</summary>
    [System.ComponentModel.TypeConverter(typeof(ExchangeOperationResultResponseTypeConverter))]
    public partial class ExchangeOperationResultResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangeOperationResultResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExchangeOperationResultResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangeOperationResultResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExchangeOperationResultResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangeOperationResultResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExchangeOperationResultResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Properties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Properties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeResponseProperties) content.GetValueForProperty("Properties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Properties, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangeResponsePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IOperationResultError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.OperationResultErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ExchangeOperationResultStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ExchangeOperationResultStatus.CreateFrom);
            }
            if (content.Contains("PolicyResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResult = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangePolicyErrors) content.GetValueForProperty("PolicyResult",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResult, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangePolicyErrorsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SessionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).SessionId = (string) content.GetValueForProperty("SessionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).SessionId, global::System.Convert.ToString);
            }
            if (content.Contains("NetPayable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).NetPayable = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice) content.GetValueForProperty("NetPayable",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).NetPayable, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("RefundsTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).RefundsTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice) content.GetValueForProperty("RefundsTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).RefundsTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PurchasesTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PurchasesTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice) content.GetValueForProperty("PurchasesTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PurchasesTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservationsToPurchase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToPurchase = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToPurchaseExchange[]) content.GetValueForProperty("ReservationsToPurchase",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToPurchase, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToPurchaseExchange>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ReservationToPurchaseExchangeTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReservationsToExchange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToExchange = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToReturnForExchange[]) content.GetValueForProperty("ReservationsToExchange",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToExchange, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToReturnForExchange>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ReservationToReturnForExchangeTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyResultPolicyError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResultPolicyError = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangePolicyError[]) content.GetValueForProperty("PolicyResultPolicyError",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResultPolicyError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangePolicyError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangePolicyErrorTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangeOperationResultResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExchangeOperationResultResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Properties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Properties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeResponseProperties) content.GetValueForProperty("Properties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Properties, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangeResponsePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IOperationResultError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.OperationResultErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ExchangeOperationResultStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ExchangeOperationResultStatus.CreateFrom);
            }
            if (content.Contains("PolicyResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResult = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangePolicyErrors) content.GetValueForProperty("PolicyResult",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResult, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangePolicyErrorsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SessionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).SessionId = (string) content.GetValueForProperty("SessionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).SessionId, global::System.Convert.ToString);
            }
            if (content.Contains("NetPayable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).NetPayable = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice) content.GetValueForProperty("NetPayable",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).NetPayable, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("RefundsTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).RefundsTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice) content.GetValueForProperty("RefundsTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).RefundsTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PurchasesTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PurchasesTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPrice) content.GetValueForProperty("PurchasesTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PurchasesTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservationsToPurchase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToPurchase = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToPurchaseExchange[]) content.GetValueForProperty("ReservationsToPurchase",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToPurchase, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToPurchaseExchange>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ReservationToPurchaseExchangeTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReservationsToExchange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToExchange = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToReturnForExchange[]) content.GetValueForProperty("ReservationsToExchange",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).ReservationsToExchange, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToReturnForExchange>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ReservationToReturnForExchangeTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyResultPolicyError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResultPolicyError = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangePolicyError[]) content.GetValueForProperty("PolicyResultPolicyError",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponseInternal)this).PolicyResultPolicyError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangePolicyError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExchangePolicyErrorTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExchangeOperationResultResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ExchangeOperationResultResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExchangeOperationResultResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Exchange operation result
    [System.ComponentModel.TypeConverter(typeof(ExchangeOperationResultResponseTypeConverter))]
    public partial interface IExchangeOperationResultResponse

    {

    }
}