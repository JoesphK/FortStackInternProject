using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages or MVC depending on your app
builder.Services.AddRazorPages(); // Use AddControllersWithViews() for MVC

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(80); // Important for Docker
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//app.UseHttpsRedirection(); // Can be disabled if no HTTPS certs
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Use Razor Pages
app.MapRazorPages();

// OR, if you're using MVC:
// app.MapDefaultControllerRoute();

app.Run();
