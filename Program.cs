using Social_Media_API.Data;
using Microsoft.EntityFrameworkCore;
using Social_Media_API.Services;
using Social_Media_API.Services.Repository;
using Social_Media_API.Services.Repository.IRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using System.Security.Policy;


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
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

//! AUTHENTICATION SETTINGS
var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }
).AddJwtBearer(
    //!BEARER OPTIONS
    options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    }
);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//! BEARER TOKEN IN SWAGGER
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        //? description of how it's should be generated in swagger
        Description =
            "JWT Authorization header using the Bearer scheme. \r\n\r\n " +
            "Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\n" +
            "Example: \"Bearer 12345abcdef\"",
        Name = "Authorization", //? header name in request 
        In = ParameterLocation.Header, //? location should be in header
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });

    //! DIFFERENT VERSIONS SWAGGER DOC CONTENT
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0",
        Title = "Social_Media V1",
        Description = "API to manage Social Media",
        // TermsOfService = new Uri("bananapotato.noidea"),
        // Contact = new OpenApiContact
        // {
        //     Name = "Dotnetmastery",
        //     Url = new Uri("somewhere.noidea")
        // },
        // License = new OpenApiLicense
        // {
        //     Name = "Example License",
        //     Url = new Uri("here.noidea")
        // }
    });

    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2.0",
        Title = "Social_Media V2",
        Description = "API to manage Social Media",
        // TermsOfService = new Uri("bananapotato.noidea"),
        // Contact = new OpenApiContact
        // {
        //     Name = "Dotnetmastery",
        //     Url = new Uri("somewhere.noidea")
        // },
        // License = new OpenApiLicense
        // {
        //     Name = "Example License",
        //     Url = new Uri("here.noidea")
        // }
    });
    
});

//! VERSIONING
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    options.ReportApiVersions = true; // returns supported api versions in header
});

//! PASS VERSION IN SWAGGER
builder.Services.AddVersionedApiExplorer
(
    options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true; //auto sets version used in swagger url
    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        //! DIFFERENT VERSIONS SWAGGER DOC
        options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Social_Mediav1"); //url , name
            options.SwaggerEndpoint("/swagger/v2/swagger.json", "Social_Mediav2"); 

        }
    );
}

app.UseHttpsRedirection();

//! AUTHENTICATION PIPELINE
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
