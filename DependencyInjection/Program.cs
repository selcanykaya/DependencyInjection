using DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// DI kaydý (Scoped: Her HTTP isteði için bir Teacher nesnesi oluþturur)
builder.Services.AddScoped<ITeacher, Teacher>();

builder.Services.AddControllers();

// Swagger 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapControllers();

app.Run();
