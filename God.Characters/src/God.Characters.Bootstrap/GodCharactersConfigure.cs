using God.Characters.Application.Services;
using God.Characters.Bootstrap.Interface;
using God.Characters.Common.Resources.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace God.Characters.Bootstrap
{
    public class GodCharactersConfigure : IComponentConfigure
    {
        private readonly IServiceCollection _serviceCollection;

        public GodCharactersConfigure(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }
        public void ConfigureServices()
        {
            _serviceCollection.AddSingleton<AttributeRepository>();
            _serviceCollection.AddSingleton<ModifierService>();
        }
    }
}
