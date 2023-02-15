using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    // leer comentario en Isoceles.cs.

    class Triangulo : Figura
    {
        private float _ladoa;

        public Triangulo(float ladoa,
                         string color) : base(color)
        {
            _ladoa = ladoa;
        }

        public override double GetArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(_ladoa, 2);
        }

        public override double GetPerimetro()
        {
            return _ladoa + _ladoa + _ladoa;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
        }
    }
}