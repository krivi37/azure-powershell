namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>InMageRcmFailback protected disk details.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageRcmFailbackProtectedDiskDetailsTypeConverter))]
    public partial class InMageRcmFailbackProtectedDiskDetails
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageRcmFailbackProtectedDiskDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageRcmFailbackProtectedDiskDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageRcmFailbackProtectedDiskDetails" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageRcmFailbackProtectedDiskDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails) content.GetValueForProperty("IrDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails) content.GetValueForProperty("ResyncDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskName = (string) content.GetValueForProperty("DiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsOSDisk = (string) content.GetValueForProperty("IsOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsOSDisk, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).CapacityInByte = (long?) content.GetValueForProperty("CapacityInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).CapacityInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskUuid = (string) content.GetValueForProperty("DiskUuid",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskUuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingInLogDataStoreInMb = (double?) content.GetValueForProperty("DataPendingInLogDataStoreInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingInLogDataStoreInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingAtSourceAgentInMb = (double?) content.GetValueForProperty("DataPendingAtSourceAgentInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingAtSourceAgentInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsInitialReplicationComplete = (string) content.GetValueForProperty("IsInitialReplicationComplete",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsInitialReplicationComplete, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).LastSyncTime = (global::System.DateTime?) content.GetValueForProperty("LastSyncTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).LastSyncTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth?) content.GetValueForProperty("IrDetailProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailTransferredByte = (long?) content.GetValueForProperty("IrDetailTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLast15MinutesTransferredByte = (long?) content.GetValueForProperty("IrDetailLast15MinutesTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLast15MinutesTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastDataTransferTimeUtc = (string) content.GetValueForProperty("IrDetailLastDataTransferTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastDataTransferTimeUtc, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProcessedByte = (long?) content.GetValueForProperty("IrDetailProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailStartTime = (string) content.GetValueForProperty("IrDetailStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailStartTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastRefreshTime = (string) content.GetValueForProperty("IrDetailLastRefreshTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastRefreshTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressPercentage = (int?) content.GetValueForProperty("IrDetailProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth?) content.GetValueForProperty("ResyncDetailProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailTransferredByte = (long?) content.GetValueForProperty("ResyncDetailTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLast15MinutesTransferredByte = (long?) content.GetValueForProperty("ResyncDetailLast15MinutesTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLast15MinutesTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastDataTransferTimeUtc = (string) content.GetValueForProperty("ResyncDetailLastDataTransferTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastDataTransferTimeUtc, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProcessedByte = (long?) content.GetValueForProperty("ResyncDetailProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailStartTime = (string) content.GetValueForProperty("ResyncDetailStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailStartTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastRefreshTime = (string) content.GetValueForProperty("ResyncDetailLastRefreshTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastRefreshTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressPercentage = (int?) content.GetValueForProperty("ResyncDetailProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageRcmFailbackProtectedDiskDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails) content.GetValueForProperty("IrDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails) content.GetValueForProperty("ResyncDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskName = (string) content.GetValueForProperty("DiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsOSDisk = (string) content.GetValueForProperty("IsOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsOSDisk, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).CapacityInByte = (long?) content.GetValueForProperty("CapacityInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).CapacityInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskUuid = (string) content.GetValueForProperty("DiskUuid",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DiskUuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingInLogDataStoreInMb = (double?) content.GetValueForProperty("DataPendingInLogDataStoreInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingInLogDataStoreInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingAtSourceAgentInMb = (double?) content.GetValueForProperty("DataPendingAtSourceAgentInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).DataPendingAtSourceAgentInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsInitialReplicationComplete = (string) content.GetValueForProperty("IsInitialReplicationComplete",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IsInitialReplicationComplete, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).LastSyncTime = (global::System.DateTime?) content.GetValueForProperty("LastSyncTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).LastSyncTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth?) content.GetValueForProperty("IrDetailProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailTransferredByte = (long?) content.GetValueForProperty("IrDetailTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLast15MinutesTransferredByte = (long?) content.GetValueForProperty("IrDetailLast15MinutesTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLast15MinutesTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastDataTransferTimeUtc = (string) content.GetValueForProperty("IrDetailLastDataTransferTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastDataTransferTimeUtc, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProcessedByte = (long?) content.GetValueForProperty("IrDetailProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailStartTime = (string) content.GetValueForProperty("IrDetailStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailStartTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastRefreshTime = (string) content.GetValueForProperty("IrDetailLastRefreshTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailLastRefreshTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressPercentage = (int?) content.GetValueForProperty("IrDetailProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).IrDetailProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth?) content.GetValueForProperty("ResyncDetailProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailTransferredByte = (long?) content.GetValueForProperty("ResyncDetailTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLast15MinutesTransferredByte = (long?) content.GetValueForProperty("ResyncDetailLast15MinutesTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLast15MinutesTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastDataTransferTimeUtc = (string) content.GetValueForProperty("ResyncDetailLastDataTransferTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastDataTransferTimeUtc, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProcessedByte = (long?) content.GetValueForProperty("ResyncDetailProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailStartTime = (string) content.GetValueForProperty("ResyncDetailStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailStartTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastRefreshTime = (string) content.GetValueForProperty("ResyncDetailLastRefreshTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailLastRefreshTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressPercentage = (int?) content.GetValueForProperty("ResyncDetailProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal)this).ResyncDetailProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMageRcmFailback protected disk details.
    [System.ComponentModel.TypeConverter(typeof(InMageRcmFailbackProtectedDiskDetailsTypeConverter))]
    public partial interface IInMageRcmFailbackProtectedDiskDetails

    {

    }
}