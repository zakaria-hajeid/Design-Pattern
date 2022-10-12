


using Core;
using Microsoft.Extensions.DependencyInjection;
using Observe.Absraction;
using Observe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observe.ConfigureModule
{
    public static class ObserevExtinstionMethod
    {
        public static void ConfigureObserve(this IServiceCollection services)
        {
            services.AddSingleton<ITokenSubject>(
              new TokenSubject(EnumTokenStatus.Expired)
            );
        }
    }
}
