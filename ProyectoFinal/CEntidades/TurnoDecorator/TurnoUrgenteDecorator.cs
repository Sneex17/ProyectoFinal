namespace CEntidades.TurnoDecorator
{
    public sealed class TurnoUrgenteDecorator : TurnoDecoratorBase
    {
        public TurnoUrgenteDecorator(ITurno turno) : base(turno) { }

        public override string GetEtiqueta() => "Urgente";

        public override string GetColorFila() => "#FFC8C8";

        public override System.Drawing.Color GetColor() => System.Drawing.Color.FromArgb(255, 200, 200);

        public override string GetDescripcion()
            => $"{base.GetDescripcion()} | Prioridad: Urgente";
    }

}
