using BlazorDownloadFile;
using Blazored.LocalStorage;
using FakeDataMaker;
using FakeDataMaker.Services.Implementations;
using FakeDataMaker.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

#region Initialization

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://andredobbss.github.io/FakeDataMaker/") });

#endregion

#region Congiguration MudBlazor

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazorDownloadFile();

#endregion

#region Configuration Services

builder.Services.AddScoped<IAccountingFaker, AccountingFaker>();
builder.Services.AddScoped<IAerospaceFaker, AerospaceFaker>();
builder.Services.AddScoped<IAgricultureFaker, AgricultureFaker>();
builder.Services.AddScoped<IAutomotiveFaker, AutomotiveFaker>();
builder.Services.AddScoped<IBiotechnologyFaker, BiotechnologyFaker>();
builder.Services.AddScoped<ICivilConstructionFaker, CivilConstructionFaker>();
builder.Services.AddScoped<IConsumerGoodsFaker, ConsumerGoodsFaker>();
builder.Services.AddScoped<IContabilityFaker, ContabilityFaker> ();
builder.Services.AddScoped<ICybersecurityFaker, CybersecurityFaker>();
builder.Services.AddScoped<IEcommerceFaker, EcommerceFaker>();
builder.Services.AddScoped<IEconomyFaker, EconomyFaker>();
builder.Services.AddScoped<IEducationFaker, EducationFaker>();
builder.Services.AddScoped<IEnergyFaker, EnergyFaker>();
builder.Services.AddScoped<IEntertainmentFaker, EntertainmentFaker>();
builder.Services.AddScoped<IEnvironmentalServiceFaker, EnvironmentalServiceFaker>();
builder.Services.AddScoped<IFinanceFaker, FinanceFaker>();
builder.Services.AddScoped<IFoodFaker, FoodFaker>();
builder.Services.AddScoped<IGovernmentPublicSectorFaker, GovernmentPublicSectorFaker>();
builder.Services.AddScoped<IHealthcareFaker, HealthcareFaker>();
builder.Services.AddScoped<IHospitalityFaker, HospitalityFaker>();
builder.Services.AddScoped<IInformationTechnologyFaker, InformationTechnologyFaker>();
builder.Services.AddScoped<IInsuranceFaker, InsuranceFaker>();
builder.Services.AddScoped<ILegalServicesFaker, LegalServicesFaker>();
builder.Services.AddScoped<ILogisticsFaker, LogisticsFaker>();
builder.Services.AddScoped<IManufacturingFaker, ManufacturingFaker>();
builder.Services.AddScoped<IMarketingFaker, MarketingFaker>();
builder.Services.AddScoped<IMediaPublishingFaker, MediaPublishingFaker>();
builder.Services.AddScoped<IMiningFaker, MiningFaker>();
builder.Services.AddScoped<INonprofitFaker, NonprofitFaker>();
builder.Services.AddScoped<IRealEstateFaker, RealEstateFaker>();
builder.Services.AddScoped<IRetailFaker, RetailFaker>();
builder.Services.AddScoped<ISportsRecreationFaker, SportsRecreationFaker>();
builder.Services.AddScoped<ITelecommunicationsFaker, TelecommunicationsFaker>();
builder.Services.AddScoped<ITransportationFaker, TransportationFaker>();

builder.Services.AddScoped<IFileExporterService, FileExporterService>();
builder.Services.AddScoped<ILanguages, Languages>();
builder.Services.AddScoped<ISectors, Sectors>();

#endregion

#region Run Application

await builder.Build().RunAsync();

#endregion