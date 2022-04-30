using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3y4.Models
{
    internal class Mascota
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Energia { get; set; }

        public Mascota(string Nombre, string Tipo)
        {
            this.Nombre = Nombre;   
            this.Tipo = Tipo;
            Energia = 0;
        }

        public void Alimentar()
        {
            this.Energia = +30;
            if (this.Energia > 100)
                this.Energia = 100;

        }

        public void Correr()
        {
            if (this.Energia > 20)
            {
                this.Energia -= 10;
                if (this.Energia < 0)
                    this.Energia = 0;
                return;
            }
            else
            {
                Console.WriteLine(Nombre + " está muy cansado.");
                return;
            }
        }
    }
}
