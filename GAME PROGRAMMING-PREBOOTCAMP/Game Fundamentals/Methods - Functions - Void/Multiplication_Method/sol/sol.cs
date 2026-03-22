using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Starting my Multiplication Program");
		int result = Multiply(1.2, 1.5, 3.4, 7.2);
		Console.WriteLine("The multiplication output is: " + result);
	}
	
	public int Multiply(double param1, double param2, double param3, double param4)
	{
		int convertedParam1 = Convert.ToInt32(param1); // Convert the varialbe type from double to int
		int convertedParam2 = Convert.ToInt32(param2); // Convert the varialbe type from double to int
		int convertedParam3 = Convert.ToInt32(param3); // Convert the varialbe type from double to int
		int convertedParam4 = Convert.ToInt32(param4); // Convert the varialbe type from double to int

		int result = convertedParam1 * convertedParam2 * convertedParam3 *  convertedParam4; // Multiply all together
		
		return result; // Return the result
	}
}