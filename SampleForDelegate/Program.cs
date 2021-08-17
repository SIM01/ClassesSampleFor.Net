using System;

namespace SampleForDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            var messHandler = new BankAccount.AccountMessageHandler(SendMessage);
            messHandler += SendRedMessage;
            bankAccount.DeligateRegister(messHandler);
            bankAccount.Add(100);
            bankAccount.AddNew(100,messHandler);

            var test = new Test();
            for (int i=0;i<10;i++)
            {
                test.Divide(10,i);
            }
            
        }

        public static void SendRedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void SendMessage(string message)
        {
           
            Console.WriteLine(message);
        }
    }
}