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
        }
    }
}
