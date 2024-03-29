using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using TPharmacy.Client.Services;

namespace TPharmacy.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("TPharmacy.ServerAPI", (sp, client) => 
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                client.EnableIntercept(sp);
            })
            .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("TPharmacy.ServerAPI"));

            builder.Services.AddHttpClientInterceptor();
            builder.Services.AddScoped<HttpInterceptorService>();
            builder.Services.AddApiAuthorization();
            builder.Services.AddApiAuthorization().AddAccountClaimsPrincipalFactory<UserFactory>();

            await builder.Build().RunAsync();
        }
    }
}
