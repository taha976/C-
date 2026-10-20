using System;
namespace Diziler2
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Dizi boyutunu giriniz");
            int boyut = Convert.ToInt32(Console.ReadLine());


            int[] sayilar = new int[boyut];
            var r = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = r.Next(1, 10);    
            }
            foreach (var s in sayilar) // for'un içine yazdırdıklarımızı görmek için yazıldı.
            {
                Console.WriteLine(s);
            }

            foreach (var s in sayilar)
            {
                Console.WriteLine($"{s,2} {s*s,2}"); // burada yazılan sayı değerleri ekranda ne kadar boşluk olacağına karar verir.
            }
        }
    }
}