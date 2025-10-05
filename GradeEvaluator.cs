class GradeEvaluator
{
    private int marks;

    public GradeEvaluator(int m)
    {
        marks = m;
    }

    public char evaluate()
    {
        if (marks >= 85)
        {
            return 'A';
        }
        else if (marks >= 70)
        {
            return 'B';
        }
        else if (marks >= 55)
        {
            return 'C';
        }
        else if (marks >= 40)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
}
