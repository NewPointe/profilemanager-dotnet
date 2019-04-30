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
    public partial class InstalledApplicationList
    {
        [JsonProperty("HasUpdateAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasUpdateAvailable { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ShortVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortVersion { get; set; }

        [JsonProperty("IsValidated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValidated { get; set; }

        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("Installing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Installing { get; set; }

        [JsonProperty("BetaApp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BetaApp { get; set; }

        [JsonProperty("ExternalVersionIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExternalVersionIdentifier { get; set; }

        [JsonProperty("DynamicSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? DynamicSize { get; set; }

        [JsonProperty("AppStoreVendable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppStoreVendable { get; set; }

        [JsonProperty("BundleSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? BundleSize { get; set; }

        [JsonProperty("DeviceBasedVPP", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeviceBasedVpp { get; set; }

        [JsonProperty("Identifier")]
        public string Identifier { get; set; }

        [JsonProperty("AdHocCodeSigned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdHocCodeSigned { get; set; }
    }

}