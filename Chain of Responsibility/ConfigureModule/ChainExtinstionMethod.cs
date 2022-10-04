


using Chain_of_Responsibility.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.ConfigureModule
{
    public static class ChainExtinstionMethod
    {
        public static void ConfigureChain(this IServiceCollection services)
        {
            services.AddSingleton<ThirdPartyService, FirstHandlerToCallService>();
            services.AddSingleton<ThirdPartyService, SecondHandlerToCallService>();
               
           


        }
    }
}
