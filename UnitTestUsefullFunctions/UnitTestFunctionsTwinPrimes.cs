using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsPrimes = UsefulMethods.FunctionsPrimes;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsTwinPrimes
  {
    [TestMethod]
    public void TestMethod_IsTwinPrime_2()
    {
      const int source = 2;
      bool expected = true;
      bool result = FunctionsPrimes.IsTwinPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTwinPrime_3()
    {
      const int source = 3;
      bool expected = true;
      bool result = FunctionsPrimes.IsTwinPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTwinPrime_5()
    {
      const int source = 5;
      bool expected = true;
      bool result = FunctionsPrimes.IsTwinPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTwinPrime_7()
    {
      const int source = 7;
      bool expected = false;
      bool result = FunctionsPrimes.IsTwinPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTwinPrime_11()
    {
      const int source = 11;
      bool expected = true;
      bool result = FunctionsPrimes.IsTwinPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_2()
    {
      const int source = 2;
      List<int> expected = new List<int>() { 2 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_3()
    {
      const int source = 3;
      List<int> expected = new List<int>() { 2 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_5()
    {
      const int source = 5;
      List<int> expected = new List<int>() { 2, 5 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_11()
    {
      const int source = 11;
      List<int> expected = new List<int>() { 2, 5, 11 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_13()
    {
      const int source = 13;
      List<int> expected = new List<int>() { 2, 5, 11 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_19()
    {
      const int source = 19;
      List<int> expected = new List<int>() { 2, 5,  11, 17 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_31()
    {
      const int source = 31;
      List<int> expected = new List<int>() { 2, 5, 11, 17, 29 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeBefore_43()
    {
      const int source = 43;
      List<int> expected = new List<int>() { 2, 5, 11, 17, 29, 41 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    /*
     Suite des couples de nombres premiers jumeaux1 jusqu'à 1 000 :
(3, 5) 	(5, 7) 	(11, 13) 	(17, 19) 	(29, 31)
(41, 43) 	(59, 61) 	(71, 73) 	(101, 103) 	(107, 109)
(137, 139) 	(149, 151) 	(179, 181) 	(191, 193) 	(197, 199)
(227, 229) 	(239, 241) 	(269, 271) 	(281, 283) 	(311, 313)
(347, 349) 	(419 , 421) 	(431 , 433) 	(461 , 463) 	(521 , 523)
(569 , 571) 	(599 , 601) 	(617 , 619) 	(641 , 643) 	(659 , 661)
(809 , 811) 	(821 , 823) 	(827 , 829) 	(857 , 859) 	(881 , 883) 
     * */

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_2()
    {
      const int source = 2;
      List<int> expected = new List<int>() { 2 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_3()
    {
      const int source = 3;
      List<int> expected = new List<int>() { 2 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_5()
    {
      const int source = 5;
      List<int> expected = new List<int>() { 2, 5 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_11()
    {
      const int source = 11;
      List<int> expected = new List<int>() { 2, 5, 11 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_13()
    {
      const int source = 13;
      List<int> expected = new List<int>() { 2, 5, 11 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_19()
    {
      const int source = 19;
      List<int> expected = new List<int>() { 2, 5, 11, 17 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_31()
    {
      const int source = 31;
      List<int> expected = new List<int>() { 2, 5, 11, 17, 29 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_GetTwinPrimeWith6NBefore_43()
    {
      const int source = 43;
      List<int> expected = new List<int>() { 2, 5, 11, 17, 29, 41 };
      List<int> result = FunctionsPrimes.GetTwinPrimeWith6NBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    public static bool AssertListAreEqualed(List<int> source, List<int> target)
    {
      bool result = true;
      if (source.Count != target.Count)
      {
        return false;
      }

      for (int i = 0; i < source.Count; i++)
      {
        if (source[i] != target[i])
        {
          result = false;
          break;
        }
      }

      return result;
    }
  }
}
