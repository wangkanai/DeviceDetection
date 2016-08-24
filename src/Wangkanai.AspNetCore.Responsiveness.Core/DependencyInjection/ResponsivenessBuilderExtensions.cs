// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Wangkanai.AspNetCore.Responsiveness;
using Wangkanai.AspNetCore.Responsiveness.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for configuring MVC view responsiveness
    /// </summary>    
    public static class ResponsivenessBuilderExtensions
    {
        /// <summary>
        /// Adds MVC view responsiveness to the application.
        /// </summary>
        /// <param name="builder">The <see cref="IMvcBuilder"/>.</param>
        /// <returns>The <see cref="IMvcBuilder"/>.</returns>
        public static IMvcBuilder AddViewResponsiveness(
            this IMvcBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            return AddViewResponsiveness(builder, null);
        }
        /// <summary>
        /// Adds MVC view responsiveness to the application.
        /// </summary>
        /// <param name="builder">the <see cref="IMvcBuilder"/>.</param>
        /// <param name="setupAction">An action to configure the <see cref="ViewResponsivenessOptions"/>.</param>
        /// <returns>The <see cref="IMvcBuilder"/>.</returns>
        public static IMvcBuilder AddViewResponsiveness(
            this IMvcBuilder builder,
            Action<ViewResponsivenessOptions> setupAction)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (setupAction == null) throw new ArgumentNullException(nameof(setupAction));

            ResponsivenessServices.AddResponsivenessServices(builder.Services, setupAction);
            return builder;
        }
    }
}
