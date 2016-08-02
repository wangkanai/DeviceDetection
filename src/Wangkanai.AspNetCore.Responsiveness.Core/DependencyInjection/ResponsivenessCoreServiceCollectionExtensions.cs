using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.AspNetCore.Responsiveness.Core.Abstractions;
using Wangkanai.AspNetCore.Responsiveness.Core.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ResponsivenessCoreServiceCollectionExtensions
    {
        public static IResponsivenessCoreBuilder AddResponsivenessCore(
            this IServiceCollection services)
        {
            return new ResponsivenessCoreBuilder(services);
        }
    }
}
