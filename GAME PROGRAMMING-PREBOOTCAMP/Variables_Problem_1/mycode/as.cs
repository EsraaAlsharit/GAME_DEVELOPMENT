using System;
					
public class Program
{
	public static void Main()
	{
		int firstnum = 5;
		int secondnum = 10;

		Console.WriteLine("Welcome to Variable Swapping Problem!");
		Console.WriteLine("firstNumber is the first variable in our program and currently holding the value of: "+firstnum);
		Console.WriteLine("secondNumber is the second variable in our program and currently holding the value of: "+secondnum);
		Console.WriteLine("Starting the Swapping Process...");
		
		int tmp= firstnum;
		firstnum= secondnum;
		secondnum= tmp;
		
		Console.WriteLine("firstNumber is the first variable in our program and now holding the value of: "+firstnum);
		Console.WriteLine("secondNumber is the second variable in our program and now holding the value of: "+secondnum);
		
	}
}