//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

namespace NewPointe.ProfileManager.Structures
{
    public class UnifiedApplication
    {
        public string adam_id_str_ext {get; set;}
        public dynamic alt_version {get; set;}
        public int app_id {get; set;}
        public string asset_type {get; set;}
        public string category {get; set;}
        public string created_at {get; set;}
        public bool device_assignable {get; set;}
        public UnifiedApplicationAssignment[] device_groups {get; set;}
        public UnifiedApplicationAssignment[] devices {get; set;}
        public int ext_version_id {get; set;}
        public bool has_complete_data {get; set;}
        public string icon_url {get; set;}
        public int id {get; set;}
        public bool irrevocable {get; set;}
        public bool is_deleted {get; set;}
        public bool is_metadata_available {get; set;}
        public int license_count {get; set;}
        public int licenses_assigned_ext {get; set;}
        public int licenses_committed {get; set;}
        public bool maid_assignable {get; set;}
        public int media_id {get; set;}
        public string media_type {get; set;}
        public string metadata_last_updated {get; set;}
        public string name {get; set;}
        public string pricing_param {get; set;}
        public int product_type_id {get; set;}
        public int size_in_kb {get; set;}
        public int supported_association_types {get; set;}
        public int supported_devices {get; set;}
        public string unique_identifier {get; set;}
        public string updated_at {get; set;}
        public int updated_at_xid {get; set;}
        public dynamic user_groups {get; set;}
        public dynamic users {get; set;}
        public string uuid {get; set;}
        public dynamic variant {get; set;}
        public string version {get; set;}
        public string vpp_last_synced {get; set;}
        public int vpp_product_id {get; set;}
        public string xmin {get; set;}
    }
}