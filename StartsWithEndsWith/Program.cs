using System;

namespace StartsWithEndsWith
{
    class Program
    {   
        static void Main(string[] args)
        {
            var text = "isso aqui é um texto";
            Console.WriteLine(text.StartsWith("teste"));
            Console.WriteLine(text.StartsWith("isso"));
            Console.WriteLine(text.EndsWith("esse"));
            Console.WriteLine(text.EndsWith("texto"));
            Console.WriteLine(text.EndsWith("o"));
        }
    }
}
