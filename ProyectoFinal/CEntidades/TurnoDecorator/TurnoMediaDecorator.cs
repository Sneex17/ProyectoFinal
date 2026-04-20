namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoMediaDecorator : TurnoDecoratorBase
    {
        public TurnoMediaDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Media";

        public override string GetColorFila() => "#FFFFC8";

        public override System.Drawing.Color GetColor() => System.Drawing.Color.FromArgb(220, 255, 220);

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Media";
    }

}
