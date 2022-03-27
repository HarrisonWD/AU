global using System.Net.Http.Json;
global using AU.Shared;
global using AU.Shared.Models;
global using AU.Client.Services.ProductService;
global using AU.Client.Services.CategoryService;
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
builder.Services.AddSingleton<RegisterViewModel>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthentificationStateProvider>();

var host = builder.Build();

var profileViewModel = host.Services.GetRequiredService<ProfileViewModel>();

await host.RunAsync();
