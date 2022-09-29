using Core.ConfigureModules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP.ConfigureModule
{
    public class ConfigureDecorator : DesignPatternModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDecorator();
        }
    }
}
