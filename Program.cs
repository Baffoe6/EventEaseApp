using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using EventEaseApp.Data;
using EventEaseApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<EventEaseApp.App>("#app");
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<UserSessionService>();
builder.Services.AddSingleton<AttendanceService>();

await builder.Build().RunAsync();
