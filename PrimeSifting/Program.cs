using System;
using System.Collections.Generic;

namespace PrimeSifting
{
  public class Program
  {
    public static List<int> Solve (int num)
    {
      List<int> primes = new List<int>();

      if (num < 2) return primes;

      bool[] sieve = new bool[num];
      for (int i = 0; i < sieve.Length; i++) {
        sieve[i] = true;
      }

      sieve[0] = false;
      sieve[1] = false;
      
      for (int i = 2; i < sieve.Length; i++) {
        if (sieve[i]) {
          primes.Add(i);

          for (int j = i + i; j < sieve.Length; j += i) {
            sieve[j] = false;
          }
        }
      }

      return primes;
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