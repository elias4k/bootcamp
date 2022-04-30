using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3y4.Models
{
    class Auto
    {
        public bool Encendido { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }

        public Auto(string Marca, string Modelo, string Color)
        {
            this.Marca = Marca; 
            this.Modelo = Modelo;
            this.Color = Color;
            this.Encendido = false;
            return;
        }

        public void Encender()
        {
            this.Encendido = true;
        }

        public void Apagar()
        {
            this.Encendido = false;
        }
    }
}
