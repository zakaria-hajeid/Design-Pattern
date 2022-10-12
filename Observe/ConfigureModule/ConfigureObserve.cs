
using Core.ConfigureModules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observe.ConfigureModule
{
    public class ConfigureObserve : DesignPatternModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureObserve();
        }
    }
}
