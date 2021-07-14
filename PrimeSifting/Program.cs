using System;
using System.Collections.Generic;

namespace PrimeSifting
{
  public class Program
  {
    public static List<int> Solve (int num)
    {
      List<int> primeNumberList = new List<int>();

      for (int i = 0; i < num; i++)
      {
        if (IsPrime(i)) primeNumberList.Add(i);
      }

      return primeNumberList;
    }

    public static bool IsPrime (int num)
    {
      if (num == 2) return true;
      if (num % 2 == 0) return false;

      for (int i = 3; i <= Math.Sqrt(num); i += 2) 
      {
        if (num % i == 0) return false;
      }

      return !(num < 2);
    }
  }
}