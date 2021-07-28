namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Represents applicable recovery vm sizes.</summary>
    [System.ComponentModel.TypeConverter(typeof(TargetComputeSizeTypeConverter))]
    public partial class TargetComputeSize
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TargetComputeSize"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSize" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSize DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TargetComputeSize(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TargetComputeSize"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSize" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSize DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TargetComputeSize(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TargetComputeSize" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSize FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TargetComputeSize"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TargetComputeSize(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TargetComputeSizePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).PropertiesName = (string) content.GetValueForProperty("PropertiesName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).PropertiesName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).CpuCoresCount = (int?) content.GetValueForProperty("CpuCoresCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).CpuCoresCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).VCpUsAvailable = (int?) content.GetValueForProperty("VCpUsAvailable",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).VCpUsAvailable, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MemoryInGb = (double?) content.GetValueForProperty("MemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MemoryInGb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxDataDiskCount = (int?) content.GetValueForProperty("MaxDataDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxDataDiskCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxNicsCount = (int?) content.GetValueForProperty("MaxNicsCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxNicsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IComputeSizeErrorDetails[]) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Error, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IComputeSizeErrorDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ComputeSizeErrorDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HighIopsSupported = (string) content.GetValueForProperty("HighIopsSupported",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HighIopsSupported, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HyperVGeneration = (string[]) content.GetValueForProperty("HyperVGeneration",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HyperVGeneration, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TargetComputeSize"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TargetComputeSize(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TargetComputeSizePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).PropertiesName = (string) content.GetValueForProperty("PropertiesName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).PropertiesName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).CpuCoresCount = (int?) content.GetValueForProperty("CpuCoresCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).CpuCoresCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).VCpUsAvailable = (int?) content.GetValueForProperty("VCpUsAvailable",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).VCpUsAvailable, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MemoryInGb = (double?) content.GetValueForProperty("MemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MemoryInGb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxDataDiskCount = (int?) content.GetValueForProperty("MaxDataDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxDataDiskCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxNicsCount = (int?) content.GetValueForProperty("MaxNicsCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).MaxNicsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IComputeSizeErrorDetails[]) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).Error, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IComputeSizeErrorDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ComputeSizeErrorDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HighIopsSupported = (string) content.GetValueForProperty("HighIopsSupported",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HighIopsSupported, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HyperVGeneration = (string[]) content.GetValueForProperty("HyperVGeneration",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITargetComputeSizeInternal)this).HyperVGeneration, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents applicable recovery vm sizes.
    [System.ComponentModel.TypeConverter(typeof(TargetComputeSizeTypeConverter))]
    public partial interface ITargetComputeSize

    {

    }
}