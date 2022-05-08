using Ejercicios;


Console.WriteLine("\n\n*** Ejercicio 1 ***");
Console.WriteLine("El promedio de las notas de los alumnos es: " + Lista.ejercicio1());


Console.WriteLine("\n\n*** Ejercicio 2 ***");
Console.WriteLine(Lista.ejercicio2());


Console.WriteLine("\n\n*** Ejercicio 3 ***");
Console.WriteLine(Lista.ejercicio3());


Console.WriteLine("\n\n*** Ejercicio 4 ***");
Console.WriteLine("(Presione Y para ejecutar ejercicio 4, de lo contrario presione cualquier otra tecla para continuar.)");
var resp4 = Console.ReadKey();
if (resp4.KeyChar == 'y' || resp4.KeyChar == 'Y')
    Lista.ejercicio4();


Console.WriteLine("\n\n*** Ejercicio 5 ***");
Lista.ejercicio5();


Console.WriteLine("\n\n*** Ejercicio 6 ***");
Lista.ejercicio6();


Console.WriteLine("\n\n*** Ejercicio 7 ***");
Lista.ejercicio7();


Console.WriteLine("\n\n*** Ejercicio 8 ***");
Console.WriteLine("(Presione Y para ejecutar ejercicio 8, de lo contrario presione cualquier otra tecla para finalizar.)");
var resp8 = Console.ReadKey();
if (resp8.KeyChar == 'y' || resp8.KeyChar == 'Y')
    Lista.ejercicio8();

Console.WriteLine("\n\n\n");
