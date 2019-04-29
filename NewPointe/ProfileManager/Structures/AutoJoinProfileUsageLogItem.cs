//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

namespace NewPointe.ProfileManager.Structures
{
    public class AutoJoinProfileUsageLogItem
    {
        public string DeviceName { get; set; }
        public string ProductName { get; set; }
        public int auto_join_profile_id { get; set; }
        public string checkin_token { get; set; }
        public string created_at { get; set; }
        public int device_id { get; set; }
        public int? device_tombstone_id { get; set; }
        public bool has_complete_data { get; set; }
        public int id { get; set; }
        public string udid { get; set; }
    }
}