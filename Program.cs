using System;
<<<<<<< HEAD
using System.Collections.Generic;
=======
>>>>>>> Agregar archivos de proyecto.

namespace Lab3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
            bool salir = false;
            var listaCiudadanos = new ListaCiudadanos();
            var metodos = new Metodos();

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Ciudadanos");
                Console.WriteLine("2. Película y SubPelicula");
                Console.WriteLine("3. Insertar Listas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MenuCiudadanos(listaCiudadanos, metodos);
                        break;
                    case "2":
                        MenuPeliculas();
                        break;
                    case "3":
                        EjecutarInsertarListas();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Pausa();
                        break;
                }
            }
        }

        // Submenú para Ciudadanos (Ejercicio 1)
        static void MenuCiudadanos(ListaCiudadanos lista, Metodos metodos)
        {
            bool volver = false;
            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("--- Submenú Ciudadanos ---");
                Console.WriteLine("1. Registrar ciudadano");
                Console.WriteLine("2. Mostrar ciudadanos ordenados por edad");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        RegistrarCiudadano(lista);
                        Pausa();
                        break;
                    case "2":
                        Console.Clear();
                        MostrarCiudadanos(lista);
                        Pausa();
                        break;
                    case "3":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Pausa();
                        break;
                }
            }
        }

        // Submenú para Película y SubPelicula
        static void MenuPeliculas()
        {
            bool volver = false;
            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("--- Submenú Película y SubPelicula ---");
                Console.WriteLine("1. Calcular duración de una película");
                Console.WriteLine("2. Registrar y mostrar películas (SubPelicula)");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        CalcularDuracionPelicula(new Metodos());
                        Pausa();
                        break;
                    case "2":
                        Console.Clear();
                        SubPelicula.Ejecutar();
                        Pausa();
                        break;
                    case "3":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Pausa();
                        break;
                }
            }
        }

        // Llama a la funcionalidad de InsertarListas
        static void EjecutarInsertarListas()
        {
            Console.Clear();
            InsertarListas.Ejecutar();
            Pausa();
        }

        // Métodos auxiliares para Ciudadanos
        static void RegistrarCiudadano(ListaCiudadanos lista)
        {
            Console.Write("Ingrese DNI: ");
            int dni = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese nombres: ");
            string nombres = Console.ReadLine() ?? "";
            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine() ?? "0");

            lista.Registrar(dni, nombres, edad);
            Console.WriteLine("Ciudadano registrado correctamente.");
        }

        static void MostrarCiudadanos(ListaCiudadanos lista)
        {
            lista.OrdenarPorEdad();
            Console.WriteLine("\nLista de ciudadanos ordenada por edad:");
            Console.WriteLine(lista.Listar());
        }

        // Método auxiliar para calcular duración de película
        static void CalcularDuracionPelicula(Metodos metodos)
        {
            Console.Write("Ingrese horas: ");
            int horas = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese minutos: ");
            int minutos = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese segundos: ");
            int segundos = int.Parse(Console.ReadLine() ?? "0");

            string duracion = metodos.DuracionPelicula(horas, minutos, segundos);
            Console.WriteLine($"Duración total: {duracion}");
        }

        // Método para pausar la consola
        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
>>>>>>> Agregar archivos de proyecto.
    }
}
