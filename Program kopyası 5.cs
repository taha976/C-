using System;
using System.Collections;
using System.Collections.Generic;

namespace Diziler
{
    public class Program
    {
        static void Main(string[]args)
        {
            // Array | Dizi

            int[] sayilar = new int[] {10,2,3,4,5,18,23,44,45,6,34,19}; // ikiside ayni mantik;
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
            var arr = new ArrayList(sayilar);

            /*for (int i = 0; i < sayilar.Length; i++)// sayilar dizisindeki elemanlar numbers dizisine atamak için.
            {
                numbers.SetValue(sayilar[i], i); 
            }*/

            sayilar.CopyTo(numbers,0); // sayilar dizisindeki sayilari kopyala ve numbers dizisine at. 0. indeksten basla.

            Array.Sort(sayilar); // sayilar dizisi sıralandı.
            Array.Sort(numbers); // numbers dizisi sıralandı.   
            arr.Sort(); // ArrayList'de sort metodu var. Array'de yok. 
            Array.Clear(sayilar, 2, 2);
            Console.WriteLine(Array.IndexOf(sayilar,23));

            for (int i = 0; i<sayilar.Length; i++)
            {
                /*Console.WriteLine("Sayilar[{0}] = {1} - numbers[{0}] = {2}" , i, sayilar[i], numbers.GetValue(i));// böylede yazılabiliyor.*/

                Console.WriteLine($"Sayilar[{i}] = " + $"{sayilar[i],3} - " + $"numbers[{i}] = " + $"{numbers.GetValue(i),3} " 
                    + $"arr[{i}] = " + $"{arr[i],3}"); // böylede yazılabiliyor.
            }

            Console.ReadKey();
        }
    }
}