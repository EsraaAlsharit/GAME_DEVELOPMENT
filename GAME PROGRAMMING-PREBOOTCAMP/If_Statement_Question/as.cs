// the x is 7 the first if condition checking if x equal to 5 
// which the condition is false
//  so go to next else if x grater than 5 and less than 10
// here the condition is true so it enter the condition to say
// "I am inside if x is greater than 5 and less than 10 condition, X: value is 7"
// "We just decreased x value by 1 using the -- operator, new x value is: 6"

using System;

public class Program
{
    public static void Main()
    {
        int x = 0;

        if (x == 5) // Check if x is equal to 5
        {
            Console.WriteLine("I am inside if x equal to 5 condition");
            x++; // Increase x value by 1
            Console.WriteLine("We just increased x value by 1 using the ++ operator, new x value is: " + x);
        }

        else if (x > 5 && x < 10) // Check if x is greater than 5 and less than 10
        {
            Console.WriteLine("I am inside if x is greater than 5 and less than 10 condition, X: value is " + x);
            x--; // Decrease x value by 1
            Console.WriteLine("We just decreased x value by 1 using the -- operator, new x value is: " + x);
        }

        else if (x != 5)
        {
            Console.WriteLine("I am inside if x not equal to 5 condition, X: value is " + x);
            if (x >= 100) // Check if x is greater than or equal to 100
            {
                Console.WriteLine("I am inside nested if which checks if x is greater than or equal to 100, X: value is " + x);
            }

            else if (x <= 100) // Check if x is less than or equal to 100
            {
                Console.WriteLine("I am inside nested if which checks if x is less than or equal to 100, X: value is " + x);
            }
            else // Anything else
            {
                Console.WriteLine("I am inside an else condition where x is not equal to 5, yet neither greater than or equal nor less than or equal to a , X: value is " + x);
            }
        }

        // Will this else if ever be reached?
        else if (x != 5 && x > 1)
        {
            Console.WriteLine("I am inside if x not equal to 5 AND x is greater 1 condition, X: value is " + x);
        }
    }
}