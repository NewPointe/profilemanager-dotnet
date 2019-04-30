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
    public partial class SecurityInfo
    {
        [JsonProperty("HardwareEncryptionCaps", NullValueHandling = NullValueHandling.Ignore)]
        public long? HardwareEncryptionCaps { get; set; }

        [JsonProperty("PasscodePresent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasscodePresent { get; set; }

        [JsonProperty("PasscodeLockGracePeriod", NullValueHandling = NullValueHandling.Ignore)]
        public long? PasscodeLockGracePeriod { get; set; }

        [JsonProperty("PasscodeLockGracePeriodEnforced", NullValueHandling = NullValueHandling.Ignore)]
        public long? PasscodeLockGracePeriodEnforced { get; set; }

        [JsonProperty("PasscodeCompliantWithProfiles", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasscodeCompliantWithProfiles { get; set; }

        [JsonProperty("PasscodeCompliant", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasscodeCompliant { get; set; }

        [JsonProperty("FDE_Enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FdeEnabled { get; set; }

        [JsonProperty("SystemIntegrityProtectionEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SystemIntegrityProtectionEnabled { get; set; }

        [JsonProperty("ManagementStatus", NullValueHandling = NullValueHandling.Ignore)]
        public ManagementStatus ManagementStatus { get; set; }

        [JsonProperty("FirewallSettings", NullValueHandling = NullValueHandling.Ignore)]
        public FirewallSettings FirewallSettings { get; set; }

        [JsonProperty("FirmwarePasswordStatus", NullValueHandling = NullValueHandling.Ignore)]
        public FirmwarePasswordStatus FirmwarePasswordStatus { get; set; }
    }

}