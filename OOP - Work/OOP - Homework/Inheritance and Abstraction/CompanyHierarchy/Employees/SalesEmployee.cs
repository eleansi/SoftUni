using System.Collections.Generic;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
    public class SalesEmployee : RegularEmployee, IRegularEmployee
    {
        private List<Sale> sales;
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, DepartmentType department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.sales = new List<Sale>();
        }


        public IEnumerable<Sale> Sales
        {
            get { return this.sales; } 
            
        }

        public void AddSale(Sale sale)
        {
            this.sales.Add(sale);
        }
    }
}
