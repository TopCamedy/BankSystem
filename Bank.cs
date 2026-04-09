namespace BankSystem
{
    public class Bank
    {
        // Метод связывает клиента и конкретный счет
        public void OpenAccount(Client client, BankAccount account)
        {
            client.Accounts.Add(account.AccountId);
        }
    }
}