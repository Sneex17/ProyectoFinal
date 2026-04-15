namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoBajaDecorator : TurnoDecoratorBase
    {
        public TurnoBajaDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Baja";

        public override string GetColorFila() => "PaleGreen";

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Baja";
    }

}
