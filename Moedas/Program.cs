using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = 10.50m;
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(value.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(value.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));

            
            //arredondar pra cima ou pra baixo com a class Math - Roud, Ceiling e Floor
        }
    }
}
