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
            var edades = new List<int>() { 16, 33, 17, 27, 9, 10, 28, 18, 96, 12 };
            int mayores = 0;
            int menores = 0;
            foreach (int edad in edades)
            {
                if (edad >= 18)
                    mayores = +1;
                else
                    menores = +1;
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
            /**
            foreach (int item in matriz)
            {
                
                Console.WriteLine(Array.IndexOf(matriz, item));


            }*/
        }
    }
}