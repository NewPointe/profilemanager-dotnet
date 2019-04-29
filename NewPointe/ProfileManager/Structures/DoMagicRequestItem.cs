//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace NewPointe.ProfileManager.Structures
{
    public class DoMagicRequestItem
    {
        public string Item { get; set; }
        public string Method { get; set; }
        public object[] Parameters { get; set; }
    }
}