using System;

public class Program
{
	public static void Main()
	{
		int age = 25;
		string name = "Esoo";
		double price = 19.99;
		bool isMember = true;
		double ageAsDouble = double.Parse(age);
		int priceAsInt = int.Parse(price);

		Console.WriteLine("age: " + age, "name: " + name, "price: " + price, "isMember: " + isMember);
		Console.WriteLine("ageAsDouble: " + ageAsDouble, "priceAsInt: " + priceAsInt);

	}
}