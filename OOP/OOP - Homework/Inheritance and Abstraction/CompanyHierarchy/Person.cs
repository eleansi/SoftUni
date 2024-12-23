using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        
        private const int MinFirstNameLength = 1;
        private const int MinLastNameLength = 1;
        private const int MaxFirstNameLength = 10;
        private const int MaxLastNameLength = 10;
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < MinFirstNameLength || value.Length > MaxFirstNameLength)
                {
                    throw new ArgumentException("Your name can't contain less than 1 characters and more than 10!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < MinLastNameLength || value.Length > MaxLastNameLength)
                {
                    throw new ArgumentException("Your last name can't contain less than 1 characters and more than 10!");
                }
                this.lastName = value;
            }
        }
    }
}
