// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System.Collections.Generic;
using Wangkanai.AspNetCore.Responsiveness;
using Wangkanai.Extensions.Browser;

namespace Microsoft.AspNetCore.Builder
{
    public class RequestResponsivenessOptions
    {
        public RequestResponsivenessOptions()
        {
            
        }
        public IList<DeviceTypes> SupportedDevices { get; set; } = new List<DeviceTypes>();
    }
}
