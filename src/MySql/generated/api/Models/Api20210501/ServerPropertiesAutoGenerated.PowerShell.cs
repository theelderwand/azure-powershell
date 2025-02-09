// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell;

    /// <summary>The properties of a server.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesAutoGeneratedTypeConverter))]
    public partial class ServerPropertiesAutoGenerated
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerPropertiesAutoGenerated" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerPropertiesAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.StorageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IBackup) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.BackupTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IHighAvailability) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.HighAvailabilityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Network = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.INetwork) content.GetValueForProperty("Network",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Network, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.NetworkTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.MaintenanceWindowTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin = (string) content.GetValueForProperty("AdministratorLogin",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Version = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerVersion?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Version, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).CreateMode = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreateMode?) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).CreateMode, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreateMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).SourceServerResourceId = (string) content.GetValueForProperty("SourceServerResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).SourceServerResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).RestorePointInTime = (global::System.DateTime?) content.GetValueForProperty("RestorePointInTime",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).RestorePointInTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicationRole = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole?) content.GetValueForProperty("ReplicationRole",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicationRole, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicaCapacity = (int?) content.GetValueForProperty("ReplicaCapacity",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicaCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName = (string) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageIop = (int?) content.GetValueForProperty("StorageIop",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageIop, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityMode = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode?) content.GetValueForProperty("HighAvailabilityMode",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityMode, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityState = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState?) content.GetValueForProperty("HighAvailabilityState",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityState, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSizeGb = (int?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageAutoGrow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("StorageAutoGrow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageAutoGrow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupRetentionDay = (int?) content.GetValueForProperty("BackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupGeoRedundantBackup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("BackupGeoRedundantBackup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupGeoRedundantBackup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupEarliestRestoreDate = (global::System.DateTime?) content.GetValueForProperty("BackupEarliestRestoreDate",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupEarliestRestoreDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityStandbyAvailabilityZone = (string) content.GetValueForProperty("HighAvailabilityStandbyAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityStandbyAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("NetworkPublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkDelegatedSubnetResourceId = (string) content.GetValueForProperty("NetworkDelegatedSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkDelegatedSubnetResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPrivateDnsZoneResourceId = (string) content.GetValueForProperty("NetworkPrivateDnsZoneResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPrivateDnsZoneResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerPropertiesAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.StorageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IBackup) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.BackupTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IHighAvailability) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.HighAvailabilityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Network = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.INetwork) content.GetValueForProperty("Network",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Network, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.NetworkTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.MaintenanceWindowTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin = (string) content.GetValueForProperty("AdministratorLogin",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLogin, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Version = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerVersion?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).Version, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).AvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).CreateMode = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreateMode?) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).CreateMode, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreateMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).SourceServerResourceId = (string) content.GetValueForProperty("SourceServerResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).SourceServerResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).RestorePointInTime = (global::System.DateTime?) content.GetValueForProperty("RestorePointInTime",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).RestorePointInTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicationRole = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole?) content.GetValueForProperty("ReplicationRole",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicationRole, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicaCapacity = (int?) content.GetValueForProperty("ReplicaCapacity",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).ReplicaCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ServerState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName = (string) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).FullyQualifiedDomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageIop = (int?) content.GetValueForProperty("StorageIop",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageIop, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityMode = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode?) content.GetValueForProperty("HighAvailabilityMode",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityMode, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityState = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState?) content.GetValueForProperty("HighAvailabilityState",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityState, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSizeGb = (int?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageAutoGrow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("StorageAutoGrow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).StorageAutoGrow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupRetentionDay = (int?) content.GetValueForProperty("BackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupGeoRedundantBackup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("BackupGeoRedundantBackup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupGeoRedundantBackup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupEarliestRestoreDate = (global::System.DateTime?) content.GetValueForProperty("BackupEarliestRestoreDate",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).BackupEarliestRestoreDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityStandbyAvailabilityZone = (string) content.GetValueForProperty("HighAvailabilityStandbyAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).HighAvailabilityStandbyAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("NetworkPublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkDelegatedSubnetResourceId = (string) content.GetValueForProperty("NetworkDelegatedSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkDelegatedSubnetResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPrivateDnsZoneResourceId = (string) content.GetValueForProperty("NetworkPrivateDnsZoneResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).NetworkPrivateDnsZoneResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGeneratedInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties of a server.
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesAutoGeneratedTypeConverter))]
    public partial interface IServerPropertiesAutoGenerated

    {

    }
}