using System;


class program
{
    static int S(int n)
    {
        if (n == 1)
            return 1; // Change from 0 to 1
        return n * S(n - 1);
    }

    static void Main()
    {
        Console.WriteLine(S(5));
        Console.ReadLine();
    }
}