using System;
using System.Collections.Generic;
using UsefulMethods;

namespace ConsoleAppTestFastIsPrime
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;

      List<int> source = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31};
      /*
       , 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281 
       * */

      Dictionary<int, bool> dicoResult = new Dictionary<int, bool>();
      foreach (int number in source)
      {
        dicoResult.Add(number, FunctionsMath.FastIsPrime(number));
      }

      foreach (var keyValuePair in dicoResult)
      {
        //display($"{keyValuePair.Key} - {keyValuePair.Value}");
      }

      foreach (int number in source)
      {
        if (number == 4) display("4 is false");
        var tmpDecalage = number >> 1;
        var tmpFactorial = FunctionsMath.Factorial(number >> 1);
        var tmpFactorialModulo = FunctionsMath.Factorial(number >> 1) % number;
        display($"number {number}");
        display($"decalage {tmpDecalage}");
        display($"factorial {tmpFactorial}");
        display($"modulo {tmpFactorialModulo}");
        display($"Is Prime {FunctionsMath.FastIsPrime(tmpFactorialModulo)}");
        display(string.Empty);
        Console.ReadKey();
      }
           
      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}