using DesignPattern.Abstraction;
using DesignPattern.DesignSetupConcreateStretegyClasses;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ConfigureSetupDesignModule
{
    public static class ConfigureSetupExtinsion
    {
        public static void ConfigureSetup(this IServiceCollection services)
        {
            services.AddSingleton<IDesignPatternSelector, BridgeSetup>();
            services.AddSingleton<IDesignPatternSelector, BuilderSetupClass>();
            services.AddSingleton<IDesignPatternSelector, DecoratorSetup>();
            services.AddSingleton<IDesignPatternSelector, AdapterSetup>();
            services.AddSingleton<IDesignPatternSelector, CompositeSetup>();
            services.AddSingleton<IDesignPatternSelector, ChainSetup>();


        }
    }
}
