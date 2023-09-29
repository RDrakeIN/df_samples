using df-samples.Data;
using df-samples.Services;
// Additional using declarations

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add the SampleContext
builder.Services.AddSqlite<SampleContext>("Data Source=df-samples.db");

// Add the PromotionsContext

builder.Services.AddScoped<SampleService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

// Add the CreateDbIfNotExists method call

app.MapGet("/", () => @"Dimensions Sample Tracker API. Navigate to /swagger to open the Swagger test UI.");

app.Run();
