using CEntidades.Models;
using CNegocio;

namespace CNegocio.Tests.Validators;

public class ValidacionRecepcionistaTests
{
    [Fact]
    public void Validar_RecepcionistaValido_NoDebeTenerErrores()
    {
        var validator = new ValidacionRecepcionista();
        var recepcionista = new Recepcionista 
        { 
            Nombre = "Maria", 
            Apellido = "Gomez" 
        };
        
        var result = validator.Validate(recepcionista);
        
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Validar_RecepcionistaSinNombre_DebeTenerError()
    {
        var validator = new ValidacionRecepcionista();
        var recepcionista = new Recepcionista 
        { 
            Nombre = "", 
            Apellido = "Gomez" 
        };
        
        var result = validator.Validate(recepcionista);
        
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Validar_RecepcionistaSinApellido_DebeTenerError()
    {
        var validator = new ValidacionRecepcionista();
        var recepcionista = new Recepcionista 
        { 
            Nombre = "Maria", 
            Apellido = "" 
        };
        
        var result = validator.Validate(recepcionista);
        
        Assert.False(result.IsValid);
    }
}