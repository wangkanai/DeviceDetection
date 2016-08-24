// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.AspNetCore.Responsiveness.Internal;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Wangkanai.AspNetCore.Responsiveness.DependencyInjection
{
    public static class ResponsivenessCoreServiceCollectionExtensions
    {
        public static IResponsivenessCoreBuilder AddResponsivenessCore(
            this IServiceCollection services)
        {
            if(services == null) throw new ArgumentNullException(nameof(services));

            var manager = GetResponsivenessManager(services);
            services.TryAddSingleton(manager);

            ConfigureDefaultResponsivenessRepository(manager);

            return new ResponsivenessCoreBuilder(services);
        }

        private static void ConfigureDefaultResponsivenessRepository(ResponsivenessManagerFactory managerFactory)
        {
            if(managerFactory == null) throw new NotImplementedException(nameof(managerFactory));
        }

        private static ResponsivenessManagerFactory GetResponsivenessManager(IServiceCollection services)
        {
            var manager = GetServiceFromCollection<ResponsivenessManagerFactory>(services);
            if (manager == null)            
                manager = new ResponsivenessManagerFactory();
            
            return manager;
        }

        private static T GetServiceFromCollection<T>(IServiceCollection services) 
            => (T)services
                .FirstOrDefault(d => d.ServiceType == typeof(T))
                ?.ImplementationInstance;
    }
}
