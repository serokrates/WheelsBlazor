using Microsoft.EntityFrameworkCore;
using WheelsBlazor.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WheelsDB");

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContextFactory<WheelsContext>(options => options.UseSqlite(connectionString));
builder.Services.AddScoped<IWheelsRepository, WheelsRepository>();
builder.Services.AddScoped<WheelsService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
