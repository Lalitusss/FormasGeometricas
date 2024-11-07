namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormasGeometricasAbstract
    {
        private decimal _lado1;
        private decimal _lado2;
        private decimal _lado3;
        private decimal _lado4;
        private decimal _altura;
        private EnumFormas _nombreForma;

        public Trapecio(decimal lado1, decimal lado2, decimal altura)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _altura = altura;
        }

        public Trapecio(decimal lado1, decimal lado2, decimal lado3, decimal lado4)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
            _lado4 = lado4;
        }

        public override EnumFormas NombreForma { get => _nombreForma; set => _nombreForma = value; }

        public override decimal CalcularArea()
        {
            return _altura * ((_lado1 + _lado2) / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (_lado1 + _lado2 +_lado3 + _lado4);
        }
    }
}
