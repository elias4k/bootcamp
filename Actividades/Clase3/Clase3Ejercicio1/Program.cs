namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el ejercicio que desea probar.");
            Console.WriteLine("Ejercicios disponibles: 1, 2, 3, 6, 7, 8, 9, 10, 11, 12.");
            String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    ProgramClass.ejercicio1();
                    break;
                case "2":
                    ProgramClass.ejercicio2();
                    break;
                case "3":
                    ProgramClass.ejercicio3();
                    break;
                case "4":
                    NoImplementado();
                    break;
                case "5":
                    NoImplementado();
                    break;
                case "6":
                    ProgramClass.ejercicio6();
                    break;
                case "7":
                    ProgramClass.ejercicio7();
                    break;
                case "8":
                    ProgramClass.ejercicio8();
                    break;
                case "9":
                    ProgramClass.ejercicio9();
                    break;
                case "10":
                    ProgramClass.ejercicio10();
                    break;
                case "11":
                    ProgramClass.ejercicio11();
                    break;
                case "12":
                    ProgramClass.ejercicio12();
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

        private static void NoImplementado()
        {
            throw new NotImplementedException();
        }
    }
}

