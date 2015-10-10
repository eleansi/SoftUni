using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.ClassStudent;


class WriteStudentList
{
    static void Main(string[] args)
    {

        // Exercise 1
        foreach (var student in StudentList.studentsList)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }

        // Exercise 2
        List<Student> studList = StudentList.studentsList;
        var studentQuery =
            from student in studList
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;

        
        Console.WriteLine("*************** STUDENTS WITH GROUP NUMBER = 2 ***********");
        foreach (Student student in studentQuery)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }
        // Exercise 3
        List<Student> stList = StudentList.studentsList;
        var names =
            from st in stList
            where st.FirstName.CompareTo(st.LastName) == -1
            select st;
        Console.WriteLine("*************** STUDENTS WHOSE FIRST NAME PRECEEDS (ALPHABETICALLY) LAST NAME ***********");
        foreach (Student student in names)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }

        // Exercise 4
        List<Student> studenList = StudentList.studentsList;
        var ages =
            from studentAge in studenList
            where studentAge.Age > 18 && studentAge.Age < 24
            select studentAge;
        Console.WriteLine("*************** GROUP STUDENTS BY THEIR AGE ***********");
        foreach (Student student in ages)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }


        // Exercise 5
        List<Student> sList = StudentList.studentsList;
        IEnumerable<Student> orderedList =
            sList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);


        Console.WriteLine("*************** STUDENTS ORDERED BY FIRST AND LAST NAME ***********");
        foreach (Student student in orderedList)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }

        // Exercise 6
        List<Student> emailValidation = StudentList.studentsList;
        var emails =
            from email in emailValidation
            where email.Email.IndexOf("@abv.bg") > 0
            orderby email.FirstName
            select email;

        Console.WriteLine("***************************STUDENTS WHICH HAVE EMAIL IN ABV.BG**************************");
        foreach (Student student in emailValidation)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }


        // Exercise 8
        List<Student> gradesList = StudentList.studentsList;
        var grades =
            from student in studList
            where student.Marks.IndexOf(6) > -1
            orderby student.FirstName
            select new
            {
                FullName = student.FirstName + " " + student.LastName,
                Marks = string.Join(", ", student.Marks.ToArray())
            };


        Console.WriteLine("*********************************** STUDENTS WITH EXCELLENT MARKS *********************************");
        foreach (var data in grades)
        {
            Console.WriteLine("Name: {0}", data.FullName);
            Console.WriteLine("Marks: {0}", data.Marks);

            Console.WriteLine("=========================================");
        }


        List<Student> studentList2014 = StudentList.studentsList;

        var students2014 =
            from student2014 in studentList2014
            where student2014.FacultyNumber.Substring(4, 2).Equals("14")
            orderby student2014.FirstName
            select student2014;

        Console.WriteLine("**************************************** STUDENTS ENROLLED IN 2014 **********************************");
        foreach (Student student in students2014)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }
    }
}

