using System.Globalization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Organize.Business;
using Organize.Shared.Contracts;
using Organize.Test;
using Organize.WASM;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped<IUserManager, UserManagerTest>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

var host = builder.Build();

var currentUserService = host.Services.GetRequiredService<ICurrentUserService>();
TestData.CreateTestUser();
currentUserService.CurrentUser = TestData.TestUser;
await host.RunAsync();