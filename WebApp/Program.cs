using Mapster;
using Microsoft.EntityFrameworkCore;
using WebApp;
using WebApp.Endpoints;
using WebApp.Mappings;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<AppDb>(opt => opt.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Football; Integrated Security = true"));
builder.Services.AddDbContext<AppDb>(opt => opt.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=Football;Trusted_Connection=True;TrustServerCertificate=true"));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddMapster();
MapsterConfig.Configure();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.RegisterPlayerEndpoints();
app.RegisterClubEndpoints();

app.Run();