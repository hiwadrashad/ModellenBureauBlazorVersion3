﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModellenBureauBlazorVersion3.Server.Data;
using ModellenBureauBlazorVersion3.Server.Models;

[assembly: HostingStartup(typeof(ModellenBureauBlazorVersion3.Server.Areas.Identity.IdentityHostingStartup))]
namespace ModellenBureauBlazorVersion3.Server.Areas.Identity
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