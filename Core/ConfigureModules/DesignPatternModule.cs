using Microsoft.Extensions.DependencyInjection;

namespace Core.ConfigureModules
{
    public abstract class DesignPatternModule
    {
        public DesignPatternModule()
        {
            // do singlton instance to use it in our app
            BuileServiceProviderInstance buileServiceProviderInstance = BuileServiceProviderInstance.GetInstance;
            ConfigureServices(buileServiceProviderInstance.serviceCollection);
        }
        public abstract void ConfigureServices(IServiceCollection services);
    }
}
