using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    internal class Escaleno : Triangulo
    {
        public Escaleno() : base(7, 6, 5, 4, 3, "azulito")
        {
        }

        public override double GetArea()
        {
            return ((_bt * _height) / 2);
        }
        public override double GetPerimetro()
        {
            return _ladoa + _ladob + _ladoc;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Soy un triangulo escaleno. mi area es de {0}, mi perimetro {1} y mi color: {2}", GetArea(), GetPerimetro(), GetColor());
            base.MostrarDatos();
        }

    }
}