using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3y4
{
    internal class Cuadrado
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Cuadrado(double BaseCuadrado, double AlturaCuadrado = 0)
        {
            this.Base = BaseCuadrado;
            this.Altura = AlturaCuadrado > 0 ? AlturaCuadrado : this.Base;
            return;
        }
        public float Area()
        {
            return (float)(Base * Altura);
        }
    }
}
