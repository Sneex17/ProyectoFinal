namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoAltaDecorator : TurnoDecoratorBase
    {
        public TurnoAltaDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Alta";

        public override string GetColorFila() => "LightSkyBlue";

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Alta";
    }

}
