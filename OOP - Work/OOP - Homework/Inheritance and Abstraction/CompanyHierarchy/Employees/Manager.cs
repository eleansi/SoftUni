using System;
using System.Collections.Generic;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
    public class Manager : Employee, IManager
    {
        private readonly List<Employee> employees; 
        public Manager(int id, string firstName, string lastName, decimal salary,
            DepartmentType department) : base(id, firstName, lastName, salary, department)
        {
            this.employees = new List<Employee>();
        }

        

        public IEnumerable<Employee> Employees
        {
            get { return this.employees; }
            
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("The employee cannot be null");
            }
            if (employee.Department != this.Department)
            {
                throw new ArgumentException("Department of employee and manage must be the same");
            }
            this.employees.Add(employee);
        }
    }
}
