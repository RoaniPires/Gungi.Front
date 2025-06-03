using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Gungi.Front;
using Gungi.Front.Services; // <-- Adicione esse using!

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registra o HttpClient para a API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5267/") });

// REGISTRA O SEU SERVIÇO
builder.Services.AddScoped<GungiApiService>();

await builder.Build().RunAsync();