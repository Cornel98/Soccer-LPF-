using Microsoft.EntityFrameworkCore;
using PROIECTDaw.DataContext;  // Pentru TeamAppDb
using PROIECTDaw.Controllers;  // Pentru TestController
using PROIECTDaw.Models.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Înregistrarea serviciilor pentru aplicație
builder.Services.AddControllersWithViews();

// Înregistrarea serviciului EchipeService pentru a fi utilizat în aplicație
builder.Services.AddScoped<EchipeDTO>();

// Înregistrarea DbContext pentru a putea accesa baza de date
builder.Services.AddDbContext<TeamAppDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Asigură-te că ai conexiunea corectă în appsettings.json

var app = builder.Build();

// Configurarea pipeline-ului HTTP
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Adăugăm ruta explicită pentru TestController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Rutele pentru TestController
app.MapControllerRoute(
    name: "test",
    pattern: "Test/TestConnection",  // Rutele sunt de tipul Controller/Action
    defaults: new { controller = "Test", action = "TestConnection" }
);

app.Run();
