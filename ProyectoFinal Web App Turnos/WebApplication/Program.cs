using HospitalTurnos.Data;
using HospitalTurnos.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ─── Servicios ─────────────────────────────────────────────────────────────

builder.Services.AddControllersWithViews();

// DbContext — usa la cadena de conexión de appsettings.json
builder.Services.AddDbContext<HospitalTurnosContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("HospitalTurnos")
    )
);

// Servicio de turnos con BD real.
// Scoped: una instancia por request HTTP (correcto para EF Core).
builder.Services.AddScoped<ITurnoService, DbTurnoService>();

// ─── Pipeline ──────────────────────────────────────────────────────────────

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Turnos}/{action=Index}/{id?}");

app.Run();