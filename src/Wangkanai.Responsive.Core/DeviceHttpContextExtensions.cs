// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using Wangkanai.Responsive;

namespace Microsoft.AspNetCore.Http
{
    public static class DeviceHttpContextExtensions
    {
        private const string ResponsiveContextKey = "Responsive";

        public static void SetDevice(this HttpContext context, UserPerference perference)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (perference == null) throw new ArgumentNullException(nameof(perference));

            context.Items[ResponsiveContextKey] = perference;
        }
        public static UserPerference GetDevice(this HttpContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            object responsiveContext;
            if (context.Items.TryGetValue(ResponsiveContextKey, out responsiveContext))
                return responsiveContext as UserPerference;

            return null;
        }
    }
}
