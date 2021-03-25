using System;
using System.Text;

namespace BuilderString
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder();
            texto.Append("Hello World!");
            texto.Append(" ");
            texto.Append("Olá mundo!!");
            Console.WriteLine(texto);
        }
    }
}
