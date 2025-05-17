using BlazorDownloadFile;
using Blazored.LocalStorage;
using FakeDataMaker;
using FakeDataMaker.Services.Implementations;
using FakeDataMaker.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddBlazorDownloadFile();

builder.Services.AddScoped<ILanguages, Languages>();
builder.Services.AddScoped<ISectors, Sectors>();

builder.Services.AddScoped<IAgricultureFaker, AgricultureFaker>();
builder.Services.AddScoped<IAccountingFaker, AccountingFaker>();
builder.Services.AddScoped<IAerospaceFaker, AerospaceFaker>();
builder.Services.AddScoped<IAgricultureFaker, AgricultureFaker>();
builder.Services.AddScoped<IAutomotiveFaker, AutomotiveFaker>();

builder.Services.AddScoped<IFileExporterService, FileExporterService>();

await builder.Build().RunAsync();
