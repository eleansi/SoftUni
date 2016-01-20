using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get { return this.grade; }
        private set
        {
            if (value < 0)
            {
                throw new IndexOutOfRangeException("The grade must be in range from 1 to 10");
            }
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get { return this.minGrade; }
        private set
        {
            if (value < 0)
            {
                throw new IndexOutOfRangeException("The min grade is 1");
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get { return this.minGrade; }
        private set
        {
            if (maxGrade <= minGrade)
            {
                throw new IndexOutOfRangeException("Max grade cannot be less than the minimum grade!");
            }
            this.minGrade = value;
        }
    }

    public string Comments
    {
        get { return this.comments; }
        private set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Your coment must contain something");
            }
        }
    }
}
