using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.AspNetCore.Responsiveness;
using Wangkanai.AspNetCore.Responsiveness.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ResponsivenessBuilderExtensions
    {
        /// <summary>
        /// Adds MVC view locatization to the application.
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
        /// Adds MVC view locatization to the application.
        /// </summary>
        /// <param name="builder">the <see cref="IMvcBuilder"/>.</param>
        /// <param name="setupAction">An action to configure the <see cref="ResponsivenessOptions"/>.</param>
        /// <returns>The <see cref="IMvcBuilder"/>.</returns>
        public static IMvcBuilder AddViewResponsiveness(
            this IMvcBuilder builder,
            Action<ResponsivenessOptions> setupAction)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            ResponsivenessServices.AddResponsivenessServices(builder.Services, setupAction);
            return builder;
        }
    }
}
