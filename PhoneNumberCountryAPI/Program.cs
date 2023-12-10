using Microsoft.EntityFrameworkCore;
using PhoneNumberCountry.Data;
using PhoneNumberCountry.Interfaces;
using PhoneNumberCountry.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register your DbContext here
builder.Services.AddDbContext<PhoneNumberContext>(options =>
{
    options.UseInMemoryDatabase("PhoneNumberDB"); // Use an in-memory database for this example
});

builder.Services.AddTransient<IPhoneNumberService, PhoneNumberService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Ensure database is initialized with sample data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<PhoneNumberContext>();
    DbInitializer.Initialize(context); // Initialize the in-memory database with sample data
}


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
