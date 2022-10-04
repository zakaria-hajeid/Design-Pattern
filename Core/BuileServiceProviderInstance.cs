using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public sealed class BuileServiceProviderInstance
    {
        private static readonly object Instancelock = new object();
        private static BuileServiceProviderInstance instance = null;
        public IServiceCollection serviceCollection { get; set; }
        public IServiceProvider? serviceProvider { get; set; }
        private BuileServiceProviderInstance()
        {
            serviceCollection = new ServiceCollection();

        }
        public static BuileServiceProviderInstance GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new BuileServiceProviderInstance();
                    }
                    return instance;
                }
            }
        }
        public void buildeserviceProvider()
        {
            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
