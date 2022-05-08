using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Lista
    {
        public static double ejercicio1()
        {
            var notas = new List<int>() { 6, 3, 7, 7, 9, 10, 8, 8, 6, 10 };
            double total = 0;
            foreach (int i in notas)
            {
                total = total + i;
            }
            return total / notas.Count;
        }
        public static string ejercicio2()
        {
            var edades = new List<int>() { 16, 33, 17, 27, 9, 10, 28, 18, 96, 22 };
            int mayores = 0;
            int menores = 0;
            foreach (int edad in edades)
            {
                if (edad >= 18)
                    mayores += 1;
                else
                    menores += 1;
            }
            return "Cantidad de mayores: " + mayores + "\nCantidad de menores: " + menores;
        }
        public static string ejercicio3()
        {
            var nombres = new List<string>() { "Juan", "Pedro", "Alejando", "Alberto", "Ignacio" };
            string mayor = "";
            string menor = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";
            foreach (string nombre in nombres)
            {
                if (nombre.Length > mayor.Length)
                    mayor = nombre;
                if (nombre.Length < menor.Length)
                    menor = nombre;
            }
            return "Nombre mas largo: " + mayor + " con " + mayor.Length + " caracteres.\nNombre mas corto: " + menor + " con " + menor.Length + " caracteres.";
        }

        public static void ejercicio4()
        {
            List<String> lista = new List<string>();
            lista.Add("papa");
            lista.Add("carne");
            bool fin = false;
            List<String> itemy = new List<String>();
            List<String> itemn = new List<String>();
            while (!fin)
            {
                Console.WriteLine("\nIngrese producto, 'fin' para salir: ");
                var item = Console.ReadLine();
                if (item == "fin")
                    fin = true;
                else
                {
                    if (lista.Contains(item))
                    {
                        itemy.Add(item);
                        Console.WriteLine("\nEl Producto esta en la lista");
                    }
                    else
                    {
                        itemn.Add(item);
                        Console.WriteLine("\nEl Producto no esta en la lista");
                    }

                }
            }
            var u = itemy.Union(itemn);
            var nc = lista.Except(u);

            Console.WriteLine("\nProductos que no compro");
            foreach (string s in nc)
                Console.WriteLine(s);
            Console.WriteLine("\nProductos que compro y no estaban en la lista");
            foreach (string s in itemn)
                Console.WriteLine(s);
            Console.WriteLine("\nTodo lo que compro: ");
            foreach (string s in u)
                Console.WriteLine(s);

        }

        public static void ejercicio5()
        {
            int a = 5;
            int b = 5;
            char[,] matriz = new char[a, b];

            Console.WriteLine("\nMatriz original:");
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {                    
                    Console.Write(j % 2 == 0 ? "P " : "I ");
                }
                Console.WriteLine("");
            }
        }
        public static string DayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    return "lunes";
                case 2:
                    return "martes";
                case 3:
                    return "miércoles";
                case 4:
                    return "jueves";
                case 5:
                    return "viernes";
                case 6:
                    return "sábado";
                case 0:
                    return "domingo";
                default:
                    return "";
            }
        }
        public static void ejercicio6()
        {
            int max = 0, min = 50, posmax = 0, posmin = 0;
            int acumT = 0;
            string dmax, dmin;
            int[,] d = new int[5, 7];
            Random Random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    d[i, j] = Random.Next(7, 38);
                }
            }

            for (int j = 0; j < 7; j++) // 1 para la respectiva semana
            {
                if (d[1, j] < min)
                {
                    min = d[1, j];
                    posmin = j;
                }
                if (d[1, j] > max)
                {
                    max = d[1, j];
                    posmax = j;
                }
                acumT += d[1, j];
            }
            dmax = DayOfWeek(posmax);
            dmin = DayOfWeek(posmin);
            Console.WriteLine("Temperatura más alta semana: {0}° se dió el día {2}.\nTemperatura más baja semana: {1}° se dió el día {3}.", max, min, dmax, dmin);
            Console.WriteLine("\nTemperatura promedio de la semana: " + acumT / 7 + "°.");

            max = 0;
            int week = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (d[i, j] > max)
                    {
                        posmax = j;
                        max = d[i, j];
                        week = i;
                    }
                }
            }
            dmax = DayOfWeek(posmax);
            Console.WriteLine("\nTemperatura más alta del mes: {0}° se dió el día: {1} de la semana {2}", max, dmax, week);

        }

        public static void ejercicio7()
        {
            int[,] t = new int[10, 10];

            for (int i = 0; i < 10; i++)
                t[i, 0] = i;
            for (int j = 0; j < 10; j++)
                t[0, j] = j;

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    t[i, j] = i * j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(t[j, i] + "   ");
                }
                Console.WriteLine();
            }
        }
        public static void ejercicio8()
        {
            char[,] x = new char[10, 10];

            for (int i = 0; i < 45; i++)
            {
                int rposi = new Random().Next(0, 10);
                int rposj = new Random().Next(0, 10);
                x[rposi, rposj] = 'X';
            }
            int chance = 3;
            while (chance != 0)
            {

                int posi, posj;
                Console.WriteLine("\nIngrese fila: ");
                posi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nIngrese columna: ");
                posj = Convert.ToInt32(Console.ReadLine());

                if (x[posi, posj] == 'X')
                    Console.WriteLine("\nAcerto");
                else
                {
                    Console.WriteLine("\nNo Acerto");

                    chance--;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (x[i, j] != 'X')
                        Console.Write(" * ");
                    else
                        Console.Write(" X ");
                }
                Console.WriteLine();
            }
        }
    }
}