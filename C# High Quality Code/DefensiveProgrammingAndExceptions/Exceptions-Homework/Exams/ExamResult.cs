using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade cannot be a negative number!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minimal grade cannot be a negative number!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("The maximal grade must be greater than minimal grade!");
        }

        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException("Comments cannot be empty string!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
