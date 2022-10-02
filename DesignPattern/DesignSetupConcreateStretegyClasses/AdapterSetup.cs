using Adapter.Abstraction;
using BridgeDP;
using Core;
using DesignPattern.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignSetupConcreateStretegyClasses
{
    public class AdapterSetup : IDesignPatternSelector
    {
        
        public void DesigntypeSetup()
        {
            BuileServiceProviderInstance.GetInstance.serviceProvider?.GetService<IRequest>()?.request(new [] {"item 1"," item 2"});
        }
    }
}
