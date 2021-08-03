using System;
using System.Collections.Generic;

namespace BankKlients
{
    class Program
    {
        static void Main(string[] args)
        {
            var petia = new Klient() {Fio = "Иванов Пётр Иванович", PassNom = 123456};
            var kolia = new Klient() {Fio = "Иванов Николай Иванович", PassNom = 234567};
            var serega = new Klient() {Fio = "Иванов Сергей Иванович", PassNom = 345678};
            var piotr = new Klient() {Fio = "Иванов Пётр Иванович", PassNom = 456789};
            var newpetia = new Klient() {Fio = "Иванов Пётр Иванович", PassNom = 123456};

            List<Klient> klients = new List<Klient>();
            klients.AddRange(new Klient[] {petia, kolia});

            Dictionary<Klient, Accounts> bankklients = new Dictionary<Klient, Accounts>();
            foreach (var men in klients)
            {
                Console.WriteLine($"Введите валюту клиента {men.Fio}(usd,eur,rub,mdl):");
                string klientcurrency = Console.ReadLine();
                Console.WriteLine($"Введите сумму в валюте клиента:");
                string klientsum = Console.ReadLine();
                Accounts klientaccount = new Accounts();
                int check = 0;
                switch (klientcurrency)
                {
                    case "usd":
                        klientaccount = new Accounts()
                            {Account = new Usd() {CurrencyRate = 1}, Sum = Convert.ToDecimal(klientsum)};
                        break;
                    case "eur":
                        klientaccount = new Accounts()
                            {Account = new Eur() {CurrencyRate = 1.2}, Sum = Convert.ToDecimal(klientsum)};
                        break;
                    case "mdl":
                        klientaccount = new Accounts()
                            {Account = new Mdl() {CurrencyRate = 0.2}, Sum = Convert.ToDecimal(klientsum)};
                        break;
                    case "rub":
                        klientaccount = new Accounts()
                            {Account = new Rub() {CurrencyRate = 0.1}, Sum = Convert.ToDecimal(klientsum)};
                        break;
                    default:
                        check = 1;
                        break;
                }

                if (check == 0)
                {
                    bankklients.Add(men, klientaccount);
                }
                else
                {
                    Console.WriteLine("Неверно введена валюта!");
                }
            }

            decimal summ = CurrencyConverter(new Mdl() {CurrencyRate = 0.2}, 10000, new Usd() {CurrencyRate = 1});
        }

        public static decimal CurrencyConverter(Currency valin, decimal sumin, Currency valout)
        {
            return Convert.ToDecimal(
                (Convert.ToDouble(sumin) * valin.CurrencyRate) / valout.CurrencyRate
            );
        }
    }
}