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
    public partial class EnrollmentSettings
    {
        [JsonProperty("set_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetDeviceName { get; set; }

        [JsonProperty("device_name_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceNameValue { get; set; }

        [JsonProperty("allow_activation_lock")]
        public string AllowActivationLock { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("dep_supervised_activation_lock")]
        public string DepSupervisedActivationLock { get; set; }

        [JsonProperty("dep_unsupervised_activation_lock")]
        public string DepUnsupervisedActivationLock { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("library_item_id")]
        public long LibraryItemId { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("has_complete_data")]
        public bool HasCompleteData { get; set; }
    }

}