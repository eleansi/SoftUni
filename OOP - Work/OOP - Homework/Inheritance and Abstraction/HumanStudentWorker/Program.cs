using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Student> students = new List<Student>();
                Student s1 = new Student("Filip", "Kolev", "A12356");
                Student s2 = new Student("Stancho", "Kralev", "B124596");
                Student s3 = new Student("Asparuh", "Motichkov", "A12996");
                Student s4 = new Student("Stoil", "Stoichev", "F123456");
                Student s5 = new Student("Chico", "Markin", "S125555");
                Student s6 = new Student("Aladin", "Aladinov", "C112456");
                Student s7 = new Student("Spaider", "Men", "B123788");
                Student s8 = new Student("Kosta", "Markov", "E57676");
                Student s9 = new Student("Fiki", "Storaro", "Q7348956");
                Student s10 = new Student("Brat", "Mu", "VforVendeta");
                students.Add(s1);
                students.Add(s2);
                students.Add(s3);
                students.Add(s4);
                students.Add(s5);
                students.Add(s6);
                students.Add(s7);
                students.Add(s8);
                students.Add(s9);
                students.Add(s10);

                //var sortedStudents = students.OrderBy(x => x.FacultyNumber);
                List<Student> sortedStudents = new List<Student>();
                foreach (Student studentt in students)
                {
                    sortedStudents.Add(studentt);
                }


                //To be Merged
                var superSortedStudent = sortedStudents.OrderBy(x => x.FacultyNumber);
                foreach (Student stud in superSortedStudent)
                {
                    Console.WriteLine(stud.ToString());
                }

                Console.WriteLine();
                //Merge (students) and (workers)
                List<Worker> workers = new List<Worker>()
                {
                    new Worker("Chicho", "Gosho", 200.20, 4),
                    new Worker("Bate", "Sasho", 250.20, 8),
                    new Worker("Bai", "Blagoi", 220.20, 5),
                    new Worker("Vulchan", "Mechkov", 243.49, 7),
                    new Worker("Stamat", "Melnikov", 200.20, 4),
                    new Worker("Gosho", "Kukuvicata", 200.20, 4),
                    new Worker("Svetlin", "Svetliq", 200.20, 4),
                    new Worker("Azis", "Azis", 200.20, 4),
                    new Worker("Toni", "Storaro", 200.20, 4),
                    new Worker("Bat", "Vanio", 200.20, 4)
                };
                


                var sortedWorkers =
                    from worker in workers
                    orderby worker.MoneyPerHour() descending
                    select worker;

                foreach (Worker work in sortedWorkers)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(work.ToString());
                }

                List<Human> humans = new List<Human>();
                humans.AddRange(students);
                humans.AddRange(workers);

                humans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();
                foreach (Human human in humans)
                {
                    Console.WriteLine();
                    Console.WriteLine(human.ToString());
                }
            }
            catch (ArgumentOutOfRangeException are)
            {
                Console.WriteLine(are.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
