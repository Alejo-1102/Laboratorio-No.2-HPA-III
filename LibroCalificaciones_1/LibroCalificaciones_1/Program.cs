using System;

namespace LibroCalificaciones_1
{
    internal class PruebaLibroCalificaciones_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Instancias la clase donde SÍ creaste el método:
            LibroCalificacion MyLibro = new LibroCalificacion();

            // Ahora sí encuentra el método sin marcar error
            MyLibro.MostrarMensaje();
        }
    }
}