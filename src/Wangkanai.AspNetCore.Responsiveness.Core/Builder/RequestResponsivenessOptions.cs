using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.AspNetCore.Responsiveness;

namespace Microsoft.AspNetCore.Builder
{
    public class RequestResponsivenessOptions
    {
        public RequestResponsivenessOptions()
        {
            
        }
        public IList<DeviceType> SupportedDevices { get; set; } = new List<DeviceType>();
    }
}
