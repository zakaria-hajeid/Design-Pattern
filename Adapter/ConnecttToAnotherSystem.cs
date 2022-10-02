using Adapter.Abstraction;
using Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ConnecttToAnotherSystem : IConnecttToAnotherSystem
    {
        public void ConnectToAnotherSystem(string[] a)
        {
            List<string> AdapterResult = new List<string>();
            foreach (var item in a)
            {
                AdapterResult.Add(item);
            }
            Console.WriteLine("the request is prepared by adapter and sent to respnse");

            BuileServiceProviderInstance.GetInstance.serviceProvider?.GetService<IResponse>()?.response(AdapterResult);
            ;
        }
    }
}
