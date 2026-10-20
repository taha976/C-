using System;

namespace Deneme1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            float sayi1;
            float sayi2;
            float sayi3;
            Console.WriteLine("Iki deger giriniz: ");
            sayi1 = float.Parse(Console.ReadLine());
            sayi2 = float.Parse(Console.ReadLine());
            sayi3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Toplam: " + (sayi1 + sayi2 + sayi3));
            Console.WriteLine("Bölme: "  + (sayi1 / sayi2 / sayi3));
            Console.WriteLine("Carpma: " + (sayi1 * sayi2 * sayi3));
            Console.WriteLine("Cıkarma: " + (sayi1 - sayi2 - sayi3));

            Console.ReadKey();
        }
    }
}
    