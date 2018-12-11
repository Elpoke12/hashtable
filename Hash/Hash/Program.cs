using System;
using System.Collections;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos e insertamos datos
            Hashtable miDiccio = new Hashtable();
            miDiccio.Add("byte", "8 bits");
            miDiccio.Add("componente", "Random Access Memory");
            miDiccio.Add("kilobyte", "1000 bytes");

            // Mostramos algún dato de nuestro diccionario
            Console.WriteLine("Cantidad de palabras en el diccionario: {0}",
                miDiccio.Count);
            try
            {
                Console.WriteLine("El significado de RAM es: {0}",
                miDiccio["componente"]);
            }
            catch (Exception)
            {
                Console.WriteLine("No existe esa palabra!");
            }
            try
            {
                Console.WriteLine("1 kilobyte en bytes es: {0}",
                miDiccio["kilobyte"]);
            }
            catch (Exception)
            {
                Console.WriteLine("No existe esa palabra!");
            }
        }
    }
}
