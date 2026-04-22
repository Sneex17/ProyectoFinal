using CEntidades.Models;
using CNegocio;

namespace CNegocio.Tests.Validators;

public class ValidacionEspecialidadesTests
{
    [Fact]
    public void Validar_EspecialidadValida_NoDebeTenerErrores()
    {
        var validator = new ValidacionEspecialidades();
        var especialidad = new Especialidade 
        { 
            Nombre = "Cardiología" 
        };
        
        var result = validator.Validate(especialidad);
        
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Validar_EspecialidadSinNombre_DebeTenerError()
    {
        var validator = new ValidacionEspecialidades();
        var especialidad = new Especialidade 
        { 
            Nombre = "" 
        };
        
        var result = validator.Validate(especialidad);
        
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Validar_EspecialidadNombreNulo_DebeTenerError()
    {
        var validator = new ValidacionEspecialidades();
        var especialidad = new Especialidade 
        { 
            Nombre = null! 
        };
        
        var result = validator.Validate(especialidad);
        
        Assert.False(result.IsValid);
    }
}