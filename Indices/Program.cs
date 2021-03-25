using System;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = "Hello World!";
            Console.WriteLine(t.IndexOf("W"));
            Console.WriteLine(t.IndexOf(" "));
            Console.WriteLine(t.LastIndexOf("o"));
            //mostra a posição de determinada string
        }
    }
}
