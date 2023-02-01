namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Escribir Texto
            Console.WriteLine("¿Qué texto quieres guardar?");
            string texto = Console.ReadLine();

            Console.WriteLine("Escribe el nombre del archivo donde se guardará:");
            string nombreArchivoEscribir = Console.ReadLine();

            // Crea o Sobreescribe el archivo
            guardarEnArchivo(nombreArchivoEscribir,texto);

            // Leer Texto
            Console.WriteLine("Escribe el nombre del archivo del cual quieres leer:");
            string nombreArchivo = Console.ReadLine();
            string textoLeido = leerDeArchivo(nombreArchivo);
            Console.WriteLine(textoLeido);
        }

        public static void guardarEnArchivo(string nombreArchivo, string texto)
        {
            File.WriteAllText(nombreArchivo, texto);
        }

        public static string leerDeArchivo(string nombreArchivo)
        {
            string textoLeido = File.ReadAllText(nombreArchivo);
            return textoLeido;
        }
    }
}
