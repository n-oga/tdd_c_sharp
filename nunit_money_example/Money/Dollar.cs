namespace nunit_money_example.Money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public Dollar Times(int multipiler)
        {
            return new Dollar(Amount * multipiler);
        }
    }
}