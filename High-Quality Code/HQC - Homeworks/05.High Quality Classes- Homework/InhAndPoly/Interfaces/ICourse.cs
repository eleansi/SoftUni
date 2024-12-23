using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Interfaces
{
    public interface ICourse
    {
        string CourseName { get; set; }

        string TeacherName { get; set; }

        List<string> Students { get; set; }

        string GetStudentsAsString();
    }
}
