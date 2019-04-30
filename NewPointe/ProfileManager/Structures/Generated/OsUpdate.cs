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
    public partial class OsUpdate
    {
        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("AllowsInstallLater", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowsInstallLater { get; set; }

        [JsonProperty("Build", NullValueHandling = NullValueHandling.Ignore)]
        public string Build { get; set; }

        [JsonProperty("IsCritical", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCritical { get; set; }

        [JsonProperty("RestartRequired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartRequired { get; set; }

        [JsonProperty("InstallSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstallSize { get; set; }

        [JsonProperty("ProductKey")]
        public string ProductKey { get; set; }

        [JsonProperty("ProductName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        [JsonProperty("DownloadSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? DownloadSize { get; set; }

        [JsonProperty("HumanReadableName", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanReadableName { get; set; }

        [JsonProperty("IsFirmwareUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFirmwareUpdate { get; set; }

        [JsonProperty("MetadataURL", NullValueHandling = NullValueHandling.Ignore)]
        public Uri MetadataUrl { get; set; }

        [JsonProperty("IsConfigDataUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConfigDataUpdate { get; set; }

        [JsonProperty("AppIdentifiersToClose", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] AppIdentifiersToClose { get; set; }

        [JsonProperty("HumanReadableNameLocale", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanReadableNameLocale { get; set; }

        [JsonProperty("IsMajorOSUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMajorOsUpdate { get; set; }

        [JsonProperty("ApplicableDevicesCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? ApplicableDevicesCount { get; set; }

        [JsonProperty("DeferredDevicesCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeferredDevicesCount { get; set; }

        [JsonProperty("DeferredUntil", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DeferredUntil { get; set; }

        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }

}