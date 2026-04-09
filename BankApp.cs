using System;
using System.Collections.Generic;

namespace BankSystem
{
    public static class BankApp
    {
        // Хранилища данных в памяти на время работы программы
        static Bank centralBank = new Bank();
        static List<Client> clients = new List<Client>();
        static List<BankAccount> allAccounts = new List<BankAccount>();

        public static void Run()
        {
            while (true) // Бесконечное меню
            {
                Console.WriteLine("\n1. Новый клиент | 2. Открыть счет | 3. Пополнить | 0. Выход");
                string choice = Console.ReadLine();

                if (choice == "1") CreateClient();
                if (choice == "2") OpenAccount();
                if (choice == "3") DepositMoney();
                if (choice == "0") break;
            }
        }

        static void CreateClient()
        {
            Console.Write("Введите имя клиента: ");
            clients.Add(new Client(Console.ReadLine()));
        }

        static void OpenAccount()
        {
            if (clients.Count == 0) return;

            // Выбираем, кому открываем счет
            for (int i = 0; i < clients.Count; i++)
                Console.WriteLine((i + 1) + ". " + clients[i].Name);

            int idx = int.Parse(Console.ReadLine()) - 1;

            // Создаем счет и регистрируем его в базе
            var newAcc = new BankAccount(clients[idx].Name, Currency.RUB);
            allAccounts.Add(newAcc);
            centralBank.OpenAccount(clients[idx], newAcc);
            Console.WriteLine("Готово!");
        }

        static void DepositMoney()
        {
            // Ищем нужный счет по его ID
            foreach (var a in allAccounts) Console.WriteLine(a.GetAccountInfo());
            Console.Write("Введите ID: ");
            string id = Console.ReadLine();
            Console.Write("Сумма: ");
            decimal sum = decimal.Parse(Console.ReadLine());

            foreach (var a in allAccounts)
            {
                if (a.AccountId == id) a.Deposit(sum);
            }
        }
    }
}