using MonitoramentoAPI.Presentation.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do IConfiguration (j� vem pronto no builder)
var configuration = builder.Configuration;

// Adiciona os servi�os da aplica��o
builder.Services.AddControllers();

// Configura��o do Swagger
SwaggerConfiguration.AddSwaggerSetup(builder.Services);

// Configura��o do Entity Framework (passando IConfiguration)
EntityFrameworkConfiguration.AddEntityFrameworkSetup(builder.Services, configuration);

// Inje��o de depend�ncias customizadas
DependencyInjectionConfiguration.AddDependencyInjectionSetup(builder.Services);

// AutoMapper
AutoMapperConfiguration.AddAutoMapperSetup(builder.Services);

var app = builder.Build();

// Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwaggerSetup(); // Usa o m�todo de extens�o igual no Startup antigo
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

