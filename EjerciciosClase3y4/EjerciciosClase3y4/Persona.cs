using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3y4
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly FechaNac { get; set; }

        public Persona(string Nombre, string Apellido, string FechaNacimiento)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            if (FechaNacimiento != null)
            {
                var fecha = FechaNacimiento.Split("-");
                this.FechaNac = new DateOnly(
                    Int32.Parse(fecha[0]),
                    Int32.Parse(fecha[1]),
                    Int32.Parse(fecha[2])
                    );
            }
            
        }

        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public int Edad(bool YaCumplio = true)
        {
            int edad = 2022 - this.FechaNac.Year;
            if (!YaCumplio)
                edad--;
            return edad;
        }

        public string EdadToString()
        {
            return "Tiene " + Edad() + " Años";
        }


    }
}
