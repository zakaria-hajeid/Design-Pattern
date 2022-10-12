using BridgeDP;
using Core;
using DesignPattern.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using Observe;
using Observe.Absraction;
using Observe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignSetupConcreateStretegyClasses
{
    public class ObserveSetup : IDesignPatternSelector
    {
        public void DesigntypeSetup()
        {
            BuileServiceProviderInstance.GetInstance?.serviceCollection?
                .AddSingleton<ITokenObserves>(
            new TokenObserve(
                BuileServiceProviderInstance.GetInstance?.serviceProvider?.
               GetService<ITokenSubject>())
            );

            ITokenSubject? subject = BuileServiceProviderInstance.GetInstance?.serviceProvider?.
                  GetService<ITokenSubject>();
            subject.tokenStatus = EnumTokenStatus.Active;
       }
    }
}
