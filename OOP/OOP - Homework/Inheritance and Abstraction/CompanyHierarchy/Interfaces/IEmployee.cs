using CompanyHierarchy.Employees;

namespace CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
        decimal Salary { get; set; }

        DepartmentType Department { get; set; }
    }
}
