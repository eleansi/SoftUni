using System;
using System.Collections.Generic;
using CompanyHierarchy.Employees;

namespace CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesEmployee saler = new SalesEmployee(123145, "Joro", "Petrov", 120.20m, DepartmentType.Production);
            saler.AddSale(new Sale("Liutenica", DateTime.Parse("12.12.2015"), 2.20m));

            Customer kakaMinka = new Customer(15651513, "Kaka", "Minka", 5000);
            Customer pepiMotichkata = new Customer(67654654, "Pepi", "Motichkata", 3000);
            Manager theBoss = new Manager(156136, "Chicho", "Gosho", 10000, DepartmentType.Marketing);

            Developer dev = new Developer(333, "Bai", "Stavri", 101010, DepartmentType.Accounting);
            var projectAmazon = new Project("Amazon", null, null, true);
            var projectSoftUni = new Project("SoftUni", DateTime.Now, "....", true);
            dev.Projects.Add(projectAmazon);
           

            List<Person> people = new List<Person>();
            people.Add(kakaMinka);
            people.Add(pepiMotichkata);
            people.Add(theBoss);
          

            foreach (Person per in people)
            {
                Console.WriteLine("ID: {0}\nFirst name: {1}\nLast name: {2}", per.Id,
                    per.FirstName, per.LastName);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
