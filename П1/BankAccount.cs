namespace BankSystem
{   
    public class BankAccount : AbstractAccount
    {
        public Currency Currency;

        public BankAccount(string ownerName, Currency currency) : base(ownerName)
        {
            Currency = currency;
        }

        // Метод для вывода данных в красивом виде
        public string GetAccountInfo()
        {
            return $"Счет {AccountId} | {Balance} {Currency} | {Status}";
        }
    }
}