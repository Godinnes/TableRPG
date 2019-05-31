using Microsoft.Extensions.DependencyInjection;

namespace God.RPG.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureBootstrap(this IServiceCollection services)
        {
            services.AddSingleton(services);
            //services.AddSingleton<IComponentConfigure, GodCharactersConfigure>();
        }
    }
}
