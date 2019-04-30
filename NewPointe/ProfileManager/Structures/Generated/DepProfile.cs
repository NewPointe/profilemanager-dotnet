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
    public partial class DepProfile
    {
        [JsonProperty("is_mandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("is_supervised", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupervised { get; set; }

        [JsonProperty("is_mdm_removable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMdmRemovable { get; set; }

        [JsonProperty("__SKIP_USER_AUTH")]
        public bool SkipUserAuth { get; set; }

        [JsonProperty("skip_setup_items")]
        public string[] SkipSetupItems { get; set; }
    }

}