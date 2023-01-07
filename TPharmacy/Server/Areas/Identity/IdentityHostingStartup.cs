using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(TPharmacy.Server.Areas.Identity.IdentityHostingStartup))]
namespace TPharmacy.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}