// See https://aka.ms/new-console-template for more information
using BulderDb;
using BulderDb.Abstraction;
using Core;
using Core.ConfigureModules;
using Decorator_DP.Abstraction;
using Decorator_DP.ConfigureModule;
using DesignPattern;
using DesignPattern.Abstraction;
using DesignPattern.DesignSetupConcreateStretegyClasses;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

/*using factory Method
DesignPatternSelcrorContext designPatternSelcrorContext =
new DesignPatternSelcrorContext(AbstractFactoryDPCaller.FactoryCallDp(DpType.bulder));
designPatternSelcrorContext.SetupDesign();*/

//Using Scan All assimblies
// register Each Configure Moudles
PrepareModules.PrepareConfigreModules();
//register Each DesignStreatgy Setup


var types = BuileServiceProviderInstance.GetInstance?.serviceProvider?.
        GetServices<IDesignPatternSelector>();

foreach (var designPatternSelectorUnstance in types)
{
    if (!designPatternSelectorUnstance.GetType().IsAbstract)
    {
        if (designPatternSelectorUnstance != null)
            Console.WriteLine($"------------------Call {designPatternSelectorUnstance.GetType().Name}  Pattern Setup Class-------------------------");
        designPatternSelectorUnstance?.DesigntypeSetup();
    }

}



