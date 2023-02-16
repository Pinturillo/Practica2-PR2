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
        //implementacion de los atributos a heredar.

        protected float _ladoa;
        protected float _ladob;
        protected float _ladoc;
        protected float _height; 
        protected float _bt;

        public Triangulo(float ladoa, 
                         float ladob,
                         float ladoc,
                         float height,
                         float bt,
                         string color) : base(color)
        {
            _ladoa = ladoa;
            _ladob = ladob;
            _ladoc = ladoc;
            _height = height;
            _bt = bt;
        }

        public override double GetArea()
        {
            return (_bt * _height / 2); // el triangulo base es un triangulo equilatero.
        }

        public override double GetPerimetro()
        {
            return _ladoa + _ladoa + _ladoa; // el triangulo base es un triangulo equilatero.
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
        }
    }
}