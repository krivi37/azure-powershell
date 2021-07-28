namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>InMage protected disk details.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageProtectedDiskDetailsTypeConverter))]
    public partial class InMageProtectedDiskDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageProtectedDiskDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageProtectedDiskDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageProtectedDiskDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageProtectedDiskDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskName = (string) content.GetValueForProperty("DiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProtectionStage = (string) content.GetValueForProperty("ProtectionStage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProtectionStage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).HealthErrorCode = (string) content.GetValueForProperty("HealthErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).HealthErrorCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).RpoInSecond = (long?) content.GetValueForProperty("RpoInSecond",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).RpoInSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncRequired = (string) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncRequired, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProgressPercentage = (int?) content.GetValueForProperty("ResyncProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncDurationInSecond = (long?) content.GetValueForProperty("ResyncDurationInSecond",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncDurationInSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskCapacityInByte = (long?) content.GetValueForProperty("DiskCapacityInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskCapacityInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).FileSystemCapacityInByte = (long?) content.GetValueForProperty("FileSystemCapacityInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).FileSystemCapacityInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).SourceDataInMb = (double?) content.GetValueForProperty("SourceDataInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).SourceDataInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).PsDataInMb = (double?) content.GetValueForProperty("PsDataInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).PsDataInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).TargetDataInMb = (double?) content.GetValueForProperty("TargetDataInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).TargetDataInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskResized = (string) content.GetValueForProperty("DiskResized",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskResized, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).LastRpoCalculatedTime = (global::System.DateTime?) content.GetValueForProperty("LastRpoCalculatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).LastRpoCalculatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProcessedByte = (long?) content.GetValueForProperty("ResyncProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncTotalTransferredByte = (long?) content.GetValueForProperty("ResyncTotalTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncTotalTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLast15MinutesTransferredByte = (long?) content.GetValueForProperty("ResyncLast15MinutesTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLast15MinutesTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLastDataTransferTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ResyncLastDataTransferTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLastDataTransferTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncStartTime = (global::System.DateTime?) content.GetValueForProperty("ResyncStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressHealth = (string) content.GetValueForProperty("ProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressHealth, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressStatus = (string) content.GetValueForProperty("ProgressStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressStatus, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageProtectedDiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageProtectedDiskDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskName = (string) content.GetValueForProperty("DiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProtectionStage = (string) content.GetValueForProperty("ProtectionStage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProtectionStage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).HealthErrorCode = (string) content.GetValueForProperty("HealthErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).HealthErrorCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).RpoInSecond = (long?) content.GetValueForProperty("RpoInSecond",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).RpoInSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncRequired = (string) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncRequired, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProgressPercentage = (int?) content.GetValueForProperty("ResyncProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncDurationInSecond = (long?) content.GetValueForProperty("ResyncDurationInSecond",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncDurationInSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskCapacityInByte = (long?) content.GetValueForProperty("DiskCapacityInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskCapacityInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).FileSystemCapacityInByte = (long?) content.GetValueForProperty("FileSystemCapacityInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).FileSystemCapacityInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).SourceDataInMb = (double?) content.GetValueForProperty("SourceDataInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).SourceDataInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).PsDataInMb = (double?) content.GetValueForProperty("PsDataInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).PsDataInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).TargetDataInMb = (double?) content.GetValueForProperty("TargetDataInMb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).TargetDataInMb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskResized = (string) content.GetValueForProperty("DiskResized",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).DiskResized, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).LastRpoCalculatedTime = (global::System.DateTime?) content.GetValueForProperty("LastRpoCalculatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).LastRpoCalculatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProcessedByte = (long?) content.GetValueForProperty("ResyncProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncTotalTransferredByte = (long?) content.GetValueForProperty("ResyncTotalTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncTotalTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLast15MinutesTransferredByte = (long?) content.GetValueForProperty("ResyncLast15MinutesTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLast15MinutesTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLastDataTransferTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ResyncLastDataTransferTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncLastDataTransferTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncStartTime = (global::System.DateTime?) content.GetValueForProperty("ResyncStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ResyncStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressHealth = (string) content.GetValueForProperty("ProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressHealth, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressStatus = (string) content.GetValueForProperty("ProgressStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal)this).ProgressStatus, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMage protected disk details.
    [System.ComponentModel.TypeConverter(typeof(InMageProtectedDiskDetailsTypeConverter))]
    public partial interface IInMageProtectedDiskDetails

    {

    }
}