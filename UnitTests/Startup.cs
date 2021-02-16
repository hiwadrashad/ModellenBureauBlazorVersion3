using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using ModellenBureauBlazorVersion3.Client.DataServices;

namespace UnitTests
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IAdminDataService, AdminDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            services.AddHttpClient<IClientDataService, ClientDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            services.AddHttpClient<IEventDataService, EventDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            services.AddHttpClient<IMaleModelDataService, MaleModelDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });

            services.AddHttpClient<IFemaleModelDataService, FemaleModelDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
            });
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
        }
    }
}
