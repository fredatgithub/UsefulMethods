using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using dllFuncs = UsefulMethods;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestEnumerations
  {
    #region LetterCasingSequence
    // **********************LetterCasingSequence**************
    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.LetterCasingSequence.DigitLowerUpper, dllFuncs.LetterCasingSequence.DigitLowerUpper);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.DigitUpperLower, dllFuncs.LetterCasingSequence.DigitUpperLower);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.LowerDigitUpper, dllFuncs.LetterCasingSequence.LowerDigitUpper);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.LowerUpperDigit, dllFuncs.LetterCasingSequence.LowerUpperDigit);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.UpperDigitLower, dllFuncs.LetterCasingSequence.UpperDigitLower);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.UpperLowerDigit, dllFuncs.LetterCasingSequence.UpperLowerDigit);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.DigitLowerUpper, dllFuncs.LetterCasingSequence.DigitUpperLower);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.DigitUpperLower, dllFuncs.LetterCasingSequence.LowerDigitUpper);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.LowerDigitUpper, dllFuncs.LetterCasingSequence.LowerUpperDigit);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.LowerUpperDigit, dllFuncs.LetterCasingSequence.UpperDigitLower);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.UpperDigitLower, dllFuncs.LetterCasingSequence.UpperLowerDigit);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.UpperLowerDigit, dllFuncs.LetterCasingSequence.DigitLowerUpper);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 3));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 4));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 5));
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.LowerUpperDigit, 0);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.UpperLowerDigit, 1);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.DigitLowerUpper, 2);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.DigitUpperLower, 3);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.LowerDigitUpper, 4);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.UpperDigitLower, 5);
    }
    #endregion LetterCasingSequence
    #region DefaultCasing
    [TestMethod]
    public void TestMethod_DefaultCasing_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.DefaultCasing.DefaultAsIs, dllFuncs.DefaultCasing.DefaultAsIs);
      Assert.AreEqual(dllFuncs.DefaultCasing.DefaultLowerCase, dllFuncs.DefaultCasing.DefaultLowerCase);
      Assert.AreEqual(dllFuncs.DefaultCasing.DefaultUpperCase, dllFuncs.DefaultCasing.DefaultUpperCase);
    }

    [TestMethod]
    public void TestMethod_DefaultCasing_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.DefaultCasing.DefaultAsIs, dllFuncs.DefaultCasing.DefaultUpperCase);
      Assert.AreNotEqual(dllFuncs.DefaultCasing.DefaultLowerCase, dllFuncs.DefaultCasing.DefaultAsIs);
      Assert.AreNotEqual(dllFuncs.DefaultCasing.DefaultUpperCase, dllFuncs.DefaultCasing.DefaultLowerCase);
    }

    [TestMethod]
    public void TestMethod_DefaultCasing_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.DefaultCasing), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.DefaultCasing), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.DefaultCasing), 2));
    }

    [TestMethod]
    public void TestMethod_DefaultCasing_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.DefaultCasing.DefaultLowerCase, 0);
      Assert.AreEqual((int)dllFuncs.DefaultCasing.DefaultUpperCase, 1);
      Assert.AreEqual((int)dllFuncs.DefaultCasing.DefaultAsIs, 2);
    }
    #endregion DefaultCasing
    #region SearchedLanguage
    //**************************************************SearchedLanguage**************************************
    [TestMethod]
    public void TestMethod_SearchedLanguage_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.SearchedLanguage.English, dllFuncs.SearchedLanguage.English);
      Assert.AreEqual(dllFuncs.SearchedLanguage.French, dllFuncs.SearchedLanguage.French);
      Assert.AreEqual(dllFuncs.SearchedLanguage.FrenchAndEnglish, dllFuncs.SearchedLanguage.FrenchAndEnglish);
      Assert.AreEqual(dllFuncs.SearchedLanguage.NoLanguageChosen, dllFuncs.SearchedLanguage.NoLanguageChosen);
    }

    [TestMethod]
    public void TestMethod_SearchedLanguage_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.English, dllFuncs.SearchedLanguage.French);
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.French, dllFuncs.SearchedLanguage.English);
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.FrenchAndEnglish, dllFuncs.SearchedLanguage.NoLanguageChosen);
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.NoLanguageChosen, dllFuncs.SearchedLanguage.FrenchAndEnglish);
    }

    [TestMethod]
    public void TestMethod_SearchedLanguage_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 3));
    }

    [TestMethod]
    public void TestMethod_SearchedLanguage_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.NoLanguageChosen, 0);
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.French, 1);
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.English, 2);
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.FrenchAndEnglish, 3);
    }
    #endregion SearchedLanguage
    #region TimeSpanElement
    // **********************TimeSpanElement**************
    [TestMethod]
    public void TestMethod_TimeSpanElement_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.TimeSpanElement.Millisecond, dllFuncs.TimeSpanElement.Millisecond);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Second, dllFuncs.TimeSpanElement.Second);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Minute, dllFuncs.TimeSpanElement.Minute);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Hour, dllFuncs.TimeSpanElement.Hour);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Day, dllFuncs.TimeSpanElement.Day);
    }

    [TestMethod]
    public void TestMethod_TimeSpanElement_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Millisecond, dllFuncs.TimeSpanElement.Day);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Second, dllFuncs.TimeSpanElement.Minute);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Minute, dllFuncs.TimeSpanElement.Second);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Hour, dllFuncs.TimeSpanElement.Millisecond);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Day, dllFuncs.TimeSpanElement.Hour);
    }

    [TestMethod]
    public void TestMethod_TimeSpanElement_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 3));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 4));
    }

    [TestMethod]
    public void TestMethod_TimeSpanElement_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Millisecond, 0);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Second, 1);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Minute, 2);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Hour, 3);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Day, 4);
    }
    #endregion TimeSpanElement
  }
}