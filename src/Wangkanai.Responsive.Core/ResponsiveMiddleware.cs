// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Wangkanai.Detection;
using Wangkanai.Responsive.Abstractions;

namespace Wangkanai.Responsive
{
    public class ResponsiveMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ResponsiveOptions _options;        

        public ResponsiveMiddleware(RequestDelegate next, IOptions<ResponsiveOptions> options)
        {
            if (next == null) throw new ArgumentNullException(nameof(next));            
            if (options == null) throw new ArgumentNullException(nameof(options));

            _next = next;            
            _options = options.Value;
        }

        public async Task Invoke(HttpContext context, IDeviceResolver resolver)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            var perference = new UserPerference() { Device = resolver.Device.Type.ToString() };
            context.SetDevice(perference);

            await _next(context);
        }
    }
}
