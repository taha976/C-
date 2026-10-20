using System;
namespace Btk_Akademi
{
    class Program
    {
        static void Main(string[]args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("{0},{1}",x,y);
            Degistir(x, y);
            Console.WriteLine("{0},{1}", x, y);
            Degistir(ref x, ref y); // bunu yazınca parametre yerine a ve be yerine x ve y yazmalıyız.
            Console.ReadKey();
        }

        private static void Degistir(int a, int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);
        }
        private static void Degistir(ref int a, ref int b) // ref yazıp x ve y'den referans aldık ve sayıların yerlerini yyine değiştirebildik
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);
        }
    }
}