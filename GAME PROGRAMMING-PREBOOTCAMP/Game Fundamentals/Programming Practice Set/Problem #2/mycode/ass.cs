using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static string GetRandomString()
    {
        string path = Path.GetRandomFileName();
        path = path.Replace(".", ""); // Remove period.
        return path;
    }

    public static void Main()
    {
        List<Dictionary<string, string>> My_list = new List<Dictionary<string, string>>();
        Random rnd = new Random();

        Console.WriteLine("Preparing new records to be stored in our Dictionary!");

        for (int i = 0; i < 2; i++)
        {
            Dictionary<string, string> My_dict1 = new Dictionary<string, string>();

            int num = rnd.Next(0, 1000); // Generate a random number between 0 (inclusive) and 999 (exclusive)
            Console.WriteLine("The randomly generated number for that record is: " + num);
            Console.WriteLine("Successfully stored the record with ID: " + num);
            Console.WriteLine("Printing all dictionary items:");

            My_dict1.Add("Username", "Mohammed");
            My_dict1.Add("ID", num.ToString()); // Convert num to a string
            string exampleString = GetRandomString();
            My_dict1.Add("Password", exampleString);
            My_dict1.Add("Category", (num % 2 == 0) ? "even" : "odd");

            My_list.Add(My_dict1);
        }

		for (int i = 0; i < 2; i++)
			foreach (var kvp in My_list[i]) // Assuming you want to print the first dictionary
			{
				Console.WriteLine(kvp.Key + ": " + kvp.Value);
			}
    }
}
