using System.Collections.Generic;
using CompanyHierarchy.Employees;
namespace CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        IEnumerable<Employee> Employees { get; }
    }
}
