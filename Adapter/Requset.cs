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
    public class Requset : IRequest
    {
        public void request(string[] arg)
        {
            Console.WriteLine("the request is send to adapter");

            BuileServiceProviderInstance.GetInstance.serviceProvider?.GetService<IConnecttToAnotherSystem>()?.ConnectToAnotherSystem(arg);
        }
    }
}
