using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("Иван Иванов", Currency.RUB);
            acc.Deposit(500);
            Console.WriteLine(acc.GetAccountInfo());
            acc.Withdraw(200);
            Console.WriteLine("После снятия: " + acc.Balance);
        }
    }
}