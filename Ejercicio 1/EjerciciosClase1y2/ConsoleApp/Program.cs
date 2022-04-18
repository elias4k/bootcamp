using System;

namespace program
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione el ejercicio que desea probar.");
        String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    ejercicio1();
                    break;
                case "2":
                    ejercicio2();
                    break;
                case "7":
                    ejercicio7();
                    break;
                case "8":
                    ejercicio8();
                    break;
                case "9":
                    ejercicio9();
                    break;
                case "10":
                    ejercicio10();
                    break;
                default:
                    break;
            }
    }

        

        public static void ejercicio1()
    {
        Console.WriteLine("Ingrese un valor");
        String val = Console.ReadLine();
        if (val != null)
        {
            try
            {
                int num = int.Parse(val);
                if (num > 100)
                {
                    Console.WriteLine("El valor es mayor que 100");
                }
            }
            catch
            {
                Console.WriteLine("El valor ingresado debe ser un número.");
            }
        }
        else
        {
            Console.WriteLine("No se ha ingresado ningun valor");
        }
    }

        public static void ejercicio2()
        {
            Console.WriteLine("Ingrese un valor");
            String val = Console.ReadLine();
            if (val != null)
            {
                try
                {
                    int num = int.Parse(val);
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("El valor es par");
                    }
                    else
                    {
                        Console.WriteLine("El numero es impar");
                    }
                }
                catch
                {
                    Console.WriteLine("El valor ingresado debe ser un número.");
                }
            }
            else
            {
                Console.WriteLine("No se ha ingresado ningun valor");
            }
        }

        private static void ejercicio8()
        {
            Console.WriteLine("Ingrese un valor");
            String val = Console.ReadLine();
            if (val != null)
            {
                try
                {
                    int num = int.Parse(val);
                    for (int i = 0; i <= num; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch
                {
                    Console.WriteLine("El valor ingresado debe ser un número.");
                }
            }
            else
            {
                Console.WriteLine("No se ha ingresado ningun valor");
            }
        }

        private static void ejercicio9()
        {
            int total = 0;
            int num = 0;
            for (int i = 1;i <= 15;i++)
            {
                Console.WriteLine("Ingrese el valor " + i);
                String val = Console.ReadLine();
                Int32.TryParse(val, out num);
                total += num;
            }
            Console.WriteLine("El total es " + total);
            
        }
        private static void tryejercicio7()
        {
            int[] billetes = new int[] { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Ingrese un valor");
            String val = Console.ReadLine();
            if (val != null)
            {
                try
                {
                    int num = int.Parse(val);
                    for (int i = 0; i <= num; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch
                {
                    Console.WriteLine("El valor ingresado debe ser un número.");
                }
            }
            else
            {
                Console.WriteLine("No se ha ingresado ningun valor");
            }
        }


        private static void ejercicio7()
        {
            int can, c1000, c500, c100, c50, c20, c10, c5, c2, c1;
            c1000 = 0;
            c500 = 0;
            c100 = 0;
            c50 = 0;
            c20 = 0;
            c10 = 0;
            c5 = 0;
            c2 = 0;
            c1 = 0;
            Console.WriteLine("Digite una cantidad: ");
            can = int.Parse(Console.ReadLine());
            if (can >= 100)
            {
                c1000 = (can / 1000);
                can = can - (c1000 * 1000);
            }
            if (can >= 500)
            {
                c500 = (can / 500);
                can = can - (c500 * 500);
            }
            if (can >= 100)
            {
                c100 = (can / 100);
                can = can - (c100 * 100);
            }
            if (can >= 50)
            {
                c50 = (can / 50);
                can = can - (c50 * 50);
            }
            if (can >= 20)
            {
                c20 = (can / 20);
                can = can - (c20 * 20);
            }
            if (can >= 10)
            {
                c10 = (can / 10);
                can = can - (c10 * 10);
            }
            if (can >= 5)
            {
                c5 = (can / 5);
                can = can - (c5 * 5);
            }
            if (can >= 2)
            {
                c2 = (can / 2);
                can = can - (c2 * 2);
            }
            if (can >= 1)
            {
                c1 = (can / 1);
                can = can - (c1 * 1);
            }
            if (c1000 > 0)
                Console.WriteLine("Billetes de $1000: " + c1000);
            if (c500 > 0)
                Console.WriteLine("Billetes de $500: " + c500);
            if (c100 > 0)
                Console.WriteLine("Billetes de $100: " + c100);
            if (c50 > 0)
                Console.WriteLine("Billetes de $50: " + c50);
            if (c20 > 0)
                Console.WriteLine("Billetes de $20: " + c20);
            if (c10 > 0)
                Console.WriteLine("Billetes de $10: " + c10);
            if (c5 > 0)
                Console.WriteLine("Monedas de $5: " + c5);
            if (c2 > 0)
                Console.WriteLine("Monedas de $2: " + c2);
            if (c1 > 0)
                Console.WriteLine("Monedas de $1: " + c1);
        }

        private static void ejercicio10()
        {
            String respuesta = "";
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingresa el valor " + i);
                int num = int.Parse(Console.ReadLine());
                if (num % 3 == 0)
                    respuesta = respuesta + num + " es multiplo de 3\n";
            }
            Console.WriteLine(respuesta);
        }

    }
}