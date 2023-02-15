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
        private float _ladoa;
        private float _ladob;
        private float _ladoc;
        private float _height;
        private float _bt; //base triangulo

        public Escaleno(float height,
                        float bt,
                        float ladoa,
                        float ladob,
                        float ladoc) : base(7, 6, 5, "azulito")
        {
            _height = height;
            _bt = bt;
            _ladoa = ladoa;
            _ladob = ladob;
            _ladoc = ladoc;
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