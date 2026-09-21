using System;

namespace LibroCalificaciones_3
{
    internal class PruebaLibroCalificaciones_3
    {
        static void Main(string[] args)
        {
            LibroCalificaciones MyLibro = new LibroCalificaciones("CS181 Programación en C#");
            LibroCalificaciones MyLibro2 = new LibroCalificaciones("CS150 Estructuras de Datos");

            Console.WriteLine("Bienvenido al Libro de Calificaciones para: {0}", MyLibro.NombreCurso);
            Console.WriteLine("Bienvenido al Libro de Calificaciones para: {0}", MyLibro2.NombreCurso);
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese el nombre del curso: ");
            string nombreDelCurso = Console.ReadLine();

            MyLibro.NombreCurso = nombreDelCurso;

            Console.WriteLine();
            Console.WriteLine("El nombre del Curso es: {0}", MyLibro.NombreCurso);
            Console.WriteLine();

            MyLibro.MostrarMensaje();

            Console.WriteLine("\nPresione cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
        }
    }
}
