using System;
using System.Collections.Generic;

namespace Kalıtım
{
    class Arac
    {
        public string Marka;
        public int ModelNo;
        public string Model;
        public int Beygir;
        public Arac (string marka, int modelNo, string model, int beygir)
        {
            Marka = marka;
            ModelNo = modelNo;
            Model = model;
            Beygir = beygir;
        }
        public void BilgiYazdir()
        {
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Model No: " + ModelNo);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Beygir Gücü: " + Beygir);
        }
    }
    class Araba : Arac
    {
        public Araba(string marka, int modelNo, string model, int beygir) : base(marka, modelNo, model, beygir) { }
        
    }
    class Program
    {
        static void Main(string[]args)
        {
            Araba araba = new Araba("BMW", 2006, "M5", 507);
            araba.BilgiYazdir();

            Console.ReadKey();
        }
    }
}