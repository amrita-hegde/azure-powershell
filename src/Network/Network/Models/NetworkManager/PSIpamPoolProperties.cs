﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace Microsoft.Azure.Commands.Network.Models.NetworkManager
{
    public class PSIpamPoolProperties
    {
        public string ProvisioningState { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public string ParentPoolName { get; set; }

        public System.Collections.Generic.IList<string> IPAddressType { get; set; }

        public System.Collections.Generic.IList<string> AddressPrefixes { get; set; }

        [JsonIgnore]
        public string AddressPrefixesText
        {
            get { return JsonConvert.SerializeObject(AddressPrefixes, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }

        [JsonIgnore]
        public string IpAddressTypeText
        {
            get { return JsonConvert.SerializeObject(IPAddressType, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }
    }
}
