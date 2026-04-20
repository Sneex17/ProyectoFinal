namespace CNegocio
{
    public class ControlExcepciones : Exception
    {
        public ControlExcepciones() : base() { }
        public ControlExcepciones(string mensaje) : base(mensaje) { }
    }
}
