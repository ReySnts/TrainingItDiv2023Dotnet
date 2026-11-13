using Microsoft.EntityFrameworkCore;
using TrainingItDiv2023Api.Classes;
using TrainingItDiv2023Api.Classes.Helpers;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddDbContext<DbContextSchool>(optionsAction: options => options
    .UseSqlServer(builder.Configuration
        .GetConnectionString(name: "DBConnection")));

services.AddScoped<HelperGender>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();