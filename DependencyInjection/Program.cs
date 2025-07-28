using DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// DI kayd� (Scoped: Her HTTP iste�i i�in bir Teacher nesnesi olu�turur)
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
