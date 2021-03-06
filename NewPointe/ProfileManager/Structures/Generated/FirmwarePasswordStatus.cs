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
    public partial class FirmwarePasswordStatus
    {
        [JsonProperty("PasswordExists")]
        public bool PasswordExists { get; set; }

        [JsonProperty("AllowOroms")]
        public bool AllowOroms { get; set; }

        [JsonProperty("ChangePending")]
        public bool ChangePending { get; set; }
    }

}