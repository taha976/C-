using System;
using System.Collections;

namespace Ogrenci
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ogrenciler = new Hashtable();

            ogrenciler.Add(101, "Ali");
            ogrenciler.Add(102, "Mehmet");
            ogrenciler.Add(103, "Ahmet");

            

            foreach (DictionaryEntry ogrenci in ogrenciler)
            {
                Console.WriteLine($"{ogrenci.Key} : {ogrenci.Value}");
            }



            Console.ReadKey();
        }
    }
}