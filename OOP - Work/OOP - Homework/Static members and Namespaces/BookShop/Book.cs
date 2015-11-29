using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookShop
{
    class Book
    {
        // This exercise is from "exercise in class", not from the homework.
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The title of the book cannot be null!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The book should have an author!");
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The price cant't be negative!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            int index = base.ToString().LastIndexOf(".");
            return string.Format("Type: {0}{1}-Title: {2}\n-Author: {3}\n-Price: {4:f2} leva",
                base.ToString().Substring(index + 1),
                Environment.NewLine,
                this.title, 
                this.author, 
                this.price);
        }
    }
}
