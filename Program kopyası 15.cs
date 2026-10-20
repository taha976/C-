using System;
using System.Collections.Generic;

namespace HastaKayit
{
    public class Patient : IComparable<Patient>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public Patient(int id, string name, string surname, string tcNo, string phoneNumber, string gender,  DateTime birthDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            TcNo = tcNo;
            PhoneNumber = phoneNumber;
            Gender = gender;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Sira No          : {Id}\n" +
                   $"Adi              : {Name}\n" +
                   $"Soyadi           : {Surname}\n" +
                   $"Kimlik No        : {TcNo}\n" + 
                   $"Telefon Numarasi : {PhoneNumber}\n" +
                   $"Cinsiyet         : {Gender}\n" +
                   $"Dogum Tarihi     : {BirthDate}\n";
        }
        public int CompareTo(Patient? other)
        {
            if(this.Id < other.Id)
            {
                return - 1;
            }
            else if (this.Id == other.Id)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

    }


    public class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("\n-----Hasta Kayit Sistemi-----");
            List<Patient> patients = new List<Patient>()
            {
                new Patient (5, "Ahmet", "Yilmaz", "12345678901", "05551234567", "Erkek", new DateTime(1990, 1, 1)),
                new Patient (2, "Ayse", "Demir", "23456789012", "05552345678", "Kadin", new DateTime(1995, 2, 2)),
                new Patient (4, "Mehmet", "Kara", "34567890123", "05553456789", "Erkek", new DateTime(1985, 3, 3)),
                new Patient (1, "Fatma", "Yildiz", "45678901234", "05554567890", "Kadin", new DateTime(2000, 4, 4)),
                new Patient (3,"Taha", "Kabakci", "56789012345", "05555678901", "Erkek", new DateTime(2006,4,19)),
                new Patient (6, "Zeynep", "Aydin", "67890123456", "05556789012", "Kadin", new DateTime(2006, 5, 5))
            };


            patients.Sort();
            foreach(var patient in patients)
            {
                Console.WriteLine(patient);
                Console.WriteLine("---------------------------------------");
            }


            Console.ReadKey();
        }
    }
}