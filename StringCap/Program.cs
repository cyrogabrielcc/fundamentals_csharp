using System;

namespace StringCap
{
    class Program
    {
        static void Main(string[] args)
        {
            // var id = Guid.NewGuid();
            // //id = new Guid("2a246b28-4ad8-4a4f-8682-9caf36c2f7f4");
            // System.Console.WriteLine(id.ToString().Substring(0,8)); 

            var test = "test";

            System.Console.WriteLine(test.CompareTo("test")); //-> -1 falso
            System.Console.WriteLine(test.Contains("t"));
            //para ignorar o case-sensitive StringComparison.OrdinalIgnoreCase
        }
    }
}
