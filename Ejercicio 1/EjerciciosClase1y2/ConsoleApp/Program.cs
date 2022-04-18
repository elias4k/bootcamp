using System;

namespace program
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione el ejercicio que desea probar.");
        Console.WriteLine("Ejercicios disponibles: 1, 2, 3, 6, 7, 8, 9, 10, 11");
        String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    ejercicio1();
                    break;
                case "2":
                    ejercicio2();
                    break;
                case "3":
                    ejercicio3();
                    break;
                case "4":
                    NoImplementado();
                    break;
                case "5":
                    NoImplementado();
                    break;
                case "6":
                    ejercicio6();
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
                case "11":
                    ejercicio11();
                    break;
                case "12":
                    NoImplementado();
                    break;
                case "13":
                    NoImplementado();
                    break;
                case "14":
                    NoImplementado();
                    break;
                case "15":
                    NoImplementado();
                    break;
                default:
                    Console.WriteLine("Solo puede ingresar numeros de ejercicios disponibles");
                    break;
            }
            Console.ReadKey();
    }

        public static void NoImplementado()
        {
            Console.WriteLine("Esta funcion aún no está implementada.");
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
                        Console.WriteLine("El valor es mayor que 100");
                    else
                        Console.WriteLine("El valor es menor que 100");
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
                    if (EsPar(num))
                        Console.WriteLine("El valor es par");
                    else
                        Console.WriteLine("El numero es impar");
                }
                catch
                {
                    Console.WriteLine("El valor ingresado debe ser un número.");
                }
            }
            else
                Console.WriteLine("No se ha ingresado ningun valor");
        }

        private static void ejercicio3()
        {
            Console.WriteLine("Ingrese un numero entero.");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            if (EsImpar(num / 2))
                Console.WriteLine("El numero ingresado es el doble de un impar. Cumple con la condicion.");
            else
                Console.WriteLine("No cumple con la condicion de ser el doble de un impar.");
        }
        private static bool EsPar(int num)
        {
            return num % 2 == 0;
        }
        private static bool EsImpar(int num)
        {
            return num % 2 == 1;
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

        private static void ejercicio6()
        {
            Console.WriteLine("\nPara este caso solo se aceptan numeros enteros.");
            Console.WriteLine("\nIngrese la longitud del lado 1.");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del lado 2.");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del lado 3.");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine("El tipo del triangulo es " + TipoTriangulo(lado1, lado2, lado3));
            Console.WriteLine("El perimetro del triangulo es " + PerimetroTriangulo(lado1, lado2, lado3));
            Console.WriteLine("Area: " + AreaTriangulo(lado1, lado2));
            Console.WriteLine("(Para el caso del area de considera el lado 1 como base y el lado 2 como altura)");
        }


        private static double AreaTriangulo(int baseTriangulo, int alturaTriangulo)
        {
            return baseTriangulo * alturaTriangulo / 2;
        }
        private static double PerimetroTriangulo(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 + lado3;
        }

        private static String TipoTriangulo(int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
                return "equilatero";
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                return "isóseles";
            return "escaleno";
            
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
        private static void ejercicio11()
        {
            Console.Clear();
            String pass1 = ""; 
            String pass2 = "";

            Console.WriteLine("Por favor. Ingrese una contraseña.");
            pass1 = Console.ReadLine();
            Console.WriteLine("Reingrese la contraseña para confirmar.");
            pass2 = Console.ReadLine();

            while (pass1 != pass2 || pass1.Length <= 0 || pass2.Length <= 0)
            {
                Console.Clear();
                Console.WriteLine("Algo salió mal, las contraseñas deben coincidir y no ser nulas\n");
                Console.WriteLine("Por favor. Ingrese una contraseña.");
                pass1 = Console.ReadLine();
                Console.WriteLine("Reingrese la contraseña para confirmar.");
                pass2 = Console.ReadLine();
            }     
            Console.WriteLine("Su contraseña ha sido guardada correctamente.");
        }



    }
}