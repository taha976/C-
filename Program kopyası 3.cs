using System;
namespace Cok_Boyutlu_Diziler
{
    class Program
    {
        static void Main()
        {
            double[,] matris = new double[,] { { 1, 2, 3, 6 }, { 2, 3, 4, 12 }, { 3, 6, 5, 10 } };

            double toplam = 0;  // İlk değer atandı!

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j) // Diagonal elemanlar
                    {
                        matris[i, j] = -1;
                    }
                    if (matris[i, j] % 2 == 0) // Çift sayıları 0 yapıyoruz
                    {
                        matris[i, j] = 0;
                    }

                    toplam += matris[i, j]; 

                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Toplam: {toplam}");

            Console.ReadKey();
        }
    }
}
