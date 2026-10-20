using System;
using System.Collections.Generic;

namespace Kalıtım
{
    class Calisan
    {
        public virtual void Calis() // Bu metot istenirse alt sınıflarda değiştirilebilir (virtual)
        {
            Console.WriteLine("Calisan calisiyor.");
        }
        
    }
    class Muhendis : Calisan
    {
        public override void Calis()  // Üst sınıftaki metodu kendi sınıfıma göre değiştiriyorum (override)
        {
            Console.WriteLine("Muhendis proje uzerinde calisiyor.");
        }
    }
    class Doktor : Calisan
    {
        public override void Calis()
        {
            Console.WriteLine("Doktor hastayi muayene ediyor.");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Calisan c1 = new Muhendis();
            c1.Calis();

            Calisan c2 = new Doktor();
            c2.Calis();


            Console.ReadKey();
        }
    }
}