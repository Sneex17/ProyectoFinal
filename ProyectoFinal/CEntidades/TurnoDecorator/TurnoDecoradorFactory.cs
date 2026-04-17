using CEntidades.Models;

namespace CEntidades.TurnoDecorator
{
    /// <summary>
    /// Devuelve el decorador correcto según el TipoTurnoID del turno.
    /// Se usa en la capa de presentación para obtener el color y la etiqueta
    /// antes de mostrar la cola en el DataGridView.
    /// 
    /// Uso:
    ///   ITurno turnoDecorado = TurnoDecoradorFactory.Decorar(turno);
    ///   filaGrid.DefaultCellStyle.BackColor = Color.FromName(turnoDecorado.GetColorFila());
    /// </summary>
    public static class TurnoDecoradorFactory
    {
        public static ITurno Decorar(Turno turno)
        {
            return turno.PrioridadId switch
            {
                4 => new TurnoUrgenteDecorator(turno),
                3 => new TurnoBajaDecorator(turno),
                2 => new TurnoMediaDecorator(turno),
                _ => new TurnoAltaDecorator(turno)
            };
        }
    }
}
