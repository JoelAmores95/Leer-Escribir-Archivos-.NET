namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Escribir Texto
            string texto = "Hola mundo";
            string ok = "Funciona bien";
            
            // Crea o Sobreescribe el archivo
            File.WriteAllText("miArchivo.txt", texto + "\n" + ok); 

            // Leer Texto
            string textoLeido = File.ReadAllText("miArchivo.txt");
            Console.WriteLine(textoLeido);
        }
    }
}
