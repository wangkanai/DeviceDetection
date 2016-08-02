using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.AspNetCore.Responsiveness.Core.Abstractions;
using Wangkanai.AspNetCore.Responsiveness.Core.Internal;
using Wangkanai.AspNetCore.Responsiveness.Core.Preference;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class ResponsivenessCoreServiceCollectionExtensions
    {
        public static IResponsivenessCoreBuilder AddResponsivenessCore(
            this IServiceCollection services)
        {
            if(services == null) throw new ArgumentNullException(nameof(services));


            return new ResponsivenessCoreBuilder(services);
        }

        private static ResponsivenessManager GetResponsivenessManager(IServiceCollection services)
        {
            var manager = GetServiceFromCollection<ResponsivenessManager>(services);
            if (manager == null)
            {
                manager = new ResponsivenessManager();
            }
            return manager;
        }

        private static T GetServiceFromCollection<T>(IServiceCollection services) 
            => (T)services
                .FirstOrDefault(d => d.ServiceType == typeof(T))
                ?.ImplementationInstance;
    }
}
