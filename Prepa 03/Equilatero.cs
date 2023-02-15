using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    internal class Equilatero : Triangulo
    {
        private float _ladoa;

        public Equilatero(float ladoa) : base(7, "verdecito")
        {
            _ladoa = ladoa;
        }

        public override double GetArea()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(_ladoa, 2);
        }

        public override double GetPerimetro()
        {
            return _ladoa + _ladoa + _ladoa;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Soy un triangulo equilatero. mi area es de {0}, mi perimetro {1} y mi color: {2}", GetArea(), GetPerimetro(), GetColor());
            base.MostrarDatos();
        }
    }
}
