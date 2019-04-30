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
    public partial class CertificateMetadatum
    {
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("is_root")]
        public bool IsRoot { get; set; }

        [JsonProperty("CommonName")]
        public string CommonName { get; set; }

        [JsonProperty("not_after")]
        public DateTimeOffset NotAfter { get; set; }

        [JsonProperty("is_identity")]
        public bool IsIdentity { get; set; }
    }

}