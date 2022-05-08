﻿using System;
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
            foreach(string nombre in nombres)
            {
                if (nombre.Length > mayor.Length)
                    mayor = nombre;
                if (nombre.Length < menor.Length)
                    menor = nombre;
            }
            return "Nombre mas largo: " + mayor + " con "+ mayor.Length+" caracteres\nNombre mas corto: " + menor + " con " + menor.Length + " caracteres";
        }
    }
}
