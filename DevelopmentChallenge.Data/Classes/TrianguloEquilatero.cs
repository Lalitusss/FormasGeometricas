using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormasGeometricasAbstract
    {
        private decimal _lado;
        private EnumFormas _nombreForma;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override EnumFormas NombreForma { get => _nombreForma; set => _nombreForma = EnumFormas.TrianguloEquilatero; }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
