using System;

class Program
{
    static void Main()
    {
        Program obj = new Program();
        obj.Question1();
    }

    void Question1()
    {
        Console.WriteLine("Enter a number to check whether it is Even or Odd: ");
        int number = Convert.ToInt32(Console.ReadLine());
        EvenOdd obj1 = new EvenOdd(number);
        if (obj1.isEven())
        {
            Console.WriteLine(number + " is Even.");
        }
        else
        {
            Console.WriteLine(number + " is Odd.");
        }
    }
}
