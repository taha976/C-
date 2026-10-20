using System;
using System.Collections;

namespace Phone
{
    class Program
    {
        static void Main(string[]args)
        {
            Hashtable phonebook = new Hashtable();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ismim giriniz: ");
                string name = Console.ReadLine();

                Console.WriteLine("Telefon numaranizi giriniz: ");
                string phoneNumber = Console.ReadLine();

                phonebook[name] = phoneNumber;

                Console.WriteLine("\n-Telefon Rehberi-");

                foreach(DictionaryEntry item in phonebook)
                {
                    Console.WriteLine(item.Key + "->" + item.Value);
                }
            }

            Console.ReadKey();
        }
    }
}