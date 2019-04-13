using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using UsefulMethods;
using FunctionsFiles = UsefulMethods.FunctionsFiles;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestFunctionsFiles
  {
    #region Files Methods
    //**************************GenerateUniqueFileName Methods****
    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_eight()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 8;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_twelve()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 12;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial, 8, true, "doc");
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_thirteen()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 13;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial, 8, true, "docx");
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_false_file_does_not_exist_in_temp_dir()
    {
      string sourceDir = Path.GetTempPath();
      const bool expected = false;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(File.Exists(Path.Combine(sourceDir, result)), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_false_file_does_not_exist_in_document_dir()
    {
      string sourceDir = Environment.SpecialFolder.MyDocuments.ToString();
      const bool expected = false;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(File.Exists(Path.Combine(sourceDir, result)), expected);
    }

    #region IsLegalXmlChar
    [TestMethod]
    public void TestMethod_IsLegalXmlChar_true_0x9()
    {
      const char source = (char)0x9;
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsLegalXmlChar_true_0xA()
    {
      const char source = (char)0xA;
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsLegalXmlChar_true_0xD()
    {
      const char source = (char)0xD;
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsLegalXmlChar_char_a()
    {
      const char source = 'a';
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }
    #endregion IsLegalXmlChar

    #endregion Files Methods
  }
}