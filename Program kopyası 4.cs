using System;
using System.ComponentModel.DataAnnotations;
namespace Dizler
{
    class Program
    {
        static void Main(string[] args)
        {
            // tanımlama başlatama atama.
            int[] numaralar = new int[3] { 10,20,30}; // new int[] olmadan da tanımlanabilir.
            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine(numaralar[i]);
            }

            for(int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine($"numaralar[{i}] = " + $"{ numaralar[i]}");
            }

            Console.ReadKey();
        }
}   }