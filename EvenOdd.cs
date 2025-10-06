using System;

class EvenOdd
{
    private int num;

    public EvenOdd(int n)
    {
        num = n;
    }

    public EvenOdd()
    {
        //
    }

    public bool isEven()
    {
        return (num % 2 == 0);
    }

    public bool isEven(int n)
    {
        return (n % 2 == 0);
    }
}
