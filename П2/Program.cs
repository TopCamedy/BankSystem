using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Проект 2: Сберегательный счет ===");
            SavingAccount saveAcc = new SavingAccount("Петр Петров", Currency.RUB);
            saveAcc.Deposit(1500);
            Console.WriteLine(saveAcc.GetAccountInfo());

            Console.WriteLine("Попытка снять 600 (должна быть ошибка лимита):");
            saveAcc.Withdraw(600);
            Console.WriteLine("Текущий баланс: " + saveAcc.Balance);
        }
    }
}