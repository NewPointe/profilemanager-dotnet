//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NewPointe.ProfileManager.Structures.Generated
{
    public partial class Device : DevicePartial
    {
        [JsonProperty("BluetoothMAC")]
        public string BluetoothMac { get; set; }

        [JsonProperty("EthernetMAC")]
        public string EthernetMac { get; set; }

        [JsonProperty("IsSupervised")]
        public bool IsSupervised { get; set; }

        [JsonProperty("OSVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("WiFiMAC")]
        public string WiFiMac { get; set; }

        [JsonProperty("activation_lock_bypass_code")]
        public string ActivationLockBypassCode { get; set; }

        [JsonProperty("assigned_dep_profile_uuid")]
        public string AssignedDepProfileUuid { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("dep_profile")]
        public DepProfile DepProfile { get; set; }

        [JsonProperty("dep_profile_uuid")]
        public string DepProfileUuid { get; set; }

        [JsonProperty("first_push_time")]
        public DateTimeOffset? FirstPushTime { get; set; }

        [JsonProperty("hp_singleton_tasks")]
        public long HpSingletonTasks { get; set; }

        [JsonProperty("is_dep_enrolled")]
        public bool IsDepEnrolled { get; set; }

        [JsonProperty("is_shared_ipad")]
        public bool IsSharedIpad { get; set; }

        [JsonProperty("last_auto_sync_media")]
        public DateTimeOffset LastAutoSyncMedia { get; set; }

        [JsonProperty("last_auto_sync_profiles")]
        public DateTimeOffset LastAutoSyncProfiles { get; set; }

        [JsonProperty("last_mdm_refresh_ttl_days")]
        public long? LastMdmRefreshTtlDays { get; set; }

        [JsonProperty("last_push_time")]
        public DateTimeOffset LastPushTime { get; set; }

        [JsonProperty("last_update_info_time")]
        public DateTimeOffset LastUpdateInfoTime { get; set; }

        [JsonProperty("library_item_type")]
        public string LibraryItemType { get; set; }

        [JsonProperty("lp_singleton_tasks")]
        public long LpSingletonTasks { get; set; }

        [JsonProperty("mdm_acl")]
        public long MdmAcl { get; set; }

        [JsonProperty("mdm_activation_lock_bypass_code")]
        public string MdmActivationLockBypassCode { get; set; }

        [JsonProperty("nn_singleton_tasks")]
        public long NnSingletonTasks { get; set; }

        [JsonProperty("order_name")]
        public string OrderName { get; set; }

        [JsonProperty("os_version_int")]
        public long? OsVersionInt { get; set; }

        [JsonProperty("pending_is_dep_enrolled")]
        public bool PendingIsDepEnrolled { get; set; }

        [JsonProperty("pending_user_id")]
        public long? PendingUserId { get; set; }

        [JsonProperty("processing_tasks")]
        public bool ProcessingTasks { get; set; }

        [JsonProperty("push_avg_response_time")]
        public long? PushAvgResponseTime { get; set; }

        [JsonProperty("push_response_times")]
        public string PushResponseTimes { get; set; }

        [JsonProperty("singleton_task_type")]
        public long SingletonTaskType { get; set; }

        [JsonProperty("singleton_uuid")]
        public Guid? SingletonUuid { get; set; }

        [JsonProperty("supported_asset_types")]
        public long SupportedAssetTypes { get; set; }

        [JsonProperty("supported_device_type")]
        public long SupportedDeviceType { get; set; }

        [JsonProperty("updated_at_xid")]
        public long UpdatedAtXid { get; set; }

        [JsonProperty("has_FDE_PersonalRecoveryKeyCMS")]
        public bool? HasFdePersonalRecoveryKeyCms { get; set; }

        [JsonProperty("EASDeviceIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public string EasDeviceIdentifier { get; set; }

        [JsonProperty("OrganizationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public OrganizationInfo OrganizationInfo { get; set; }

        [JsonProperty("IsMDMLostModeEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMdmLostModeEnabled { get; set; }

        [JsonProperty("VoiceRoamingEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VoiceRoamingEnabled { get; set; }

        [JsonProperty("AvailableOSUpdates", NullValueHandling = NullValueHandling.Ignore)]
        public OsUpdate[] AvailableOsUpdates { get; set; }

        [JsonProperty("certificate_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public CertificateMetadatum[] CertificateMetadata { get; set; }

        [JsonProperty("GlobalRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public GlobalRestrictions GlobalRestrictions { get; set; }

        [JsonProperty("ProfileList", NullValueHandling = NullValueHandling.Ignore)]
        public ProfileList[] ProfileList { get; set; }

        [JsonProperty("SystemIntegrityProtectionEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SystemIntegrityProtectionEnabled { get; set; }

        [JsonProperty("Model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        [JsonProperty("ManagedApplicationList", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ManagedApplicationList> ManagedApplicationList { get; set; }

        [JsonProperty("AvailableDeviceCapacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableDeviceCapacity { get; set; }

        [JsonProperty("InstalledApplicationList", NullValueHandling = NullValueHandling.Ignore)]
        public InstalledApplicationList[] InstalledApplicationList { get; set; }

        [JsonProperty("DataRoamingEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DataRoamingEnabled { get; set; }

        [JsonProperty("IsActivationLockEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActivationLockEnabled { get; set; }

        [JsonProperty("DeviceCapacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? DeviceCapacity { get; set; }

        [JsonProperty("CertificateList", NullValueHandling = NullValueHandling.Ignore)]
        public CertificateList[] CertificateList { get; set; }

        [JsonProperty("IsDoNotDisturbInEffect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDoNotDisturbInEffect { get; set; }

        [JsonProperty("iTunesStoreAccountIsActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ITunesStoreAccountIsActive { get; set; }

        [JsonProperty("DEP_device_info", NullValueHandling = NullValueHandling.Ignore)]
        public DepDeviceInfo DepDeviceInfo { get; set; }

        [JsonProperty("IsRoaming", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRoaming { get; set; }

        [JsonProperty("ProfileRestrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, GlobalRestrictions> ProfileRestrictions { get; set; }

        [JsonProperty("IsDeviceLocatorServiceEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeviceLocatorServiceEnabled { get; set; }

        [JsonProperty("ModelName", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        [JsonProperty("SecurityInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityInfo SecurityInfo { get; set; }

        [JsonProperty("AppAnalyticsEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppAnalyticsEnabled { get; set; }

        [JsonProperty("OSUpdateStatus", NullValueHandling = NullValueHandling.Ignore)]
        public OsUpdateStatus[] OsUpdateStatus { get; set; }

        [JsonProperty("Books", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] Books { get; set; }

        [JsonProperty("IsCloudBackupEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCloudBackupEnabled { get; set; }

        [JsonProperty("CellularTechnology", NullValueHandling = NullValueHandling.Ignore)]
        public long? CellularTechnology { get; set; }

        [JsonProperty("BuildVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildVersion { get; set; }

        [JsonProperty("DiagnosticSubmissionEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiagnosticSubmissionEnabled { get; set; }

        [JsonProperty("BatteryLevel", NullValueHandling = NullValueHandling.Ignore)]
        public double? BatteryLevel { get; set; }

        [JsonProperty("os_updates")]
        public OsUpdate[] OsUpdates { get; set; }

        [JsonProperty("device_groups")]
        public long[] DeviceGroups { get; set; }

        [JsonProperty("owner_assignable")]
        public bool OwnerAssignable { get; set; }

        [JsonProperty("admin_accounts")]
        public string[] AdminAccounts { get; set; }

        [JsonProperty("device_cached_accounts")]
        public DeviceCachedAccount[] DeviceCachedAccounts { get; set; }

        [JsonProperty("enrollment_settings")]
        public EnrollmentSettings EnrollmentSettings { get; set; }

        [JsonProperty("vpp_user_id")]
        public dynamic VppUserId { get; set; }

        [JsonProperty("apps")]
        public App[] Apps { get; set; }

        [JsonProperty("app_data")]
        public AppData[] AppData { get; set; }

        [JsonProperty("books")]
        public dynamic[] DeviceBooks { get; set; }

        [JsonProperty("book_data")]
        public dynamic[] BookData { get; set; }

        [JsonProperty("managed_apps")]
        public long[] ManagedApps { get; set; }

        [JsonProperty("managed_books")]
        public dynamic[] ManagedBooks { get; set; }

        [JsonProperty("has_unlock_token")]
        public bool HasUnlockToken { get; set; }

        [JsonProperty("PhoneNumber")]
        public dynamic PhoneNumber { get; set; }

        [JsonProperty("ICCID")]
        public dynamic Iccid { get; set; }

        [JsonProperty("CurrentCarrierNetwork")]
        public dynamic CurrentCarrierNetwork { get; set; }

        [JsonProperty("CarrierSettingsVersion")]
        public dynamic CarrierSettingsVersion { get; set; }

        [JsonProperty("LocalHostName", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalHostName { get; set; }

        [JsonProperty("AutoSetupAdminAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public AutoSetupAdminAccount[] AutoSetupAdminAccounts { get; set; }

        [JsonProperty("HostName", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        [JsonProperty("CurrentConsoleManagedUser", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentConsoleManagedUser { get; set; }

        [JsonProperty("OSUpdateSettings", NullValueHandling = NullValueHandling.Ignore)]
        public OsUpdateSettings OsUpdateSettings { get; set; }

        [JsonProperty("iTunesStoreAccountHash", NullValueHandling = NullValueHandling.Ignore)]
        public string ITunesStoreAccountHash { get; set; }

        [JsonProperty("UserList", NullValueHandling = NullValueHandling.Ignore)]
        public UserList[] UserList { get; set; }

        [JsonProperty("ActiveManagedUsers", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ActiveManagedUsers { get; set; }

        [JsonProperty("osx_setup_assistant_config", NullValueHandling = NullValueHandling.Ignore)]
        public OsxSetupAssistantConfig OsxSetupAssistantConfig { get; set; }

        [JsonProperty("Challenge", NullValueHandling = NullValueHandling.Ignore)]
        public string Challenge { get; set; }

        [JsonProperty("LastCloudBackupDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastCloudBackupDate { get; set; }
    }

}
