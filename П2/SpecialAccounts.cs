namespace BankSystem
{
    // Наследуемся от обычного счета, но меняем правила снятия
    public class SavingAccount : BankAccount
    {
        public decimal MinBalance = 1000; // Порог, ниже которого нельзя опускаться

        public SavingAccount(string owner, Currency curr) : base(owner, curr) { }

        // Перезаписываем метод снятия (override)
        public override void Withdraw(decimal amount)
        {
            // Проверяем, останется ли на счету минимальная сумма
            if (Balance - amount >= MinBalance)
            {
                Balance -= amount;
            }
            else
            {
                // Если денег мало — просто выводим предупреждение
                System.Console.WriteLine("Ошибка: лимит остатка в 1000 руб.");
            }
        }
    }
}