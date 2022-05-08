using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Lista
    {
        public static double ejecrcicio1()
        {
            var notas = new List<int>(){ 6, 3, 7, 7, 9, 10, 8, 8, 6, 10 };
            double total = 0;
            foreach (int i in notas)
            {
                total = total + i;
            }
            return total / notas.Count;
        }
    }
}
