using System;
using System.Collections.Generic;

namespace Lab3_4
{
    internal class Pelicula
    {
        public string Nombre { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public int DuracionEnSegundos => Horas * 3600 + Minutos * 60 + Segundos;

        public override string ToString()
        {
            return $"{Nombre} - {Horas:D2}:{Minutos:D2}:{Segundos:D2}";
        }
    }

    internal class ListaPeliculas
    {
        private List<Pelicula> peliculas = new List<Pelicula>();

        public void AgregarPelicula(string nombre, int horas, int minutos, int segundos)
        {
            // Normalización de valores
            if (segundos >= 60)
            {
                minutos += segundos / 60;
                segundos = segundos % 60;
            }
            if (minutos >= 60)
            {
                horas += minutos / 60;
                minutos = minutos % 60;
            }
            if (horas > 24)
            {
                horas = 24; // Limitar a 24 horas máximo
                minutos = 0;
                segundos = 0;
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
            // Copiamos la lista para no modificar el orden original
            List<Pelicula> ordenadas = new List<Pelicula>();
            foreach (var p in peliculas)
                ordenadas.Add(p);

            // Algoritmo de ordenamiento por selección
            for (int i = 0; i < ordenadas.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < ordenadas.Count; j++)
                {
                    if (ordenadas[j].DuracionEnSegundos < ordenadas[minIndex].DuracionEnSegundos)
                    {
                        minIndex = j;
                    }
                }
                // Intercambiamos si encontramos un menor
                if (minIndex != i)
                {
                    var temp = ordenadas[i];
                    ordenadas[i] = ordenadas[minIndex];
                    ordenadas[minIndex] = temp;
                }
            }

            Console.WriteLine("\n--- Películas ordenadas por duración ---");
            for (int i = 0; i < ordenadas.Count; i++)
            {
                Console.WriteLine(ordenadas[i]);
            }
        }
    }
}
