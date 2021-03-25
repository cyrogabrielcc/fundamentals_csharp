using System;

namespace MetodosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = "suco de caju, agua mineral.. goiabada para a sobremesa";
            Console.WriteLine(t.ToLower());
            Console.WriteLine(t.ToUpper());
            Console.WriteLine(t.Insert(8, "__"));
            Console.WriteLine(t.Remove(5, 5));
            Console.WriteLine(t.Length);
            Console.WriteLine(t.Replace("caju", "goiaba"));
            Console.WriteLine(t.Replace("goiabada", "bananada"));
            Console.WriteLine(t.Replace(" ", "_"));
        }
    }
}
