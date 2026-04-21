namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoBajaDecorator : TurnoDecoratorBase
    {
        public TurnoBajaDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Baja";

        public override string GetColorFila() => "#DCFFDC";

        public override System.Drawing.Color GetColor() => System.Drawing.Color.FromArgb(200, 230, 255);

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Baja";
    }

}
