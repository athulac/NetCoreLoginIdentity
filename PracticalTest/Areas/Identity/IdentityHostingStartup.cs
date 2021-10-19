using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(PracticalTest.Areas.Identity.IdentityHostingStartup))]
namespace PracticalTest.Areas.Identity
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