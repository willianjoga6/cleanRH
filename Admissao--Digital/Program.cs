using Admissao__Digital.Core.Interface.Infra;
using Admissao__Digital.Core.Interface.Services;
using Admissao__Digital.Core.Services;
using Admissao__Digital.Infra.Infra;
using Admissao__Digital.Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

// injeção de dependência
builder.Services.AddScoped<IContratadoService, ContratadoService>();
builder.Services.AddScoped<IValidadorFotosService, ValidadorFotosService>();

builder.Services.AddScoped<IConexaoDB, ConexaoDB>();
builder.Services.AddScoped<IInserirContratado, InserirContratado>();
builder.Services.AddScoped<IInserirDependentes, InserirDependentes>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
