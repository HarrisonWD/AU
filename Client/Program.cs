using AU.Client;
using AU.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ProfileViewModel>();
builder.Services.AddSingleton<SettingsViewModel>();
builder.Services.AddSingleton<LoginViewModel>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthentificationStateProvider>();

var host = builder.Build();

var profileViewModel = host.Services.GetRequiredService<ProfileViewModel>();

await host.RunAsync();
