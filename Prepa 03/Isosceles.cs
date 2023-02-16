using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{

    // No especifican que tipo de triangulo isoceles y, tampoco piden condicionales para evitar valores incorrectos.

    internal class Isosceles : Triangulo
    {
        public Isosceles() : base(7, 6, 5, 4, 3, "naranjita")
        {

        }

        public override double GetArea()
        {
            return _bt * _height / 2; //bt stands for base del triangulo
        }

        public override double GetPerimetro()
        {
            return (2 * _ladoa) + _ladob;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Soy un triangulo isosceles. mi area es de {0}, mi perimetro {1} y mi color: {2}", GetArea(), GetPerimetro(), GetColor());
            base.MostrarDatos();
        }
    }
}
