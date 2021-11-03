﻿/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Security_Authorization_RouterCascadingParameter
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.RootComponents.Add<App>("#app");

            // Setup Autorization
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            // Use fake AuthenticationStateProvider
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            //builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider1>();
            //builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider2>();

            await builder.Build().RunAsync();
        }
    }
}
