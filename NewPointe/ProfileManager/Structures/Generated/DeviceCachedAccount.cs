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
    public partial class DeviceCachedAccount
    {
        [JsonProperty("ApplicableDevicesCount")]
        public long ApplicableDevicesCount { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("Identifier")]
        public string Identifier { get; set; }

        [JsonProperty("MobileAccount")]
        public bool MobileAccount { get; set; }

        [JsonProperty("UID")]
        public long Uid { get; set; }

        [JsonProperty("UserGUID")]
        public string UserGuid { get; set; }

        [JsonProperty("UserIdentifier")]
        public string UserIdentifier { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }
    }

}