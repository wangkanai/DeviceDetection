using Microsoft.Extensions.DependencyInjection;
using Wangkanai.AspNetCore.Responsiveness.Core.Abstractions;

namespace Wangkanai.AspNetCore.Responsiveness.Core.Builder
{
    public class ResponsivenessCoreBuilder : IResponsivenessCoreBuilder
    {
        private readonly IServiceCollection _services;

        public ResponsivenessCoreBuilder(IServiceCollection services)
        {
            _services = services;
        }
    }
}