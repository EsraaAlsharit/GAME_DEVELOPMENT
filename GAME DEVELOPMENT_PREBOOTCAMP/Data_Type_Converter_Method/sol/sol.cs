using System;
					
public class Program
{
	
	public static int ConvertMyDataType (double number)
	{
		int castedNumber = Convert.ToInt32(number);
		return castedNumber;
	}
	public static void Main()
	{
		double originalNumber = 10.49;
		Console.WriteLine("Original Number: " + originalNumber); 
		int castedNumber = ConvertMyDataType(originalNumber); // calling the converter method
		Console.WriteLine("Casted Number: " + castedNumber);
	}
}