using Babidi.Dashboard;
using Babidi.Dashboard.Services;
using BlazorBlueprint.Components.Toast;
using BlazorBlueprint.Primitives.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorBlueprintPrimitives();
builder.Services.AddScoped<ToastService>();

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<ThemeService>();
builder.Services.AddScoped<ItemService>();

await builder.Build().RunAsync();
