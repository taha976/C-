using System;
using System.Collections.Generic;

namespace Kalıtım
{
    class Hayvan
    {
        public void SesiCikar()
        {
            Console.WriteLine("Hayvan ses çikariyor. ");
        }
    }
    class Kedi : Hayvan   // her sınıfı farklı bir sekilde tanımlarız!!
    {
        public void Miyavla()
        {
            Console.WriteLine("Kedi miyavliyor. ");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Kedi kedi = new Kedi();
            Hayvan hayvan = new Hayvan();  // eger hayvan sinifi kedi sinifindan türetilirse hayvan sinifini kullanamayiz.
            kedi.SesiCikar();
            kedi.Miyavla();

            Console.ReadKey();
        }
    }
}