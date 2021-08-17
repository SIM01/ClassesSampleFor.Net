using System;

namespace SampleForDelegate
{
    public class BankAccount
    {
        public delegate void AccountMessageHandler(string message);
        public int Sum { get; private set; }
        private AccountMessageHandler _messageHandler;

        public void DeligateRegister(AccountMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }
        public void Add(int sum)
        {
            Sum = Sum + sum;
            _messageHandler.Invoke($"На ваш счет пришла сумма {sum}");
        }
        public void AddNew(int sum,AccountMessageHandler messageHandler)
        {
            Sum = Sum + sum;
            messageHandler.Invoke($"На ваш счет пришла сумма {sum}");
        }
    }
}