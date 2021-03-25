using System;

namespace EqualsComand
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Só sei que nada sei";
            Console.WriteLine(text.Equals("potato"));
            Console.WriteLine(text.Equals("Só sei que nada sei"));
            Console.WriteLine(text.Equals("só sei que nada sei"));
            Console.WriteLine(text.Equals("só sei que nada sei", StringComparison.OrdinalIgnoreCase));
        }
    }
}
