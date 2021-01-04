using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace TheCreativeTeam
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            //rviceCollection.AddScoped<IResourceManifestProvider, ResourceManifest>();
        }
    }
}
