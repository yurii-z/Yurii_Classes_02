using System;
namespace Task4
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        protected string article;
        protected int quantity;

        public Invoice( int account, string customer, string provider )
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void SumWithOrWithoutVAT()
        {
            Console.WriteLine($"sum with VAT = {account * 0.2}\n");
            Console.WriteLine($"sum without VAT = {account}\n");
        }
    }
}
