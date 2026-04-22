using CEntidades.Models;
using CNegocio;

namespace CNegocio.Tests.Validators;

public class ValidacionUsuarioTests
{
    [Fact]
    public void Validar_UsuarioValido_NoDebeTenerErrores()
    {
        var validator = new ValidacionUsuario();
        var usuario = new Usuario 
        { 
            Usuario1 = "juanperez", 
            Contrasena = "password123" 
        };
        
        var result = validator.Validate(usuario);
        
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Validar_UsuarioSinUsuario_DebeTenerError()
    {
        var validator = new ValidacionUsuario();
        var usuario = new Usuario 
        { 
            Usuario1 = "", 
            Contrasena = "password123" 
        };
        
        var result = validator.Validate(usuario);
        
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Validar_UsuarioSinContrasena_DebeTenerError()
    {
        var validator = new ValidacionUsuario();
        var usuario = new Usuario 
        { 
            Usuario1 = "juanperez", 
            Contrasena = "" 
        };
        
        var result = validator.Validate(usuario);
        
        Assert.False(result.IsValid);
    }
}