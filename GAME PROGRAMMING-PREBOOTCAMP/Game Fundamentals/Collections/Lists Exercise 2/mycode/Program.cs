using System;

public class Program
{
    public static void Main()
    {
        List<int> num = new List<int>();
        int res = 0;
        Console.Write("Enter a list of integers: ");

        for (int i = 0; i < 9; i++)
        {
            num.Add(int.Parse(Console.ReadLine()));
        }
        foreach (int item in num)
        {
            if(item%2==0)
            res +=item;
        }
        Console.WriteLine("The sum of all the even numbers in the list is " + res);

    }
}