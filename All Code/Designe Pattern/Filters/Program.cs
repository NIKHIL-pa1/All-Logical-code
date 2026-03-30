using Filters.Filters;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy
                .SetIsOriginAllowed(_ => true) // allow all origins
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
});

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomAuthorizationFilter>();
    options.Filters.Add<CustomActionFilter>();
    //options.Filters.Add<CustomResultFilter>();
    //options.Filters.Add<CustomExceptionFilter>();
    //options.Filters.Add<CustomResourceFilter>();
});


builder.Services.AddEndpointsApiExplorer();
// below code to add header in swagger
builder.Services.AddSwaggerGen(options =>          
{
    options.AddSecurityDefinition("UserHeader", new OpenApiSecurityScheme
    {
        Name = "user",
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Header,
        Description = "Enter user value (admin)"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "UserHeader"
                }
            },
            new List<string>()
        }
    });
});

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
