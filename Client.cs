using System.Collections.Generic;

namespace BankSystem
{
    public class Client
    {
        public string Name;
        // Список строк, где хранятся ID всех счетов этого человека
        public List<string> Accounts = new List<string>();

        public Client(string name)
        {
            Name = name;
        }
    }
}