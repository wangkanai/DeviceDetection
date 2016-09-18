// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;
using Wangkanai.Responsive.Internal;

namespace Wangkanai.Responsive.Builder
{
    /// <summary>
    /// Extension methods for adding the <see cref="ResponsiveMiddleware"/> to an application.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseResponsive(
            this IApplicationBuilder app)
        {
            if(app == null) throw new ArgumentNullException(nameof(app));

            return app.UseResponsive(options => { });
        }

        public static IApplicationBuilder UseResponsive(
            this IApplicationBuilder app,
            Action<IResponsiveBuilder> options)
        {
            if(app == null) throw new ArgumentNullException(nameof(app));
            if(options==null) throw new ArgumentNullException(nameof(options));

            return app.UseMiddleware<ResponsiveMiddleware>();
        }
    }

    public class ResponsiveBuilder
    {
        
    }

    public interface IResponsiveBuilder
    {
        IApplicationBuilder ApplicationBuilder { get; }
        //IList<IDevice> SupportedDevices { get; }
    }
}
