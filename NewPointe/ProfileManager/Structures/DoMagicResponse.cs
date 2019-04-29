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
    class DoMagicResponse
    {
            public Dictionary<string, object[][]> remote { get; set; }
            public Dictionary<string, object> result { get; set; }
    }
}