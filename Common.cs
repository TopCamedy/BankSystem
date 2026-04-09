namespace BankSystem
{
    // Список состояний счета, чтобы не путаться в строках
    public enum AccountStatus { Active, Frozen, Closed }
    // Список доступных валют
    public enum Currency { RUB, USD, EUR }
}