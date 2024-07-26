using USElections.WASM;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using USElections.WASM.Repos.USStates;

public class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        var baseAddress = new Uri("https://localhost:5003");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = baseAddress });
        builder.Services.AddScoped<IUSStatesRepository, USStatesRepository>();

        await builder.Build().RunAsync();
    }
}