using Composite_DP.Abstractions;
using Composite_DP.Composite;
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
    public class CompositeSetup : IDesignPatternSelector
    {
        public void DesigntypeSetup()
        {
            //----------------Departement 1
            CompositeComponent? Departement1 = (CompositeComponent?)((BuileServiceProviderInstance.GetInstance.serviceProvider?.
                GetServices<IGetStatusForCollageComponent>())?.Where(name => name.name == "Departement1 ").FirstOrDefault());

            Departement1?.AddComponent(() =>
            {
                IEnumerable<IGetStatusForCollageComponent>? teacherInDepartement1 = BuileServiceProviderInstance.GetInstance.serviceProvider?.
            GetServices<IGetStatusForCollageComponent>().Where((name => name.name == "Teacher 1 Departement1 " ||
              name.name == "Teacher 2 Departement1"
            ));
                Departement1.components.AddRange(teacherInDepartement1);
            });
            Departement1?.GetStatus();

            //-----------------------Depeartement 2


            CompositeComponent? Departement2 = (CompositeComponent?)((BuileServiceProviderInstance.GetInstance.serviceProvider?.
                GetServices<IGetStatusForCollageComponent>())?.Where(name => name.name == "Departement2 ").FirstOrDefault());

            Departement2?.AddComponent(() =>
            {
                IEnumerable<IGetStatusForCollageComponent>? teacherInDepartement1 = BuileServiceProviderInstance.GetInstance.serviceProvider?.
            GetServices<IGetStatusForCollageComponent>().Where((name => name.name == "Teacher 3 Departement2 " ||
              name.name == "Teacher 4 Departement2"
            ));
                Departement2.components.AddRange(teacherInDepartement1);
            });
            Departement2?.GetStatus();


            //----------------------------Collage

            CompositeComponent? Collage = (CompositeComponent?)((BuileServiceProviderInstance.GetInstance.serviceProvider?.
                GetServices<IGetStatusForCollageComponent>())?.Where(name => name.name == "Collage ").FirstOrDefault());

            Collage?.AddComponent(() =>
            {
                IEnumerable<IGetStatusForCollageComponent>? teacherInDepartement1 = BuileServiceProviderInstance.GetInstance.serviceProvider?.
            GetServices<IGetStatusForCollageComponent>().Where((name => name.name == "Departement1 " ||
              name.name == "Departement2 "
            ));
                Collage.components.AddRange(teacherInDepartement1);
            });
            Collage?.GetStatus();


        }

    }
}
