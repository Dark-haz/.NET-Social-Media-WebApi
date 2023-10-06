using Social_Media_API.Data;
using Microsoft.EntityFrameworkCore;
using Social_Media_API.Services;
using Social_Media_API.Services.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//! HTTP PATCH

builder.Services.AddControllers().AddNewtonsoftJson();

//! DB CONTEXT

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultMysqlConnection") ?? throw new InvalidOperationException("Connection string 'DefaultMysqlConnection' not found.")));

//! AUTOMAPPER

builder.Services.AddAutoMapper(typeof(MappingConfig));

//! REPOSITORY
builder.Services.AddScoped<IPostRepository,PostRepository>();

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
