namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoUrgenteDecorator : TurnoDecoratorBase
    {
        public TurnoUrgenteDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Urgente";

        public override string GetColorFila() => "Tomato";

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Urgente";
    }

}
