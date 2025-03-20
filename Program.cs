using ServerProjectMvcWithoutView.Configurations;
using ServerProjectMvcWithoutView.Data;
using ServerProjectMvcWithoutView.Repositories;
using ServerProjectMvcWithoutView.Repositories.Interface;
using Microsoft.Extensions.Options;
using ServerProjectMvcWithoutView.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("QueuesManagementDatabase"));

builder.Services.AddScoped<MongoDbContext>(serviceProvider =>
{
    var appSettings = serviceProvider.GetRequiredService<IOptions<AppSettings>>().Value;
        
    return new MongoDbContext(appSettings);
});

builder.Services.AddScoped<IQueuesRepository, QueuesRepository>();

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("AllowAngularOrigin");

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();


app.Run();

