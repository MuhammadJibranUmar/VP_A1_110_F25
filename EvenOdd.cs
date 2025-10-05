using System;

class EvenOdd
{
    private int num;

    public EvenOdd(int n)
    {
        num = n;
    }

    public bool isEven()
    {
        return (num % 2 == 0);
    }
}
