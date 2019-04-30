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
    public partial class PayloadContent
    {
        [JsonProperty("PayloadDisplayName")]
        public string PayloadDisplayName { get; set; }

        [JsonProperty("PayloadType")]
        public string PayloadType { get; set; }

        [JsonProperty("PayloadVersion")]
        public long PayloadVersion { get; set; }

        [JsonProperty("PayloadIdentifier")]
        public string PayloadIdentifier { get; set; }

        [JsonProperty("PayloadDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string PayloadDescription { get; set; }

        [JsonProperty("PayloadOrganization", NullValueHandling = NullValueHandling.Ignore)]
        public string PayloadOrganization { get; set; }

        [JsonProperty("PayloadUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string PayloadUuid { get; set; }
    }

}