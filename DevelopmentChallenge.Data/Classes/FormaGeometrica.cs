/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Formas
{
    Cuadrado = 1,
    TrianguloEquilatero = 2,
    Circulo = 3,
    Trapecio = 4,
    Rectangulo = 5
}

public enum Idiomas
{
    Castellano = 1,
    Ingles = 2
}

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<FormasGeometricas> formas, Idiomas idioma)
        {
            StringBuilder sb;

            if (!formas.Any())
            {
                sb = FuncionesGenerales.AsignarIdiomaVacio(idioma);
            }
            else
            {
                sb = FuncionesGenerales.AsignarIdioma(idioma);

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    switch (formas[i].Tipo)
                    {
                        case EnumFormas.Cuadrado:
                            numeroCuadrados++;
                            areaCuadrados += new Cuadrado(formas[i].Ancho).CalcularArea();
                            perimetroCuadrados += new Cuadrado(formas[i].Ancho).CalcularPerimetro();
                            break;
                        case EnumFormas.Circulo:
                            numeroCirculos++;
                            areaCirculos += new Circulo(formas[i].Ancho).CalcularArea();
                            perimetroCirculos += new Circulo(formas[i].Ancho).CalcularPerimetro();
                            break;
                        case EnumFormas.TrianguloEquilatero:
                            numeroTriangulos++;
                            areaTriangulos += new TrianguloEquilatero(formas[i].Ancho).CalcularArea();
                            perimetroTriangulos += new TrianguloEquilatero(formas[i].Ancho).CalcularPerimetro();
                            break;
                        case EnumFormas.Rectangulo:
                            numeroTriangulos++;
                            areaTriangulos += new Rectangulo(formas[i].Ancho, formas[i].Largo).CalcularArea();
                            perimetroTriangulos += new Rectangulo(formas[i].Ancho, formas[i].Largo).CalcularPerimetro();
                            break;
                        case EnumFormas.Trapecio:
                            numeroTriangulos++;
                            areaTriangulos += new Trapecio(formas[i].Ancho, formas[i].Largo, formas[i].Altura).CalcularArea();
                            perimetroTriangulos += new Trapecio(formas[i].Ancho, formas[i].Largo, formas[i].Lado3, formas[i].Lado4).CalcularPerimetro();
                            break;
                    }
                }

                sb.Append(FuncionesGenerales.ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, EnumFormas.Cuadrado, idioma));
                sb.Append(FuncionesGenerales.ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, EnumFormas.Circulo, idioma));
                sb.Append(FuncionesGenerales.ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, EnumFormas.TrianguloEquilatero, idioma));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Idiomas.Castellano ? "formas" : "shapes") + " ");
                sb.Append((idioma == Idiomas.Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }

    }
}
