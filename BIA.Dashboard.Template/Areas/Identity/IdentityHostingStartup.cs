using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BIA.Dashboard.Template.Areas.Identity.IdentityHostingStartup))]
namespace BIA.Dashboard.Template.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}