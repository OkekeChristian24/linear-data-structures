using System;
using System.Collections.Generic;

public class PrimeNumbers
{
  static List<int> GetPrimes(int start, int stop)
  {
    List<int> primesList = new List<int>();

    for(int num = start; num <= stop; num++)
    {
      bool prime = true;
      double numSqrt = Math.Sqrt(num);
      for(int div = 2; div <= numSqrt; div++)
      {
        if(num % div == 0)
        {
          prime = false;
          break;
        }
      }
      if(prime)
      {
        primesList.Add(num);
      }
    }

    return primesList;

  }

  static void Main()
  {
    Console.WriteLine("\n#### Welcome ####");
    int start;
    int stop;
    while(true)
    {
      Console.Write("\nEnter the START number: ");
      start = int.Parse(Console.ReadLine());

      Console.Write("\nEnter the STOP number: ");
      stop = int.Parse(Console.ReadLine());
      if(start < stop)
      {
        break;
      }
      else
      {
        Console.Write("\nThe stop number MUST be greater than the start number. Please try again...\n ");
      }
    }
    List<int> primes = GetPrimes(start, stop);

    if(primes.Count > 0)
    {
      Console.WriteLine("\nThe prime numbers between {0} and {1} are:", start, stop);

      foreach(var item in primes)
      {
        Console.Write("{0} ", item);
      }
    }
    else
    {
      Console.WriteLine("\nThere are no prime numbers between {0} and {1}.", start, stop);
    }

  }

}
