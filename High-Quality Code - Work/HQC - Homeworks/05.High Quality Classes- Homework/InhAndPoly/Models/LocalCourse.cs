using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    using Models;
    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName)
            : base(courseName)
        {
        }

        public LocalCourse(string courseName, string teacherName, List<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

       

        public string Lab 
        {
            get { return this.lab; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                   throw new ArgumentException("Lab name cannot be null.");   
                }
            }
        }

        public override string GetStudentsAsString()
        {
            if (base.Students == null || this.Students.Count == 0)
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
            result.Append("LocalCourse { Name = ");
            result.Append(this.CourseName);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
