using BlazorWebAppDemo.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<IAnimalService, AnimalService>();

await builder.Build().RunAsync();
