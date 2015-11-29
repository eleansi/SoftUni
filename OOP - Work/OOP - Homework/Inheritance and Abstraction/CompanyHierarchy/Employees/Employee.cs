using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
    public abstract class Employee : Person, IEmployee
    {
        
        private const decimal MinSalary = 0;
        private decimal salary;
        

        protected Employee(int id, string firstName, string lastName, decimal salary, DepartmentType department) 
            : base(id, firstName, lastName)
        { 
            this.Salary = salary;
            this.Department = department;
        }

        public DepartmentType Department { get; set; }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < MinSalary)
                {
                    throw new ArgumentException("Salary can't be negative!");
                }
                this.salary = value;
            }
        }
    }
}
