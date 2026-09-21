using System;

namespace LibroCalificaciones_2
{
    public class LibroPuebaCalificaciones
    {
        static void Main(string[] args)
        {
            // Instancia del objeto MiLibroCalificaciones
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();

            // Pide el nombre del Curso y lo recibe como entrada
            Console.WriteLine("Por favor ingrese el nombre del curso: ");
             
            string nombreDelCurso = Console.ReadLine(); // Lee una línea de Texto
            Console.WriteLine(); // Imprime en pantalla una línea en blanco

            // Llama al método MostrarMensaje de MiLibroCalificaciones
            // y pasa el nombre del curso como argumento
            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}
