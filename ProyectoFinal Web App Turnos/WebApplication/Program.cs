using HospitalTurnos.Services;

var builder = WebApplication.CreateBuilder(args);

// Servicios

builder.Services.AddControllersWithViews();

// Registro del servicio de turnos en memoria.
// Cuando se tenga la BD: reemplaza InMemoryTurnoService por DbTurnoService
// y cambia Singleton → Scoped (para que EF Core maneje el ciclo de vida).
builder.Services.AddSingleton<ITurnoService, InMemoryTurnoService>();

// Pipeline

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

// Ruta por defecto → TurnosController.Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Turnos}/{action=Index}/{id?}");

app.Run();