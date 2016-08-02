using System;
using Wangkanai.AspNetCore.Responsiveness.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions for configuring Responsiveness using an <see cref="IResponsivenessBuilder"/>
    /// </summary>
    public static class ResponsivenessCoreBuilderExtensions
    {
        public static IResponsivenessBuilder AddResponsivenessOptions(
            this IResponsivenessBuilder builder,
            Action<ResponsivenessOptions> options)
        {
            if(builder == null) throw new ArgumentNullException(nameof(builder));
            if(options == null) throw new ArgumentNullException(nameof(options));

            builder.Services.Configure<ResponsivenessOptions>(options);
            return builder;
        }
    }
}