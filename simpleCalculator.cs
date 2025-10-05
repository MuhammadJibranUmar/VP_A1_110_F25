class simpleCalculator
{
    private double num1;
    private double num2;

    public simpleCalculator(double a, double b)
    {
        num1 = a;
        num2 = b;
    }

    public double add()
    {
        return num1 + num2;
    }

    public double subtract()
    {
        return num1 - num2;
    }

    public double multiply()
    {
        return num1 * num2;
    }

    public double divide()
    {
        return num1 / num2;
    }
}
