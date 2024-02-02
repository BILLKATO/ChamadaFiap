using ChamadaFiap;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);



var connection = builder.Configuration
    .GetConnectionString("AZURE_CONNECTION_STRING2");

builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet(
    "/chamadas",
    (MyDbContext context, int professor, int turma) =>
    context.ClassPeriods
        .Include(classPeriod => classPeriod.Class).ThenInclude(_class => _class.Team)
        .Include(classPeriod => classPeriod.Class).ThenInclude(_class => _class.Subject)
        .Where(classPeriod => classPeriod.Class.TeacherId == professor && classPeriod.Class.TeamId == turma).ToList()
).WithOpenApi();

app.Run();