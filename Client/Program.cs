using AU.Client;
using AU.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ProfileViewModel>();
builder.Services.AddSingleton<SettingsViewModel>();

var host = builder.Build();

var profileViewModel = host.Services.GetRequiredService<ProfileViewModel>();
profileViewModel.GetProfile();

await host.RunAsync();
