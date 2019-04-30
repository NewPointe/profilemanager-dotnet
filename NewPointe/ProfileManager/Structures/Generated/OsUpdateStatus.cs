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
    public partial class OsUpdateStatus
    {
        [JsonProperty("ProductKey")]
        public string ProductKey { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("IsDownloaded")]
        public bool IsDownloaded { get; set; }

        [JsonProperty("DownloadPercentComplete")]
        public long DownloadPercentComplete { get; set; }
    }

}