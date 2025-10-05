class ReverseNumber
{
    public ReverseNumber()
    {
        //
    }

    public int reverse(int number)
    {
        int digit = 0;
        int reversedNumber = 0;

        while (number != 0)
        {
            reversedNumber *= 10;
            digit = number % 10;
            number /= 10;
            reversedNumber += digit;
        }

        return reversedNumber;
    }
}