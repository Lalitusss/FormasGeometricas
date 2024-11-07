namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormasGeometricasAbstract
    {
        private decimal _lado;
        private EnumFormas _nombreForma;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override EnumFormas NombreForma { get => _nombreForma; set => _nombreForma = EnumFormas.Cuadrado; }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
