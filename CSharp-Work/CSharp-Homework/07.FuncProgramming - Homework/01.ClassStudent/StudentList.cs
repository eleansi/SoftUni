using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudent
{
    class StudentList
    {
        public static List<Student> studentsList = new List<Student>(){

            new Student(){ 
                FirstName ="Strahil", LastName = "Ivanov",
                Age = 22, FacultyNumber="893073",
                Phone="0889333444", Email = "ivan@abv.bg", 
                Marks = new List<int>(){2, 6, 4, 5, 3, 3},
                GroupNumber = 2},

            new Student(){ 
                FirstName ="Stoil", LastName = "Petrov",
                Age = 33, FacultyNumber="891023", 
                Phone="0885333444", Email = "peter@petrov.com", 
                Marks = new List<int>(){3, 3, 4, 2, 3, 3},
                GroupNumber = 3},

                new Student(){ 
                FirstName ="Spas", LastName = "Georgiev",
                Age = 21, FacultyNumber="891533", 
                Phone="0873456144", Email = "gosho@losho.com", 
                Marks = new List<int>(){6, 6, 5, 6, 6, 6},
                GroupNumber = 1},

                new Student(){ 
                FirstName ="Veselka", LastName = "Marinova",
                Age = 27, FacultyNumber="991533", 
                Phone="0873452224", Email = "maria@abv.bg", 
                Marks = new List<int>(){4, 6, 5, 6, 6, 6},
                GroupNumber = 1},

                new Student(){ 
                FirstName ="Roza", LastName = "Stoyanova",
                Age = 26, FacultyNumber="851533", 
                Phone="0823456144", Email = "stoyanka@losho.com", 
                Marks = new List<int>(){2, 6, 5, 6, 2, 6},
                GroupNumber = 2},

                new Student(){ 
                FirstName ="Asen", LastName = "Draganov",
                Age = 41, FacultyNumber="855533", 
                Phone="0853456144", Email = "dragan@draganov.com", 
                Marks = new List<int>(){2, 6, 2, 2, 6, 6},
                GroupNumber = 1},

                new Student(){ 
                FirstName ="Bojkata", LastName = "Milanov",
                Age = 26, FacultyNumber="841533", 
                Phone="0888888888", Email = "milan@miladinov.com", 
                Marks = new List<int>(){2, 3, 4, 5, 6, 6},
                GroupNumber = 3},
        };
        
    }
}
