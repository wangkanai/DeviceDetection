using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.AspNetCore.DeviceDetection.Core.Abstractions;

namespace Wangkanai.AspNetCore.DeviceDetection.Core.Builder
{
    public class DeviceDetectionBuilder: IDeviceDetectionBuilder
    {
        private readonly IServiceCollection _serivces;
        public DeviceDetectionBuilder(IServiceCollection services)
        {
            _serivces = services;
        }
    }
}
