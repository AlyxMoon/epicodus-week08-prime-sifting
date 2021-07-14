using System;
using System.Collections.Generic;

namespace PrimeSifting
{
  public class Program
  {
    public static List<int> Solve (int num)
    {
      // Given a number, write a method that returns all of the prime numbers less than that number.

      // get a number, x
      // that number is our upper bound
      // check each number up to it, whether it's prime (or not)
        // 
      // if number is prime, add to list
      // return that list

      return new List<int> {};
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