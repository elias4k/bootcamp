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
        public double Velocidad { get; set; }
        public Persona? Conductor { get; set; }
        public List<Persona> Pasajeros { get; set; }
        public int Capacidad { get; set; }
        public Mascota? Mascota { get; set; }


        public Auto(string Marca, string Modelo, string Color, int Capacidad)
        {
            this.Marca = Marca; 
            this.Modelo = Modelo;
            this.Color = Color;
            this.Encendido = false;
            this.Velocidad = 0;
            this.Capacidad = Capacidad;
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
                if (Velocidad == 0)
                    Velocidad = +10;
                else
                {
                    Velocidad *= 1.1;
                }
                VelocidadActual();
            }
            else
                Console.WriteLine("Primero debe encender el auto.");
        }
        public void Frenar()
        {
            this.Velocidad *= 0.8;
            VelocidadActual();
        }
        public void VelocidadActual()
        {
            Console.WriteLine(Velocidad);
        }
        public void AgregarConductor(Persona conductor)
        {
            if (Conductor != null)
            {
                Conductor = conductor;
                Console.WriteLine("El conductor del vehiculo ahora es " + Conductor.NombreCompleto());
            }
            else
                Console.WriteLine("El vehiculo ya tiene como conductor a " + Conductor.NombreCompleto());
        }
        public void AgregarPasajero(Persona pasajero)
        {
            Pasajeros.Add(pasajero);
            Console.WriteLine(pasajero.NombreCompleto + " es el pasajero Nro " + Pasajeros.Count);
        }

        public void AgregarMascota(Mascota mascota, Persona pasajero)
        {

            if (this.Conductor != null && this.Conductor.Edad() >= 18)
            {
                if (pasajero.NombreCompleto() != Conductor.NombreCompleto())
                {
                    if (mascota.Tamano == "pequeño")
                    {
                        this.Mascota = mascota;
                        mascota.SentarseEnRegazo(pasajero);
                        this.AgregarPasajero(pasajero);
                    }
                    else
                    {
                        Console.WriteLine("La mascota es muy grande para llevarla en el regazo");
                    }
                }
                else
                    Console.WriteLine("La mascota no puede viajar en el regazo del conductor");
            }
            else
            {
                Console.WriteLine("Para subir con la mascota, debe estar presente un conductor mayor de 18 años.");
            }
        }
        public void BajarATodos()
        {
            if (Velocidad == 0 && this.Encendido == false)
            {
                this.Pasajeros.Clear();
                this.Conductor = null;
            }
            else
            {
                Console.WriteLine("El vehiculo debe estar detenido y apagado para que todos se bajen.");
            }
        }


    }

}
