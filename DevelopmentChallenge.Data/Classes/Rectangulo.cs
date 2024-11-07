namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormasGeometricasAbstract
    {
        private decimal _lado1;
        private decimal _lado2;
        private EnumFormas _nombreForma;

        public Rectangulo(decimal lado1, decimal lado2)
        {
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public override EnumFormas NombreForma { get => _nombreForma; set => _nombreForma = EnumFormas.Rectangulo; }
        public override decimal CalcularArea()
        {
            return _lado1 * _lado2;
        }

        public override decimal CalcularPerimetro()
        {
          return (_lado1 * 2) + (_lado2 * 2);
        }
    }
}
