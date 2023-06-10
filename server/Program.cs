using server.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.OpenApi.Models;
using server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddDbContext<AppDbContext>(
    e => e.UseNpgsql("Server=localhost;Database=statsdb;Port=5432;User Id=postgres")
);


//add services
builder.Services.AddScoped<DbUpdateService>();
builder.Services.AddScoped<PlayerStatsService>();
builder.Services.AddScoped<SeasonService>();
builder.Services.AddScoped<SeasonStatsService>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});
var app = builder.Build();

//create database
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var dbUpdateService = scope.ServiceProvider.GetRequiredService<DbUpdateService>();
    var seasonService = scope.ServiceProvider.GetRequiredService<SeasonService>();
    var seasonStatsService = scope.ServiceProvider.GetRequiredService<SeasonStatsService>();
    context.Database.Migrate();
    //next two lines are to fix the current db schema
    //if your local volume does not have any data in it
    //then pls delete these lines
    seasonService.SeedSeasons();
    seasonService.UpdateExistingRecordsSeasons();
    seasonStatsService.UpdatePlayerSeasonStats();
    dbUpdateService.SeedDb("Content/team_box.csv", "Content/player_box.csv");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("swagger/v1/swagger.json", "API");
        c.RoutePrefix = string.Empty;
    });
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
