namespace Ejercicio_Semana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Se crean libros
            Libro libro1 = new Libro("Harry Potter", "J.K. Rowling");
            Libro libro2 = new Libro("IT", "Stephen King");
            // Se crean revistas
            Revista revista1 = new Revista("Olé", "Mayo 2023");
            Revista revista2 = new Revista("Muy Interesante", "Abril 2021");

            // Agregar libros a la Biblioteca
            biblioteca.AgregarMaterial(libro1);
            biblioteca.AgregarMaterial(libro2);
            // Agregar revistas a la Biblioteca
            biblioteca.AgregarMaterial(revista1);
            biblioteca.AgregarMaterial(revista2);

            List<Material> resultados = biblioteca.BuscarPorTitulo("Harry Potter");
            Console.WriteLine("Los resultado de la búsqueda son: ");
            foreach (Material material in resultados)
            {
                Console.WriteLine($"El material '{material.Titulo}' ha sido encontrado exitosamente!!!");
            }

            biblioteca.PrestarMaterial(libro1);
            biblioteca.PrestarMaterial(libro1);
            biblioteca.DevolverMaterial(libro1);
            biblioteca.PrestarMaterial(revista1);
            biblioteca.DevolverMaterial(revista1);

            Console.ReadKey();
        }
    }
}