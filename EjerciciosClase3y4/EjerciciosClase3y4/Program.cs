// See https://aka.ms/new-console-template for more information
using EjerciciosClase3y4;

var cuadrado = new Cuadrado(2.5);
Console.WriteLine(cuadrado.AreaToString());
var cuadrado2 = new Cuadrado(2.5, 3);
Console.WriteLine(cuadrado2.AreaToString());

var persona = new Persona("Elias", "Lezcano", "1997-05-22");
Console.WriteLine(persona.EdadToString());