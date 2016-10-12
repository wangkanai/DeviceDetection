// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Wangkanai.Responsive
{
    public class ResponsiveMiddleware
    {
        private readonly RequestDelegate _next;
        //private readonly ResponsiveOptions _options;

        public ResponsiveMiddleware(RequestDelegate next)//, ResponsiveOptions options)
        {
            if(next ==null) throw new ArgumentNullException(nameof(next));
            //if(options ==null) throw new ArgumentNullException(nameof(options));

            _next = next;
            //_options = options;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context == null) throw new ArgumentNullException(nameof(context));

            //var requestdevice = _options.DefaultRequestDevice;

            await _next(context);
        }
    }
}
