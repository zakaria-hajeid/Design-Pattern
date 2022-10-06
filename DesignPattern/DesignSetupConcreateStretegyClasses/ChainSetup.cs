using Chain_of_Responsibility.Abstractions;
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
    public class ChainSetup: IDesignPatternSelector
    {
        public void DesigntypeSetup()
        {
            var Handlers = BuileServiceProviderInstance.GetInstance.serviceProvider?.
                  GetServices<ThirdPartyService>().OrderBy(x=>x.index).ToList();

            for (int i = 0; i < Handlers?.Count-1; i++)
            {
                Handlers?[i].SetNextHandlerWhenFaliar(Handlers.Where(j => j.index == (i+1)).FirstOrDefault());

            }

            Handlers?.FirstOrDefault()?.SendRequest();
        }
    }
}
