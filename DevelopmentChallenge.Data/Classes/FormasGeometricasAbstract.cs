namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormasGeometricasAbstract
    {
        public abstract EnumFormas NombreForma { get;  set; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

    }
}
