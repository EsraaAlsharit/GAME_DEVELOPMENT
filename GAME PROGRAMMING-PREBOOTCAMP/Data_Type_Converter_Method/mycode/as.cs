using System;
                    
public class Program
{
    public void Main()
    {
        // Calling the method we just created 
        int summation = ConvertMyDataType(7.45);
        Console.WriteLine(summation); // printing the result of our summation output is 5
    }
    
    public int ConvertMyDataType(double  myNumber)
    {	
        return  Convert.ToInt32(myNumber);
    }
}