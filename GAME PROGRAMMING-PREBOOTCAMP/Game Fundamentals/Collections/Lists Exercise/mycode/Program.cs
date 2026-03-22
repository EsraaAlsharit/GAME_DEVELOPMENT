using System;

public class Program
{
    public static void Main()
    {
        List<int> num = new List<int>([1, 2, 3, 4, 5]);

        foreach (int res in num)
        {
            Console.WriteLine("the number is " + res + " the result is " + (res * 5));
        }

    }
}