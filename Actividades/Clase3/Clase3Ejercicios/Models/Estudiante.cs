namespace EjerciciosClase3y4.Models;

public class Estudiante 
{
    public List<Libro> Libros { get; set; }
    private int LibrosNoLeidos { get; set; }
    private int PagLeidas { get; set; }
    
}