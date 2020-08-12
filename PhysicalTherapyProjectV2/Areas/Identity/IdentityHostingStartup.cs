using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhysicalTherapyProjectV2.Data;
using PhysicalTherapyProjectV2.Models;

[assembly: HostingStartup(typeof(PhysicalTherapyProjectV2.Areas.Identity.IdentityHostingStartup))]
namespace PhysicalTherapyProjectV2.Areas.Identity
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