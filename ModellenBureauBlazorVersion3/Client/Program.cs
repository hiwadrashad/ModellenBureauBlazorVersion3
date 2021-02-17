using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tewr.Blazor.FileReader;

namespace ModellenBureauBlazorVersion3.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddFileReaderService(options =>
            {
                options.UseWasmSharedBuffer = true;
            }
            );
            builder.Services.AddHttpClient("ModellenBureauBlazorVersion3.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            builder.Services.AddHttpClient<IAdminDataService, AdminDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            builder.Services.AddHttpClient<IClientDataService, ClientDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            builder.Services.AddHttpClient<IEventDataService, EventDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            builder.Services.AddHttpClient<IMaleModelDataService, MaleModelDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            builder.Services.AddHttpClient<IFemaleModelDataService, FemaleModelDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ModellenBureauBlazorVersion3.ServerAPI"));

            builder.Services.AddApiAuthorization();

            await builder.Build().RunAsync();
        }
    }
}
