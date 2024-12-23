using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Invalid first name!");
                Environment.Exit(0);
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Invalid first name!");
                Environment.Exit(0);
            }
            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentException("Wow! Error happened!!!");
        }

        if (this.Exams.Count == 0)
        {
           throw new ArgumentException("The student has no exams!");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            throw new ArgumentException("Cannot calculate average on missing exams");
        }

        if (this.Exams.Count == 0)
        {
            // No exams --> return -1;
            throw new IndexOutOfRangeException("The student has no exams!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
