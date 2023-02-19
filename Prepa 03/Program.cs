using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura3 = new Circulo(2, "negro");

            figura1.MostrarDatos();
          
            figura2.MostrarDatos();
           
            figura3.MostrarDatos();

            Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            Console.ReadLine();
          

            Triangulo triangulo = new Triangulo(5, "verde");
            Figura figura1 = triangulo;
            */

            Triangulo equilatero = new Equilatero();
            Figura equilatera = equilatero;

            Triangulo escaleno = new Escaleno();
            Figura escalena = escaleno;

            Triangulo isosceles = new Isosceles();
            Figura tIsosceles = isosceles;

            //figura1.MostrarDatos();
            equilatera.MostrarDatos();
            escalena.MostrarDatos();
            tIsosceles.MostrarDatos();


            Console.ReadKey();
            
        }
    }
}
