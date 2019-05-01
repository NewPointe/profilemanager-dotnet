//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using NewPointe.ProfileManager.Structures;
using NewPointe.ProfileManager.Structures.Generated;
using System.Net.Http.Formatting;

namespace NewPointe.ProfileManager
{

    public class ProfileManagerClient
    {

        private readonly HttpClient client;

        public ProfileManagerClient(string controllerAddress)
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri(controllerAddress);
            client.DefaultRequestHeaders.Add("User-Agent", "NewPointe.profilemanager.api.PMClient");
        }

        /// <summary>
        /// Logs in the client.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>Returns the response for the login.</returns>
        public async Task<HttpResponseMessage> Login(string username, string password)
        {
            return await client.PostAsJsonAsync(
                "/auth/user",
                new LoginRequest
                {
                    username = username,
                    password = password,
                    rememberMe = false
                }
            );
        }

        // Util

        /// <summary>
        /// Does the Magic. Woosh! ✨🌠🌌💫
        /// </summary>
        /// <param name="item">The item to do magic to.</param>
        /// <param name="method">The type of magic to do.</param>
        /// <param name="parameters">The parameters for the magic.</param>
        /// <typeparam name="T">The Type of the `parameters`.</typeparam>
        /// <returns>Returns the Magic's response.</returns>
        public Task<HttpResponseMessage> DoMagic(string item, string method, params object[] parameters)
        {
            return DoMagicBatch(new[] { new MagicRequest { Model = item, Method = method, Parameters = parameters } });
        }

        /// <summary>
        /// Does a lot of Magic. The Woosh has been doubled! ✨🌠🌌💫✨🌠🌌💫
        /// 
        /// Note: Duplicate Magic requests (requests with the same `Item` and `Method`) will be ignored.
        /// </summary>
        /// <param name="magicRequests">An array of Magic requests to make.</param>
        /// <returns>Returns the Magic's response.</returns>
        public async Task<HttpResponseMessage> DoMagicBatch(MagicRequest[] magicRequests)
        {
            var response = await client.PostAsJsonAsync("/devicemanagement/webapi/magic/do_magic", MergeMagicRequests(magicRequests));
            // Fix for the web server not setting the Content-Type
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return response;
        }

        private static Dictionary<string, Dictionary<string, object>> MergeMagicRequests(MagicRequest[] magicRequests)
        {
            var magic = new Dictionary<string, Dictionary<string, object>>();
            foreach (var request in magicRequests)
            {
                if (magic.TryGetValue(request.Model, out var actions))
                {
                    if (!actions.ContainsKey(request.Method))
                    {
                        actions.Add(request.Method, new[] { request.Parameters });
                    }
                }
                else
                {
                    magic.Add(request.Model, new Dictionary<string, object> { { request.Method, new[] { request.Parameters } } });
                }
            }
            return magic;
        }

        /// <summary>
        /// Does Magic to retreive a list of Ids.
        /// </summary>
        /// <param name="item">The item to do magic to.</param>
        /// <param name="method">The type of magic to do.</param>
        /// <returns>Returns a list of Ids.</returns>
        public async Task<int[]> DoMagicForRemoteIds(string item, string method)
        {
            // Do Magic
            var response = await DoMagic(item, method, "__ReturnValue");

            // Check response codes
            response.EnsureSuccessStatusCode();

            // Read response
            var responseData = await response.Content.ReadAsAsync<DoMagicForRemoteIdsResponse>();

            // Try extracting the remote response
            if (responseData.remote.TryGetValue("__ReturnValue", out var returnValue))
            {
                if (returnValue.Length > 0)
                {
                    var innerReturnValue = returnValue[0];
                    return innerReturnValue.Skip(1).Select(v => Convert.ToInt32(v)).ToArray();
                }
            }
            
            //  Oops
            throw new Exception(@"Response was not in the expected format. Do you have the right Magic?");

        }

