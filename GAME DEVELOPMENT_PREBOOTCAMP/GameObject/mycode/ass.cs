using System;
	
public class GameObject
{
	
	int id;
	bool isActive;
	string name;
	//components - type List Hint: List components= new List;

	void SetName (string Name){
		this.name= Name;	
	}
	void SetIsActive (bool active){
		this.isActive= active;	
	}
	
	string GetName (){
		return this.name;	
	}
}

public class Transform 
{
	
 int positionX=0;

int positionY=0;
	
	int GetXPosition (){
		return this.positionX;	
	}
		
	int GetYPosition (){
		return this.positionY;	
	}
	
	//string GetName (){
		//Console.WriteLine("I am a Transform");
		//return this.positionY;
		//return "I am a Transform"
	//}
	
	void Translate(){
		this.positionY++;
		this.positionX++;
	}
	
	public static void Main()
	{

		
		Console.WriteLine("");
	}
}
