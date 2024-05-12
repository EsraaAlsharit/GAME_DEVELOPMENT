using System;
					
public class Program
{
	public static void Main()
	{
		int[] array = {1, 9, 6, 7, 5, 9};
		  Console.Write("Input : array = { ");
		foreach (int variableName in array) {
					  Console.Write(variableName+", ");
		}
Console.WriteLine("};");
		Array.Sort(array);
		Array.Reverse(array);
		Console.Write("Output: ");
		foreach (int variableName in array) 
{
  Console.Write(variableName+" ");
}
		
	}
}
