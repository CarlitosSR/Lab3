using System;
using System.Text;

namespace Lab3_4
{
    // Métodos utilitarios
    internal class Metodos
    {
        public string DuracionPelicula(int horas, int minutos, int segundos)
        {
            int totalSegundos = (horas * 3600) + (minutos * 60) + segundos;
            int duracionHoras = totalSegundos / 3600;
            int duracionMinutos = (totalSegundos % 3600) / 60;
            int duracionSegundos = totalSegundos % 60;
            return $"{duracionHoras} horas, {duracionMinutos} minutos, {duracionSegundos} segundos";
        }
        public string MostrarDatosCiudadano(string nombre, string apellido, int edad, int dni)
        {
            return $"Nombre: {nombre} {apellido}, Edad: {edad}, DNI: {dni}";
        }
    }

    internal class Ciudadano
    {
        public int Dni { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public Ciudadano? Siguiente { get; set; }
    }

    internal class ListaCiudadanos
    {
        private Ciudadano? cabeza;

        public void Registrar(int dni, string nombres, int edad)
        {
            var nuevo = new Ciudadano
            {
                Dni = dni,
                Nombres = nombres,
                Edad = edad,
                Siguiente = cabeza
            };
            cabeza = nuevo;
        }

        public void OrdenarPorEdad()
        {
            if (cabeza == null) return;
            bool cambiado;
            do
            {
                cambiado = false;
                var actual = cabeza;
                while (actual.Siguiente != null)
                {
                    if (actual.Edad > actual.Siguiente.Edad)
                    {
                        (actual.Dni, actual.Siguiente.Dni) = (actual.Siguiente.Dni, actual.Dni);
                        (actual.Nombres, actual.Siguiente.Nombres) = (actual.Siguiente.Nombres, actual.Nombres);
                        (actual.Edad, actual.Siguiente.Edad) = (actual.Siguiente.Edad, actual.Edad);
                        cambiado = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (cambiado);
        }

        public string Listar()
        {
            var actual = cabeza;
            var resultado = new StringBuilder();
            while (actual != null)
            {
                resultado.AppendLine($"DNI: {actual.Dni}, Nombres: {actual.Nombres}, Edad: {actual.Edad}");
                actual = actual.Siguiente;
            }
            return resultado.ToString();
        }
    }

    internal class Conjunto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int DNI { get; set; }
    }

    internal class Nodos // Equivalente a Pelicula/SubPelicula
    {
        public string NombrePelicula { get; set; }
        public int horas { get; set; }
        public int minutos { get; set; }
        public int segundos { get; set; }
    }
}
