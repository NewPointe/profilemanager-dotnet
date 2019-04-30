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
    public partial class OsUpdateSettings
    {
        [JsonProperty("PerformPeriodicCheck")]
        public bool PerformPeriodicCheck { get; set; }

        [JsonProperty("AutomaticSecurityUpdatesEnabled")]
        public bool AutomaticSecurityUpdatesEnabled { get; set; }

        [JsonProperty("BackgroundDownloadEnabled")]
        public bool BackgroundDownloadEnabled { get; set; }

        [JsonProperty("PreviousScanDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PreviousScanDate { get; set; }

        [JsonProperty("CatalogURL", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CatalogUrl { get; set; }

        [JsonProperty("PreviousScanResult")]
        public long PreviousScanResult { get; set; }

        [JsonProperty("AutoCheckEnabled")]
        public bool AutoCheckEnabled { get; set; }

        [JsonProperty("AutomaticAppInstallationEnabled")]
        public bool AutomaticAppInstallationEnabled { get; set; }

        [JsonProperty("AutomaticOSInstallationEnabled")]
        public bool AutomaticOsInstallationEnabled { get; set; }

        [JsonProperty("IsDefaultCatalog")]
        public bool IsDefaultCatalog { get; set; }
    }

}