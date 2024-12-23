using System;

namespace CompanyHierarchy.Employees
{
    public class Project
    {
        public Project(string name, DateTime? startDate, string details, bool isOpen)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.IsOpen = isOpen;
        }

        public string Name { get; set; }

        public bool IsOpen { get; set; }

        public DateTime? StartDate { get; set; }

        public string Details { get; set; }
    }
}
