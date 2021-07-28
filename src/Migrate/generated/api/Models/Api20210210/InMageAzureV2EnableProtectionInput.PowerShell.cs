namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>VMware Azure specific enable protection input.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageAzureV2EnableProtectionInputTypeConverter))]
    public partial class InMageAzureV2EnableProtectionInput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageAzureV2EnableProtectionInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageAzureV2EnableProtectionInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageAzureV2EnableProtectionInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageAzureV2EnableProtectionInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MasterTargetId = (string) content.GetValueForProperty("MasterTargetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MasterTargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).ProcessServerId = (string) content.GetValueForProperty("ProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).ProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).RunAsAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupId = (string) content.GetValueForProperty("MultiVMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DisksToInclude = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails[]) content.GetValueForProperty("DisksToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DisksToInclude, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2DiskInputDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureNetworkId = (string) content.GetValueForProperty("TargetAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureSubnetId = (string) content.GetValueForProperty("TargetAzureSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).EnableRdpOnTargetOption = (string) content.GetValueForProperty("EnableRdpOnTargetOption",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).EnableRdpOnTargetOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureVMName = (string) content.GetValueForProperty("TargetAzureVMName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureVMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LogStorageAccountId = (string) content.GetValueForProperty("LogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LogStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV1ResourceGroupId = (string) content.GetValueForProperty("TargetAzureV1ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV1ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV2ResourceGroupId = (string) content.GetValueForProperty("TargetAzureV2ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV2ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilitySetId = (string) content.GetValueForProperty("TargetAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilitySetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilityZone = (string) content.GetValueForProperty("TargetAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetProximityPlacementGroupId = (string) content.GetValueForProperty("TargetProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetProximityPlacementGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType?) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SqlServerLicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType?) content.GetValueForProperty("SqlServerLicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SqlServerLicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMSize = (string) content.GetValueForProperty("TargetVMSize",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskEncryptionSetId = (string) content.GetValueForProperty("DiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskEncryptionSetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags) content.GetValueForProperty("TargetVMTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetVMTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SeedManagedDiskTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputSeedManagedDiskTags) content.GetValueForProperty("SeedManagedDiskTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SeedManagedDiskTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputSeedManagedDiskTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetManagedDiskTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetManagedDiskTags) content.GetValueForProperty("TargetManagedDiskTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetManagedDiskTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetManagedDiskTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetNicTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags) content.GetValueForProperty("TargetNicTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetNicTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetNicTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageAzureV2EnableProtectionInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MasterTargetId = (string) content.GetValueForProperty("MasterTargetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MasterTargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).ProcessServerId = (string) content.GetValueForProperty("ProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).ProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).RunAsAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupId = (string) content.GetValueForProperty("MultiVMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DisksToInclude = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails[]) content.GetValueForProperty("DisksToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DisksToInclude, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2DiskInputDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureNetworkId = (string) content.GetValueForProperty("TargetAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureSubnetId = (string) content.GetValueForProperty("TargetAzureSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).EnableRdpOnTargetOption = (string) content.GetValueForProperty("EnableRdpOnTargetOption",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).EnableRdpOnTargetOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureVMName = (string) content.GetValueForProperty("TargetAzureVMName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureVMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LogStorageAccountId = (string) content.GetValueForProperty("LogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LogStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV1ResourceGroupId = (string) content.GetValueForProperty("TargetAzureV1ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV1ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV2ResourceGroupId = (string) content.GetValueForProperty("TargetAzureV2ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAzureV2ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilitySetId = (string) content.GetValueForProperty("TargetAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilitySetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilityZone = (string) content.GetValueForProperty("TargetAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetProximityPlacementGroupId = (string) content.GetValueForProperty("TargetProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetProximityPlacementGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType?) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).LicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SqlServerLicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType?) content.GetValueForProperty("SqlServerLicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SqlServerLicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMSize = (string) content.GetValueForProperty("TargetVMSize",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskEncryptionSetId = (string) content.GetValueForProperty("DiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).DiskEncryptionSetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags) content.GetValueForProperty("TargetVMTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetVMTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetVMTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SeedManagedDiskTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputSeedManagedDiskTags) content.GetValueForProperty("SeedManagedDiskTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).SeedManagedDiskTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputSeedManagedDiskTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetManagedDiskTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetManagedDiskTags) content.GetValueForProperty("TargetManagedDiskTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetManagedDiskTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetManagedDiskTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetNicTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags) content.GetValueForProperty("TargetNicTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal)this).TargetNicTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetNicTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// VMware Azure specific enable protection input.
    [System.ComponentModel.TypeConverter(typeof(InMageAzureV2EnableProtectionInputTypeConverter))]
    public partial interface IInMageAzureV2EnableProtectionInput

    {

    }
}