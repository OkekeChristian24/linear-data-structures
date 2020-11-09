using System;

public class CustomArrayListTest
{
	
	static void PrintArray(CustomArrayList<string> arr)
	{
		for(int i=0; i<arr.Count; i++)
			Console.WriteLine(arr[i]);
	}
	
	static void Main()
	{
		CustomArrayList<string> shoppingList = new CustomArrayList<string>();
		
		while(true)
		{
			Console.Write("Enter your item: ");
			string answer = Console.ReadLine();
			
			if(answer.ToLower() == "n")
				break;
			shoppingList.Add(answer);
		}
		
		Console.WriteLine("\nYour items are: ");
		PrintArray(shoppingList);
		
		shoppingList.Remove("Milk");
		Console.WriteLine("\nAfter removing Milk from the list: ");
		PrintArray(shoppingList);
		
		shoppingList.Insert(1, "Fruits");
		Console.WriteLine("\nAfter inserting Fruits at indexd 1: ");
		PrintArray(shoppingList);
		
		Console.WriteLine("\nIndex of Akara: {0}", shoppingList.IndexOf("Akara"));
		Console.WriteLine("\nItem at index 2: {0}", shoppingList[2]);
		Console.WriteLine("\nDoes the list contain Chicken? : {0}", shoppingList.Contains("Chicken"));
	}
}