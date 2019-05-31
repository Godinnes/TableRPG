using God.Characters.Bootstrap.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace God.RPG.Bootstrap
{
    public static class ApplicationBuilderExtensions
    {
        public static void Bootstrap(this IApplicationBuilder app)
        {
            var bootstrap = app.ApplicationServices.GetRequiredService<IComponentBootstrap>();
            bootstrap.Bootstrap();
        }
    }
}
