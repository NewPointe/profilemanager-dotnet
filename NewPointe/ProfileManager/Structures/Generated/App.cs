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
    public partial class App
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentType { get; set; }

        [JsonProperty("assignment_mode")]
        public string AssignmentMode { get; set; }

        [JsonProperty("installation_mode")]
        public string InstallationMode { get; set; }
    }

}