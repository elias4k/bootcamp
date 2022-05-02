using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3y4.Models
{
    public class Smartphone
    {
        public string Moldelo { get; set; }
        public string Marca { get; set; }
        public bool Encendido { get; set; }
        private int Volumen { get; set; }
        private int Brillo { get; set; }

        public Smartphone(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Moldelo = Modelo;
            Encendido = false;
            Volumen = 50;
            Brillo = 50;
        }
        public void Encender()
        {
            this.Encendido = true;
        }
        public void Apagar()
        {
            this.Encendido = false;
        }
        public void SubirVolumen()
        {
            Volumen = +10;
            if (Volumen > 100)
                Volumen = 100;
            
        }
        public void BajarVolumen()
        {
            Volumen = -10;
            if (Volumen < 0)
                Volumen = 0;
        }
        public void Silencio()
        {
            Volumen = 0;
        }
        public void SubirBrillo()
        {
            Brillo = +10;
            if (Brillo > 100)
                Brillo = 100;

        }
        public void BajarBrillo()
        {
            Brillo = -10;
            if (Brillo < 0)
                Brillo = 0;
        }
    }
}
