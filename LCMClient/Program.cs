using Blazored.LocalStorage;
using LCMClient.Features.Auth;
using LCMClient.Features.Auth.Models;
using LCMClient.Features.Dashboard;
using LCMClient.Features.Shared.Repository;
using LCMClient.Services;
using MatBlazor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LCMClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            
            builder.Services.AddScoped(sp => new HttpClient 
            { 
                BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"]) 
            })
                .AddBlazoredLocalStorage();

            // Configure auth
            // ref: https://aka.ms/blazor-standalone-auth
            builder.Services.AddOidcAuthentication(options =>
            {                
                builder.Configuration.Bind("Local", options.ProviderOptions);
            });

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDashboardRepository, DashboardRepository>();

            services.AddScoped<JWTAuthenticationStateProvider>();
            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
            );
            services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
               provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
                );

            services.AddScoped<TokenRenewer>();

            services.AddMudBlazorDialog();
            services.AddMudBlazorSnackbar();
            services.AddMudBlazorResizeListener();

            services.AddMatBlazor();

            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.TopCenter;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });
        }
    }
}
