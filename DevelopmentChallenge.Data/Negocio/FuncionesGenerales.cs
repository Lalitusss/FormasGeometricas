using DevelopmentChallenge.Data.Classes;
using System.Text;

namespace DevelopmentChallenge.Data.Negocio
{
    public class FuncionesGenerales
    {
        public static StringBuilder AsignarIdiomaVacio(Idiomas idioma)
        {
            var sb = new StringBuilder();

            switch (idioma)
            {
                case Idiomas.Castellano:
                    sb.Append("<h1>Lista vacía de formas!</h1>");
                    break;
                case Idiomas.Ingles:
                    sb.Append("<h1>Empty list of shapes!</h1>");
                    break;
                default: break;
            }

            return sb;
        }

        public static StringBuilder AsignarIdioma(Idiomas idioma)
        {
            var sb = new StringBuilder();

            switch (idioma)
            {
                case Idiomas.Castellano:
                    sb.Append("<h1>Reporte de Formas</h1>");
                    break;
                case Idiomas.Ingles:
                    sb.Append("<h1>Shapes report</h1>");
                    break;
                default: break;
            }

            return sb;
        }


        public static string TraducirForma(EnumFormas tipo, int cantidad, Idiomas idioma)
        {
            switch (tipo)
            {
                case EnumFormas.Cuadrado:
                    if (idioma == Idiomas.Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    else return cantidad == 1 ? "Square" : "Squares";
                case EnumFormas.Circulo:
                    if (idioma == Idiomas.Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
                    else return cantidad == 1 ? "Circle" : "Circles";
                case EnumFormas.TrianguloEquilatero:
                    if (idioma == Idiomas.Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else return cantidad == 1 ? "Triangle" : "Triangles";
            }

            return string.Empty;
        }


        public static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, EnumFormas tipo, Idiomas idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == Idiomas.Castellano)
                    return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

                return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
