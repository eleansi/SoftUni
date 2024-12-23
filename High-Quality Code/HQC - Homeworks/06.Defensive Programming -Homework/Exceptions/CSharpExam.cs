using System;

public class CSharpExam : Exam
{
    private int score;
    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get { return this.score; }
        private set
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException("Exam score can not be negative.");
            }
            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new ArgumentOutOfRangeException("Exam score must be between 0 and 100.");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
