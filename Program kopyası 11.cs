using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[]args)
        {
            // Hashtable kullanımı
            var sehirler = new Hashtable();



            //Ekleme 
            Console.WriteLine("\nSehirler");
            sehirler.Add(06, "Ankara");
            sehirler.Add(34, "Istanbul");
            sehirler.Add(55, "Samsun");

            // Dolaşma
            foreach(DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key} - {item.Value,-7}");
            }

            // Anahtarları Alma
            Console.WriteLine("\n-Anahtarlar (Keys)-");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }


            // Değerleri Alma
            Console.WriteLine("\n-Value (Values)-");
            ICollection degerler = sehirler.Values;
            foreach(var item in degerler)
            {
                Console.WriteLine(item);
            }
            // Elemana Erişme 
            Console.WriteLine("\n-Elemana Erişme-");
            Console.WriteLine(sehirler[55]);
            //Eleman Silme
            Console.WriteLine("\nEleman Silme");
            sehirler.Remove(34);

            // Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key} - {item.Value,-7}");
            }

            Console.ReadKey();
        }
    }
}