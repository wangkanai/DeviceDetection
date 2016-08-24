using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
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
