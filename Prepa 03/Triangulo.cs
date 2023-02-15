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
        private float _height; //aunque no se usan, prefiero dejarlos especificados.
        private float _bt;

        public Triangulo(float ladoa,
                         float height,
                         float bt,
                         string color) : base(color)
        {
            _ladoa = ladoa;
            _height = height;
            _bt = bt;
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