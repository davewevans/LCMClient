using Blazored.LocalStorage;
using LCMClient.Features.Auth;
using LCMClient.Features.Auth.Models;
using LCMClient.Features.Dashboard;
using LCMClient.Features.Orphans.Repository;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Features.Shared.Repository;
using LCMClient.Services;
using MatBlazor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;
using Syncfusion.Blazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using LCMClient.Repository;
using Tewr.Blazor.FileReader;

namespace LCMClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Syncfusion -- register community service license
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense(builder.Configuration["SyncfusionLicense"]);


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
            services.AddScoped<IOrphanRepository, OrphanRepository>();
            services.AddScoped<IDashboardRepository, DashboardRepository>();
            services.AddScoped<IPDFRepository, PDFRepository>();
            services.AddScoped<IPictureRepository, PictureRepository>();
            services.AddScoped<IAcademicRepository, AcademicRepository>();
            services.AddScoped<IGuardianRepository, GuardianRepository>();
            services.AddScoped<ISponsorRepository, SponsorRepository>();
            services.AddScoped<IOrphanSponsorRepository, OrphanSponsorRepository>();
            services.AddScoped<INarrationRepository, NarrationRepository>();


            services.AddScoped<JWTAuthenticationStateProvider>();
            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
            );
            services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
               provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
                );

            services.AddScoped<TokenRenewer>();

            // Configure MudBlazor
            services.AddMudBlazorDialog();
            services.AddMudBlazorSnackbar();
            services.AddMudBlazorResizeListener();

            // Configure MatBlazor
            services.AddMatBlazor();
            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.TopCenter;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 5000;
            });

            // Syncfusion
            services.AddSyncfusionBlazor();

            // Terp file reader
            services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);
        }
    }
}
