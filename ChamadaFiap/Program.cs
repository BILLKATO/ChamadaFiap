using AutoMapper;
using ChamadaFiap;
using ChamadaFiap.Dto;
using ChamadaFiap.Entities;
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
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
    (MyDbContext context, IMapper mapper, int professor, int turma) =>
    {
        return mapper.Map<List<ReadClassPeriodDto>>(context.ClassPeriods
            .Include(classPeriod => classPeriod.Class).ThenInclude(_class => _class.Team)
            .Include(classPeriod => classPeriod.Class).ThenInclude(_class => _class.Subject)
            .Where(classPeriod => 
                classPeriod.Class.TeacherId == professor && 
                classPeriod.Class.TeamId == turma &&
                classPeriod.StartTime.Date >= DateTime.Now.Date
           ).ToList());
    }
).WithOpenApi();

app.MapGet(
    "/alunos",
    (MyDbContext context, IMapper mapper, int turma) =>
    {
        return mapper.Map<List<ReadStudentDto>>(context.Students
            .Where(student =>
                student.TeamId == turma
           ).ToList());
    }
).WithOpenApi();

app.MapGet(
    "/courseSyllabus",
    (MyDbContext context, IMapper mapper, int classPeriod) =>
    {
        return mapper.Map<List<ReadStudentDto>>(context.CourseSyllabuses
            .Where(courseSyllabus =>
                courseSyllabus.ClassPeriodId == classPeriod
           ).ToList());
    }
).WithOpenApi();

app.Run();