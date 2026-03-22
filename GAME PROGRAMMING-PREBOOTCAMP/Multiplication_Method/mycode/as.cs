using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome to my Multiplication Program");
		Console.WriteLine(Multiply(1.2,1.5,3.4,7.2));
	}
	public int Multiply(double num1,double num2, double num3, double num4){
		
		return (int) (num1*num2 *num3*num4);
	}
}