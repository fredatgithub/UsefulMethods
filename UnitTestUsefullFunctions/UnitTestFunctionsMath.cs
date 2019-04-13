using System.Collections.Generic;
using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulMethods;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestFunctionsMath
  {
    #region Math Methods
    #region Math Methods - Factorial
    [TestMethod]
    public void TestMethod_Factorial_one()
    {
      this.TestFactorial(1, 1);
    }

    public void TestFactorial(long numberToBeTested, long resultExpected)
    {
      long testedNumber = numberToBeTested;
      long expected = resultExpected;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_two()
    {
      TestFactorial(2, 2);
    }

    [TestMethod]
    public void TestMethod_Factorial_three()
    {
      TestFactorial(3, 6);
    }

    [TestMethod]
    public void TestMethod_Factorial_four()
    {
      TestFactorial(4, 24);
    }

    [TestMethod]
    public void TestMethod_Factorial_five()
    {
      const long testedNumber = 5;
      const long expected = 120;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_six()
    {
      const long testedNumber = 6;
      const long expected = 720;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_seven()
    {
      const long testedNumber = 7;
      const long expected = 5040;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eight()
    {
      const long testedNumber = 8;
      const long expected = 40320;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_nine()
    {
      const long testedNumber = 9;
      const long expected = 362880;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_ten()
    {
      const long testedNumber = 10;
      const long expected = 3628800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eleven()
    {
      const long testedNumber = 11;
      const long expected = 39916800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twelve()
    {
      const long testedNumber = 12;
      const long expected = 479001600;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_thirteen()
    {
      const long testedNumber = 13;
      const long expected = 6227020800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_fourteen()
    {
      const long testedNumber = 14;
      const long expected = 87178291200;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_fifteen()
    {
      const long testedNumber = 15;
      const long expected = 1307674368000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_sixteen()
    {
      const long testedNumber = 16;
      const long expected = 20922789888000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_seventeen()
    {
      const long testedNumber = 17;
      const long expected = 355687428096000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eighteen()
    {
      const long testedNumber = 18;
      const long expected = 6402373705728000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_nineteen()
    {
      const long testedNumber = 19;
      const long expected = 121645100408832000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twenty()
    {
      const long testedNumber = 20;
      const long expected = 2432902008176640000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twentyOne()
    {
      long result = FunctionsMath.Factorial(21);
      Assert.IsTrue(result < 0); // negative number
    }

    [TestMethod]
    public void TestMethod_Factorial_Negative_number()
    {
      const long testedNumber = -3;
      const long expected = 0;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_zero()
    {
      const long testedNumber = 0;
      const long expected = 0;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_one_step()
    {
      const long testedNumber1 = 10;
      const long testedNumber2 = 9;
      const long expected = 10;
      long result = FunctionsMath.Factorial(testedNumber1, testedNumber2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_two_step()
    {
      const long testedNumber1 = 10;
      const long testedNumber2 = 8;
      const long expected = 90;
      long result = FunctionsMath.Factorial(testedNumber1, testedNumber2);
      Assert.AreEqual(result, expected);
    }

    #region Math Methods - BigInt Factorial
    // *******************************BigInt Method******
    [TestMethod]
    public void TestMethod_Factorial_BigInt_one()
    {
      BigInt source = 1;
      BigInt expected = 1;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_two()
    {
      BigInt source = 2;
      BigInt expected = 2;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_three()
    {
      BigInt source = 3;
      BigInt expected = 6;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_four()
    {
      BigInt source = 4;
      BigInt expected = 24;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_five()
    {
      BigInt source = 5;
      BigInt expected = 120;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_six()
    {
      BigInt source = 6;
      BigInt expected = 720;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_seven()
    {
      BigInt source = 7;
      BigInt expected = 5040;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_eight()
    {
      BigInt source = 8;
      BigInt expected = 40320;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_nine()
    {
      BigInt source = 9;
      BigInt expected = 362880;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_ten()
    {
      BigInt source = 10;
      BigInt expected = 3628800;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_eleven()
    {
      BigInt source = 11;
      BigInt expected = 39916800;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_twelve()
    {
      BigInt source = 12;
      BigInt expected = 479001600;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_thirteen()
    {
      BigInt source = 13;
      BigInt expected = 6227020800;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_fourteen()
    {
      BigInt source = 14;
      BigInt expected = 87178291200;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_fifteen()
    {
      BigInt source = 15;
      BigInt expected = 1307674368000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_sixteen()
    {
      BigInt source = 16;
      BigInt expected = 20922789888000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_seventeen()
    {
      BigInt source = 17;
      BigInt expected = 355687428096000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_eighteen()
    {
      BigInt source = 18;
      BigInt expected = 6402373705728000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_nineteen()
    {
      BigInt source = 19;
      BigInt expected = 121645100408832000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_twenty()
    {
      BigInt source = 20;
      BigInt expected = 2432902008176640000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    #endregion Math Methods - BigInt Factorial
    #endregion Math Methods - Factorial
    #region Math Methods - Recursive Factorial
    // **********************Recursive Factorial****************
    [TestMethod]
    public void TestMethod_RecursiveFactorial_one()
    {
      ulong result = FunctionsMath.RecursiveFactorial(1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_two()
    {
      ulong result = FunctionsMath.RecursiveFactorial(2);
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_three()
    {
      ulong result = FunctionsMath.RecursiveFactorial(3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_four()
    {
      ulong result = FunctionsMath.RecursiveFactorial(4);
      Assert.IsTrue(result == 24);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_five()
    {
      ulong result = FunctionsMath.RecursiveFactorial(5);
      Assert.IsTrue(result == 120);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_six()
    {
      ulong result = FunctionsMath.RecursiveFactorial(6);
      Assert.IsTrue(result == 720);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seven()
    {
      ulong result = FunctionsMath.RecursiveFactorial(7);
      Assert.IsTrue(result == 5040);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eight()
    {
      ulong result = FunctionsMath.RecursiveFactorial(8);
      Assert.IsTrue(result == 40320);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nine()
    {
      ulong result = FunctionsMath.RecursiveFactorial(9);
      Assert.IsTrue(result == 362880);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_ten()
    {
      ulong result = FunctionsMath.RecursiveFactorial(10);
      Assert.IsTrue(result == 3628800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eleven()
    {
      ulong result = FunctionsMath.RecursiveFactorial(11);
      Assert.IsTrue(result == 39916800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twelve()
    {
      ulong result = FunctionsMath.RecursiveFactorial(12);
      Assert.IsTrue(result == 479001600);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_thirteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(13);
      Assert.IsTrue(result == 6227020800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fourteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(14);
      Assert.IsTrue(result == 87178291200);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fifteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(15);
      Assert.IsTrue(result == 1307674368000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_sixteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(16);
      Assert.IsTrue(result == 20922789888000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seventeen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(17);
      Assert.IsTrue(result == 355687428096000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eighteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(18);
      Assert.IsTrue(result == 6402373705728000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nineteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(19);
      Assert.IsTrue(result == 121645100408832000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twenty()
    {
      ulong result = FunctionsMath.RecursiveFactorial(20);
      Assert.IsTrue(result == 2432902008176640000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twentyOne()
    {
      ulong result = FunctionsMath.RecursiveFactorial(21);
      Assert.IsTrue(result == 14197454024290336768);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_Negative_number()
    {
      ulong result = FunctionsMath.RecursiveFactorial(-3);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_zero()
    {
      ulong result = FunctionsMath.RecursiveFactorial(0);
      Assert.IsTrue(result == 0);
    }
    #endregion Math Methods - Recursive Factorial
    #region Math Methods - Sommielle
    // **********************Sommielle****************
    [TestMethod]
    public void TestMethod_Sommielle_zero()
    {
      long result = FunctionsMath.Sommielle(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_one_interval()
    {
      long result = FunctionsMath.Sommielle(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_Sommielle_two_interval()
    {
      long result = FunctionsMath.Sommielle(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_Sommielle_inverted_max_min()
    {
      long result = FunctionsMath.Sommielle(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_ten()
    {
      long result = FunctionsMath.Sommielle(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_twentyFour()
    {
      long result = FunctionsMath.Sommielle(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_fifty()
    {
      long result = FunctionsMath.Sommielle(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_Sommielle_ten_ten()
    {
      long result = FunctionsMath.Sommielle(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundred()
    {
      long result = FunctionsMath.Sommielle(0, 100);
      Assert.IsTrue(result == 5050);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundredAndFifty()
    {
      long result = FunctionsMath.Sommielle(0, 150);
      Assert.IsTrue(result == 11325);
    }
    #endregion Math Methods - Sommielle
    #region Math Methods - Sommielle Recursive
    // **********************Sommielle Recursive****************
    [TestMethod]
    public void TestMethod_SommielleRecursive_zero()
    {
      long result = FunctionsMath.SommielleRecursive(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_one_interval()
    {
      long result = FunctionsMath.SommielleRecursive(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_two_interval()
    {
      long result = FunctionsMath.SommielleRecursive(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_inverted_max_min()
    {
      long result = FunctionsMath.SommielleRecursive(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_ten()
    {
      long result = FunctionsMath.SommielleRecursive(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_twentyFour()
    {
      long result = FunctionsMath.SommielleRecursive(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_fifty()
    {
      long result = FunctionsMath.SommielleRecursive(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_ten_ten()
    {
      long result = FunctionsMath.SommielleRecursive(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_hundred()
    {
      long result = FunctionsMath.SommielleRecursive(0, 100);
      Assert.IsTrue(result == 5050);
    }
    #endregion Math Methods - Sommielle Recursive
    #region GetListOfPrime
    [TestMethod]
    public void TestMethod_GetListOfPrime_4_numbers()
    {
      const int source1 = 2;
      const int source2 = 10;
      var expected = new List<int> { 2, 3, 5, 7 };
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2 - source1);
      AssertListsAreSimilar(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetListOfPrime_none()
    {
      const int source1 = 32;
      const int source2 = 5;
      var expected = new List<int>();
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetListOfPrime_until_100()
    {
      const int source1 = 2;
      const int source2 = 100;
      var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2 - source1);
      AssertListsAreSimilar(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetListOfPrime_until_7919()
    {
      const int source1 = 2;
      const int source2 = 7919;
      var expected = new List<int>
      {
        2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,
        101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193,
        197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307,
        311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421,
        431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547,
        557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659,
        661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797,
        809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929,
        937, 941, 947, 953, 967, 971, 977, 983, 991, 997, 1009, 1013, 1019, 1021, 1031, 1033, 1039,
        1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097, 1103, 1109, 1117, 1123, 1129, 1151,
        1153, 1163, 1171, 1181, 1187, 1193, 1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259,
        1277, 1279, 1283, 1289, 1291, 1297, 1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373,
        1381, 1399, 1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483,
        1487, 1489, 1493, 1499, 1511, 1523, 1531, 1543, 1549, 1553, 1559, 1567, 1571, 1579, 1583,
        1597, 1601, 1607, 1609, 1613, 1619, 1621, 1627, 1637, 1657, 1663, 1667, 1669, 1693, 1697,
        1699, 1709, 1721, 1723, 1733, 1741, 1747, 1753, 1759, 1777, 1783, 1787, 1789, 1801, 1811,
        1823, 1831, 1847, 1861, 1867, 1871, 1873, 1877, 1879, 1889, 1901, 1907, 1913, 1931, 1933,
        1949, 1951, 1973, 1979, 1987, 1993, 1997, 1999, 2003, 2011, 2017, 2027, 2029, 2039, 2053,
        2063, 2069, 2081, 2083, 2087, 2089, 2099, 2111, 2113, 2129, 2131, 2137, 2141, 2143, 2153,
        2161, 2179, 2203, 2207, 2213, 2221, 2237, 2239, 2243, 2251, 2267, 2269, 2273, 2281, 2287,
        2293, 2297, 2309, 2311, 2333, 2339, 2341, 2347, 2351, 2357, 2371, 2377, 2381, 2383, 2389,
        2393, 2399, 2411, 2417, 2423, 2437, 2441, 2447, 2459, 2467, 2473, 2477, 2503, 2521, 2531,
        2539, 2543, 2549, 2551, 2557, 2579, 2591, 2593, 2609, 2617, 2621, 2633, 2647, 2657, 2659,
        2663, 2671, 2677, 2683, 2687, 2689, 2693, 2699, 2707, 2711, 2713, 2719, 2729, 2731, 2741,
        2749, 2753, 2767, 2777, 2789, 2791, 2797, 2801, 2803, 2819, 2833, 2837, 2843, 2851, 2857,
        2861, 2879, 2887, 2897, 2903, 2909, 2917, 2927, 2939, 2953, 2957, 2963, 2969, 2971, 2999,
        3001, 3011, 3019, 3023, 3037, 3041, 3049, 3061, 3067, 3079, 3083, 3089, 3109, 3119, 3121,
        3137, 3163, 3167, 3169, 3181, 3187, 3191, 3203, 3209, 3217, 3221, 3229, 3251, 3253, 3257,
        3259, 3271, 3299, 3301, 3307, 3313, 3319, 3323, 3329, 3331, 3343, 3347, 3359, 3361, 3371,
        3373, 3389, 3391, 3407, 3413, 3433, 3449, 3457, 3461, 3463, 3467, 3469, 3491, 3499, 3511,
        3517, 3527, 3529, 3533, 3539, 3541, 3547, 3557, 3559, 3571, 3581, 3583, 3593, 3607, 3613,
        3617, 3623, 3631, 3637, 3643, 3659, 3671, 3673, 3677, 3691, 3697, 3701, 3709, 3719, 3727,
        3733, 3739, 3761, 3767, 3769, 3779, 3793, 3797, 3803, 3821, 3823, 3833, 3847, 3851, 3853,
        3863, 3877, 3881, 3889, 3907, 3911, 3917, 3919, 3923, 3929, 3931, 3943, 3947, 3967, 3989,
        4001, 4003, 4007, 4013, 4019, 4021, 4027, 4049, 4051, 4057, 4073, 4079, 4091, 4093, 4099,
        4111, 4127, 4129, 4133, 4139, 4153, 4157, 4159, 4177, 4201, 4211, 4217, 4219, 4229, 4231,
        4241, 4243, 4253, 4259, 4261, 4271, 4273, 4283, 4289, 4297, 4327, 4337, 4339, 4349, 4357,
        4363, 4373, 4391, 4397, 4409, 4421, 4423, 4441, 4447, 4451, 4457, 4463, 4481, 4483, 4493,
        4507, 4513, 4517, 4519, 4523, 4547, 4549, 4561, 4567, 4583, 4591, 4597, 4603, 4621, 4637,
        4639, 4643, 4649, 4651, 4657, 4663, 4673, 4679, 4691, 4703, 4721, 4723, 4729, 4733, 4751,
        4759, 4783, 4787, 4789, 4793, 4799, 4801, 4813, 4817, 4831, 4861, 4871, 4877, 4889, 4903,
        4909, 4919, 4931, 4933, 4937, 4943, 4951, 4957, 4967, 4969, 4973, 4987, 4993, 4999, 5003,
        5009, 5011, 5021, 5023, 5039, 5051, 5059, 5077, 5081, 5087, 5099, 5101, 5107, 5113, 5119,
        5147, 5153, 5167, 5171, 5179, 5189, 5197, 5209, 5227, 5231, 5233, 5237, 5261, 5273, 5279,
        5281, 5297, 5303, 5309, 5323, 5333, 5347, 5351, 5381, 5387, 5393, 5399, 5407, 5413, 5417,
        5419, 5431, 5437, 5441, 5443, 5449, 5471, 5477, 5479, 5483, 5501, 5503, 5507, 5519, 5521,
        5527, 5531, 5557, 5563, 5569, 5573, 5581, 5591, 5623, 5639, 5641, 5647, 5651, 5653, 5657,
        5659, 5669, 5683, 5689, 5693, 5701, 5711, 5717, 5737, 5741, 5743, 5749, 5779, 5783, 5791,
        5801, 5807, 5813, 5821, 5827, 5839, 5843, 5849, 5851, 5857, 5861, 5867, 5869, 5879, 5881,
        5897, 5903, 5923, 5927, 5939, 5953, 5981, 5987, 6007, 6011, 6029, 6037, 6043, 6047, 6053,
        6067, 6073, 6079, 6089, 6091, 6101, 6113, 6121, 6131, 6133, 6143, 6151, 6163, 6173, 6197,
        6199, 6203, 6211, 6217, 6221, 6229, 6247, 6257, 6263, 6269, 6271, 6277, 6287, 6299, 6301,
        6311, 6317, 6323, 6329, 6337, 6343, 6353, 6359, 6361, 6367, 6373, 6379, 6389, 6397, 6421,
        6427, 6449, 6451, 6469, 6473, 6481, 6491, 6521, 6529, 6547, 6551, 6553, 6563, 6569, 6571,
        6577, 6581, 6599, 6607, 6619, 6637, 6653, 6659, 6661, 6673, 6679, 6689, 6691, 6701, 6703,
        6709, 6719, 6733, 6737, 6761, 6763, 6779, 6781, 6791, 6793, 6803, 6823, 6827, 6829, 6833,
        6841, 6857, 6863, 6869, 6871, 6883, 6899, 6907, 6911, 6917, 6947, 6949, 6959, 6961, 6967,
        6971, 6977, 6983, 6991, 6997, 7001, 7013, 7019, 7027, 7039, 7043, 7057, 7069, 7079, 7103,
        7109, 7121, 7127, 7129, 7151, 7159, 7177, 7187, 7193, 7207, 7211, 7213, 7219, 7229, 7237,
        7243, 7247, 7253, 7283, 7297, 7307, 7309, 7321, 7331, 7333, 7349, 7351, 7369, 7393, 7411,
        7417, 7433, 7451, 7457, 7459, 7477, 7481, 7487, 7489, 7499, 7507, 7517, 7523, 7529, 7537,
        7541, 7547, 7549, 7559, 7561, 7573, 7577, 7583, 7589, 7591, 7603, 7607, 7621, 7639, 7643,
        7649, 7669, 7673, 7681, 7687, 7691, 7699, 7703, 7717, 7723, 7727, 7741, 7753, 7757, 7759,
        7789, 7793, 7817, 7823, 7829, 7841, 7853, 7867, 7873, 7877, 7879, 7883, 7901, 7907, 7919
      };
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2);
      AssertListsAreSimilar(result, expected);
    }

    private static void AssertListsAreEqual(IReadOnlyList<int> result, IReadOnlyList<int> expected)
    {
      Assert.AreEqual(result.Count, expected.Count);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(result[i], expected[i]);
      }
    }

    private static void AssertListsAreSimilar(IReadOnlyCollection<int> result, ICollection<int> expected)
    {
      // similar because of a Parallel loop
      Assert.AreEqual(result.Count, expected.Count);
      foreach (int item in result)
      {
        Assert.IsTrue(expected.Contains(item));
      }
    }

    #endregion
    #region GetSmallest
    [TestMethod]
    public void TestMethod_GetSmallest_1()
    {
      var source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      const int expected = 1;
      int result = FunctionsMath.GetSmallest(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallest_10()
    {
      var source = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
      const int expected = 10;
      int result = FunctionsMath.GetSmallest(source);
      Assert.AreEqual(result, expected);
    }
    #endregion GetSmallest
    #region GetGreatests
    [TestMethod]
    public void TestMethod_GetSmallests_empty_source()
    {
      var source1 = new List<int>();
      const int source2 = 1;
      var expected = new List<int>();
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_1_number()
    {
      var source1 = new List<int> { 2, 3, 4, 1, 5, 6, 7, 8, 9 };
      const int source2 = 1;
      var expected = new List<int> { 1 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_2_numbers_same()
    {
      var source1 = new List<int> { 1, 2, 3, 4, 1, 5, 6, 7, 8, 9 };
      const int source2 = 2;
      var expected = new List<int> { 1, 1 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_2_numbers_different()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 2;
      var expected = new List<int> { 1, 2 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_3_numbers()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 3;
      var expected = new List<int> { 1, 2, 3 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_4_numbers()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 4;
      var expected = new List<int> { 1, 2, 3, 4 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_number_greater_than_list_count()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 54;
      var expected = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_negative_number()
    {
      var source1 = new List<int> { 9, 8, -7, 6, -5, 4, -3, 2, 1 };
      const int source2 = 2;
      var expected = new List<int> { -7, -5 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetSmallests_negative_number_mixed_with_positive_numbers()
    {
      var source1 = new List<int> { 9, 0, 8, -7, 6, -5, 4, -3, 2, 1 };
      const int source2 = 6;
      var expected = new List<int> { -7, -5, -3, 0, 1, 2 };
      var result = FunctionsMath.GetSmallests(source1, source2);
      AssertListsAreEqual(result, expected);
    }
    #endregion GetSmallests
    #region GetGreatest
    [TestMethod]
    public void TestMethod_GetGreatest_1()
    {
      var source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      const int expected = 9;
      int result = FunctionsMath.GetGreatest(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatest_10()
    {
      var source = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
      const int expected = 90;
      int result = FunctionsMath.GetGreatest(source);
      Assert.AreEqual(result, expected);
    }
    #endregion GetGreatest
    #region GetGreatests
    [TestMethod]
    public void TestMethod_GetGreatests_empty_source()
    {
      var source1 = new List<int>();
      const int source2 = 1;
      var expected = new List<int>();
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_1_number()
    {
      var source1 = new List<int> { 2, 3, 4, 1, 5, 6, 7, 8, 9 };
      const int source2 = 1;
      var expected = new List<int> { 9 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_2_numbers_same()
    {
      var source1 = new List<int> { 1, 2, 9, 3, 4, 1, 5, 6, 7, 8, 9 };
      const int source2 = 2;
      var expected = new List<int> { 9, 9 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_2_numbers_different()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 2;
      var expected = new List<int> { 9, 8 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_3_numbers()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 3;
      var expected = new List<int> { 9, 8, 7 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_4_numbers()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 4;
      var expected = new List<int> { 9, 8, 7, 6 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_number_greater_than_list_count()
    {
      var source1 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      const int source2 = 54;
      var expected = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_negative_number()
    {
      var source1 = new List<int> { 9, 8, -7, 6, -5, 4, -3, 2, 1 };
      const int source2 = 2;
      var expected = new List<int> { 9, 8 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_negative_numbers_mixed_with_positive_numbers()
    {
      var source1 = new List<int> { 9, 0, 8, -7, 6, -5, 4, -3, 2, 1 };
      const int source2 = 6;
      var expected = new List<int> { 9, 8, 6, 4, 2, 1 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGreatests_negative_and_positive_numbers_with_decimals()
    {
      var source1 = new List<int> { 9000, 0, 800, -7, 60, -5, 40, 15, -3, 22, 11 };
      const int source2 = 6;
      var expected = new List<int> { 9000, 800, 60, 40, 22, 15 };
      var result = FunctionsMath.GetGreatests(source1, source2);
      AssertListsAreEqual(result, expected);
    }
    #endregion GetGreatests
    #region PrimeByFormula
    [TestMethod]
    public void TestMethod_PrimeByFormula_0()
    {
      const ushort source = 0;
      const int expected = 41;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_1()
    {
      const ushort source = 1;
      const int expected = 41;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_2()
    {
      const ushort source = 2;
      const int expected = 43;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_3()
    {
      const ushort source = 3;
      const int expected = 47;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_4()
    {
      const ushort source = 4;
      const int expected = 53;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_5()
    {
      const ushort source = 5;
      const int expected = 61;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_6()
    {
      const ushort source = 6;
      const int expected = 71;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_7()
    {
      const ushort source = 7;
      const int expected = 83;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_8()
    {
      const ushort source = 8;
      const int expected = 97;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_9()
    {
      const ushort source = 9;
      const int expected = 113;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_10()
    {
      const ushort source = 10;
      const int expected = 131;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_11()
    {
      const ushort source = 11;
      const int expected = 151;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_12()
    {
      const ushort source = 12;
      const int expected = 173;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_13()
    {
      const ushort source = 13;
      const int expected = 197;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_14()
    {
      const ushort source = 14;
      const int expected = 223;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_15()
    {
      const ushort source = 15;
      const int expected = 251;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_16()
    {
      const ushort source = 16;
      const int expected = 281;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_17()
    {
      const ushort source = 17;
      const int expected = 313;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_18()
    {
      const ushort source = 18;
      const int expected = 347;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_19()
    {
      const ushort source = 19;
      const int expected = 383;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_20()
    {
      const ushort source = 20;
      const int expected = 421;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_21()
    {
      const ushort source = 21;
      const int expected = 461;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_22()
    {
      const ushort source = 22;
      const int expected = 503;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_23()
    {
      const ushort source = 23;
      const int expected = 547;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_24()
    {
      const ushort source = 24;
      const int expected = 593;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_25()
    {
      const ushort source = 25;
      const int expected = 641;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_26()
    {
      const ushort source = 26;
      const int expected = 691;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_27()
    {
      const ushort source = 27;
      const int expected = 743;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_28()
    {
      const ushort source = 28;
      const int expected = 797;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_29()
    {
      const ushort source = 29;
      const int expected = 853;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_30()
    {
      const ushort source = 30;
      const int expected = 911;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_31()
    {
      const ushort source = 31;
      const int expected = 971;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_32()
    {
      const ushort source = 32;
      const int expected = 1033;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_33()
    {
      const ushort source = 33;
      const int expected = 1097;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_34()
    {
      const ushort source = 34;
      const int expected = 1163;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_35()
    {
      const ushort source = 35;
      const int expected = 1231;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_36()
    {
      const ushort source = 36;
      const int expected = 1301;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_37()
    {
      const ushort source = 37;
      const int expected = 1373;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_38()
    {
      const ushort source = 38;
      const int expected = 1447;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_39()
    {
      const ushort source = 39;
      const int expected = 1523;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_40()
    {
      const ushort source = 40;
      const int expected = 1601;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    #endregion PrimeByFormula
    #region IsAPowerOfTwo
    [TestMethod]
    public void TestMethod_IsAPowerOfTwo_value_2()
    {
      const int source = 2;
      const bool expected = true;
      bool result = FunctionsMath.IsAPowerOfTwo(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAPowerOfTwo_value_4()
    {
      const int source = 4;
      const bool expected = true;
      bool result = FunctionsMath.IsAPowerOfTwo(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAPowerOfTwo_value_6()
    {
      const int source = 6;
      const bool expected = false;
      bool result = FunctionsMath.IsAPowerOfTwo(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAPowerOfTwo_value_7()
    {
      const int source = 7;
      const bool expected = false;
      bool result = FunctionsMath.IsAPowerOfTwo(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAPowerOfTwo_value_8()
    {
      const int source = 8;
      const bool expected = true;
      bool result = FunctionsMath.IsAPowerOfTwo(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAPowerOfTwo_value_15()
    {
      const int source = 15;
      const bool expected = false;
      bool result = FunctionsMath.IsAPowerOfTwo(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAPowerOfTwo_value_16()
    {
      const int source = 16;
      const bool expected = true;
      bool result = FunctionsMath.IsAPowerOfTwo(source);
      Assert.AreEqual(result, expected);
    }

    #endregion IsAPowerOfTwo
    #region Factorization
    [TestMethod]
    public void TestMethod_Factorization_value_6()
    {
      const int source = 6;
      List<int> expected = new List<int> { 2, 3 };
      List<int> result = FunctionsMath.Factorization(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorization_value_9()
    {
      const int source = 9;
      List<int> expected = new List<int> { 3, 3 };
      List<int> result = FunctionsMath.Factorization(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorization_value_10()
    {
      const int source = 10;
      List<int> expected = new List<int> { 2, 5 };
      List<int> result = FunctionsMath.Factorization(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorization_value_15()
    {
      const int source = 15;
      List<int> expected = new List<int> { 3, 5 };
      List<int> result = FunctionsMath.Factorization(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorization_value_100()
    {
      const int source = 100;
      List<int> expected = new List<int> { 2, 2, 5, 5 };
      List<int> result = FunctionsMath.Factorization(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorization_value_200()
    {
      const int source = 200;
      List<int> expected = new List<int> { 2, 2, 2, 5, 5 };
      List<int> result = FunctionsMath.Factorization(source);
      AssertAreEqualList(result, expected);
    }

    #endregion Factorization
    #endregion Math Methods

    #region GetDivisors
    [TestMethod]
    public void TestMethod_GetDivisors_value_10()
    {
      const int source = 10;
      List<int> expected = new List<int> { 1, 10, 2, 5 };
      List<int> result = FunctionsMath.GetDivisors(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisors_value_50()
    {
      const int source = 50;
      List<int> expected = new List<int> { 1, 50, 2, 5, 10, 25 };
      List<int> result = FunctionsMath.GetDivisors(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisors_value_100()
    {
      const int source = 100;
      List<int> expected = new List<int> { 1, 100, 2, 4, 5, 10, 20, 25, 50 };
      List<int> result = FunctionsMath.GetDivisors(source);
      AssertAreEqualList(result, expected);
    }
    #endregion

    #region GetDivisorsSorted
    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_10()
    {
      const int source = 10;
      List<int> expected = new List<int> { 1, 2, 5, 10 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_11()
    {
      const int source = 11;
      List<int> expected = new List<int> { 1, 11 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_12()
    {
      const int source = 12;
      List<int> expected = new List<int> { 1, 2, 3, 4, 6, 12 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_13()
    {
      const int source = 13;
      List<int> expected = new List<int> { 1, 13 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_14()
    {
      const int source = 14;
      List<int> expected = new List<int> { 1, 2, 7, 14 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_15()
    {
      const int source = 15;
      List<int> expected = new List<int> { 1, 3, 5, 15 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_16()
    {
      const int source = 16;
      List<int> expected = new List<int> { 1, 2, 4, 8, 16 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_17()
    {
      const int source = 17;
      List<int> expected = new List<int> { 1, 17 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_50()
    {
      const int source = 50;
      List<int> expected = new List<int> { 1, 2, 5, 10, 25, 50 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDivisorsSorted_value_100()
    {
      const int source = 100;
      List<int> expected = new List<int> { 1,  2, 4, 5, 10, 20, 25, 50, 100 };
      List<int> result = FunctionsMath.GetDivisorsSorted(source);
      AssertAreEqualList(result, expected);
    }
    
    #endregion

    #region Unit Test Helper methods
    public static void AssertAreEqualList(List<int> result, List<int> expected)
    {
      Assert.AreEqual(result.Count, expected.Count);
      for (int i = 0; i < expected.Count; i++)
      {
        Assert.AreEqual(result[i], expected[i]);
      }
    }
    #endregion Unit Test Helper methods

    // ConvertDoublewithCultureInfo
    [TestMethod]
    public void TestMethod_ConvertDoublewithCultureInfo_1()
    {
      const string source = "1,14535765";
      const decimal expected = (decimal)1.14535765d;
      decimal result = FunctionsMath.ConvertDoublewithCultureInfo(source);
      Assert.AreEqual(result, expected);
    }
  }
}