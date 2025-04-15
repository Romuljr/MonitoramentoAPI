using MonitoramentoAPI.Presentation.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Configuração do IConfiguration (já vem pronto no builder)
var configuration = builder.Configuration;

// Adiciona os serviços da aplicação
builder.Services.AddControllers();

// Configuração do Swagger
SwaggerConfiguration.AddSwaggerSetup(builder.Services);

// Configuração do Entity Framework (passando IConfiguration)
EntityFrameworkConfiguration.AddEntityFrameworkSetup(builder.Services, configuration);

// Injeção de dependências customizadas
DependencyInjectionConfiguration.AddDependencyInjectionSetup(builder.Services);

// AutoMapper
AutoMapperConfiguration.AddAutoMapperSetup(builder.Services);

var app = builder.Build();

// Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwaggerSetup(); // Usa o método de extensão igual no Startup antigo
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

