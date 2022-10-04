using Core.ConfigureModules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.ConfigureModule
{
    public class ConfigureChain : DesignPatternModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureChain();
        }
    }
}
