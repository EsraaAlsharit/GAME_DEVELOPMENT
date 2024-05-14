using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> num = new List<int> { 9, 8, 7, 6, 5, 4, 3 };
        foreach (int k in num)
        {
            Console.WriteLine("the number is : " + k + " " + (k * 5));
        }
    }
}