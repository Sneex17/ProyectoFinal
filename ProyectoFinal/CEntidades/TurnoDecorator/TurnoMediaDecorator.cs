namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoMediaDecorator : TurnoDecoratorBase
    {
        public TurnoMediaDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Media";

        public override string GetColorFila() => "Khaki";

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Media";
    }

}
