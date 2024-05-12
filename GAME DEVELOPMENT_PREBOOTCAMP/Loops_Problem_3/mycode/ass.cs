using System;
					
public class Program
{
	public static void Main()
	{
		
		for(int i=10 ; i>0;i--){
		string isIt = "odd";	
			if(i%2==0){
				isIt= "even";}
			
			Console.WriteLine("Counting Down: "+i+" and the number is "+isIt);	
		}
		
	}
}
