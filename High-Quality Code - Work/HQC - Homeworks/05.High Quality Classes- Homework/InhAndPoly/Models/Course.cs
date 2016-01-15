using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Models
{
    using Interfaces;
    public abstract class Course : ICourse
    {
        private string courseName;
        private string teacherName;
        private List<string> students;

        protected Course(string courseName)
        {
            this.CourseName = courseName;
        }

        protected Course(string courseName, string teacherName, List<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }
        public string CourseName
        {
            get { return this.courseName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The course must have a specific name!");
                }
                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get { return this.teacherName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The teacher must have a specific name!");
                }
                this.teacherName = value;
            }
        }

        public List<string> Students { get; set; }
    

        public abstract string GetStudentsAsString();
    }
}
