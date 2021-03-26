using System;

namespace ComparandoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();


            var data = DateTime.Now;

            //nunca será igual -> por conta dos segundos e milésimos de segundo
            if (data.Date == DateTime.Now.Date)  
            {
                Console.WriteLine("Igual");
            }
                System.Console.WriteLine(data);
        }
    }
}
