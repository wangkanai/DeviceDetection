// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.Options;
using Wangkanai.AspNetCore.Responsiveness.Internal;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Extension methods for adding the <see cref="ResponsivenessMiddleware"/> to an application.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseResponsiveness(
            this IApplicationBuilder app)
        {
            if(app == null) throw new ArgumentNullException(nameof(app));

            return app.UseMiddleware<ResponsivenessMiddleware>();
        }

        public static IApplicationBuilder UseResponsiveness(
            this IApplicationBuilder app,
            RequestResponsivenessOptions options)
        {
            return app.UseMiddleware<ResponsivenessMiddleware>(Options.Create(options));
        }
    }
}
