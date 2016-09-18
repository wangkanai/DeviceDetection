// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.Responsive;
using Wangkanai.Responsive.Internal;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for configuring MVC view Responsive
    /// </summary>    
    public static class ResponsiveBuilderExtensions
    {
        /// <summary>
        /// Adds MVC view Responsive to the application.
        /// </summary>
        /// <param name="builder">The <see cref="IMvcBuilder"/>.</param>
        /// <returns>The <see cref="IMvcBuilder"/>.</returns>
        public static IResponsiveBuilder AddViewResponsive(
            this IResponsiveBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            return AddViewResponsive(builder, null);
        }
        /// <summary>
        /// Adds MVC view Responsive to the application.
        /// </summary>
        /// <param name="builder">the <see cref="IMvcBuilder"/>.</param>
        /// <param name="setupAction">An action to configure the <see cref="ViewResponsiveOptions"/>.</param>
        /// <returns>The <see cref="IMvcBuilder"/>.</returns>
        public static IResponsiveBuilder AddViewResponsive(
            this IResponsiveBuilder builder,
            Action<ViewResponsiveOptions> setupAction)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (setupAction == null) throw new ArgumentNullException(nameof(setupAction));

            ResponsiveServices.AddResponsiveServices(builder.Services, setupAction);
            return builder;
        }
    }
}
