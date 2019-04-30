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
    public partial class ManagedApplicationList
    {
        [JsonProperty("ManagementFlags")]
        public long ManagementFlags { get; set; }

        [JsonProperty("HasFeedback")]
        public bool HasFeedback { get; set; }

        [JsonProperty("IsValidated")]
        public bool IsValidated { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("ExternalVersionIdentifier")]
        public long ExternalVersionIdentifier { get; set; }

        [JsonProperty("HasConfiguration")]
        public bool HasConfiguration { get; set; }
    }

}