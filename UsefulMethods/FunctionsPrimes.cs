using System;
using System.Collections.Generic;

namespace UsefulMethods
{
  public static class FunctionsPrimes
  {
    public static int NumberOfPrimeUnder(int number)
    {
      int result = 0;
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          result++;
        }
      }

      return result;
    }

    public static List<int> GetPrimesBefore(int number)
    {
      List<int> result = new List<int>();
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          result.Add(i);
        }
      }

      return result;
    }

    public static Dictionary<int, int> NumberOfPrimesByNthHundred(int number, int nth = 100)
    {
      Dictionary<int, int> result = new Dictionary<int, int>();
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          int index = (Math.Abs(i / nth) + 1) * nth;
          if (result.ContainsKey(index))
          {
            result[index]++;
          }
          else
          {
            result.Add(index, 1);
          }
        }
      }

      return result;
    }

    public static Dictionary<int, int> NumberOfPrimesByHundred(int number)
    {
      Dictionary<int, int> result = new Dictionary<int, int>();
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          int index = (Math.Abs(i / 100) + 1) * 100;
          if (result.ContainsKey(index))
          {
            result[index]++;
          }
          else
          {
            result.Add(index, 1);
          }
        }
      }

      return result;
    }

    public static Dictionary<int, int> GetAbsoluteValues()
    {
      Dictionary<int, int> result = new Dictionary<int, int>();
      for (int i = 0; i < 300; i++)
      {
        int index = (Math.Abs(i / 100) + 1) * 100;
        if (result.ContainsKey(index))
        {
          result[index]++;
        }
        else
        {
          result.Add(index, 1);
        }
      }

      return result;
    }

    public static bool IsTwinPrime(int number)
    {
      if (number < 2)
      {
        return false;
      }

      if (number == 2)
      {
        return true;
      }

      return FunctionsMath.IsPrime(number) && FunctionsMath.IsPrime(number + 2);
    }

    public static List<int> GetTwinPrimeBefore(int number)
    {
      List<int> result = new List<int>();
      if (number < 2)
      {
        return result;
      }

      result.Add(2);

      if (number <= 3)
      {
        return result;
      }

      result.Add(5);

      if (number < 7)
      {
        return result;
      }

      for (int i = 7; i <= number; i++)
      {
        if (IsTwinPrime(i))
        {
          result.Add(i);
        }
      }

      return result;
    }

    public static List<int> GetTwinPrimeWith6NBefore(int number)
    {
      List<int> result = new List<int>();
      if (number < 2)
      {
        return result;
      }

      result.Add(2);

      if (number <= 3)
      {
        return result;
      }

      /*
       Tout couple de nombres premiers jumeaux, à l'exception du couple (3, 5), est de la forme (6n – 1, 6n + 1) pour un certain entier n. En effet, tout triplet d'entiers consécutifs comporte au moins un multiple de 2 (éventuellement deux) et un seul multiple de 3 ; l'entier qui se trouve entre les deux nombres premiers jumeaux est à la fois ce multiple de 2 et ce multiple de 3, car cela ne peut pas être l'un des nombres premiers.
       * */

      int n = 1;

      while (6 * n - 1 <= number)
      {
        if (IsTwinPrime(6 * n - 1))
        {
          result.Add(6 * n - 1);
        }

        n++;
      }

      return result;
    }

    public static List<int> GetTwinPrimeWithMPlus2Before(int number)
    {
      List<int> result = new List<int>();
      if (number < 2)
      {
        return result;
      }

      result.Add(2);

      if (number <= 3)
      {
        return result;
      }

      /*
       Pour tout entier m ≥ 2, le couple (m, m + 2) est constitué de nombres premiers jumeaux si et seulement si 4[(m - 1)! + 1] + m est divisible par m(m + 2). Cette caractérisation des nombres premiers jumeaux, remarquée par P. A. Clement en 1949, résulte du théorème de Wilson.
       * */

      int m = 1;

      while (6 * m - 1 <= number)
      {
        if (IsTwinPrime(6 * m - 1))
        {
          result.Add(6 * m - 1);
        }

        m++;
      }

      return result;
    }
  }
}
