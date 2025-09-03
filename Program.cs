using System;
using System.Collections.Generic;

namespace Lab3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear tres listas simples de números enteros
            List<int> X = new List<int> { 1, 2, 3 };
            List<int> Y = new List<int> { 4, 5, 6 };
            List<int> Z = new List<int> { 7, 8, 9 };

            // Se ha eliminado la impresión de las listas X y Y iniciales

            // Crear una lista temporal para almacenar el resultado
            List<int> resultado = new List<int>();

            // Insertar los elementos de X y mostrar el proceso
            Console.WriteLine("\nInsertando lista X en resultado:");
            for (int i = 0; i < X.Count; i++)
            {
                resultado.Add(X[i]);
            }
            Console.WriteLine($"Resultado tras insertar X: [{string.Join(", ", resultado)}]");

            // Insertar los elementos de Y y mostrar el proceso
            Console.WriteLine("\nInsertando lista Y en resultado:");
            for (int i = 0; i < Y.Count; i++)
            {
                resultado.Add(Y[i]);
            }
            Console.WriteLine($"Resultado tras insertar Y: [{string.Join(", ", resultado)}]");

            // Insertar los elementos de Z y mostrar el proceso
            Console.WriteLine("\nInsertando lista Z en resultado:");
            for (int i = 0; i < Z.Count; i++)
            {
                resultado.Add(Z[i]);
            }
            Console.WriteLine($"Resultado tras insertar Z: [{string.Join(", ", resultado)}]");

            // Guardar el resultado en Z
            Z = resultado;

            // Mostrar los elementos de la lista Z final
            Console.WriteLine("\nLista Z final (X -> Y -> Z):");
            for (int i = 0; i < Z.Count; i++)
            {
                Console.WriteLine(Z[i]);
            }

            // Lista de películas
            var listaPeliculas = new ListaPeliculas();

            Console.WriteLine("\n--- Registro de películas ---");
            Console.WriteLine("[ La pelicula ingresada esta limitada a un maximo de 24h ]");
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
        static int LeerEntero()
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
