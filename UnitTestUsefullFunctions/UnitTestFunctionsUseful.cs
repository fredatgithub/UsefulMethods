using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFunc = UsefulMethods.FunctionsString;
using DateFunc = UsefulMethods.FunctionsDateTime;
using System;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestFunctionsUseful
  {
    #region Useful Methods
    
    #region DateToByteArray Methods
    //**********************DateToByteArray Methods***************
    [TestMethod]
    public void TestMethod_DateToByteArray_true()
    {
      byte[] source = { 0x20, 0x15, 0x03, 0x27, 0x13, 0x30, 0x00, 0x00, 0x00 };
      DateTime expected = new DateTime(01, 01, 01, 00, 00, 00, DateTimeKind.Local);
      DateTime result = DateFunc.ByteArrayToDate(source);
      Assert.IsTrue(result == expected);
    }

    [TestMethod]
    public void TestMethod_DateToByteArray_false()
    {
      byte[] source = { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01 };
      DateTime expected = new DateTime(1601, 03, 03, 05, 18, 01);
      DateTime result = DateFunc.ByteArrayToDate(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DateToByteArray_false_length_not_equal_to_eight()
    {
      byte[] source = { 0x01, 0x01, 0x01, 0x01 };
      DateTime expected = new DateTime();
      DateTime result = DateFunc.ByteArrayToDate(source);
      Assert.AreEqual(result, expected);
    }
    #endregion DateToByteArray Methods
    #region ByteArrayToString Methods
    //**********************ByteArrayToString Methods***************
    [TestMethod]
    public void TestMethod_ByteArrayToHexString_true()
    {
      byte[] source = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      const string expected = "010203091011121314151617";
      string result = StringFunc.ByteArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ByteArrayToString_true_one()
    {
      byte[] source = { 0x01 };
      const string expected = "01";
      string result = StringFunc.ByteArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexString_false()
    {
      byte[] source = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      const string expected = "01";
      string result = StringFunc.ByteArrayToString(source);
      Assert.AreNotEqual(result, expected);
    }

    #endregion ByteArrayToString Methods
    #region HexStringToByteArray Methods
    [TestMethod]
    public void TestMethod_HexStringToByteArray_true()
    {
      string source = "010203091011121314151617";
      byte[] expected = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      for (int i = 0; i < expected.Length; i++)
      {
        Assert.IsTrue(result[i] == expected[i]);
      }
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_true_two_values()
    {
      string source = "0102";
      byte[] expected = { 0x01, 0x02 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      Assert.IsTrue(result[0] == expected[0]);
      Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_false()
    {
      string source = "010203091011121314151617";
      byte[] expected = { 0x01 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_false_not_even_length()
    {
      string source = "01020";
      byte[] expected = { 0x01, 0x02 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      Assert.AreNotEqual(result, expected);
    }

    #endregion HexStringToByteArray Methods
    #endregion Useful Methods
  }
}