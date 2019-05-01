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
    public partial class DevicePartial
    {
        [JsonProperty("DeviceID")]
        public string DeviceId { get; set; }

        [JsonProperty("DeviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("IMEI")]
        public string IMEI { get; set; }

        [JsonProperty("MEID")]
        public string MEID { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("SerialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("airplay_password")]
        public string AirplayPassword { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("is_dep_device")]
        public bool IsDepDevice { get; set; }

        [JsonProperty("last_checkin_time")]
        public DateTimeOffset? LastCheckinTime { get; set; }

        [JsonProperty("mdm_target_type")]
        public string MdmTargetType { get; set; }

        [JsonProperty("udid")]
        public string UUID { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        [JsonProperty("vpp_last_invite_delivered")]
        public DateTimeOffset? VppLastInviteDelivered { get; set; }

        [JsonProperty("vpp_last_invite_requested")]
        public DateTimeOffset? VppLastInviteRequested { get; set; }

        [JsonProperty("profile")]
        public long? Profile { get; set; }

        [JsonProperty("is_mac")]
        public bool IsMac { get; set; }

        [JsonProperty("is_ios")]
        public bool IsIos { get; set; }

        [JsonProperty("enrollment_state")]
        public string EnrollmentState { get; set; }

        [JsonProperty("has_complete_data")]
        public bool HasCompleteData { get; set; }
    }
}
