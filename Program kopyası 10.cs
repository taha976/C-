using System;
namespace Fonksiyonlar2
{
    public class Program
    {
        static void Main(string[]args)
        {

           var odenecekMiktar = SatisYap(100);
            Console.WriteLine(odenecekMiktar);

            var odenecekMiktar2 = SatisYap(100, 0.1);
            Console.WriteLine("{0,5:0.##}", odenecekMiktar2); // burada süslğ parantez içinde yazan işlem 5 karakterle sınırlar.


            Console.ReadKey();
        }
        static double SatisYap(double tutar)
        {
            return tutar * 1.18;
        }
        static double SatisYap(double tutar, double indirim)
        {
            return (tutar * (1.0 - indirim)) * 1.18;
        }
    }
}