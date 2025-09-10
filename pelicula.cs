using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_4
{
    // Clase Pelicula
    internal class Pelicula
    {
        public string Nombre { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public int DuracionEnSegundos => Horas * 3600 + Minutos * 60 + Segundos;

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Duración: {Horas}h {Minutos}m {Segundos}s";
        }
    }

    // Clase ListaPeliculas que puede trabajar con Pelicula y SubPelicula
    internal class ListaPeliculas
    {
        private readonly List<Pelicula> peliculas = new();

        public void AgregarPelicula(string nombre, int horas, int minutos, int segundos)
        {
            if (horas > 24 || horas < 0 || minutos < 0 || minutos >= 60 || segundos < 0 || segundos >= 60)
            {
                Console.WriteLine("Duración inválida. Horas debe ser 0-24, minutos y segundos 0-59.");
                return;
            }
            peliculas.Add(new Pelicula
            {
                Nombre = nombre,
                Horas = horas,
                Minutos = minutos,
                Segundos = segundos
            });
        }

        public void MostrarPeliculasOrdenadas()
        {
            if (peliculas.Count == 0)
            {
                Console.WriteLine("No hay películas registradas.");
                return;
            }

            var ordenadas = peliculas.OrderBy(p => p.DuracionEnSegundos).ToList();
            Console.WriteLine("\n--- Películas ordenadas por duración (ascendente) ---");
            foreach (var pelicula in ordenadas)
            {
                Console.WriteLine(pelicula);
            }
        }
    }
}

