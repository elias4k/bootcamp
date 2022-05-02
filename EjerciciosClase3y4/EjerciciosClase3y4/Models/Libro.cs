using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3y4.Models
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string CantPaginas { get; set; }
        private bool WasRead { get; set; }
    }
}
