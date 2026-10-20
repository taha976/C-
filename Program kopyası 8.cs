using System;
namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;*/
            int sayac = 1;

            /*Console.WriteLine("Dongu Baslangici !");
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Dongu sonu !");*/
            // 10'dan 0'a azalan sekilde
            /*while (sayac > 0)
            {
                
                Console.WriteLine("{0,-3} {1,-3}" ,sayac ,sayac*sayac);  // süslü parantez ile yazılan 5 karakterlik boşluk bırakıyor.
                sayac = sayac - 1;
            }*/

            //1'den 10' a artan sekilde
            /*while (sayac <= 10)
            {
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac*sayac);
                sayac++;
            }*/

            /*int i = 2;
            Console.Write("Bir sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine()); 
            do
            {
                Console.Write("{0,-3}", i);
                i += 2;
            }
            while (i <= n);*/

            /*Console.WriteLine("Iki deger giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a;i <= b;i++)
            {
                if (i % 3 == 0) // 3'ün katlarını yazdırmamak için.
                {
                   continue;
                }
                Console.Write("{0,-3}", i);
            }

            for (int i=a;i <b; i++)
            {
                if (i == 100) // 100'e kadar yazmasına izin veriyor.
                {
                    break;
                }
                Console.Write("{0,-3}", i);
            }*/



            /*int m = 0;
            for (int i = 0;i <5;i++)
            {
                for (int j=0;j<5;j++)
                {
                    m++;
                    Console.Write(" * " + m);
                }
                Console.WriteLine();
            }*/

            /*for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    
                    Console.Write(" {0},{1} " ,i,j);
                    Console.WriteLine(" {0},{1} " ,i+1,j+1);
                }
                Console.WriteLine();
            }*/
            Console.Write("Bir deger giriniz: ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<=i;j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }






            /*for (int i=100;i>=0;i-=2)
            {
                Console.WriteLine("{0,-3}", i);
            }*/




            Console.ReadKey();
        }

    }
}