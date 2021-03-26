using System;

namespace WorkDatas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;
            var formatada = String.Format("{0:y}",data);
            var formatada1 = String.Format("{0:yy}",data);
            var formatada2 = String.Format("{0:yyyy}",data);
            var formatada3 = String.Format("{0:M}",data);
            var formatada4 = String.Format("{0:dd/MM/yyyy hh:mm:ss z}",data);
            // var formatada3 = String.Format("{0:y}",data);
            Console.WriteLine(formatada);
            Console.WriteLine(formatada1);
            Console.WriteLine(formatada2);
            Console.WriteLine(formatada3);
            Console.WriteLine(formatada4);
        }
    }
}
