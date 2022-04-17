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
