using System;

namespace CompanyHierarchy.Employees
{
    public class Sale
    {
        private const int MINProductNameLength = 1;
        private const decimal MinPrice = 0;
        private string productName;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.DateOfSale = date;
            this.Price = price;
        }
        public DateTime DateOfSale { get; set; }

        public string ProductName 
        {
            get { return this.productName; }
            set
            {
                if (value.Length < MINProductNameLength || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name length cannot be less than 1 character");
                }
                this.productName = value;
            }
        }

        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (value < MinPrice)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative!");
                }
                this.price = value;
            }
        }

    }
}
