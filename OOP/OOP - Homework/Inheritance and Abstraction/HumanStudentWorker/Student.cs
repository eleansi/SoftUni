﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 && value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number:");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} ---> {2}", this.FirstName, this.LastName, this.facultyNumber);
        }
    }
}
