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
    public partial class DepDeviceInfo
    {
        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("profile_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileUuid { get; set; }

        [JsonProperty("profile_assign_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ProfileAssignTime { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("device_family")]
        public string DeviceFamily { get; set; }

        [JsonProperty("profile_status")]
        public string ProfileStatus { get; set; }

        [JsonProperty("device_assigned_by")]
        public string DeviceAssignedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("device_assigned_date")]
        public DateTimeOffset DeviceAssignedDate { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }
    }

}