namespace BankSystem
{
    public abstract class AbstractAccount
    {
        public string AccountId; // Уникальный номер
        public string OwnerName; // ФИО владельца
        public decimal Balance;  // Остаток на счету
        public AccountStatus Status;

        public AbstractAccount(string ownerName)
        {
            // случайный номер при создании
            AccountId = "ID" + new System.Random().Next(1000, 9999);
            OwnerName = ownerName;
            Balance = 0;
            Status = AccountStatus.Active;
        }

        // virtual позволяет дочерним классам менять логику этих методов
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