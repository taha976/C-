using System;
using System.Collections.Generic;

namespace Class_2
{
    public class OgretimElemani
    {
        // Özellikler
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Constructor
        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }
        public override string ToString()
        {
            return $"{SicilNo,-5} {Adi,-5} {Soyadi,-5} {(Cinsiyet ? "Erkek" : "Kadin"), -5}";
        }

        // Main metodu
        public static void Main(string[] args)
        {
            var liste1 =
                new List<OgretimElemani>
                {
                    new OgretimElemani(100,"Ali", "Yılmaz", true),
                    new OgretimElemani(101,"Ayşe", "Demir", false),
                    new OgretimElemani(102,"Mehmet", "Kaya", true),
                    new OgretimElemani(103,"Fatma", "Çelik", false)
                };
            Console.WriteLine("liste1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine("----------------------------------------------");
            
            

            var liste2 = liste1;
            Console.WriteLine("liste2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine("----------------------------------------------");
            
            liste2.Add(new OgretimElemani(104, "Taha", "Kabakci", true));
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine("----------------------------------------------");
            
            Console.WriteLine("liste 1'den eleman eksildi!");
            liste1.RemoveAt(0);
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            
            Console.ReadKey();
        }
    }
}
