using Adapter.Abstraction;
using Core.ConfigureModules;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ConfigureModule
{
    public static class AdapterExtinstionMethod
    {
        public static void ConfigureAdapter(this IServiceCollection services)
        {
            services.AddSingleton<IConnecttToAnotherSystem, ConnecttToAnotherSystem>();
            services.AddSingleton<IRequest, Requset>();
            services.AddSingleton<IResponse, response>();

        }
    }
}
