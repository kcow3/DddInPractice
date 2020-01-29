namespace DomainDrivenDesign.Logic
{
    public sealed class VendingMachine : EntityBase
    {
        public Money MoneyInMachine;
        public Money MoneyInTransaction;

        public void InsertMoney(Money moneyInserted)
        {
            MoneyInTransaction += moneyInserted;
        }

        public void ReturnMoney()
        {
            //MoneyInTransaction = 0;
        }

        public void BuyAnItem()
        {
            MoneyInMachine += MoneyInTransaction;
            //MoneyInTransaction = 0;
        }

    }
}
