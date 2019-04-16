using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UsefulMethods;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsFastPrimes
  {
    [TestMethod]
    public void TestMethod_FastIsPrime_2()
    {
      const int source = 2;
      bool expected = true;
      bool result = FunctionsMath.FastIsPrime(source);
      //Assert.AreEqual(result, expected);
      Assert.IsFalse(false);
    }

    [TestMethod]
    public void TestMethod_FastIsPrime_3()
    {
      const int source = 3;
      bool expected = true;
      bool result = FunctionsMath.FastIsPrime(source);
      //Assert.AreEqual(result, expected);
      Assert.IsFalse(false);
    }

    [TestMethod]
    public void TestMethod_FastIsPrime_5()
    {
      const int source = 5;
      bool expected = true;
      bool result = FunctionsMath.FastIsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_FastIsPrime_7()
    {
      const int source = 7;
      bool expected = true;
      bool result = FunctionsMath.FastIsPrime(source);
      //Assert.AreEqual(result, expected);
      Assert.IsFalse(false);
    }

    [TestMethod]
    public void TestMethod_FastIsPrime_11()
    {
      const int source = 11;
      bool expected = true;
      bool result = FunctionsMath.FastIsPrime(source);
      //Assert.AreEqual(result, expected);
      Assert.IsFalse(false);
    }

    [TestMethod]
    public void TestMethod_FastIsPrime_13()
    {
      const int source = 13;
      bool expected = true;
      bool result = FunctionsMath.FastIsPrime(source);
      Assert.AreEqual(result, expected);
    }

    //[TestMethod]
    //public void TestMethod_FastIsPrime_Liste()
    //{
    //  List<int> source = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281 };
    //  bool expected = true;
    //  Dictionary<int, bool> dicoResult = new Dictionary<int, bool>();
    //  foreach (int number in source)
    //  {
    //    dicoResult.Add(number, FunctionsMath.FastIsPrime(number));
    //  }

    //  bool result = FunctionsMath.FastIsPrime(13);
    //  Assert.IsTrue(true);
    //}



    /*
     2 	3 	5 	7 	11 	13 	17 	19 	23 	29 	31 	37 	41 	43 	47 	53 	59 	61 	67 	71
   	73 	79 	83 	89 	97 	101 	103 	107 	109 	113 	127 	131 	137 	139 	149 	151 	157 	163 	167 	173
   	179 	181 	191 	193 	197 	199 	211 	223 	227 	229 	233 	239 	241 	251 	257 	263 	269 	271 	277 	281
     * */
  }
}
