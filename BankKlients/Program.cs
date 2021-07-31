using System;

using System.Collections.Generic;

namespace BankKlients
{
    class Program
    {
        static void Main(string[] args)
        {
            var petia = new Klient() {Fio = "Иванов Пётр Иванович", PassNom= 123456, Sum = 100};
            var kolia = new Klient() {Fio = "Иванов Николай Иванович", PassNom = 234567, Sum = 200};
            var serega = new Klient() {Fio = "Иванов Сергей Иванович", PassNom = 345678, Sum = 200};
            var piotr = new Klient() {Fio = "Иванов Пётр Иванович", PassNom = 456789, Sum = 500};
            var newpetia = new Klient() {Fio = "Иванов Пётр Иванович", PassNom = 123456, Sum = 100};

            Klient[] people = new Klient[] {petia, kolia, serega, piotr, newpetia};

            List<Klient> klients = new List<Klient>();
            foreach (var men in people)
            {
                AddClient(men, ref klients);
            }

            int countklient = klients.Count;
        }

        public static void AddClient(Klient person, ref List<Klient> persons)
        {
            if (!persons.Contains(person))
            {
                persons.Add(person);
            }
        }
    }
}