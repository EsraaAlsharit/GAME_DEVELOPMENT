using System;
using System.Collections.Generic;

public class GameObject
{

	private int id;
	private bool isActive;
	private string name;
	private List<string> components = new List<string>();

	public void CreateComponent(string Name)
	{
		this.components.Add(Name);
	}

	public void PrintAllComponents()
	{
		Console.WriteLine("the components list:");
		foreach (string k in this.components)
		{
			Console.WriteLine(k);
		}
		Console.WriteLine("");

	}
	public bool GetComponent(string Name)
	{
		return this.components.Contains(Name);
	}

	public void SetName(string Name)
	{
		this.name = Name;
	}
	public void SetIsActive(bool active)
	{
		this.isActive = active;
	}

	public string GetName()
	{
		return this.name;
	}
}

public class Transform
{

	private int positionX = 0;

	private int positionY = 0;

	public int GetXPosition()
	{
		return this.positionX;
	}

	public int GetYPosition()
	{
		return this.positionY;
	}

	public string GetName()
	{

		return "I am a Transform";
	}

	public void Translate()
	{
		this.positionY++;
		this.positionX++;
	}

	public static void Main()
	{

		GameObject game = new GameObject();
		game.SetName("Esoo");
		game.SetIsActive(true);
		game.CreateComponent("Esoo");
		game.CreateComponent("Esraa");
		game.CreateComponent("Ezraa");
		Console.WriteLine(game.GetComponent("Esoo_chan"));
		Console.WriteLine(game.GetComponent("Esoo"));
		Console.WriteLine(game.GetName());
		game.PrintAllComponents();

		Transform transform = new Transform();
		Console.WriteLine(transform.GetYPosition());
		Console.WriteLine(transform.GetXPosition());
		transform.Translate();
		Console.WriteLine(transform.GetYPosition());
		Console.WriteLine(transform.GetXPosition());
	}
}