        public async Task<T[]> DoMagicForResults<T>(string item, string method, params object[] parameters)
        {
            var response = await DoMagic(item, method, parameters);
            response.EnsureSuccessStatusCode();
            var responseJSON = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<DoMagicForResultResponse<T>>(responseJSON);

            if (responseData.result.TryGetValue(item, out var returnValue))
            {
                return returnValue.retrieved;
            }

            throw new Exception(@"Response was not in the expected format. Do you have the right Magic?
Expected Format:
{ ""result"": { <item>: { retrieved: [<item_data>...] } } }

Actual Response:
" + responseJSON);

        }


        // Library Actions

        public async Task<int[]> GetActiveLibraryTaskIds()
        {
            return await DoMagicForRemoteIds("library_item_task", "find_all_active");
        }

        public Task<HttpResponseMessage> StartLibraryTask(string target_class, long target_id, string task_type)
        {
            return this.StartLibraryTaskWithParams(target_class, target_id, task_type, new object { });
        }
        public Task<HttpResponseMessage> StartLibraryTaskWithParams(string target_class, long target_id, string task_type, object @params)
        {
            return DoMagic("library_item_task", "start_task", new { target_class, target_id, task_type, @params }, "");
        }

        // Device Actions

        public Task<int[]> GetDeviceIds()
        {
            return DoMagicForRemoteIds("device", "find_all");
        }

        public Task<int[]> GetAppleTvDeviceIds()
        {
            return DoMagicForRemoteIds("device", "find_all_apple_tvs");
        }

        public Task<DevicePartial[]> GetPartialDevices(int[] ids)
        {
            return DoMagicForResults<DevicePartial>("device", "get_details", new { ids });
        }

        public Task<Device[]> GetDevices(int[] ids)
        {
            return DoMagicForResults<Device>("device", "get_complete_details", new { ids });
        }

        public Task<HttpResponseMessage> LockDevice(int deviceId)
        {
            return this.StartLibraryTask("Device", deviceId, "DeviceLock");
        }
        public Task<HttpResponseMessage> ShutDownDevice(int deviceId)
        {
            return this.StartLibraryTask("Device", deviceId, "ShutDownDevice");
        }
        public Task<HttpResponseMessage> RestartDevice(int deviceId)
        {
            return this.StartLibraryTask("Device", deviceId, "RestartDevice");
        }

        // Device Group Actions

        public Task<int[]> GetDeviceGroupIds()
        {
            return DoMagicForRemoteIds("device_group", "find_all");
        }

        public Task<HttpResponseMessage> LockDeviceGroup(int deviceGroupId)
        {
            return this.StartLibraryTask("DeviceGroup", deviceGroupId, "DeviceLock");
        }
        public Task<HttpResponseMessage> ShutDownDeviceGroup(int deviceGroupId)
        {
            return this.StartLibraryTask("DeviceGroup", deviceGroupId, "ShutDownDevice");
        }
        public Task<HttpResponseMessage> RestartDeviceGroup(int deviceGroupId)
        {
            return this.StartLibraryTask("DeviceGroup", deviceGroupId, "RestartDevice");
        }

        // User Actions

        public Task<int[]> GetUserIds()
        {
            return DoMagicForRemoteIds("user", "find_all");
        }

        public async Task<int> GetMyUserId()
        {
            return (await DoMagicForRemoteIds("user", "find_me")).FirstOrDefault();
        }

        // User Group Actions

        public Task<int[]> GetUserGroupIds()
        {
            return DoMagicForRemoteIds("user_group", "find_all");
        }

        public Task<int[]> GetVPPEnabledUserGroupIds()
        {
            return DoMagicForRemoteIds("user_group", "find_all_vpp_enabled");
        }

        // Class Actions

        public Task<int[]> GetClassIds()
        {
            return DoMagicForRemoteIds("edu_class", "find_all");
        }

        // Utility Classes

        private class LoginRequest
        {
            public string username { get; set; }
            public string password { get; set; }
            public bool rememberMe { get; set; }
        }

        private class DoMagicForRemoteIdsResponse
        {
            public Dictionary<string, object[][]> remote { get; set; }
        }

        private class DoMagicForResultResponse<T>
        {
            public Dictionary<string, DoMagicForResultResponseItem<T>> result { get; set; }
        }

        private class DoMagicForResultResponseItem<T>
        {
            public T[] retrieved { get; set; }
        }

    }
}