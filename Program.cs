using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EscalationMatrixCountdown;
using EscalationMatrixCountdown.Services;
using Supabase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Read from wwwroot/appsettings.json
var supabaseUrl = builder.Configuration["Supabase:Url"];
var supabaseAnonKey = builder.Configuration["Supabase:AnonKey"];

// Program.cs
var options = new SupabaseOptions
{
    AutoRefreshToken = true,
    AutoConnectRealtime = true,
    Schema = "public"
};

// Initialize and register a single Client instance
var sb = new Client(supabaseUrl, supabaseAnonKey, options);
await sb.InitializeAsync();
builder.Services.AddSingleton(sb);

// Existing services
builder.Services.AddSingleton<IAircraftConfigService, StaticAircraftConfigService>();
builder.Services.AddSingleton<FlightsService>();

await builder.Build().RunAsync();