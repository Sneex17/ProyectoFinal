namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoAltaDecorator : TurnoDecoratorBase
    {
        public TurnoAltaDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Alta";

        public override string GetColorFila() => "#C8E6FF";

        public override System.Drawing.Color GetColor() => System.Drawing.Color.FromArgb(255, 255, 200);

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Alta";
    }

}
