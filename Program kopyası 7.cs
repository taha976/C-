using System;
using System.Collections;
namespace Diziler_Liste
{
    public class  Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList()
            {
                10, "Taha KABAKCI", true, '*'   
            };
           
               

            /*arraylist.Add(10);  // boxing işlemi gerçekleşir    
            arraylist.Add("Taha KABAKCI");
            arraylist.Add(true);
            arraylist.Add('e*/

            foreach (var e in arraylist)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            int[] sayilar = new int[] { 1283,1453,1071 };  // burada yaptıgımız islem yukarida yapilan arraylist islemine ekleme yapildi.
            arraylist.AddRange(sayilar); // boxing işlemi gerçekleşir   

            foreach (var e in arraylist)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            Console.WriteLine(arraylist[4]);
            var x = (int)arraylist[0];  // arraylist'in ilk elemanını alıp üzerine 10 ekledik.
            Console.WriteLine(x + 10);
            arraylist.RemoveRange(3, 3);
            arraylist.Remove(10);// arraylist'ten 10'u sildik.
            arraylist.Remove('*');
            Console.WriteLine();
            foreach (var e in arraylist)
            {
                Console.Write($"{e} ");
            }

            Console.ReadKey();
        }
    }
}