using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
    public class Customer : Person, ICustomer
    {
        private decimal balance;
        public Customer(int id, string firstName, string lastName, decimal balance) : base(id, firstName, lastName)
        {
            this.Balance = balance;
        }

        public decimal Balance 
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be negative");
                }
                this.balance = value;
            }
        }
    }
}
