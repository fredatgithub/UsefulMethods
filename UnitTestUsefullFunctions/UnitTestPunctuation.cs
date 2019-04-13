using Microsoft.VisualStudio.TestTools.UnitTesting;
using dllFuncs = UsefulMethods;
namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestPunctuation
  {
    #region CreateSentence
    [TestMethod]
    public void TestMethod_Punctuation_no_argument()
    {
      string[] source = {};
      const string expected = "";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_one_argument()
    {
      string[] source = { dllFuncs.Punctuation.Comma};
      const string expected = ",";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_two_argument()
    {
      string[] source = { dllFuncs.Punctuation.Comma, dllFuncs.Punctuation.Dash };
      const string expected = ",-";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_three_argument()
    {
      string[] source = { dllFuncs.Punctuation.SemiColon, dllFuncs.Punctuation.Backslash, "notepad.exe" };
      const string expected = ";\\notepad.exe";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    #endregion
  }
}