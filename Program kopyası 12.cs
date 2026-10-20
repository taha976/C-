using System;
using System.Collections;

namespace HashTable
{
    public class Program
    {
        static void Main(string[]args)
        {
            //Hash Table Uygulamasi

            // Baslik Okuma
            Console.WriteLine("Baslik Giriniz: ");
            string baslik = Console.ReadLine();

            //Kucultme Islemı
            baslik = baslik.ToLower();

            //HashTAble
            var karakterSeti = new Hashtable()
            {
                {'ç' , 'c' },
                {'ı' , 'i' },
                {'ö' , 'o' },
                {'ü' , 'u' },
                {' ' , '-' },
                {'ş' , 's' },
                {'ğ' , 'g' }
            };


            foreach(DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key,(char) item.Value);

            }

            //Ekrana Yazdirma
            Console.WriteLine(baslik);


            Console.ReadKey();
        }
    }
}
