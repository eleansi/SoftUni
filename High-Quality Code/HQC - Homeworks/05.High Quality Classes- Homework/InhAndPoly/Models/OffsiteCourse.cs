using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    using Models;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName, string teacherName, List<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, List<string> students, string town) 
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get { return this.town; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                   throw new ArgumentException("Town name cannot be null");  
                }
                this.town = value;
            }
        }
        

        public override string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(this.CourseName);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
