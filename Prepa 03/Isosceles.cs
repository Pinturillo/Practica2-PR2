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
        private float _ladoa;
        private float _ladob;
        private float _height;
        private float _bt;
        public Isosceles(float height,
                        float bt,
                        float ladoa,
                        float ladob) : base(7, 6, 5, "naranjita")
        {
            _ladoa = ladoa;
            _ladob = ladob;
            _height = height;
            _bt = bt; //bt stands for base del triangulo
        }
        public override double GetArea()
        {
            return ((_bt * _height) / 2); //bt stands for base del triangulo
        }

        public override double GetPerimetro()
        {
            return ((2 * _ladoa) + _ladob);
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Soy un triangulo isosceles. mi area es de {0}, mi perimetro {1} y mi color: {2}", GetArea(), GetPerimetro(), GetColor());
            base.MostrarDatos();
        }
    }
}
