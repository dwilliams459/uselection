using USElections.WASM;
using USElections.WASM.Repos.Football;
using USElections.WASM.Repository.Home;
using USElections.WASM.Repository.SocialClub;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ISocialClubRepository, SocialClubRepository>();
builder.Services.AddScoped<IHomeRepository, HomeRepository>();
builder.Services.AddScoped<IFootballRepository, FootballRepository>();

await builder.Build().RunAsync();
