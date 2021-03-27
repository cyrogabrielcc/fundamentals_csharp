using System;

namespace ListasDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
           var meuArray = new int[5] {0, 1, 2, 3, 4};
       
        for (var i = 0; i < meuArray.Length; i++) System.Console.WriteLine(meuArray[i]);
        
        foreach (var item in meuArray)  System.Console.WriteLine(item);
        

        }
    }
}
