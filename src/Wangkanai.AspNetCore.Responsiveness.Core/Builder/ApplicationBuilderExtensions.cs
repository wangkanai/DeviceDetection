// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
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

            return app.UseResponsiveness(options => { });
        }

        public static IApplicationBuilder UseResponsiveness(
            this IApplicationBuilder app,
            Action<IResponsivenessBuilder> options)
        {
            if(app == null) throw new ArgumentNullException(nameof(app));
            if(options==null) throw new ArgumentNullException(nameof(options));

            return app.UseMiddleware<ResponsivenessMiddleware>();
        }
    }

    public class ResponsivenessBuilder
    {
        
    }

    public interface IResponsivenessBuilder
    {
        IApplicationBuilder ApplicationBuilder { get; }
        //IList<IDevice> SupportedDevices { get; }
    }
}
