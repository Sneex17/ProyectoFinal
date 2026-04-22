using CEntidades.StatePattern;

namespace CNegocio.Tests.StatePattern;

public class EstadoTurnoContextoTests
{
    [Fact]
    public void Constructor_EstadoInicial_DebeSerCreado()
    {
        var contexto = new EstadoTurnoContexto();
        
        Assert.IsType<EstadoCreado>(contexto.estado);
        Assert.Equal("Creado", contexto.estado.Nombre);
    }

    [Fact]
    public void Crear_DesdeCreado_NoCambiaEstado()
    {
        var contexto = new EstadoTurnoContexto();
        var estadoInicial = contexto.estado;
        
        contexto.Creado();
        
        Assert.Equal(estadoInicial, contexto.estado);
    }

    [Fact]
    public void EnAtencion_DesdeCreado_CambiaAEnAtencion()
    {
        var contexto = new EstadoTurnoContexto();
        
        contexto.EnAtencion();
        
        Assert.IsType<EstadoEnAtencion>(contexto.estado);
        Assert.Equal("En Atencion", contexto.estado.Nombre);
    }

    [Fact]
    public void Cancelado_DesdeCreado_CambiaACancelado()
    {
        var contexto = new EstadoTurnoContexto();
        
        contexto.Cancelado();
        
        Assert.IsType<EstadoCancelado>(contexto.estado);
        Assert.Equal("Cancelado", contexto.estado.Nombre);
    }

    [Fact]
    public void Postergado_DesdeCreado_CambiaAPostergado()
    {
        var contexto = new EstadoTurnoContexto();
        
        contexto.Postergado();
        
        Assert.IsType<EstadoPostergado>(contexto.estado);
        Assert.Equal("Postergado", contexto.estado.Nombre);
    }

    [Fact]
    public void Atendido_DesdeEnAtencion_CambiaAAtendido()
    {
        var contexto = new EstadoTurnoContexto();
        contexto.EnAtencion();
        
        contexto.Atendido();
        
        Assert.IsType<EstadoAtendido>(contexto.estado);
        Assert.Equal("Atendido", contexto.estado.Nombre);
    }

    [Fact]
    public void Atendido_DesdeCreado_NoCambiaEstado()
    {
        var contexto = new EstadoTurnoContexto();
        
        contexto.Atendido();
        
        Assert.IsType<EstadoCreado>(contexto.estado);
    }

    [Fact]
    public void TransicionCompleta_CreadoEnAtencionAtendido_FlujoValido()
    {
        var contexto = new EstadoTurnoContexto();
        
        contexto.EnAtencion();
        Assert.IsType<EstadoEnAtencion>(contexto.estado);
        
        contexto.Atendido();
        Assert.IsType<EstadoAtendido>(contexto.estado);
    }

    [Fact]
    public void EstadoAtendido_NoAdmiteTransiciones()
    {
        var contexto = new EstadoTurnoContexto();
        contexto.EnAtencion();
        contexto.Atendido();
        
        var estadoActual = contexto.estado;
        
        contexto.Creado();
        contexto.EnAtencion();
        contexto.Cancelado();
        contexto.Postergado();
        
        Assert.Equal(estadoActual, contexto.estado);
    }

    [Fact]
    public void EstadoCancelado_NoAdmiteTransiciones()
    {
        var contexto = new EstadoTurnoContexto();
        contexto.Cancelado();
        
        var estadoActual = contexto.estado;
        
        contexto.Creado();
        contexto.EnAtencion();
        contexto.Atendido();
        contexto.Postergado();
        
        Assert.Equal(estadoActual, contexto.estado);
    }
}