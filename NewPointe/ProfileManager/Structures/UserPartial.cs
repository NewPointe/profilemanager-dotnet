//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

namespace NewPointe.ProfileManager.Structures
{
    public class UserPartial
    {
        public dynamic asm_first_name_ext { get; set; }
        public dynamic asm_full_name_ext { get; set; }
        public dynamic asm_last_name_ext { get; set; }
        public dynamic asm_unique_id_ext { get; set; }
        public string created_at { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string full_name { get; set; }
        public string guid { get; set; }
        public bool has_complete_data { get; set; }
        public long id { get; set; }
        public string jpeg_data { get; set; }
        public string last_name { get; set; }
        public dynamic managed_apple_id { get; set; }
        public dynamic mobile_phone { get; set; }
        public dynamic passcode_policy { get; set; }
        public dynamic profile { get; set; }
        public string short_name { get; set; }
        public string updated_at { get; set; }
    }
}