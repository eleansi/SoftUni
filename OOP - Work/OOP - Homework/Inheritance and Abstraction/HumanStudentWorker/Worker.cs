using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Worker : Human
    {

        private int weekSalary;
        private int workHoursPerDay;
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            double result = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return result;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}\nWork hours per day: {2}\nWeek salary: {3}\n" +
                                                   "Money per hour: {4}", this.FirstName,this.LastName , this.WorkHoursPerDay, this.WeekSalary, this.MoneyPerHour());
        }
    }
}
