using System;
using System.Runtime.InteropServices.Marshalling;

namespace teste;
class Program
{
    static void Main(string[] args)
    {
        int tam = 0;

        Console.Write("Quantas vezes xereca?");
        tam = int.Parse(Console.ReadLine());    
        
        for (int i = 0; i < tam; i++)
        {
            Console.Write("XERECA" + " ");
            int f = i * 3;
            if (f % 3 == 0)
            {
                Console.WriteLine("COME XERECA E MANDA PASSINHO!");
            }
        }
    }
}