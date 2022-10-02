using Core;
using Core.ConfigureModules;
using DesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public static class PrepareModules
    {
        public static void PrepareConfigreModules()
        {
            var assymblyListConfigureModule =
    Assembly.GetExecutingAssembly().GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(DesignPatternModule))).ToList();
            foreach (var assemblyName in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            {
                Assembly assembly = Assembly.Load(assemblyName);
                var ReferenceassemblyTypesConfigureModule = assembly.GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(DesignPatternModule))).ToList();
                if (ReferenceassemblyTypesConfigureModule.Count != 0)
                    assymblyListConfigureModule = (List<Type>?)assymblyListConfigureModule?.Concat(ReferenceassemblyTypesConfigureModule).ToList();
            }

            foreach (var assemblyType in assymblyListConfigureModule)
            {
                DesignPatternModule? designPatternModule = (DesignPatternModule?)Activator.CreateInstance(assemblyType);
            }

            BuileServiceProviderInstance buileServiceProviderInstance = BuileServiceProviderInstance.GetInstance;
            buileServiceProviderInstance.buildeserviceProvider();
        }

       /* public static IEnumerable<Type> GetTypeOfDesignSetup()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes()).Where(p => typeof(IDesignPatternSelector).IsAssignableFrom(p) && !p.IsAbstract);
            return types;
        }*/
    }
}
