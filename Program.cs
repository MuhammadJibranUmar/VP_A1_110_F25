using System;

class Program
{
    static void Main()
    {
        Program obj = new Program();
        char option;

        Console.WriteLine("------------------------");
        Console.WriteLine("Visual Programming  ----   Assignment 1");
        Console.WriteLine("Submitted To: Sir Noman Mazhar");
        Console.WriteLine("Submitted By: Muhammad Jibran Umar");
        Console.WriteLine("Roll No.23011556-110");
        Console.WriteLine("------------------------");

        do
        {
            Console.WriteLine("\nChoose From Following: ");
            Console.WriteLine("[0]. Check Even Or Odd ");
            Console.WriteLine("[1]. Simple Calculator ");
            Console.WriteLine("[q]. Exit ");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            option = keyInfo.KeyChar;

            switch (option)
            {
                case '0':
                    Console.WriteLine("\nQuestion No. 1: \n");
                    obj.Question1();
                    break;
                case '1':
                    Console.WriteLine("\nQuestion No. 2: \n");
                    obj.Question2();
                    break;
                case 'q':
                    break;
                default:
                    Console.WriteLine("\nTryAgain...");
                    break;
            }
        } while (option != 'q');

        Console.WriteLine("\nExiting....");
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

    void Question2()
    {
        string num;
        do
        {
            Console.WriteLine("Enter 00 as First Number to exit.");
            Console.WriteLine("Enter the First Number: ");
            num = Console.ReadLine();

            if (num == "00")
            {
                continue;
            }

            double number1 = double.Parse(num);
            Console.WriteLine("Enter the Operator:");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("\nEnter the second Number: ");
            double number2 = double.Parse(Console.ReadLine());

            simpleCalculator calculator = new simpleCalculator(number1, number2);

            switch (keyInfo.KeyChar)
            {
                case '+':
                    Console.WriteLine(number1 + " + " + number2 + " = " + calculator.add());
                    break;
                case '-':
                    Console.WriteLine(number1 + " - " + number2 + " = " + calculator.subtract());
                    break;
                case '*':
                    Console.WriteLine(number1 + " * " + number2 + " = " + calculator.multiply());
                    break;
                case '/':
                    Console.WriteLine(number1 + " / " + number2 + " = " + calculator.divide());
                    break;

                default:
                    Console.WriteLine("Try Again...");
                    break;
            }
        } while (num != "00");
    }
}
