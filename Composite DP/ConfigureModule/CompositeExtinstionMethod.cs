

using Composite_DP.Abstractions;
using Composite_DP.Composite;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DP.ConfigureModule
{
    public static class CompositeExtinstionMethod
    {
        public static void ConfigureComposite(this IServiceCollection services)
        {
            services.AddSingleton<IGetStatusForCollageComponent>(
                 new CompositeComponent("Collage ", StatusEnum.Active)
             );
            services.AddSingleton<IGetStatusForCollageComponent>(
                new CompositeComponent("Departement1 ", StatusEnum.Active)
            );
            services.AddSingleton<IGetStatusForCollageComponent>(
             new CompositeComponent("Departement2 ", StatusEnum.Active)
         );

            services.AddSingleton<IGetStatusForCollageComponent>(
                new Leaf("Teacher 1 Departement1 ", StatusEnum.Active)
            );
            services.AddSingleton<IGetStatusForCollageComponent>(
               new Leaf("Teacher 2 Departement1", StatusEnum.Active)
           );

            services.AddSingleton<IGetStatusForCollageComponent>(
                new Leaf("Teacher 3 Departement2 ", StatusEnum.Active)
            );
            services.AddSingleton<IGetStatusForCollageComponent>(
               new Leaf("Teacher 4 Departement2", StatusEnum.Active)
           );


        }
    }
}
