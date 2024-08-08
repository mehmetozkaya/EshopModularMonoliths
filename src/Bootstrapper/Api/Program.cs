
var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, config) =>
    config.ReadFrom.Configuration(context.Configuration));

// Add services to the container.

//common services: carter, mediatr, fluentvalidation
var catalogAssembly = typeof(CatalogModule).Assembly;
var basketAssembly = typeof(BasketModule).Assembly;

builder.Services
    .AddCarterWithAssemblies(catalogAssembly, basketAssembly);

builder.Services
    .AddMediatRWithAssemblies(catalogAssembly, basketAssembly);

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});

builder.Services
    .AddMassTransitWithAssemblies(builder.Configuration, catalogAssembly, basketAssembly);

builder.Services.AddKeycloakWebApiAuthentication(builder.Configuration);
builder.Services.AddAuthorization();

//module services: catalog, basket, ordering
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

builder.Services
    .AddExceptionHandler<CustomExceptionHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapCarter();
app.UseSerilogRequestLogging();
app.UseExceptionHandler(options => { });
app.UseAuthentication();
app.UseAuthorization();

app
    .UseCatalogModule()
    .UseBasketModule()
    .UseOrderingModule();

app.Run();