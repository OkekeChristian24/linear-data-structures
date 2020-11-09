using System;

class DynamicListTest
{

	static void PrintArray(DynamicList<string> arr)
	{
		for(int i=0; i<arr.Count; i++)
			Console.WriteLine(arr[i]);
	}

	static void Main()
	{
		DynamicList<string> shoppingList = new DynamicList<string>();

		while(true)
		{
			Console.Write("Enter your item ('n' to quit): ");
			string answer = Console.ReadLine();

			if(answer.ToLower() == "n")
				break;
			shoppingList.Add(answer);
		}

		Console.WriteLine("This is your list: ");
		PrintArray(shoppingList);

		shoppingList.Remove("Milk");
		Console.WriteLine("\nAfter removing Milk from the list: ");
		PrintArray(shoppingList);

		shoppingList.RemoveAt(1);
		Console.WriteLine("\nAfter removing the item at indexd 1: ");
		PrintArray(shoppingList);

		shoppingList.Insert(2, "Perfume");
		Console.WriteLine("\nAfter inserting Perfume at index 2: ");
		PrintArray(shoppingList);
		
		Console.WriteLine("\nIndex of Akara: {0}", shoppingList.IndexOf("Akara"));
		Console.WriteLine("\nItem at index 2: {0}", shoppingList[2]);
		Console.WriteLine("\nDoes the list contain Chicken? : {0}", shoppingList.Contains("Chicken"));
		Console.WriteLine("\nHow many items do we have in the list?: {0}", shoppingList.Count);

	}

}
