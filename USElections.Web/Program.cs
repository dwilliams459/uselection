using USElections.Data;
using USElections.Data.Models;
using Microsoft.EntityFrameworkCore;
using USElections.Repos;
using USElections.Repos.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<USElectionsDBContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("USStatesDb")));

// Repository Pattern
builder.Services.AddScoped<IUSStateRepo, USStateRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(cp => cp.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection(); 
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
       name: "default",
       pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapFallbackToFile("index.html");

    endpoints.MapAreaControllerRoute(
        name: "Events",
        areaName: "Events",
        pattern: "{controller=Events}/{action=Index}/{id?}");
});

app.Run();
