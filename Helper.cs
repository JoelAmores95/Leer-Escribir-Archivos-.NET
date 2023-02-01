namespace ConsoleApp{
    class Helper{
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