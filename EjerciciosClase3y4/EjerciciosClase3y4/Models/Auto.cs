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
        public int Velocidad { get; set; }
        public Persona? Conductor { get; set; }
        public List<Persona> Pasajeros { get; set; }
        public int Capacidad { get; set; }


        public Auto(string Marca, string Modelo, string Color)
        {
            this.Marca = Marca; 
            this.Modelo = Modelo;
            this.Color = Color;
            this.Encendido = false;
            this.Velocidad = 0;
            return;
        }

        public void Encender()
        {
            if (Conductor != null)
            {
                if (Conductor.Edad() >= 18)
                {
                    this.Encendido = true;
                    Console.WriteLine("Auto encendido.");
                }
                else
                    Console.WriteLine("El conductor debe tener mas de 18 años");
            }
            else
                Console.WriteLine("El auto no se puede encender sin conductor.");
        }

        public void Apagar()
        {
            this.Encendido = false;
            Console.WriteLine("Auto apagado.");
        }

        public void Acelerar()
        {
            if (Encendido)
            {
                Velocidad = +10;
                Console.WriteLine(Velocidad);
            }
            else
                Console.WriteLine("Primero debe encender el auto.");
        }
        public void Frenar()
        {
            this.Velocidad = -20;
        }
        public void VelocidadActual()
        {
            Console.WriteLine(Velocidad);
        }
    }
}
