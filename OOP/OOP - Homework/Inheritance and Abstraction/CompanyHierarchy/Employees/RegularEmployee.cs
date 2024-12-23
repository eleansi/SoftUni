using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
    public class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, DepartmentType department) 
            : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
