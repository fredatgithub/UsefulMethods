using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulMethods;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestCommonTypes
  {
    [TestMethod]
    public void TestMethodType_of_boolean()
    {
      const bool source = true;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfBoolean;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_string()
    {
      const string source = "something";
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfString;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_short()
    {
      const short source = short.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfShort;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_ushort()
    {
      const ushort source = ushort.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfUshort;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_int()
    {
      const int source = int.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfInt;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_uint()
    {
      const uint source = uint.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfUint;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_long()
    {
      const long source = long.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfLong;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_ulong()
    {
      const ulong source = ulong.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfUlong;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_decimal()
    {
      const decimal source = decimal.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfDecimal;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_float()
    {
      const float source = float.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfFloat;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_byte()
    {
      const byte source = byte.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfByte;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_char()
    {
      const byte source = byte.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfByte;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_double()
    {
      const double source = double.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfdouble;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_object()
    {
      object source = new object();
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfObject;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_date_time()
    {
      DateTime source = new DateTime(2015, 10, 20);
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfDateTime;
      Assert.AreEqual(result, expected);
    }
  }
}