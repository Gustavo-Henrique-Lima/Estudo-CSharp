using Bank.Entities.Exceptions;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDraw)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDraw;
        }

        public void WithDraw(double amount)
        {
            if (amount > Balance)
            {

                throw new DomainException("Not enough balance");
            }
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
