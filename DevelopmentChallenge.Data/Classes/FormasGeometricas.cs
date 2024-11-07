namespace DevelopmentChallenge.Data.Classes
{
    public class FormasGeometricas
    {
        public EnumFormas Tipo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Largo { get; set; }
        public decimal Altura { get; set; }
        public decimal Lado3 { get; set; }
        public decimal Lado4 { get; set; }

        public FormasGeometricas(EnumFormas tipo, decimal ancho) {

            Tipo = tipo;
            Ancho = ancho;            
        }

        public FormasGeometricas(EnumFormas tipo, decimal ancho, decimal largo)
        {
            Tipo = tipo;
            Ancho = ancho;
            Largo = largo;
        }

        public FormasGeometricas(EnumFormas tipo, decimal ancho, decimal largo, decimal altura)
        {
            Tipo = tipo;
            Ancho = ancho;
            Largo = largo;
            Altura = altura;
        }

        public FormasGeometricas(EnumFormas tipo, decimal ancho, decimal largo, decimal lado3, decimal lado4)
        {
            Tipo = tipo;
            Ancho = ancho;
            Largo = largo;
            Lado3 = lado3;
            Lado4 = lado4;
        }
    }
}
