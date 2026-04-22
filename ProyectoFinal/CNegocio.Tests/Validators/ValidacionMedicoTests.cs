using CEntidades.Models;
using CNegocio;

namespace CNegocio.Tests.Validators;

public class ValidacionMedicoTests
{
    [Fact]
    public void Validar_MedicoValido_NoDebeTenerErrores()
    {
        var validator = new ValidacionMedico();
        var medico = new Medico 
        { 
            Nombre = "Juan", 
            Apellido = "Perez", 
            Nlicencia = "LM12345" 
        };
        
        var result = validator.Validate(medico);
        
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Validar_MedicoSinNombre_DebeTenerError()
    {
        var validator = new ValidacionMedico();
        var medico = new Medico 
        { 
            Nombre = "", 
            Apellido = "Perez", 
            Nlicencia = "LM12345" 
        };
        
        var result = validator.Validate(medico);
        
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Validar_MedicoSinApellido_DebeTenerError()
    {
        var validator = new ValidacionMedico();
        var medico = new Medico 
        { 
            Nombre = "Juan", 
            Apellido = "", 
            Nlicencia = "LM12345" 
        };
        
        var result = validator.Validate(medico);
        
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Validar_MedicoSinLicencia_DebeTenerError()
    {
        var validator = new ValidacionMedico();
        var medico = new Medico 
        { 
            Nombre = "Juan", 
            Apellido = "Perez", 
            Nlicencia = "" 
        };
        
        var result = validator.Validate(medico);
        
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Validar_MedicoNull_DebeTenerErrores()
    {
        var validator = new ValidacionMedico();
        var medico = new Medico 
        { 
            Nombre = null!, 
            Apellido = null!, 
            Nlicencia = null! 
        };
        
        var result = validator.Validate(medico);
        
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Validar_MedicoConNombreNulo_DebeContenerErrorNOMBRE()
    {
        var validator = new ValidacionMedico();
        var medico = new Medico 
        { 
            Nombre = null!, 
            Apellido = "Perez", 
            Nlicencia = "LM12345" 
        };
        
        var result = validator.Validate(medico);
        
        Assert.Contains(result.Errors, e => e.PropertyName == "Nombre");
    }
}