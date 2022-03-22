using System;

namespace ejemploConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;
            int maximo = 0;
            int minimo= 0;
            float acumulador = 0;
            float promedio = 0;
            string numeroString;
          

            do
            {
                Console.WriteLine("ingrese un número");
                numeroString = Console.ReadLine();
                int.TryParse(numeroString, out numero);
                if(contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                } else
                {
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }
                    if(numero<minimo)
                    {
                        minimo = numero;
                    }
                }
                acumulador += numero;
                contador++;
            } while (contador<5);
            promedio = acumulador / 5;

            Console.WriteLine("EL promedio ingresado es {0}", promedio);
            Console.WriteLine("EL minimo ingresado es {0}", minimo);
            Console.WriteLine("EL maximo ingresado es {0}", maximo);


        }
    }
}
