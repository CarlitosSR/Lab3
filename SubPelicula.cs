using System;

namespace Lab3_4
{
    // SubPelicula es una clase utilitaria para interacción con el usuario
    internal class SubPelicula
    {
        public static void Ejecutar()
        {
            // Crear instancia de ListaPeliculas (que usa Pelicula)
            var listaPeliculas = new ListaPeliculas();

            Console.WriteLine("\n--- Registro de películas ---");
            Console.WriteLine("[ La película ingresada está limitada a un máximo de 24h ]");
            Console.Write("¿Cuántas películas desea ingresar?\n");
            if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"\nPelícula #{i + 1}:");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine() ?? "";

                    Console.Write("Horas: ");
                    int horas = LeerEntero();

                    Console.Write("Minutos: ");
                    int minutos = LeerEntero();

                    Console.Write("Segundos: ");
                    int segundos = LeerEntero();

                    // Llama a ListaPeliculas que internamente crea objetos Pelicula
                    listaPeliculas.AgregarPelicula(nombre, horas, minutos, segundos);
                }

                listaPeliculas.MostrarPeliculasOrdenadas();
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }

        // Método auxiliar para leer enteros de consola
        private static int LeerEntero()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor) && valor >= 0)
                    return valor;
                Console.Write("Valor inválido. Intente nuevamente: ");
            }
        }
    }
}
