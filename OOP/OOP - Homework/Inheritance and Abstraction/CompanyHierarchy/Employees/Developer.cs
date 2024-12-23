using System;
using System.Collections.Generic;
using System.Linq;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;
        public Developer(int id, string firstName, string lastName, decimal salary, DepartmentType department)
            : base(id, firstName, lastName, salary, department)
        {
            this.projects = new List<Project>();
        }

        public List<Project> Projects
        {
            get { return this.projects; }
        }

        public void CloseProject(Project project)
        {
            var containsProject = this.projects.Any(pr => pr == project);

            if (!containsProject)
            {
                throw new ArgumentException("The project is not part of this developer's projects");
            }
            project.IsOpen = false;
        }
     }
}
