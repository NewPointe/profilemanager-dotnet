//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

namespace NewPointe.ProfileManager.Structures
{
    public class DevicePartial
    {
        public dynamic DeviceID { get; set; }
        public string DeviceName { get; set; }
        public dynamic IMEI { get; set; }
        public dynamic MEID { get; set; }
        public string ProductName { get; set; }
        public string SerialNumber { get; set; }
        public dynamic airplay_password { get; set; }
        public string created_at { get; set; }
        public string enrollment_state { get; set; }
        public bool has_complete_data { get; set; }
        public int id { get; set; }
        public dynamic identifier { get; set; }
        public bool is_dep_device { get; set; }
        public bool is_ios { get; set; }
        public bool is_mac { get; set; }
        public string last_checkin_time { get; set; }
        public string mdm_target_type { get; set; }
        public int? profile { get; set; }
        public string udid { get; set; }
        public string updated_at { get; set; }
        public dynamic user_id { get; set; }
        public dynamic vpp_last_invite_delivered { get; set; }
        public dynamic vpp_last_invite_requested { get; set; }
    }
}