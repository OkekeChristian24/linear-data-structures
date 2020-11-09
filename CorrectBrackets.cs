using System;
using System.Collections.Generic;

public class CorrectBrackets
{

  static bool CheckBrackets(string expression)
  {
    Stack<int> stack = new Stack<int>();
    bool areBracketsCorrect = true;

    for(int i = 0; i < expression.Length; i++)
    {
      char ch = expression[i];
      if(ch == '(')
      {
        stack.Push(i);
      }
      else if(ch == ')')
      {
        if(stack.Count == 0)
        {
          areBracketsCorrect = false;
          break;
        }
        stack.Pop();
      }

    }
    if(stack.Count != 0)
    {
      areBracketsCorrect = false;
    }

    return areBracketsCorrect;

  }

  public static void Main()
  {
    while(true)
    {
      Console.Write("\nEnter your expression: ");
      string expression = Console.ReadLine();

      if(CheckBrackets(expression))
      {
        Console.WriteLine("\n...The number of brackets is correct...");
      }
      else
      {
        Console.WriteLine("\n...The number of brackets is NOT correct...");
      }

      Console.Write("\nDo you want to try again? (Enter 'y' for yes): ");
      string response = Console.ReadLine();
      if(response.ToLower() != "y")
        break;

    }

  }

}
