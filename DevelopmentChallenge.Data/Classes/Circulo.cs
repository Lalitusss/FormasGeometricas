using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormasGeometricasAbstract
    {
        private decimal _lado;
        private EnumFormas _nombreForma;

        public Circulo(decimal lado)
        {
            _lado = lado;
        }

        public override EnumFormas NombreForma { get => _nombreForma; set => _nombreForma = EnumFormas.Circulo; }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
