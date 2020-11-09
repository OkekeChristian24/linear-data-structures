using System;
using System.Collections.Generic;

public class Sequence
{
  static void Main()
  {
    Console.Write("Enter the starting number of the sequence: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Enter the ending number of the sequence: ");
    int p = int.Parse(Console.ReadLine());

    Queue<int> queue = new Queue<int>();
    queue.Enqueue(n);
    int index = 0;
    Console.Write("Seq = ");
    while(queue.Count > 0)
    {
      index++;
      int current = queue.Dequeue();
      Console.Write(" " + current);
      if(current == p)
      {
        Console.WriteLine();
        Console.WriteLine("Index = " + index);
        return;
      }
      queue.Enqueue(current + 1);
      queue.Enqueue(2 * current);
    }
  }
}
