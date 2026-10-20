using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
namespace Class
{
    public class OgretimElemani
    {
        // Property-Özellik                     
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        //public OgretimElemani()
        //{
        //    System.Console.WriteLine("Sicil No Giriniz: ");
        //    SicilNo = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Adinizi Giriniz: ");
        //    Adi = Console.ReadLine();

        //    Console.WriteLine("Soyadinizi Giriniz: ");
        //    Soyadi = Console.ReadLine();

        //    Console.WriteLine("Cinsiyet (E/K)");
        //    string c = Console.ReadLine();
        //    Cinsiyet = (c.ToUpper() == "E") ? true : false;
        //}
        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }
        public override string ToString()
        {
            return $"{SicilNo,-5} " +
                   $"{Adi,-5} " +
                   $"{Soyadi,-5} " +
                   string.Format("{0,-5}", Cinsiyet == true ? "Erkek" : "Kadin");
        }

        public static void Main(string[]args)
        {
            //Tanımlama
            OgretimElemani ogrGor = new OgretimElemani(1002, "Taha", "Kabakci", true);
            Console.WriteLine(ogrGor);
            Console.ReadKey();
        }
    }
}