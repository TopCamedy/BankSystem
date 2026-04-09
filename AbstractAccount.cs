namespace BankSystem
{
    public class AbstractAccount
    {
        public string AccountId;
        public string OwnerName;
        public decimal Balance;
        public AccountStatus Status;

        public AbstractAccount(string ownerName)
        {
            AccountId = "ID" + new System.Random().Next(1000, 9999);
            OwnerName = ownerName;
            Balance = 0;
            Status = AccountStatus.Active;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount) Balance -= amount;
        }
    }
}