using Core.ConfigureModules;
using Decorator_DP.Abstraction;
using Decorator_DP.Decorator;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP.ConfigureModule
{
    public static class DecoratorExtinstionMethod
    {
        public static void ConfigureDecorator(this IServiceCollection services)
        {
            services.AddSingleton<IToken, TokenService>();
            services.AddSingleton<TokenDecorator, AddEncryptedItemToToken>();

        }
    }
}
