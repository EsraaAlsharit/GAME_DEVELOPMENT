using System;
					
public class Program
{
	public static void Main()
	{
		int firstNumber = 5;
		int secondNumber = 10;
		
		Console.WriteLine("Welcome to Variable Swapping Problem!");
		Console.WriteLine("firstNumber is the first variable in our program and currently holding the value of: " + firstNumber);
		Console.WriteLine("secondNumber is the second variable in our program and currently holding the value of: " + secondNumber);
		
		Console.WriteLine("Starting the Swapping Process...");
		int temp = firstNumber;
		firstNumber = secondNumber;
		secondNumber = temp;
		
		Console.WriteLine("firstNumber is the first variable in our program and now holding the value of: " + firstNumber);
		Console.WriteLine("secondNumber is the second variable in our program and now holding the value of: " + secondNumber);

	}
}