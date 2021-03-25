using System;

namespace SplitSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello World! Hello World! Hello World! ";
            var division = text.Split(" "); 
            System.Console.WriteLine(division[0]);
            System.Console.WriteLine(division[1]);
            System.Console.WriteLine(text.Trim()); //ajeita os espaços

            //começa do dois e pega dois valores 
            var value = text.Substring(2, text.LastIndexOf("d"));
            System.Console.WriteLine(value);

        }
    }
}
