//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

namespace NewPointe.ProfileManager.Structures
{
    public class AutoJoinProfile
    {
        public string admin_session { get; set; }
        public string created_at { get; set; }
        public int[] device_groups { get; set; }
        public bool has_complete_data { get; set; }
        public long id { get; set; }
        public bool is_wildcard { get; set; }
        public string name { get; set; }
        public string reg_challenge { get; set; }
        public long temporary_id { get; set; }
        public string updated_at { get; set; }
        public AutoJoinProfileUsageLogItem[] usage_log { get; set; }
    }
}