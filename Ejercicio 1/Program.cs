using System;

namespace ejemploConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroString;
            bool resultado;

            do
            {
                Console.WriteLine("ingrese un número");
                numeroString = Console.ReadLine();
                resultado = int.TryParse(numeroString, out numero);
            } while (!resultado);


            Console.WriteLine("EL número ingresado es {0}", numero);
        }
    }
}
