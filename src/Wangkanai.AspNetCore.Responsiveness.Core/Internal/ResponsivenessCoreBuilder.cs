using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.AspNetCore.Responsiveness.Core.Internal
{
    public class ResponsivenessCoreBuilder : IResponsivenessCoreBuilder
    {
        public IServiceCollection Services { get; }

        public ResponsivenessCoreBuilder(IServiceCollection services)
        {
            Services = services;
        }
    }
}