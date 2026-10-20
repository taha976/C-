using System;
namespace Fonksiyonlar
{
    public class Program
    {
        static void Main(string[]args)
        {


            int buyuk = Karsilastir(15,10);
            Console.WriteLine(buyuk);
            var x = KareAl(5);  // ilk başta 5'in karesi alıyoruz ve x'e atıyoruz ve double y = KareAl(x); ile x'in karesini alıp y'ye atıyoruz.    
            double y = KareAl(x);
            Console.WriteLine(x);
            Console.WriteLine(y);

            double toplam = SeriToplam(15.75, 20.6, 25.5);
            Console.WriteLine("{0,5}", toplam);
           





            Console.ReadKey();
        }

        private static double SeriToplam(params double[] seri) // burada yazan params kaç tane argüman geleceğini bilmek zorunda olmamamızı sağlıyor.
        {
            double toplam = 0;
            foreach (var s in seri)
            {
                toplam += s;
            }
            return toplam;
        }

        public static  int Karsilastir(int sayi1, int sayi2)
        {
            return sayi1 > sayi2 ? sayi1 : sayi2;
           
        }

        static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }

    }
}