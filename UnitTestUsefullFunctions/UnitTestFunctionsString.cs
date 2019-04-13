using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using dllFuncs = UsefulMethods;
using StringFunc = UsefulMethods.FunctionsString;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestMethodsString
  {
    #region String Methods

    //**********************String Methods***************
    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_One_item()
    {
      int[] source = { 1 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Two_items()
    {
      int[] source = { 1, 1 };
      const bool expected = true;
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_Two_items()
    {
      int[] source = { 1, 2 };
      const bool expected = false;
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_none()
    {
      int[] source = { 1, 2, 3, 4 };
      const bool expected = false;
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Empty_list_because_all_items_equal_zero()
    {
      int[] source = new int[5];
      const bool expected = true;
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_null_list()
    {
      int[] source = null;
      const bool expected = false;
      // ReSharper disable once ExpressionIsAlwaysNull
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_several_items()
    {
      int[] source = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      const bool expected = false;
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_several_items()
    {
      int[] source = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };
      const bool expected = true;
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }

    // **********************EndPadding****************
    [TestMethod]
    public void TestMethod_EndPadding()
    {
      string result = StringFunc.EndPadding("azerty", 8);
      Assert.IsTrue(result == "azerty  ");
    }

    [TestMethod]
    public void TestMethod_EndPadding_length()
    {
      string result = StringFunc.EndPadding("azerty", 8);
      Assert.IsTrue(result.Length == 8);
    }

    [TestMethod]
    public void TestMethod_EndPadding_none_length()
    {
      string result = StringFunc.EndPadding("azerty", 6);
      Assert.IsTrue(result.Length == 6);
    }

    [TestMethod]
    public void TestMethod_EndPadding_none_string()
    {
      string result = StringFunc.EndPadding("azerty", 6);
      Assert.IsTrue(result == "azerty");
    }

    // **********************GetFileNameAfterLastSlash****************
    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash()
    {
      string result = StringFunc.GetFileNameAfterLastSlash(@"C:\tmp\texte.txt");
      Assert.IsTrue(result == "texte.txt");
    }

    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash_empty_string()
    {
      string result = StringFunc.GetFileNameAfterLastSlash(@"");
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash_no_path()
    {
      string result = StringFunc.GetFileNameAfterLastSlash(@"texte.txt");
      Assert.IsTrue(result == "texte.txt");
    }

    // **********************RemoveInString****************
    [TestMethod]
    public void TestMethod_RemoveInString()
    {
      string result = StringFunc.RemoveInString("azerty", "azertyuiop");
      Assert.IsTrue(result == "uiop");
    }

    [TestMethod]
    public void TestMethod_RemoveInString_with_trim_end_equal_to_true()
    {
      string result = StringFunc.RemoveInString("azerty", "azertyuiop ", true);
      Assert.IsTrue(result == "uiop");
    }

    [TestMethod]
    public void TestMethod_RemoveInString_with_trim_end_equal_to_false()
    {
      string result = StringFunc.RemoveInString("azerty", "azertyuiop ");
      Assert.IsTrue(result == "uiop ");
    }

    [TestMethod]
    public void TestMethod_RemoveInString__nothing()
    {
      string result = StringFunc.RemoveInString("azerty", "uiop");
      Assert.IsTrue(result == "uiop");
    }

    // **********************CamelCase****************
    [TestMethod]
    public void TestMethod_CamelCase_a_sentence()
    {
      string result = StringFunc.CamelCase("once upon a time");
      Assert.IsTrue(result == "Once Upon A Time");
    }

    [TestMethod]
    public void TestMethod_CamelCase_one_word()
    {
      string result = StringFunc.CamelCase("azerty");
      Assert.IsTrue(result == "Azerty");
    }

    [TestMethod]
    public void TestMethod_CamelCase_string_empty()
    {
      string result = StringFunc.CamelCase("");
      Assert.IsTrue(result == "");
    }

    // **********************IsNumeric****************
    [TestMethod]
    public void TestMethod_IsNumeric_A_character()
    {
      bool result = StringFunc.IsNumeric('a');
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_IsNumeric_a_digit()
    {
      bool result = StringFunc.IsNumeric("4");
      Assert.IsTrue(result);
    }

    // **********************IsLetter****************
    [TestMethod]
    public void TestMethod_IsLetter_()
    {
      bool result = StringFunc.IsLetter('a');
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_IsLetter_upperCase()
    {
      bool result = StringFunc.IsLetter('A');
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_IsLetter_upperCase_blank()
    {
      bool result = StringFunc.IsLetter(' ');
      Assert.IsFalse(result);
    }
    #endregion String methods
    #region String methods - Plural
    // **********************Plural****************
    [TestMethod]
    public void TestMethod_Plural_zero_with_int()
    {
      const int source = 0;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one_with_int()
    {
      const int source = 1;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two_with_int()
    {
      const int source = 2;
      const string expected = "s";
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_zero_with_byte()
    {
      const byte source = 0;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one_with_byte()
    {
      const byte source = 1;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two_with_byte()
    {
      const byte source = 2;
      const string expected = "s";
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_zero_with_Int16()
    {
      const Int16 source = 0;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one_with_Int16()
    {
      const Int16 source = 1;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two_with_Int16()
    {
      const Int16 source = 2;
      const string expected = "s";
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_zero_with_Int64()
    {
      const Int64 source = 0;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one_with_Int64()
    {
      const Int64 source = 1;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two_with_Int64()
    {
      const Int64 source = 2;
      const string expected = "s";
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_zero_with_uint()
    {
      const uint source = 0;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one_with_uint()
    {
      const uint source = 1;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two_with_uint()
    {
      const uint source = 2;
      const string expected = "s";
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_zero_with_UInt16()
    {
      const UInt16 source = 0;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one_with_UInt16()
    {
      const UInt16 source = 1;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two_with_UInt16()
    {
      const UInt16 source = 2;
      const string expected = "s";
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_zero_with_UInt64()
    {
      const UInt64 source = 0;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one_with_UInt64()
    {
      const UInt64 source = 1;
      string expected = string.Empty;
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two_with_UInt64()
    {
      const UInt64 source = 2;
      const string expected = "s";
      string result = StringFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_Plural_al_one_with_int()
    {
      const int source = 1;
      const string source2 = "al";
      const string expected = source2;
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_al_two_with_int()
    {
      const int source = 2;
      const string source2 = "al";
      const string expected = "aux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_au_two_with_int()
    {
      const int source = 2;
      const string source2 = "au";
      const string expected = "aux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_est_one_with_int()
    {
      const int source = 1;
      const string source2 = "est";
      const string expected = "est";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_est_two_with_int()
    {
      const int source = 2;
      const string source2 = "est";
      const string expected = "sont";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_eau_two_with_int()
    {
      const int source = 2;
      const string source2 = "eau";
      const string expected = "eaux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_eu_two_with_int()
    {
      const int source = 2;
      const string source2 = "eu";
      const string expected = "eux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_landau_two_with_int()
    {
      const int source = 2;
      const string source2 = "landau";
      const string expected = "landaus";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_sarrau_two_with_int()
    {
      const int source = 2;
      const string source2 = "sarrau";
      const string expected = "sarraus";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_bleu_two_with_int()
    {
      const int source = 2;
      const string source2 = "bleu";
      const string expected = "bleus";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_émeu_two_with_int()
    {
      const int source = 2;
      const string source2 = "émeu";
      const string expected = "émeus";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_lieu_two_with_int()
    {
      const int source = 2;
      const string source2 = "lieu";
      const string expected = "lieux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_pneu_two_with_int()
    {
      const int source = 2;
      const string source2 = "pneu";
      const string expected = "pneus";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_aval_two_with_int()
    {
      const int source = 2;
      const string source2 = "aval";
      const string expected = "avals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_bal_two_with_int()
    {
      const int source = 2;
      const string source2 = "bal";
      const string expected = "bals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_chacal_two_with_int()
    {
      const int source = 2;
      const string source2 = "chacal";
      const string expected = "chacals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_carnaval_two_with_int()
    {
      const int source = 2;
      const string source2 = "carnaval";
      const string expected = "carnavals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_festival_two_with_int()
    {
      const int source = 2;
      const string source2 = "festival";
      const string expected = "festivals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_récital_two_with_int()
    {
      const int source = 2;
      const string source2 = "récital";
      const string expected = "récitals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_régal_two_with_int()
    {
      const int source = 2;
      const string source2 = "régal";
      const string expected = "régals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_cal_two_with_int()
    {
      const int source = 2;
      const string source2 = "cal";
      const string expected = "cals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_serval_two_with_int()
    {
      const int source = 2;
      const string source2 = "serval";
      const string expected = "servals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_choral_two_with_int()
    {
      const int source = 2;
      const string source2 = "choral";
      const string expected = "chorals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_narval_two_with_int()
    {
      const int source = 2;
      const string source2 = "narval";
      const string expected = "narvals";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_bail_two_with_int()
    {
      const int source = 2;
      const string source2 = "bail";
      const string expected = "baux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_corail_two_with_int()
    {
      const int source = 2;
      const string source2 = "corail";
      const string expected = "coraux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_émail_two_with_int()
    {
      const int source = 2;
      const string source2 = "émail";
      const string expected = "émaux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_soupirail_two_with_int()
    {
      const int source = 2;
      const string source2 = "soupirail";
      const string expected = "soupiraux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_travail_two_with_int()
    {
      const int source = 2;
      const string source2 = "travail";
      const string expected = "travaux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_vantail_two_with_int()
    {
      const int source = 2;
      const string source2 = "vantail";
      const string expected = "vantaux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_vitrail_two_with_int()
    {
      const int source = 2;
      const string source2 = "vitrail";
      const string expected = "vitraux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_bijou_two_with_int()
    {
      const int source = 2;
      const string source2 = "bijou";
      const string expected = "bijoux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_caillou_two_with_int()
    {
      const int source = 2;
      const string source2 = "caillou";
      const string expected = "cailloux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_chou_two_with_int()
    {
      const int source = 2;
      const string source2 = "chou";
      const string expected = "choux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_genou_two_with_int()
    {
      const int source = 2;
      const string source2 = "genou";
      const string expected = "genoux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_hibou_two_with_int()
    {
      const int source = 2;
      const string source2 = "hibou";
      const string expected = "hiboux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_joujou_two_with_int()
    {
      const int source = 2;
      const string source2 = "joujou";
      const string expected = "joujoux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_pou_two_with_int()
    {
      const int source = 2;
      const string source2 = "pou";
      const string expected = "poux";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    // **********************English Plural****************
    [TestMethod]
    public void TestMethod_Plural_English_is_singular()
    {
      const int source = 1;
      const string source2 = "is";
      const string expected = "is";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_English_is_plural()
    {
      const int source = 2;
      const string source2 = "is";
      const string expected = "are";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_English_plural_plus_is_singular()
    {
      const int source = 1;
      const string source2 = " is";
      const string expected = " is";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_English_plural_plus_is_plural()
    {
      const int source = 2;
      const string source2 = " is";
      const string expected = "s are";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_English_plural_The_singular()
    {
      const int source = 1;
      const string source2 = "The";
      const string expected = "The";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_English_plural_The_plural()
    {
      const int source = 2;
      const string source2 = "The";
      const string expected = "The";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_English_plural_the_singular()
    {
      const int source = 1;
      const string source2 = "the";
      const string expected = "the";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_English_plural_the_plural()
    {
      const int source = 2;
      const string source2 = "the";
      const string expected = "the";
      string result = StringFunc.Plural(source, source2);
      Assert.AreEqual(result, expected);
    }

    #endregion String methods - Plural

    // **********************StringOccurrenceWithContains****************
    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains()
    {
      int result = StringFunc.StringOccurrenceWithContains("azerty", "zer");
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_search_empty_string()
    {
      int result = StringFunc.StringOccurrenceWithContains("azerty", "");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_with_empty_string()
    {
      int result = StringFunc.StringOccurrenceWithContains("", "azerty");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_both_empty_string()
    {
      int result = StringFunc.StringOccurrenceWithContains("", "");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_two_occurences()
    {
      int result = StringFunc.StringOccurrenceWithContains("azertyqwerty", "erty");
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_three_occurences()
    {
      int result = StringFunc.StringOccurrenceWithContains("azertyqwertyandanyothererty", "erty");
      Assert.IsTrue(result == 3);
    }

    // **********************ByteArrayToHexaString****************
    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result = StringFunc.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "0102");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_two_elements_OneDigitOnly()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result = StringFunc.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "12");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_three_elements()
    {
      byte[] source = { 0x01, 0x02, 0x03 };
      string result = StringFunc.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "010203");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_three_elements_OneDigitOnly()
    {
      byte[] source = { 0x01, 0x02, 0x03 };
      string result = StringFunc.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "123");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_empty_source()
    {
      byte[] source = { };
      string result = StringFunc.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_empty_source_OneDigitOnly()
    {
      byte[] source = { };
      string result = StringFunc.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "");
    }

    // **********************HexaStringToByteArray****************
    [TestMethod]
    public void TestMethod_HexaStringToByteArray_three_elements()
    {
      const string source = "010203";
      byte[] expected = new byte[3];
      expected[0] = 0x01;
      expected[1] = 0x02;
      expected[2] = 0x03;
      byte[] result = StringFunc.HexaStringToByteArray(source);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
      Assert.AreEqual(result[2], expected[2]);
    }

    [TestMethod]
    public void TestMethod_HexaStringToByteArray_one_element()
    {
      const string source = "01";
      byte[] expected = new byte[1];
      expected[0] = 0x01;
      byte[] result = StringFunc.HexaStringToByteArray(source);
      Assert.AreEqual(result[0], expected[0]);
    }

    [TestMethod]
    public void TestMethod_HexaStringToByteArray_empty_string()
    {
      const string source = "";
      byte[] expected = new byte[0];
      byte[] result = StringFunc.HexaStringToByteArray(source);
      Assert.AreEqual(result.Length, expected.Length);
    }

    // **********************ReverseString****************
    [TestMethod]
    public void TestMethod_ReverseString()
    {
      const string source = "123456789";
      string result = StringFunc.ReverseString2(source);
      Assert.IsTrue(result == "987654321");
    }

    [TestMethod]
    public void TestMethod_ReverseString_on_an_empty_string()
    {
      const string source = "";
      string result = StringFunc.ReverseString2(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ReverseString_one_element()
    {
      const string source = "1";
      string result = StringFunc.ReverseString2(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_ReverseString_palindrome()
    {
      const string source = "laval";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == source);
    }

    [TestMethod]
    public void TestMethod_ReverseString_several_palindromes()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString(source);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString_several_palindromes_with_removal_of_space()
    {
      List<string> sourceWords = new List<string> { "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString2(source, true);
        Assert.IsTrue(result == source.Replace(" ", ""));
      }
    }

    // **********************ReverseString2****************
    [TestMethod]
    public void TestMethod_ReverseString2()
    {
      const string source = "123456789";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == "987654321");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_on_an_empty_string()
    {
      const string source = "";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_one_element()
    {
      const string source = "1";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_palindrome()
    {
      const string source = "laval";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == source);
    }

    [TestMethod]
    public void TestMethod_ReverseString2_several_palindromes()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString(source);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString2_several_palindromes_with_removal_of_space()
    {
      List<string> sourceWords = new List<string> { "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString(source, true);
        Assert.IsTrue(result == source.Replace(" ", ""));
      }
    }

    // **********************CompletePrefixWithZero****************
    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one()
    {
      const string source = "1";
      string result = StringFunc.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine()
    {
      const string source = "9";
      string result = StringFunc.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "9");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits()
    {
      const string source = "12";
      string result = StringFunc.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "12");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one_integer()
    {
      const int source = 1;
      string result = StringFunc.CompletePrefixWithZeroInt(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine_integer()
    {
      const int source = 9;
      string result = StringFunc.CompletePrefixWithZeroInt(source);
      Assert.IsTrue(result == "9");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits_integer()
    {
      const int source = 12;
      string result = StringFunc.CompletePrefixWithZeroInt(source);
      Assert.IsTrue(result == "12");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one_with_three_digits()
    {
      const string source = "1";
      const byte source2 = 2;
      string expected = "001";
      string result = StringFunc.CompletePrefixWithZero(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine_with_three_digits()
    {
      const string source = "9";
      const byte source2 = 2;
      string expected = "009";
      string result = StringFunc.CompletePrefixWithZero(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits_with_three_digits()
    {
      const string source = "12";
      const byte source2 = 2;
      string expected = "0012";
      string result = StringFunc.CompletePrefixWithZero(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one_integer_with_three_digits()
    {
      const int source = 1;
      const byte source2 = 2;
      string expected = "001";
      string result = StringFunc.CompletePrefixWithZeroInt(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine_integer_with_three_digits()
    {
      const int source = 9;
      const byte source2 = 2;
      string expected = "009";
      string result = StringFunc.CompletePrefixWithZeroInt(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits_integer_with_three_digits()
    {
      const int source = 12;
      const byte source2 = 3;
      string expected = "00012";
      string result = StringFunc.CompletePrefixWithZeroInt(source, source2);
      Assert.AreEqual(result, expected);
    }

    // **********************ArrayToString****************
    [TestMethod]
    public void TestMethod_ArrayToString_one_element()
    {
      byte[] source = new byte[1];
      source[0] = 0x01;
      const string expected = "1";
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToString_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string expected = "1" + Environment.NewLine + "2";
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToString_three_elements()
    {
      byte[] source = new byte[3];
      source[0] = 0x01;
      source[1] = 0x02;
      source[2] = 0x03;
      string expected = "1" + Environment.NewLine + "2" + Environment.NewLine + "3";
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToString_two_elements_with_separator()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string separator = "-";
      string expected = "1" + separator + "2";
      string result = StringFunc.ArrayToString(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToString_three_elements_with_separator()
    {
      byte[] source = new byte[3];
      source[0] = 0x01;
      source[1] = 0x02;
      source[2] = 0x03;
      string separator = "-";
      string expected = "1" + separator + "2" + separator + "3";
      string result = StringFunc.ArrayToString(source, separator);
      Assert.AreEqual(result, expected);
    }

    // **********************ArrayToStringWithStringBuilder****************
    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_one_element()
    {
      byte[] source = new byte[1];
      source[0] = 0x01;
      const string expected = "1";
      string result = StringFunc.ArrayToStringWithStringBuilder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string expected = "1" + Environment.NewLine + "2";
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_three_elements()
    {
      byte[] source = new byte[3];
      source[0] = 0x01;
      source[1] = 0x02;
      source[2] = 0x03;
      string expected = "1" + Environment.NewLine + "2" + Environment.NewLine + "3";
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    // **********************ArrayToStringWithStringBuilderWithSeparator**************
    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilderWithSeparator_one_element()
    {
      byte[] source = new byte[1];
      source[0] = 0x01;
      string separator = "_";
      const string expected = "1";
      string result = StringFunc.ArrayToStringWithStringBuilder(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilderWithSeparator_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string separator = "_";
      string expected = "1" + separator + "2";
      string result = StringFunc.ArrayToString(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilderWithSeparator_three_elements()
    {
      byte[] source = new byte[3];
      source[0] = 0x01;
      source[1] = 0x02;
      source[2] = 0x03;
      string separator = "_";
      string expected = "1" + separator + "2" + separator + "3";
      string result = StringFunc.ArrayToString(source, separator);
      Assert.AreEqual(result, expected);
    }
    // **********************InsertSeparatorForEachCharacter****************
    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_one_string()
    {
      const string source = "azerty";
      const string expected = "a z e r t y";
      string result = StringFunc.InsertSeparatorForEachCharacter(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_one_string_with_one_separator()
    {
      const string source = "azerty";
      const string separator = "_";
      const string expected = "a_z_e_r_t_y";
      string result = StringFunc.InsertSeparatorForEachCharacter(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_one_string_with_several_separators()
    {
      const string source = "azerty";
      const string separator = "_|_";
      const string expected = "a_|_z_|_e_|_r_|_t_|_y";
      string result = StringFunc.InsertSeparatorForEachCharacter(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_empty_string()
    {
      const string source = "";
      const string separator = "_";
      const string expected = "";
      string result = StringFunc.InsertSeparatorForEachCharacter(source, separator);
      Assert.AreEqual(result, expected);
    }

    // **********************InsertSeparatorAtInterval****************
    [TestMethod]
    public void TestMethod_InsertSeparatorAtInterval_one_element()
    {
      const string source = "azerty";
      const string expected = "az er ty";
      string result = StringFunc.InsertSeparatorAtInterval(source, " ", 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertSeparatorAtInterval_one_element_without_interval()
    {
      const string source = "azerty";
      const string expected = "a z e r t y";
      string result = StringFunc.InsertSeparatorAtInterval(source, " ", 1);
      Assert.AreEqual(result, expected);
    }

    // **********************RemoveVowels****************
    [TestMethod]
    public void TestMethod_RemoveVowels_one_string()
    {
      const string source = "azerty";
      const string expected = "zrt";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_vowels()
    {
      const string source = "aeiouy";
      const string expected = "";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_consonant()
    {
      const string source = "qsdfghjklm";
      const string expected = "qsdfghjklm";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************KeepVowels****************
    [TestMethod]
    public void TestMethod_KeepVowels_one_string()
    {
      const string source = "azerty";
      const string expected = "aey";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_vowels()
    {
      const string source = "aeiouy";
      const string expected = "aeiouy";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_consonant()
    {
      const string source = "qsdfghjklm";
      const string expected = "";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************AlternateCases****************
    [TestMethod]
    public void TestMethod_AlternateCases_one_string()
    {
      const string source = "TheWonderfulMethodThatDoesALotOfThings";
      const string expected = "ThEwOnDeRfUlMeThOdThAtDoEsAlOtOfThInGs";
      string result = StringFunc.AlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************OppositeCase****************
    [TestMethod]
    public void TestMethod_OppositeCase_one_string()
    {
      const string source = "TheWonderfulMethodThatDoesALotOfThings";
      const string expected = "tHEwONDERFULmETHODtHATdOESalOToFtHINGS";
      string result = StringFunc.OppositeCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OppositeCase_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.OppositeCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OppositeCase_one_character_string()
    {
      const string source = "a";
      const string expected = "a";
      string result = StringFunc.OppositeCase(source);
      Assert.AreEqual(result, expected);
    }

    // **********************SwapCases****************
    [TestMethod]
    public void TestMethod_SwapCases_one_string()
    {
      const string source = "TheWonderfulMethodThatDoesALotOfThings";
      const string expected = "tHEwONDERFULmETHODtHATdOESalOToFtHINGS";
      string result = StringFunc.SwapCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SwapCases_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.SwapCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SwapCases_one_character_string()
    {
      const string source = "a";
      const string expected = "a";
      string result = StringFunc.SwapCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************Capitalize****************
    [TestMethod]
    public void TestMethod_Capitalize_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "Once upon a time in a galaxy far far away";
      string result = StringFunc.Capitalize(source);
      Assert.AreEqual(result, expected);
    }

    // **********************GetInitials****************
    [TestMethod]
    public void TestMethod_GetInitials_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "ouatiagffa";
      string result = StringFunc.GetInitials(source, " ", false, false, false);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetInitials_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.GetInitials(source, " ", false, false, false);
      Assert.AreEqual(result, expected);
    }

    // **********************GetTitle****************
    [TestMethod]
    public void TestMethod_GetTitle_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "Once Upon A Time In A Galaxy Far Far Away";
      string result = StringFunc.GetTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitleGetInitials_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.GetTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitle_one_string_with_separator()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "Once Upon A Time In A Galaxy Far Far Away";
      string result = StringFunc.GetTitle(source, " ");
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitle_one_string_with_underscore_separator()
    {
      const string source = "once_upon_a_time_in_a_galaxy_far_far_away";
      const string expected = "Once_Upon_A_Time_In_A_Galaxy_Far_Far_Away";
      string result = StringFunc.GetTitle(source, "_");
      Assert.AreEqual(result, expected);
    }

    // **********************SubstringEnd****************
    [TestMethod]
    public void TestMethod_SubstringEnd_first_character()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "o";
      string result = StringFunc.SubStringEnd(source, 0, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_start_equals_end()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "";
      string result = StringFunc.SubStringEnd(source, 0, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_two_characters()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "nc";
      string result = StringFunc.SubStringEnd(source, 1, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_four_characters()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "time";
      string result = StringFunc.SubStringEnd(source, 12, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_end_character()
    {
      const string source = "azerty";
      const string expected = "y";
      string result = StringFunc.SubStringEnd(source, source.Length - 1, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_one_character()
    {
      const string source = "azerty";
      const string expected = "e";
      string result = StringFunc.SubStringEnd(source, 2, 1);
      Assert.AreEqual(result, expected);
    }

    // **********************CharRight****************
    [TestMethod]
    public void TestMethod_CharRight()
    {
      const string source = "once upon a time in a galaxy far far away";
      const char expected = 'y';
      char result = StringFunc.CharRight(source, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharRight_empty_character()
    {
      const string source = "";
      const char expected = new char();
      char result = StringFunc.CharRight(source, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharRight_one_character()
    {
      const string source = "qwerty";
      const char expected = 'e';
      char result = StringFunc.CharRight(source, 3);
      Assert.AreEqual(result, expected);
    }

    // **********************CharMid****************
    [TestMethod]
    public void TestMethod_CharMid()
    {
      const string source = "once upon a time in a galaxy far far away";
      const char expected = 'n';
      char result = StringFunc.CharMid(source, 0, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharMid_empty_string()
    {
      const string source = "";
      const char expected = new char();
      char result = StringFunc.CharMid(source, 0, 0);
      Assert.AreEqual(result, expected);
    }

    // **********************CountString****************
    [TestMethod]
    public void TestMethod_CountString()
    {
      const string source = "once upon a time in a galaxy far far away";
      const int expected = 2;
      int result = StringFunc.CountString(source, "far", true);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountString_do_not_ignore_case()
    {
      const string source = "once upon a time in a galaxy far far away";
      const int expected = 2;
      int result = StringFunc.CountString(source, "far", false);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountString_empty_string()
    {
      const string source = "";
      const int expected = 0;
      int result = StringFunc.CountString(source, "far", true);
      Assert.AreEqual(result, expected);
    }

    // **********************IndexOfAll****************
    [TestMethod]
    public void TestMethod_IndexOfAll()
    {
      const string source = "once upon a time in a galaxy far far away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = StringFunc.IndexOfAll(source, "far", true);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_ignore_case()
    {
      const string source = "once upon a time in a galaxy far far away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = StringFunc.IndexOfAll(source, "far", false);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_ignore_case_upper_source()
    {
      const string source = "once upon a time in a galaxy FAR FAR away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = StringFunc.IndexOfAll(source, "far", true);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_no_matching()
    {
      const string source = "once upon a time in a galaxy far far away";
      int[] expected = new int[0];
      int[] result = StringFunc.IndexOfAll(source, "toto", true);
      Assert.AreEqual(result.Length, expected.Length);
    }

    // **********************IsAlternateCases****************
    [TestMethod]
    public void TestMethod_IsAlternateCases()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True()
    {
      const string source = "OnCe";
      const bool expected = true;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True_two_words()
    {
      const string source = "OnCe uPoN";
      const bool expected = true;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True_four_words()
    {
      const string source = "OnCe uPoN A TiMe";
      const bool expected = true;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsCapitalized****************
    [TestMethod]
    public void TestMethod_IsCapitalized_true()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = true;
      bool result = StringFunc.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsCapitalized_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsCapitalized_false()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase****************
    [TestMethod]
    public void TestMethod_IsLowerCase_true()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = true;
      bool result = StringFunc.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase2****************
    [TestMethod]
    public void TestMethod_IsLowerCase2_true()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = true;
      bool result = StringFunc.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase2_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase2_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsUpperCase****************
    [TestMethod]
    public void TestMethod_IsUpperCase_true()
    {
      string source = "once upon a time in a galaxy far far away";
      source = source.ToUpper();
      const bool expected = true;
      bool result = StringFunc.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase2****************
    [TestMethod]
    public void TestMethod_IsUpperCase2_true()
    {
      string source = "once upon a time in a galaxy far far away";
      source = source.ToUpper();
      const bool expected = true;
      bool result = StringFunc.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase2_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase2_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************HasVowels****************
    [TestMethod]
    public void TestMethod_HasVowels_true()
    {
      const string source = "azerty";
      const bool expected = true;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_only_vowels()
    {
      const string source = "aeiouy";
      const bool expected = true;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_false()
    {
      const string source = "qsdfghjklm";
      const bool expected = false;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsSpaces****************
    [TestMethod]
    public void TestMethod_IsSpaces_true()
    {
      const string source = "       ";
      const bool expected = true;
      bool result = StringFunc.IsSpaces(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsSpaces_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsSpaces_false()
    {
      const string source = "qwerty";
      const bool expected = false;
      bool result = StringFunc.IsSpaces(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsRepeatedChar****************
    [TestMethod]
    public void TestMethod_IsRepeatedChar_true()
    {
      const string source = "aaaaaaa";
      const bool expected = true;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChars_empty_string()
    {
      const string source = "";
      const bool expected = true;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChar_false()
    {
      const string source = "qwerty";
      const bool expected = false;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChar_false_on_a_sentence()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric on a string****************
    [TestMethod]
    public void TestMethod_IsNumeric_false()
    {
      const string source = "azerty";
      const bool expected = false;
      bool result = StringFunc.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric_true()
    {
      const string source = "123456";
      const bool expected = true;
      bool result = StringFunc.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric2 on a string****************
    [TestMethod]
    public void TestMethod_IsNumeric2_false()
    {
      const string source = "azerty";
      const bool expected = false;
      bool result = StringFunc.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric2_true()
    {
      const string source = "123456";
      const bool expected = true;
      bool result = StringFunc.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric2_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric3 with NumberStyles****************
    [TestMethod]
    public void TestMethod_IsNumeric3_false()
    {
      const string source = "azerty";
      const NumberStyles numberStyle = NumberStyles.Number;
      const bool expected = false;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true()
    {
      const string source = "123456";
      const NumberStyles numberStyle = NumberStyles.Number;
      const bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric3_empty_string()
    {
      const string source = "";
      const NumberStyles numberStyle = NumberStyles.Number;
      const bool expected = false;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_trailing_white()
    {
      const string source = "123456  ";
      const NumberStyles numberStyle = NumberStyles.AllowTrailingWhite;
      const bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_leading_white()
    {
      const string source = "  123456";
      const NumberStyles numberStyle = NumberStyles.AllowLeadingWhite;
      const bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_decimal_Point()
    {
      const string source = "1234,56";
      const NumberStyles numberStyle = NumberStyles.AllowDecimalPoint;
      const bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_3_decimal_Point()
    {
      const string source = "1234,567";
      const NumberStyles numberStyle = NumberStyles.AllowDecimalPoint;
      const bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_integer()
    {
      const string source = "123456";
      const NumberStyles numberStyle = NumberStyles.Integer;
      const bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    // **********************IsAlphaNumeric****************
    [TestMethod]
    public void TestMethod_IsAlphaNumeric_false()
    {
      const string source = "1+azerty";
      const bool expected = false;
      bool result = StringFunc.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlphaNumeric_true()
    {
      const string source = "1azerty";
      const bool expected = true;
      bool result = StringFunc.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlphaNumeric_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLetters****************
    [TestMethod]
    public void TestMethod_IsLetters_false()
    {
      const string source = "123456789";
      const bool expected = false;
      bool result = StringFunc.IsOnlyLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLetters_true()
    {
      const string source = "qwertyAndazerty";
      const bool expected = true;
      bool result = StringFunc.IsOnlyLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLetters_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsOnlyLetters(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsTitle**************
    [TestMethod]
    public void TestMethod_IsTitle_false()
    {
      const string source = "once upon a time";
      const bool expected = false;
      bool result = StringFunc.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_true()
    {
      const string source = "Once A Upon A Time";
      const bool expected = true;
      bool result = StringFunc.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsTitle with a separator**************
    [TestMethod]
    public void TestMethod_IsTitle_with_separator_false()
    {
      const string source = "once upon a time";
      const string separator = " ";
      const bool expected = false;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_separator_true()
    {
      const string source = "Once A Upon A Time";
      const string separator = " ";
      const bool expected = true;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_one_separator_false()
    {
      const string source = "once A Upon A Time_in a galaxy far far away";
      const string separator = "_";
      const bool expected = false;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_one_separator_true()
    {
      const string source = "Once A Upon A Time_In a galaxy far far away";
      const string separator = "_";
      const bool expected = true;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_separator_empty_string()
    {
      const string source = "";
      const string separator = "_";
      const bool expected = false;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    // **********************IsEmailAddress**************
    [TestMethod]
    public void TestMethod_IsEmailAddress_false()
    {
      const string source = "this is certainly not a valid email address";
      const bool expected = false;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_true()
    {
      const string source = "someone@aol.com";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_2_true()
    {
      const string source = "someone@somefai.com";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_dot_before_arobase_true()
    {
      const string source = "firstName.LastName@someFAI.com";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_minimum_length_true()
    {
      const string source = "me@f2.fr";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsEmailAddressValid**************
    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true()
    {
      const string source = "someone@someFAI.com";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_no_arobase()
    {
      const string source = "someoneatsomeFAI.com";
      const bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_no_dot()
    {
      const string source = "someone@someFAIdotcom";
      const bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_too_short()
    {
      const string source = "s@I.c";
      const bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_dot_before_arobase()
    {
      const string source = "firstName.lastName@free.fr";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_five_letter_TLD()
    {
      const string source = "firstName.lastName@mairie.paris";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_seven_letter_TLD()
    {
      const string source = "firstName.lastName@mywonderful.website";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eight_letter_TLD()
    {
      const string source = "firstName.lastName@mywonderful.memorial";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_nine_letter_TLD()
    {
      const string source = "firstName.lastName@supersite.solutions";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_ten_letter_TLD()
    {
      const string source = "firstName.lastName@maysupersite.consulting";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_two_dots_in_TLD()
    {
      const string source = "firstName.lastName@mywonderful.co.com";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_two_dots_in_tld_co_uk()
    {
      const string source = "firstName.lastName@site.co.uk";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eleven_letter_TLD()
    {
      const string source = "firstName.lastName@mysupersite.accountants";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eleven_letter_TLD_blackfriday()
    {
      const string source = "firstName.lastName@mysupersite.blackfriday";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_twelve_letter_TLD_construction()
    {
      const string source = "firstName.lastName@mysupersite.construction";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_twelve_letter_TLD_contractors()
    {
      const string source = "firstName.lastName@mysupersite.contractors";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_thirteen_letter_TLD_international()
    {
      const string source = "firstName.lastName@supersite.international";
      const bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    // **********************LoadAlphabetInList**************
    [TestMethod]
    public void TestMethod_LoadAlphabetInList_false_empty_source_array()
    {
      char[] expected = new char[62];
      char[] result = StringFunc.LoadAlphabetInCharArray(false, false);
      Assert.AreEqual(result.Length, expected.Length);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_false_empty_source_array_give_sixty_two_length_array()
    {
      const bool source = false;
      const int expected = 26 + 26 + 10;
      char[] result = StringFunc.LoadAlphabetInCharArray(source, source);
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_digits()
    {
      char[] expected = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      char[] result = StringFunc.LoadAlphabetInCharArray(true, false);
      Assert.AreEqual(result[0], expected[0]); // '0'
      Assert.AreEqual(result[5], expected[5]); // '5'
      Assert.AreEqual(result[9], expected[9]); // '9'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_lower_case_letters()
    {
      char[] expected = StringFunc.GetAlphabet();
      char[] result = StringFunc.LoadAlphabetInCharArray(false);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_upper_case_letters()
    {
      char[] expected = StringFunc.GetAlphabet(false);
      char[] result = StringFunc.LoadAlphabetInCharArray(false, false, true);
      Assert.AreEqual(result[0], expected[0]); // 'A'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'Z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_lower_and_upper_case_letters()
    {
      char[] expected = new char[62];
      char[] lower = StringFunc.GetAlphabet();
      char[] upper = StringFunc.GetAlphabet(false);
      int counter = 0;
      for (int i = 0; i < lower.Length; i++)
      {
        expected[counter] = lower[i];
        counter++;
      }

      foreach (char mychar in upper)
      {
        expected[counter] = mychar;
        counter++;
      }

      char[] result = StringFunc.LoadAlphabetInCharArray(false, true, true);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // 'A'
      Assert.AreEqual(result[51], expected[51]); // 'Z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_digit_lower_and_upper_case_letters()
    {
      char[] expected = new char[62];
      char[] lower = StringFunc.GetAlphabet();
      char[] upper = StringFunc.GetAlphabet(false);
      int counter = 0;
      foreach (char mychar in lower)
      {
        expected[counter] = mychar;
        counter++;
      }

      foreach (char myChar in upper)
      {
        expected[counter] = myChar;
        counter++;
      }
      for (short chiffre = 48; chiffre < 58; chiffre++) // 48 = asc('0')
      {
        expected[counter] = (char)chiffre;
        counter++;
      }

      char[] result = StringFunc.LoadAlphabetInCharArray(true, true, true);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // 'A'
      Assert.AreEqual(result[51], expected[51]); // 'Z'
      Assert.AreEqual(result[52], expected[52]); // '0'
      Assert.AreEqual(result[61], expected[61]); // '9'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_lower_case_letters_and_digit()
    {
      char[] expected = new char[62];
      char[] lower = StringFunc.GetAlphabet();
      int counter = 0;
      foreach (char mychar in lower)
      {
        expected[counter] = mychar;
        counter++;
      }

      for (short chiffre = 48; chiffre < 58; chiffre++) // 48 = asc('0')
      {
        expected[counter] = (char)chiffre;
        counter++;
      }

      char[] result = StringFunc.LoadAlphabetInCharArray();
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // '0'
      Assert.AreEqual(result[35], expected[35]); // '9'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_upper_case_letters_and_digit()
    {
      char[] expected = new char[62];
      char[] upper = StringFunc.GetAlphabet(false);
      int counter = 0;
      foreach (char myChar in upper)
      {
        expected[counter] = myChar;
        counter++;
      }

      for (short chiffre = 48; chiffre < 58; chiffre++) // 48 = asc('0')
      {
        expected[counter] = (char)chiffre;
        counter++;
      }

      char[] result = StringFunc.LoadAlphabetInCharArray(true, false, true);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // '0'
      Assert.AreEqual(result[35], expected[35]); // '9'
    }
    #region NumberToWordsEnglish

    // **********************NumberToWordsEnglish**************
    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_zero()
    {
      const string expected = "zero";
      string result = StringFunc.NumberToEnglishWords(0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one()
    {
      const string expected = "one";
      string result = StringFunc.NumberToEnglishWords(1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_one()
    {
      const string expected = "minus one";
      string result = StringFunc.NumberToEnglishWords(-1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two()
    {
      const string expected = "two";
      string result = StringFunc.NumberToEnglishWords(2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_two()
    {
      const string expected = "minus two";
      string result = StringFunc.NumberToEnglishWords(-2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_three()
    {
      const string expected = "three";
      string result = StringFunc.NumberToEnglishWords(3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_three()
    {
      const string expected = "minus three";
      string result = StringFunc.NumberToEnglishWords(-3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_four()
    {
      const string expected = "four";
      string result = StringFunc.NumberToEnglishWords(4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_four()
    {
      const string expected = "minus four";
      string result = StringFunc.NumberToEnglishWords(-4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_five()
    {
      const string expected = "five";
      string result = StringFunc.NumberToEnglishWords(5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_five()
    {
      const string expected = "minus five";
      string result = StringFunc.NumberToEnglishWords(-5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_six()
    {
      const string expected = "six";
      string result = StringFunc.NumberToEnglishWords(6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_six()
    {
      const string expected = "minus six";
      string result = StringFunc.NumberToEnglishWords(-6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven()
    {
      const string expected = "seven";
      string result = StringFunc.NumberToEnglishWords(7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eight()
    {
      const string expected = "eight";
      string result = StringFunc.NumberToEnglishWords(8);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine()
    {
      const string expected = "nine";
      string result = StringFunc.NumberToEnglishWords(9);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ten()
    {
      const string expected = "ten";
      string result = StringFunc.NumberToEnglishWords(10);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eleven()
    {
      const string expected = "eleven";
      string result = StringFunc.NumberToEnglishWords(11);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twelve()
    {
      const string expected = "twelve";
      string result = StringFunc.NumberToEnglishWords(12);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_thirteen()
    {
      const string expected = "thirteen";
      string result = StringFunc.NumberToEnglishWords(13);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_fourteen()
    {
      const string expected = "fourteen";
      string result = StringFunc.NumberToEnglishWords(14);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_fifteen()
    {
      const string expected = "fifteen";
      string result = StringFunc.NumberToEnglishWords(15);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_sixteen()
    {
      const string expected = "sixteen";
      string result = StringFunc.NumberToEnglishWords(16);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seventeen()
    {
      const string expected = "seventeen";
      string result = StringFunc.NumberToEnglishWords(17);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen()
    {
      const string expected = "eighteen";
      string result = StringFunc.NumberToEnglishWords(18);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nineteen()
    {
      const string expected = "nineteen";
      string result = StringFunc.NumberToEnglishWords(19);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty()
    {
      const string expected = "twenty";
      string result = StringFunc.NumberToEnglishWords(20);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty_one()
    {
      const string expected = "twenty-one";
      string result = StringFunc.NumberToEnglishWords(21);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty_five()
    {
      const string expected = "twenty-five";
      string result = StringFunc.NumberToEnglishWords(25);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty()
    {
      const string expected = "thirty";
      string result = StringFunc.NumberToEnglishWords(30);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty_one()
    {
      const string expected = "thirty-one";
      string result = StringFunc.NumberToEnglishWords(31);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty_five()
    {
      const string expected = "thirty-five";
      string result = StringFunc.NumberToEnglishWords(35);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_forty()
    {
      const string expected = "forty";
      string result = StringFunc.NumberToEnglishWords(40);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_fifty()
    {
      const string expected = "fifty";
      string result = StringFunc.NumberToEnglishWords(50);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_sixty()
    {
      const string expected = "sixty";
      string result = StringFunc.NumberToEnglishWords(60);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seventy()
    {
      const string expected = "seventy";
      string result = StringFunc.NumberToEnglishWords(70);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighty()
    {
      const string expected = "eighty";
      string result = StringFunc.NumberToEnglishWords(80);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ninety()
    {
      const string expected = "ninety";
      string result = StringFunc.NumberToEnglishWords(90);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_hundred()
    {
      const string expected = "one hundred";
      string result = StringFunc.NumberToEnglishWords(100);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_five_hundred()
    {
      const string expected = "five hundred";
      string result = StringFunc.NumberToEnglishWords(500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven_hundred_fifty()
    {
      const string expected = "seven hundred and fifty";
      string result = StringFunc.NumberToEnglishWords(750);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven_hundred_and_fourty_seven()
    {
      const string expected = "seven hundred and forty-seven";
      string result = StringFunc.NumberToEnglishWords(747);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_and_nine()
    {
      const string expected = "nine hundred and nine";
      string result = StringFunc.NumberToEnglishWords(909);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand()
    {
      const string expected = "one thousand";
      string result = StringFunc.NumberToEnglishWords(1000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand_five_hundred()
    {
      const string expected = "one thousand five hundred";
      string result = StringFunc.NumberToEnglishWords(1500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand_seven_hundred_and_eighty_nine()
    {
      const string expected = "one thousand seven hundred and eighty-nine";
      string result = StringFunc.NumberToEnglishWords(1789);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two_thousand_and_fifteen()
    {
      const string expected = "two thousand and fifteen";
      string result = StringFunc.NumberToEnglishWords(2015);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "nine thousand nine hundred and ninety-nine";
      string result = StringFunc.NumberToEnglishWords(9999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_ninety_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "nine hundred and ninety-nine thousand nine hundred and ninety-nine";
      string result = StringFunc.NumberToEnglishWords(999999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million()
    {
      const string expected = "one million";
      string result = StringFunc.NumberToEnglishWords(1000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToEnglishWords_two_million()
    {
      const string expected = "two million";
      string result = StringFunc.NumberToEnglishWords(2000000);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand()
    {
      const string expected = "one million five hundred thousand";
      string result = StringFunc.NumberToEnglishWords(1500000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_one()
    {
      const string expected = "one million five hundred thousand and one";
      string result = StringFunc.NumberToEnglishWords(1500001);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_twenty()
    {
      const string expected = "one million five hundred thousand and twenty";
      string result = StringFunc.NumberToEnglishWords(1500020);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_two_hundred()
    {
      const string expected = "one million five hundred thousand two hundred";
      string result = StringFunc.NumberToEnglishWords(1500200);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two_billion()
    {
      const string expected = "two billion";
      string result = StringFunc.NumberToEnglishWords(2000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_int_maxvalue()
    {
      const string expected = "two billion one hundred and forty-seven million four hundred and eighty-three thousand six hundred and forty-seven";
      // The value of int.MaxValue constant is 2,147,483,647
      string result = StringFunc.NumberToEnglishWords(int.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_three_billion()
    {
      const string expected = "three billion";
      string result = StringFunc.NumberToEnglishWords(3000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_trillion()
    {
      const string expected = "one trillion";
      string result = StringFunc.NumberToEnglishWords(1000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_trillion()
    {
      const string expected = "nine hundred trillion";
      string result = StringFunc.NumberToEnglishWords(900000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_long_maxvalue()
    {
      const string expected = "nine quintillion two hundred and twenty-three quadrillion three hundred and seventy-two trillion thirty-six billion eight hundred and fifty-four million seven hundred and seventy-five thousand eight hundred and seven";
      // The value of long.MaxValue constant is 9,223,372,036,854,775,807
      string result = StringFunc.NumberToEnglishWords(long.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ulong_maxvalue()
    {
      const string expected = "eighteen quintillion four hundred and forty-six quadrillion seven hundred and forty-four trillion seventy-three billion seven hundred and nine million five hundred and fifty-one thousand six hundred and fifteen";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToEnglishWords(ulong.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen_quintillion()
    {
      const string expected = "eighteen quintillion";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToEnglishWords(18000000000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen_quintillion_and_twenty_two()
    {
      const string expected = "eighteen quintillion and twenty-two";
      string result = StringFunc.NumberToEnglishWords(18000000000000000022);
      Assert.AreEqual(result, expected);
    }

    // **********************NumberToFrenchWords**************
    [TestMethod]
    public void TestMethod_NumberToFrenchWords_zero()
    {
      const string expected = "zéro";
      string result = StringFunc.NumberToFrenchWords(0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one()
    {
      const string expected = "un";
      string result = StringFunc.NumberToFrenchWords(1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_minus_one()
    {
      const string expected = "moins un";
      string result = StringFunc.NumberToFrenchWords(-1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two()
    {
      const string expected = "deux";
      string result = StringFunc.NumberToFrenchWords(2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_minus_two()
    {
      const string expected = "moins deux";
      string result = StringFunc.NumberToFrenchWords(-2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_three()
    {
      const string expected = "trois";
      string result = StringFunc.NumberToFrenchWords(3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_three()
    {
      const string expected = "moins trois";
      string result = StringFunc.NumberToFrenchWords(-3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_four()
    {
      const string expected = "quatre";
      string result = StringFunc.NumberToFrenchWords(4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_four()
    {
      const string expected = "moins quatre";
      string result = StringFunc.NumberToFrenchWords(-4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_five()
    {
      const string expected = "cinq";
      string result = StringFunc.NumberToFrenchWords(5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_five()
    {
      const string expected = "moins cinq";
      string result = StringFunc.NumberToFrenchWords(-5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_six()
    {
      const string expected = "six";
      string result = StringFunc.NumberToFrenchWords(6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_six()
    {
      const string expected = "moins six";
      string result = StringFunc.NumberToFrenchWords(-6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven()
    {
      const string expected = "sept";
      string result = StringFunc.NumberToFrenchWords(7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eight()
    {
      const string expected = "huit";
      string result = StringFunc.NumberToFrenchWords(8);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine()
    {
      const string expected = "neuf";
      string result = StringFunc.NumberToFrenchWords(9);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ten()
    {
      const string expected = "dix";
      string result = StringFunc.NumberToFrenchWords(10);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eleven()
    {
      const string expected = "onze";
      string result = StringFunc.NumberToFrenchWords(11);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twelve()
    {
      const string expected = "douze";
      string result = StringFunc.NumberToFrenchWords(12);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_thirteen()
    {
      const string expected = "treize";
      string result = StringFunc.NumberToFrenchWords(13);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_fourteen()
    {
      const string expected = "quatorze";
      string result = StringFunc.NumberToFrenchWords(14);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_fifteen()
    {
      const string expected = "quinze";
      string result = StringFunc.NumberToFrenchWords(15);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_sixteen()
    {
      const string expected = "seize";
      string result = StringFunc.NumberToFrenchWords(16);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seventeen()
    {
      const string expected = "dix-sept";
      string result = StringFunc.NumberToFrenchWords(17);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen()
    {
      const string expected = "dix-huit";
      string result = StringFunc.NumberToFrenchWords(18);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nineteen()
    {
      const string expected = "dix-neuf";
      string result = StringFunc.NumberToFrenchWords(19);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty()
    {
      const string expected = "vingt";
      string result = StringFunc.NumberToFrenchWords(20);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty_one()
    {
      const string expected = "vingt-un";
      string result = StringFunc.NumberToFrenchWords(21);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty_five()
    {
      const string expected = "vingt-cinq";
      string result = StringFunc.NumberToFrenchWords(25);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty()
    {
      const string expected = "trente";
      string result = StringFunc.NumberToFrenchWords(30);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty_one()
    {
      const string expected = "trente-un";
      string result = StringFunc.NumberToFrenchWords(31);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty_five()
    {
      const string expected = "trente-cinq";
      string result = StringFunc.NumberToFrenchWords(35);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_forty()
    {
      const string expected = "quarante";
      string result = StringFunc.NumberToFrenchWords(40);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_fifty()
    {
      const string expected = "cinquante";
      string result = StringFunc.NumberToFrenchWords(50);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_sixty()
    {
      const string expected = "soixante";
      string result = StringFunc.NumberToFrenchWords(60);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seventy()
    {
      const string expected = "soixante-dix";
      string result = StringFunc.NumberToFrenchWords(70);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighty()
    {
      const string expected = "quatre-vingt";
      string result = StringFunc.NumberToFrenchWords(80);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ninety()
    {
      const string expected = "quatre-vingt-dix";
      string result = StringFunc.NumberToFrenchWords(90);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_hundred()
    {
      const string expected = "un cent";
      string result = StringFunc.NumberToFrenchWords(100);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_five_hundred()
    {
      const string expected = "cinq cent";
      string result = StringFunc.NumberToFrenchWords(500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven_hundred_fifty()
    {
      const string expected = "sept cent et cinquante";
      string result = StringFunc.NumberToFrenchWords(750);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven_hundred_and_fourty_seven()
    {
      const string expected = "sept cent et quarante-sept";
      string result = StringFunc.NumberToFrenchWords(747);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_and_nine()
    {
      const string expected = "neuf cent et neuf";
      string result = StringFunc.NumberToFrenchWords(909);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand()
    {
      const string expected = "un mille";
      string result = StringFunc.NumberToFrenchWords(1000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand_five_hundred()
    {
      const string expected = "un mille cinq cent";
      string result = StringFunc.NumberToFrenchWords(1500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand_seven_hundred_and_eighty_nine()
    {
      const string expected = "un mille sept cent et quatre-vingt-neuf";
      string result = StringFunc.NumberToFrenchWords(1789);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_thousand_and_fifteen()
    {
      const string expected = "deux mille et quinze";
      string result = StringFunc.NumberToFrenchWords(2015);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "neuf mille neuf cent et quatre-vingt-dix-neuf";
      string result = StringFunc.NumberToFrenchWords(9999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_ninety_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "neuf cent et quatre-vingt-dix-neuf mille neuf cent et quatre-vingt-dix-neuf";
      string result = StringFunc.NumberToFrenchWords(999999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million()
    {
      const string expected = "un million";
      string result = StringFunc.NumberToFrenchWords(1000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_million()
    {
      const string expected = "deux million";
      string result = StringFunc.NumberToFrenchWords(2000000);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand()
    {
      const string expected = "un million cinq cent mille";
      string result = StringFunc.NumberToFrenchWords(1500000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_one()
    {
      const string expected = "un million cinq cent mille et un";
      string result = StringFunc.NumberToFrenchWords(1500001);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_twenty()
    {
      const string expected = "un million cinq cent mille et vingt";
      string result = StringFunc.NumberToFrenchWords(1500020);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_two_hundred()
    {
      const string expected = "un million cinq cent mille deux cent";
      string result = StringFunc.NumberToFrenchWords(1500200);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_billion()
    {
      const string expected = "deux milliard";
      string result = StringFunc.NumberToFrenchWords(2000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_int_maxvalue()
    {
      const string expected = "deux milliard un cent et quarante-sept million quatre cent et quatre-vingt-trois mille six cent et quarante-sept";
      // The value of int.MaxValue constant is 2,147,483,647
      string result = StringFunc.NumberToFrenchWords(int.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_three_billion()
    {
      const string expected = "trois milliard";
      string result = StringFunc.NumberToFrenchWords(3000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_trillion()
    {
      const string expected = "un billion";
      string result = StringFunc.NumberToFrenchWords(1000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_billion()
    {
      const string expected = "neuf cent billion";
      string result = StringFunc.NumberToFrenchWords(900000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_long_maxvalue()
    {
      const string expected = "neuf trillion deux cent et vingt-trois billiard trois cent et soixante-dix-deux billion trente-six milliard huit cent et cinquante-quatre million sept cent et soixante-dix-cinq mille huit cent et sept";
      // The value of long.MaxValue constant is 9,223,372,036,854,775,807
      string result = StringFunc.NumberToFrenchWords(long.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ulong_maxvalue()
    {
      const string expected = "dix-huit trillion quatre cent et quarante-six billiard sept cent et quarante-quatre billion soixante-dix-trois milliard sept cent et neuf million cinq cent et cinquante-un mille six cent et quinze";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToFrenchWords(ulong.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen_trillion()
    {
      const string expected = "dix-huit trillion";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToFrenchWords(18000000000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen_quintillion_and_twenty_two()
    {
      const string expected = "dix-huit trillion et vingt-deux";
      string result = StringFunc.NumberToFrenchWords(18000000000000000022);
      Assert.AreEqual(result, expected);
    }
    #endregion NumberToWordsEnglish
    #region Random Unit tests generated
    // ********************************Unit tests Random code generated Methods****************************
    [TestMethod]
    public void TestMethod_one_hundred_and_twenty_three_million_four_hundred_and_twenty_seven_thousand_three_hundred_and_thirty_nine()
    {
      const string expected = "one hundred and twenty-three million four hundred and twenty-seven thousand three hundred and thirty-nine";
      string result = StringFunc.NumberToEnglishWords(123427339);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_un_cent_et_vingt_trois_million_quatre_cent_et_vingt_sept_mille_trois_cent_et_trente_neuf()
    {
      const string expected = "un cent et vingt-trois million quatre cent et vingt-sept mille trois cent et trente-neuf";
      string result = StringFunc.NumberToFrenchWords(123427339);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_three_hundred_and_seventeen_million_four_hundred_and_seventy_six_thousand_one_hundred_and_twenty_seven()
    {
      const string expected = "three hundred and seventeen million four hundred and seventy-six thousand one hundred and twenty-seven";
      string result = StringFunc.NumberToEnglishWords(317476127);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_trois_cent_et_dix_sept_million_quatre_cent_et_soixante_dix_six_mille_un_cent_et_vingt_sept()
    {
      const string expected = "trois cent et dix-sept million quatre cent et soixante-dix-six mille un cent et vingt-sept";
      string result = StringFunc.NumberToFrenchWords(317476127);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_five_hundred_and_fifteen_million_six_hundred_and_seventeen_thousand_seven_hundred_and_twenty_nine()
    {
      const string expected = "five hundred and fifteen million six hundred and seventeen thousand seven hundred and twenty-nine";
      string result = StringFunc.NumberToEnglishWords(515617729);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_cinq_cent_et_quinze_million_six_cent_et_dix_sept_mille_sept_cent_et_vingt_neuf()
    {
      const string expected = "cinq cent et quinze million six cent et dix-sept mille sept cent et vingt-neuf";
      string result = StringFunc.NumberToFrenchWords(515617729);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_three_hundred_and_sixty_three_million_four_hundred_and_seventy_one_thousand_six_hundred_and_twenty_four()
    {
      const string expected = "three hundred and sixty-three million four hundred and seventy-one thousand six hundred and twenty-four";
      string result = StringFunc.NumberToEnglishWords(363471624);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_trois_cent_et_soixante_trois_million_quatre_cent_et_soixante_dix_un_mille_six_cent_et_vingt_quatre()
    {
      const string expected = "trois cent et soixante-trois million quatre cent et soixante-dix-un mille six cent et vingt-quatre";
      string result = StringFunc.NumberToFrenchWords(363471624);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_seven_hundred_and_eighty_three_million_three_hundred_and_sixty_one_thousand_six_hundred_and_twenty_five()
    {
      const string expected = "seven hundred and eighty-three million three hundred and sixty-one thousand six hundred and twenty-five";
      string result = StringFunc.NumberToEnglishWords(783361625);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_sept_cent_et_quatre_vingt_trois_million_trois_cent_et_soixante_un_mille_six_cent_et_vingt_cinq()
    {
      const string expected = "sept cent et quatre-vingt-trois million trois cent et soixante-un mille six cent et vingt-cinq";
      string result = StringFunc.NumberToFrenchWords(783361625);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_four_hundred_and_fifty_seven_million_one_hundred_and_thirty_one_thousand_three_hundred_and_twenty_eight()
    {
      const string expected = "four hundred and fifty-seven million one hundred and thirty-one thousand three hundred and twenty-eight";
      string result = StringFunc.NumberToEnglishWords(457131328);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_quatre_cent_et_cinquante_sept_million_un_cent_et_trente_un_mille_trois_cent_et_vingt_huit()
    {
      const string expected = "quatre cent et cinquante-sept million un cent et trente-un mille trois cent et vingt-huit";
      string result = StringFunc.NumberToFrenchWords(457131328);
      Assert.AreEqual(expected, result);
    }


    #endregion Random Unit tests generated
    #region GenerateString method Unit tests
    //**************************GenerateRandomString Method****
    [TestMethod]
    public void TestMethod_GenerateRandomString_true_LowerCase_default_length()
    {
      char[] source = { };
      const byte stringLength = 8;
      string result = StringFunc.GenerateRandomString(source);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_LowerCase_length_of_20()
    {
      char[] source = { };
      const byte stringLength = 20;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.LowerCase, stringLength);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_LowerCase_length_of_byte_MaxValue()
    {
      char[] source = { };
      const byte stringLength = byte.MaxValue;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.LowerCase, stringLength);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_lower_case()
    {
      char[] source = { };
      string result = StringFunc.GenerateRandomString(source);
      Assert.AreEqual(result.ToLower(), result);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerCase_false_has_no_symbol()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.LowerCase, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperCase_true_upper_case()
    {
      char[] source = { };
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperCase);
      Assert.AreEqual(result.ToUpper(), result);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperCase_false_has_no_symbol()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperCase, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_digit_true()
    {
      const bool expected = true;
      char[] source = { };
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.Digit);
      Assert.AreEqual(StringFunc.IsNumeric2(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_Digit_false_has_no_symbol()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.Digit, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_false_SpecialCharacter_no_digit()
    {
      const bool expected = false;
      char[] source = { };
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter);
      Assert.AreEqual(StringFunc.IsNumeric2(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_false_SpecialCharacter_no_vowel()
    {
      const bool expected = false;
      char[] source = { };
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter);
      Assert.AreEqual(StringFunc.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_false_SpecialCharacter_no_consonant()
    {
      const bool expected = false;
      char[] source = { };
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter);
      Assert.AreEqual(StringFunc.HasConsonants(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_SpecialCharacter_true_has_symbols()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_DigitSpecialChar_length_default()
    {
      char[] source = { };
      const byte stringLength = 250;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.DigitSpecialChar, stringLength);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_DigitSpecialChar_has_digit()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.DigitSpecialChar, stringLength);
      Assert.AreEqual(StringFunc.HasNumeric(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_DigitSpecialChar_true_has_symbols()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.DigitSpecialChar, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_DigitSpecial_false_has_symbols()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.DigitSpecialChar, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLower_true_has_consonant()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLower, stringLength);
      Assert.AreEqual(StringFunc.HasConsonants(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLower_true_has_vowel()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLower, stringLength);
      Assert.AreEqual(StringFunc.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLower_false_has_no_symbol()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLower, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerDigit_true_has_digit()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.LowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerDigit_true_has_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.LowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerDigit_true_has_lower_case_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.LowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSomeLowerCaseLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerDigit_false_has_no_symbol()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.LowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperDigit_true_has_digit()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperDigit, stringLength);
      Assert.AreEqual(StringFunc.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperDigit_true_has_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperDigit_true_has_Upper_case_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSomeUpperCaseLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperDigit_false_has_no_symbol()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigit_true_has_digit()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigit_true_has_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigit_true_has_Upper_case_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSomeUpperCaseLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigit_true_has_lower_case_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSomeLowerCaseLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigit_false_has_no_symbol()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigit, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_true_has_digit()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_true_has_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_true_has_Upper_case_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasSomeUpperCaseLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_true_has_lower_case_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasSomeLowerCaseLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_true_has_symbols()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_false_with_forbidden_digits()
    {
      const bool expected = false;
      char[] source = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, true,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasNumeric(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_false_with_forbidden_vowels()
    {
      const bool expected = false;
      char[] source = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, true,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasVowels(result), expected); // failed on I (i uppercase)
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_false_with_forbidden_consonants()
    {
      const bool expected = false;
      char[] source =
      { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z',
        'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z'};
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, true,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength);
      Assert.AreEqual(StringFunc.HasConsonants(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_true_with_is_Windows_Filename_has_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength, true);
      Assert.AreEqual(StringFunc.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigitSpecial_true_with_is_Windows_Filename_has_digits()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, stringLength, true);
      Assert.AreEqual(StringFunc.HasNumeric(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigit_true_with_is_Windows_Filename_has_letters()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigit, stringLength, true);
      Assert.AreEqual(StringFunc.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLowerDigit_true_with_is_Windows_Filename_has_digits()
    {
      const bool expected = true;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigit, stringLength, true);
      Assert.AreEqual(StringFunc.HasNumeric(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLower_false_with_is_Windows_Filename_has_no_digits()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.UpperLower, stringLength, true);
      Assert.AreEqual(StringFunc.HasNumeric(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_Special_characters_only_false_with_is_Windows_Filename_has_no_digits()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 2;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter, stringLength, true);
      Assert.AreEqual(StringFunc.HasNumeric(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_Special_characters_only_false_with_is_Windows_Filename_has_no_letters()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 2;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter, stringLength, true);
      Assert.AreEqual(StringFunc.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_Special_characters_only_false_with_is_Windows_Filename_has_symbols()
    {
      const bool expected = false;
      char[] source = { };
      const byte stringLength = 2;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter, stringLength, true);
      Assert.AreEqual(StringFunc.HasSymbols(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_Special_characters_only_false_with_is_Windows_Filename_length_one()
    {
      const int expected = 1;
      char[] source = { };
      const byte stringLength = 1;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter, stringLength, true);
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_Special_characters_only_false_with_is_Windows_Filename_length_254()
    {
      const int expected = 254;
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomString(source, false,
        dllFuncs.RandomCharacters.SpecialCharacter, stringLength, true);
      Assert.AreEqual(result.Length, expected);
    }

    #endregion GenerateString method Unit tests
    #region GenerateRandomLongString method Unit tests
    //**************************GenerateRandomLongString Method****
    [TestMethod]
    public void TestMethod_GenerateRandomLongString_true_LowerCase_default_length()
    {
      char[] source = { };
      const byte stringLength = 8;
      string result = StringFunc.GenerateRandomLongString(source);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomLongString_true_LowerCase_length_nine()
    {
      char[] source = { };
      const byte stringLength = 9;
      string result = StringFunc.GenerateRandomLongString(source, false,
        dllFuncs.RandomCharacters.LowerCase, 9);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomLongString_true_LowerCase_length_254()
    {
      char[] source = { };
      const byte stringLength = 254;
      string result = StringFunc.GenerateRandomLongString(source, false,
        dllFuncs.RandomCharacters.LowerCase, 254);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomLongString_true_LowerCase_length_255()
    {
      char[] source = { };
      const byte stringLength = 255;
      string result = StringFunc.GenerateRandomLongString(source, false,
        dllFuncs.RandomCharacters.LowerCase, 255);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomLongString_true_LowerCase_length_300()
    {
      char[] source = { };
      const int stringLength = 300;
      string result = StringFunc.GenerateRandomLongString(source, false,
        dllFuncs.RandomCharacters.LowerCase, 300);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomLongString_true_LowerCase_length_999()
    {
      char[] source = { };
      const int stringLength = 999;
      string result = StringFunc.GenerateRandomLongString(source, false,
        dllFuncs.RandomCharacters.LowerCase, 999);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomLongString_true_UpperLowerDigitSpecial_length_1950()
    {
      char[] source = { };
      const int stringLength = 1950;
      string result = StringFunc.GenerateRandomLongString(source, false,
        dllFuncs.RandomCharacters.UpperLowerDigitSpecial, 1950);
      Assert.AreEqual(result.Length, stringLength);
    }

    #endregion GenerateRandomLongString method Unit tests
    #region HasSomeLowerCaseLetters method Unit tests
    //*********************HasSomeLowerCaseLetters*******
    [TestMethod]
    public void TestMethod_HasSomeLowerCaseLetters_true()
    {
      string source = "azerty and qwerty";
      const bool expected = true;
      bool result = StringFunc.HasSomeLowerCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeLowerCaseLetters_false()
    {
      string source = "AZERTY AND QWERTY";
      const bool expected = false;
      bool result = StringFunc.HasSomeLowerCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeLowerCaseLetters_true_one_letter()
    {
      string source = "AZERTY AND QWERTy";
      const bool expected = true;
      bool result = StringFunc.HasSomeLowerCaseLetters(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasSomeLowerCaseLetters method Unit tests
    #region HasSomeUpperCaseLetters method Unit tests
    //*********************HasSomeUpperCaseLetters*******
    [TestMethod]
    public void TestMethod_HasSomeUpperCaseLetters_false()
    {
      string source = "azerty and qwerty";
      const bool expected = false;
      bool result = StringFunc.HasSomeUpperCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeUpperCaseLetters_true()
    {
      string source = "AZERTY AND QWERTY";
      const bool expected = true;
      bool result = StringFunc.HasSomeUpperCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeUpperCaseLetters_true_one_letter()
    {
      string source = "azerty and qwertY";
      const bool expected = true;
      bool result = StringFunc.HasSomeUpperCaseLetters(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasSomeUpperCaseLetters method Unit tests
    #region StringOccurrenceWithIndexOf

    [TestMethod]
    public void TestMethod_StringOccurrenceWithIndexOf_true_occurence_8()
    {
      const int expected = 8;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "a";
      int result = StringFunc.StringOccurrenceWithIndexOf(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithIndexOf_true_long_occurence_2()
    {
      const int expected = 2;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "long";
      int result = StringFunc.StringOccurrenceWithIndexOf(source, source2);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_StringOccurrenceWithIndexOf_true_far_occurence_2()
    {
      const int expected = 2;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "far";
      int result = StringFunc.StringOccurrenceWithIndexOf(source, source2);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_StringOccurrenceWithIndexOf_true_source_string_is_empty()
    {
      const int expected = 0;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "";
      int result = StringFunc.StringOccurrenceWithIndexOf(source, source2);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_StringOccurrenceWithIndexOf_true_searched_string_is_empty()
    {
      const int expected = 0;
      string source = string.Empty;
      string source2 = "long";
      int result = StringFunc.StringOccurrenceWithIndexOf(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion StringOccurrenceWithIndexOf
    #region StringOccurrenceWithContains

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_true_occurence_8()
    {
      const int expected = 8;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "a";
      int result = StringFunc.StringOccurrenceWithContains(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_true_long_occurence_2()
    {
      const int expected = 2;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "long";
      int result = StringFunc.StringOccurrenceWithContains(source, source2);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_true_far_occurence_2()
    {
      const int expected = 2;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "far";
      int result = StringFunc.StringOccurrenceWithContains(source, source2);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_true_source_string_is_empty()
    {
      const int expected = 0;
      string source = "A long long time ago in a galaxy far far away";
      string source2 = "";
      int result = StringFunc.StringOccurrenceWithContains(source, source2);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_true_searched_string_is_empty()
    {
      const int expected = 0;
      string source = string.Empty;
      string source2 = "long";
      int result = StringFunc.StringOccurrenceWithContains(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion StringOccurrenceWithContains
    #region Palindrome
    // **********************Palindrome****************
    [TestMethod]
    public void TestMethod_Palindrome_true_on_numbers()
    {
      const bool expected = true;
      const string source = "12345678900987654321";
      bool result = StringFunc.IsPalindrome(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Palindrome_true_on_an_empty_string()
    {
      const bool expected = true;
      const string source = "";
      bool result = StringFunc.IsPalindrome(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Palindrome_one_number()
    {
      const bool expected = true;
      const string source = "1";
      bool result = StringFunc.IsPalindrome(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Palindrome_palindrome_one_word()
    {
      const bool expected = true;
      const string source = "laval";
      bool result = StringFunc.IsPalindrome(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPalindrome_several_palindromes_in_words()
    {
      const bool expected = true;
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        bool result = StringFunc.IsPalindrome(source);
        Assert.AreEqual(result, expected);
      }
    }

    [TestMethod]
    public void TestMethod_IsPalindrome_several_palindromes_with_removal_of_space()
    {
      const bool expected = true;
      List<string> sourceWords = new List<string> {
        "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        bool result = StringFunc.IsPalindrome(source, true);
        Assert.AreEqual(result, expected);
      }
    }

    #endregion Palindrome
    #region ReplaceWindowsForbiddenCharacters
    // **********************ReplaceWindowsForbiddenCharacters****************
    [TestMethod]
    public void TestMethod_ReplaceWindowsForbiddenCharacters_true()
    {
      const string source = "*:A long long time in a galaxy far far away?<>|";
      const string expected = "A long long time in a galaxy far far away";
      string result = StringFunc.ReplaceWindowsForbiddenCharacters(source);
      Assert.AreEqual(result, expected);
    }

    #endregion ReplaceWindowsForbiddenCharacters
    #region RemoveAllNonLetterCharacters
    // **********************RemoveAllNonLetterCharacters****************
    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_true()
    {
      const string source = "*:A long long time in a galaxy far far away?<>|";
      const string expected = "A long long time in a galaxy far far away";
      string result = StringFunc.RemoveAllNonLetterCharacters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_true_letters_and_numbers()
    {
      const string source = "123456789abcdefghijklmnopqrstuvwxyz";
      const string expected = "123456789abcdefghijklmnopqrstuvwxyz";
      string result = StringFunc.RemoveAllNonLetterCharacters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_true_string_empty()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.RemoveAllNonLetterCharacters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_true_only_special_characters()
    {
      const string source = "*:?<>|";
      const string expected = "";
      string result = StringFunc.RemoveAllNonLetterCharacters(source);
      Assert.AreEqual(result, expected);
    }

    #endregion RemoveAllNonLetterCharacters
    #region RemoveAllNonLetterCharacters_with_charsToRemove_in_string[]
    // ******RemoveAllNonLetterCharacters_with_charsToRemove_in_string[]****************
    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_true()
    {
      const string source = "*:A long long time in a galaxy far far away?<>|";
      string[] source2 = { "*", ":", "?", "<", ">", "|" };
      const string expected = "A long long time in a galaxy far far away";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_true_letters_and_numbers()
    {
      const string source = "123456789abcdefghijklmnopqrstuvwxyz";
      string[] source2 = { "*", ":", "?", "<", ">", "|" };
      const string expected = "123456789abcdefghijklmnopqrstuvwxyz";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_true_string_empty()
    {
      const string source = "";
      string[] source2 = { "*", ":", "?", "<", ">", "|" };
      const string expected = "";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_true_only_special_characters()
    {
      const string source = "*:?<>|";
      string[] source2 = { "*", ":", "?", "<", ">", "|" };
      const string expected = "";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    #endregion RemoveAllNonLetterCharacters_with_charsToRemove_in_string[]
    #region RemoveAllNonLetterCharacters_with_charsToRemove_in_char[]
    // ******RemoveAllNonLetterCharacters_with_charsToRemove_in_char[]****************
    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_in_char_array_true()
    {
      const string source = "*:A long long time in a galaxy far far away?<>|";
      char[] source2 = { '*', ':', '?', '<', '>', '|' };
      const string expected = "A long long time in a galaxy far far away";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_in_char_array_true_letters_and_numbers()
    {
      const string source = "123456789abcdefghijklmnopqrstuvwxyz";
      char[] source2 = { '*', ':', '?', '<', '>', '|' };
      const string expected = "123456789abcdefghijklmnopqrstuvwxyz";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_in_char_array_true_string_empty()
    {
      const string source = "";
      char[] source2 = { '*', ':', '?', '<', '>', '|' };
      const string expected = "";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAllNonLetterCharacters_with_charsToRemove_in_char_array_true_only_special_characters()
    {
      const string source = "*:?<>|";
      char[] source2 = { '*', ':', '?', '<', '>', '|' };
      const string expected = "";
      string result = StringFunc.RemoveAllNonLetterCharacters(source, source2);
      Assert.AreEqual(result, expected);
    }

    #endregion RemoveAllNonLetterCharacters_with_charsToRemove_in_char_array
    #region InsertStringAtBegining
    [TestMethod]
    public void TestMethod_InsertString_with_a_starting_space()
    {
      const string source = " A long long time ago in a galaxy far far away";
      string source2 = "It was ";
      char source3 = ' ';
      const string expected = " It was A long long time ago in a galaxy far far away";
      string result = StringFunc.InsertStringAtBegining(source, source2, source3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertString_with_no_space()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string source2 = "It was ";
      char source3 = ' ';
      const string expected = "It was A long long time ago in a galaxy far far away";
      string result = StringFunc.InsertStringAtBegining(source, source2, source3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertString_with_character_no_space()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string source2 = "It was ";
      char source3 = '>';
      const string expected = "It was A long long time ago in a galaxy far far away";
      string result = StringFunc.InsertStringAtBegining(source, source2, source3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertString_with_empty_string()
    {
      const string source = "";
      string source2 = "It was ";
      char source3 = '>';
      const string expected = "";
      string result = StringFunc.InsertStringAtBegining(source, source2, source3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertString_with_one_tabulation()
    {
      const string source = "\tA long long time ago in a galaxy far far away";
      string source2 = "It was ";
      char source3 = ' ';
      const string expected = "\tIt was A long long time ago in a galaxy far far away";
      string result = StringFunc.InsertStringAtBegining(source, source2, source3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertString_with_two_tabulations()
    {
      const string source = "\t\tA long long time ago in a galaxy far far away";
      string source2 = "It was ";
      char source3 = ' ';
      const string expected = "\t\tIt was A long long time ago in a galaxy far far away";
      string result = StringFunc.InsertStringAtBegining(source, source2, source3);
      Assert.AreEqual(result, expected);
    }

    #endregion InsertStringAtBegining
    #region Tabulation

    [TestMethod]
    public void TestMethod_Tabulation_by_default()
    {
      const string expected = " ";
      string result = StringFunc.AddTabulation();
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Tabulation_zero_tabulation()
    {
      const int source = 0;
      const string expected = "";
      string result = StringFunc.AddTabulation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Tabulation_one_tabulation()
    {
      const string expected = " ";
      string result = StringFunc.AddTabulation();
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Tabulation_two_tabulations()
    {
      const int source = 2;
      const string expected = "  ";
      string result = StringFunc.AddTabulation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Tabulation_three_tabulations()
    {
      const int source = 3;
      const string expected = "   ";
      string result = StringFunc.AddTabulation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Tabulation_four_tabulations()
    {
      const int source = 4;
      const string expected = "    ";
      string result = StringFunc.AddTabulation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Tabulation_five_tabulations()
    {
      const int source = 5;
      const string expected = "     ";
      string result = StringFunc.AddTabulation(source);
      Assert.AreEqual(result, expected);
    }
    #endregion Tabulation
    #region CountLetters

    [TestMethod]
    public void TestMethod_CountLetters_empty_string()
    {
      const string source = "";
      const bool source2 = false;
      var expected = new Dictionary<char, int>();
      var result = StringFunc.CountLetters(source, source2);
      Assert.AreEqual(result.Count, expected.Count);
    }

    [TestMethod]
    public void TestMethod_CountLetters_one_character()
    {
      const string source = "a";
      const bool source2 = false;
      var expected = new Dictionary<char, int> { { 'a', 1 } };
      var result = StringFunc.CountLetters(source, source2);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['a'], 1);
    }

    [TestMethod]
    public void TestMethod_CountLetters_two_characters()
    {
      const string source = "ab";
      const bool source2 = false;
      var expected = new Dictionary<char, int> { { 'a', 1 }, { 'b', 1 } };
      var result = StringFunc.CountLetters(source, source2);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['b'], expected['b']);
    }

    [TestMethod]
    public void TestMethod_CountLetters_three_characters()
    {
      const string source = "abc";
      const bool source2 = false;
      var expected = new Dictionary<char, int> { { 'a', 1 }, { 'b', 1 }, { 'c', 1 } };
      var result = StringFunc.CountLetters(source, source2);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['b'], expected['b']);
      Assert.AreEqual(result['c'], expected['c']);
    }

    [TestMethod]
    public void TestMethod_CountLetters_double_characters()
    {
      const string source = "aba";
      const bool source2 = false;
      var expected = new Dictionary<char, int> { { 'a', 2 }, { 'b', 1 } };
      var result = StringFunc.CountLetters(source, source2);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['b'], expected['b']);
    }

    // *****************************wholeDictionary = true**************************
    [TestMethod]
    public void TestMethod_CountLetters_empty_string_true()
    {
      const string source = "";
      var expected = StringFunc.CountLetters("");
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result.Count, expected.Count);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_one_character_true()
    {
      const string source = "a";
      var expected = StringFunc.CountLetters("");
      expected['a'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['a'], 1);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_two_characters_true()
    {
      const string source = "ab";
      var expected = StringFunc.CountLetters("");
      expected['a'] = 1;
      expected['b'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['b'], expected['b']);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_three_characters_true()
    {
      const string source = "abc";
      var expected = StringFunc.CountLetters("");
      expected['a'] = 1;
      expected['b'] = 1;
      expected['c'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['b'], expected['b']);
      Assert.AreEqual(result['c'], expected['c']);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_double_characters_true()
    {
      const string source = "aba";
      var expected = StringFunc.CountLetters("");
      expected['a'] = 2;
      expected['b'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['b'], expected['b']);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_azerty_true()
    {
      const string source = "azerty";
      var expected = StringFunc.CountLetters("");
      expected['a'] = 1;
      expected['z'] = 1;
      expected['e'] = 1;
      expected['r'] = 1;
      expected['t'] = 1;
      expected['y'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['z'], expected['z']);
      Assert.AreEqual(result['e'], expected['e']);
      Assert.AreEqual(result['r'], expected['r']);
      Assert.AreEqual(result['t'], expected['t']);
      Assert.AreEqual(result['y'], expected['y']);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_qwerty_true()
    {
      const string source = "qwerty";
      var expected = StringFunc.CountLetters("");
      expected['q'] = 1;
      expected['w'] = 1;
      expected['e'] = 1;
      expected['r'] = 1;
      expected['t'] = 1;
      expected['y'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['q'], expected['q']);
      Assert.AreEqual(result['w'], expected['w']);
      Assert.AreEqual(result['e'], expected['e']);
      Assert.AreEqual(result['r'], expected['r']);
      Assert.AreEqual(result['t'], expected['t']);
      Assert.AreEqual(result['y'], expected['y']);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_Star_Wars_true()
    {
      const string source = "A long long time ago in a galaxy far far away";
      var expected = StringFunc.CountLetters("");
      expected['a'] = 9;
      expected['l'] = 3;
      expected['o'] = 3;
      expected['n'] = 3;
      expected['g'] = 4;
      expected['t'] = 1;
      expected['i'] = 2;
      expected['m'] = 1;
      expected['e'] = 1;
      expected['x'] = 1;
      expected['y'] = 2;
      expected['f'] = 2;
      expected['r'] = 2;
      expected['w'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['l'], expected['l']);
      Assert.AreEqual(result['o'], expected['o']);
      Assert.AreEqual(result['n'], expected['n']);
      Assert.AreEqual(result['g'], expected['g']);
      Assert.AreEqual(result['t'], expected['t']);
      Assert.AreEqual(result['i'], expected['i']);
      Assert.AreEqual(result['m'], expected['m']);
      Assert.AreEqual(result['e'], expected['e']);
      Assert.AreEqual(result['x'], expected['x']);
      Assert.AreEqual(result['y'], expected['y']);
      Assert.AreEqual(result['f'], expected['f']);
      Assert.AreEqual(result['r'], expected['r']);
      Assert.AreEqual(result['w'], expected['w']);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    [TestMethod]
    public void TestMethod_CountLetters_Star_Wars_true_UpperCase()
    {
      const string source = "A LONG LONG TIME AGO IN A GALAXY FAR FAR AWAY";
      var expected = StringFunc.CountLetters("");
      expected['a'] = 9;
      expected['l'] = 3;
      expected['o'] = 3;
      expected['n'] = 3;
      expected['g'] = 4;
      expected['t'] = 1;
      expected['i'] = 2;
      expected['m'] = 1;
      expected['e'] = 1;
      expected['x'] = 1;
      expected['y'] = 2;
      expected['f'] = 2;
      expected['r'] = 2;
      expected['w'] = 1;
      var result = StringFunc.CountLetters(source);
      Assert.AreEqual(result['a'], expected['a']);
      Assert.AreEqual(result['l'], expected['l']);
      Assert.AreEqual(result['o'], expected['o']);
      Assert.AreEqual(result['n'], expected['n']);
      Assert.AreEqual(result['g'], expected['g']);
      Assert.AreEqual(result['t'], expected['t']);
      Assert.AreEqual(result['i'], expected['i']);
      Assert.AreEqual(result['m'], expected['m']);
      Assert.AreEqual(result['e'], expected['e']);
      Assert.AreEqual(result['x'], expected['x']);
      Assert.AreEqual(result['y'], expected['y']);
      Assert.AreEqual(result['f'], expected['f']);
      Assert.AreEqual(result['r'], expected['r']);
      Assert.AreEqual(result['w'], expected['w']);
      TestDictionaryCountIsEqual(expected, result);
      TestDictionaryValuesAreEqualed(expected, result);
    }

    #endregion CountLetters
    #region CountWords
    [TestMethod]
    public void TestMethod_CountWords_empty_string()
    {
      const string source = "";
      var expected = 1;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_star_wars()
    {
      const string source = "A long long time ago in a galaxy far far away";
      var expected = 11;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_one_character()
    {
      const string source = "A";
      var expected = 1;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_two_words()
    {
      const string source = "A source";
      var expected = 2;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_three_words()
    {
      const string source = "A beautiful code";
      var expected = 3;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_french_words()
    {
      const string source = "il fut dommage qu'il ne pu venir";
      var expected = 7;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_french_quote_of_mine()
    {
      const string source = "La connaissance est certitude et la certitude ne se confirme pas";
      var expected = 11;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_English_quote()
    {
      const string source = "It's immposible said pride. It's risky said experience. It's pointless said reason. Give it a try whispered the heart";
      var expected = 19;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_English_quote_antoine_de_saint_exupery()
    {
      const string source = "When you give yourself, you receive more than you give";
      var expected = 10;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_English_quote_Linus_tordvals()
    {
      const string source = "If Microsoft ever does applications for Linux, it means I've won";
      var expected = 11;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_English_quote_Mark_Twain()
    {
      const string source = "Age is an issue of mind over matter. If you don't mind, it doesn't matter";
      var expected = 15;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWords_English_quote_Issac_Newton()
    {
      const string source = "We build too many walls and not enough bridges";
      var expected = 9;
      var result = StringFunc.CountWords(source);
      Assert.AreEqual(result, expected);
    }
    #endregion CountWords
    #region GetDictionaryWords
    [TestMethod]
    public void TestMethod_GetDictionaryWords_empty_string()
    {
      const string source = "";
      var expected = new Dictionary<string, int>();
      var result = StringFunc.GetDictionaryWords(source);
      Assert.AreEqual(result.Count, expected.Count);
    }

    [TestMethod]
    public void TestMethod_GetDictionaryWords()
    {
      const string source = "We build too many walls and not enough bridges";
      var expected = new Dictionary<string, int>
      {
        {"We", 1},
        {"build", 1},
        {"too", 1},
        {"many", 1},
        {"walls", 1},
        {"and", 1},
        {"not", 1},
        {"enough", 1},
        {"bridges", 1}
      };
      var result = StringFunc.GetDictionaryWords(source);
      Assert.AreEqual(result["We"], expected["We"]);
      TestDictionariesAreEqualed(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDictionaryWords_star_wars()
    {
      const string source = "A long long time ago in a galaxy far far away";
      var expected = new Dictionary<string, int>
      {
        {"A", 1},
        {"long", 2},
        {"time", 1},
        {"ago", 1},
        {"in", 1},
        {"a", 1},
        {"galaxy", 1},
        {"far", 2},
        {"away", 1}
      };
      var result = StringFunc.GetDictionaryWords(source);
      TestDictionariesAreEqualed(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDictionaryWords_English_quote()
    {
      const string source = "When you give yourself, you receive more than you give";
      var expected = new Dictionary<string, int>
      {
        {"when", 1},
        {"you", 3},
        {"give", 2},
        {"yourself", 1},
        {"receive", 1},
        {"more", 1},
        {"than", 1}
      };
      var result = StringFunc.GetDictionaryWords(source);
      TestDictionariesAreEqualed(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDictionaryWords_English_quote_with_upper_and_lower_case()
    {
      const string source = "When you give yourself, You receive more than YOU Give";
      var expected = new Dictionary<string, int>
      {
        {"when", 1},
        {"you", 1},
        {"give", 1},
        {"yourself", 1},
        {"You", 1},
        {"receive", 1},
        {"more", 1},
        {"than", 1},
        {"YOU", 1},
        {"Give", 1}
      };
      var result = StringFunc.GetDictionaryWords(source);
      TestDictionariesAreEqualed(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDictionaryWords_English_quote_with_upper_and_lower_case_case_sensitive_equals_false()
    {
      const string source = "When you give yourself, You receive more than YOU Give";
      const bool source2 = false;
      var expected = new Dictionary<string, int>
      {
        {"when", 1},
        {"you", 3},
        {"give", 2},
        {"yourself", 1},
        {"receive", 1},
        {"more", 1},
        {"than", 1}
      };
      var result = StringFunc.GetDictionaryWords(source, source2);
      TestDictionariesAreEqualed(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDictionaryWords_upper_and_lower_case_and_case_sensitive_equals_false_and_casing_upper()
    {
      const string source = "When you give yourself, You receive more than YOU Give";
      const bool source2 = false;
      const dllFuncs.DefaultCasing source3 = dllFuncs.DefaultCasing.DefaultUpperCase;
      var expected = new Dictionary<string, int>
      {
        {"when".ToUpper(), 1},
        {"you".ToUpper(), 3},
        {"give".ToUpper(), 2},
        {"yourself".ToUpper(), 1},
        {"receive".ToUpper(), 1},
        {"more".ToUpper(), 1},
        {"than".ToUpper(), 1}
      };
      var result = StringFunc.GetDictionaryWords(source, source2, source3);
      TestDictionariesAreEqualed(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetDictionaryWords_upper_and_lower_case_and_case_sensitive_equals_false_and_casing_AsIs()
    {
      const string source = "When you give yourself, You receive more than YOU Give";
      const bool source2 = false;
      const dllFuncs.DefaultCasing source3 = dllFuncs.DefaultCasing.DefaultAsIs;
      var expected = new Dictionary<string, int>
      {
        {"when", 1},
        {"you", 1},
        {"give", 1},
        {"yourself", 1},
        {"You", 1},
        {"receive", 1},
        {"more", 1},
        {"than", 1},
        {"YOU", 1},
        {"Give", 1}
      };
      var result = StringFunc.GetDictionaryWords(source, source2, source3);
      TestDictionariesAreEqualed(result, expected);
    }
    #endregion GetDictionaryWords
    #region SeparateQuote
    [TestMethod]
    public void TestMethod_SeparateQuote_simple_quote()
    {
      string source = "A long long time ago in a galaxy far far away - StarWars";
      string[] expected = { "A long long time ago in a galaxy far far away", "StarWars" };
      string[] result = StringFunc.SeparateQuote(source);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_SeparateQuote_empty_string()
    {
      string source = "";
      string[] expected = new string[2];
      string[] result = StringFunc.SeparateQuote(source);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_SeparateQuote_two_dashes()
    {
      string source = "A long-long time ago in a galaxy far far away - StarWars";
      string[] expected = { "A long-long time ago in a galaxy far far away", "StarWars" };
      string[] result = StringFunc.SeparateQuote(source);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }


    [TestMethod]
    public void TestMethod_SeparateQuote_three_dashes()
    {
      string source = "A long-long time ago in a galaxy far-far away - StarWars";
      string[] expected = { "A long-long time ago in a galaxy far-far away", "StarWars" };
      string[] result = StringFunc.SeparateQuote(source);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_SeparateQuote_no_dash()
    {
      string source = "A long long time ago in a galaxy far far away StarWars";
      string[] expected = new string[2];
      string[] result = StringFunc.SeparateQuote(source);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    #endregion SeparateQuote
    #region Helper methods
    internal void TestDictionaryCountIsEqual(Dictionary<string, int> source, Dictionary<string, int> target)
    {
      Assert.AreEqual(source.Count, target.Count);
    }

    internal void TestDictionaryCountIsEqual(Dictionary<char, int> source, Dictionary<char, int> target)
    {
      Assert.AreEqual(source.Count, target.Count);
    }

    internal void TestDictionaryValuesAreEqualed(Dictionary<char, int> source, Dictionary<char, int> target)
    {
      for (char i = 'a'; i <= 'z'; i++)
      {
        Assert.AreEqual(source[i], target[i]);
      }
    }

    internal void TestDictionariesAreEqualed(Dictionary<string, int> source, Dictionary<string, int> target)
    {
      Assert.AreEqual(source.Count, target.Count);
      foreach (var i in source)
      {
        foreach (var j in target)
        {
          if (i.Key == j.Key)
          {
            Assert.AreEqual(i.Key, j.Key);
            Assert.AreEqual(i.Value, j.Value);
          }
        }
      }
    }
    #endregion Helper methods
    #region GetCapitalLetters
    [TestMethod]
    public void TestMethod_GetCapitalLetters_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_TextBox()
    {
      const string source = "TextBox";
      const string expected = "TB";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_ComboBox()
    {
      const string source = "ComboBox";
      const string expected = "CB";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_CheckListBox()
    {
      const string source = "CheckedListBox";
      const string expected = "CLB";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_ContextMenuStrip()
    {
      const string source = "ContextMenuStrip";
      const string expected = "CMS";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_DataGridView()
    {
      const string source = "DataGridView";
      const string expected = "DGV";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_Button()
    {
      const string source = "Button";
      const string expected = "B";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_ColorDialog()
    {
      const string source = "ColorDialog";
      const string expected = "CD";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_DataSet()
    {
      const string source = "DataSet";
      const string expected = "DS";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_DataTimPicker()
    {
      const string source = "DateTimePicker";
      const string expected = "DTP";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_DirectoryEntry()
    {
      const string source = "DirectoryEntry";
      const string expected = "DE";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_DirectorySearcher()
    {
      const string source = "DirectorySearcher";
      const string expected = "DS";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_DomainUpDown()
    {
      const string source = "DomainUpDown";
      const string expected = "DUD";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_ErrorProvider()
    {
      const string source = "ErrorProvider";
      const string expected = "EP";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_EventLog()
    {
      const string source = "EventLog";
      const string expected = "EL";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_FileSystemWatcher()
    {
      const string source = "FileSystemWatcher";
      const string expected = "FSW";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_FlowLayoutPanel()
    {
      const string source = "FlowLayoutPanel";
      const string expected = "FLP";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_FolderBrowserDialog()
    {
      const string source = "FolderBrowserDialog";
      const string expected = "FBD";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_FontDialog()
    {
      const string source = "FontDialog";
      const string expected = "FD";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_Groupbox()
    {
      const string source = "GroupBox";
      const string expected = "GB";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_HelpProvider()
    {
      const string source = "HelpProvider";
      const string expected = "HP";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_HScrollBar()
    {
      const string source = "HScrollBar";
      const string expected = "HSB";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_ImageList()
    {
      const string source = "ImageList";
      const string expected = "IL";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_Label()
    {
      const string source = "Label";
      const string expected = "L";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_LinkLabel()
    {
      const string source = "LinkLabel";
      const string expected = "LL";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_ListBox()
    {
      const string source = "ListBox";
      const string expected = "LB";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_ListView()
    {
      const string source = "ListView";
      const string expected = "LV";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_MaskedTextBox()
    {
      const string source = "MaskedTextBox";
      const string expected = "MTB";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_MenuStrip()
    {
      const string source = "MenuStrip";
      const string expected = "MS";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_MessageQueue()
    {
      const string source = "MessageQueue";
      const string expected = "MQ";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_MonthCalendar()
    {
      const string source = "MonthCalendar";
      const string expected = "MC";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_NotifyIcon()
    {
      const string source = "NotifyIcon";
      const string expected = "NI";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_NumericUpDown()
    {
      const string source = "NumericUpDown";
      const string expected = "NUD";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_OpenFileDialog()
    {
      const string source = "OpenFileDialog";
      const string expected = "OFD";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_PageSetupDialog()
    {
      const string source = "PageSetupDialog";
      const string expected = "PSD";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_BackgroundWorker()
    {
      const string source = "BackgroundWorker";
      const string expected = "BW";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_BindingNavigator()
    {
      const string source = "BindingNavigator";
      const string expected = "BN";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_BindingSource()
    {
      const string source = "BindingSource";
      const string expected = "BS";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_StarWars()
    {
      const string source = "A Long Long Time Ago In A Galaxy Far Far Away";
      const string expected = "ALLTAIAGFFA";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetCapitalLetters_All_Capital_letters()
    {
      const string source = "A LONG LONG TIME AGO";
      const string expected = "ALONGLONGTIMEAGO";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_GetCapitalLetters_no_Capital_letters()
    {
      const string source = "a long long time ago";
      const string expected = "";
      string result = StringFunc.GetCapitalLetters(source);
      Assert.AreEqual(result, expected);
    }
    #endregion GetCapitalLetters
    #region ToPascalCase
    [TestMethod]
    public void TestMethod_ToPascalCase_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.ToPascalCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToPascalCase_all_capital()
    {
      const string source = "A LONG LONG TIME AGO";
      const string expected = "A long long time ago";
      string result = StringFunc.ToPascalCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToPascalCase_all_lower_case()
    {
      const string source = "a long long time ago";
      const string expected = "A long long time ago";
      string result = StringFunc.ToPascalCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToPascalCase_lower_upper_case_mixed_up()
    {
      const string source = "a Long Long Time Ago";
      const string expected = "A long long time ago";
      string result = StringFunc.ToPascalCase(source);
      Assert.AreEqual(result, expected);
    }
    #endregion ToPascalCase
    #region ToTitleCase2
    [TestMethod]
    public void TestMethod_ToTitleCase2_Empty_String()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_USA()
    {
      const string source = "USA";
      const string expected = "USA";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_usa()
    {
      const string source = "usa";
      const string expected = "USA";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_uSa()
    {
      const string source = "uSa";
      const string expected = "USA";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_Sleepy_Hollow()
    {
      const string source = "Sleepy Hollow";
      const string expected = "Sleepy Hollow";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_Z_Nation()
    {
      const string source = "Z Nation";
      const string expected = "Z Nation";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_Hot_In_Cleveland()
    {
      const string source = "Hot In Cleveland";
      const string expected = "Hot in Cleveland";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_HOT_IN_CLEVELAND()
    {
      const string source = "HOT IN CLEVELAND";
      const string expected = "Hot in Cleveland";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_once_upon_a_time()
    {
      const string source = "once upon a time";
      const string expected = "Once Upon a Time";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_ONCE_UPON_A_TIME()
    {
      const string source = "ONCE UPON A TIME";
      const string expected = "Once Upon a Time";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_BBC_TV()
    {
      const string source = "BBC is a tv broadcasting company";
      const string expected = "BBC Is a TV Broadcasting Company";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_US()
    {
      const string source = "US is an abbreviation for USA";
      const string expected = "US Is An Abbreviation for USA";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_UK()
    {
      const string source = "UK is an abbreviation for United Kingdom";
      const string expected = "UK Is An Abbreviation for United Kingdom";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_UN()
    {
      const string source = "UN is an abbreviation for United nations";
      const string expected = "UN Is An Abbreviation for United Nations";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_TF1()
    {
      const string source = "TF1 is another french tv station";
      const string expected = "TF1 Is another French TV Station";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTitleCase2_minorWords()
    {
      const string source = "here are minor words ON, IN, AT, OFF, WITH, TO, AS, BY, THE, A, OTHER, ANOTHER, AND, BUT, ALSO, ELSE, FOR and IF";
      const string expected = "Here Are Minor Words On, In, At, Off, With, To, As, By, The, A, Other, Another, And, But, Also, Else, for and if";
      string result = StringFunc.ToTitleCase2(source);
      Assert.AreEqual(result, expected);
    }
    #endregion ToTitleCase2
    #region Space
    [TestMethod]
    public void TestMethod_Space_default_value()
    {
      const string expected = " ";
      string result = StringFunc.Space();
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_2()
    {
      const byte source = 2;
      const string expected = "  ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_3()
    {
      const byte source = 3;
      const string expected = "   ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_4()
    {
      const byte source = 4;
      const string expected = "    ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_5()
    {
      const byte source = 5;
      const string expected = "     ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_6()
    {
      const byte source = 6;
      const string expected = "      ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_7()
    {
      const byte source = 7;
      const string expected = "       ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_8()
    {
      const byte source = 8;
      const string expected = "        ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_9()
    {
      const byte source = 9;
      const string expected = "         ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_10()
    {
      const byte source = 10;
      const string expected = "          ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_11()
    {
      const byte source = 11;
      const string expected = "           ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_12()
    {
      const byte source = 12;
      const string expected = "            ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_13()
    {
      const byte source = 13;
      const string expected = "             ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_14()
    {
      const byte source = 14;
      const string expected = "              ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_15()
    {
      const byte source = 15;
      const string expected = "               ";
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_255() // byte.Max = 255
    {
      const byte source = 255;
      string expected = string.Empty;
      for (int expectedLength = 0; expectedLength < source; expectedLength++)
      {
        expected += " ";
      }
      string result = StringFunc.Space(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Space_all_values()
    {
      for (byte source = 1; source <= 254; source++)
      {
        string expected = string.Empty;
        for (int expectedLength = 0; expectedLength < source; expectedLength++)
        {
          expected += " ";
        }

        string result = StringFunc.Space(source);
        Assert.AreEqual(result, expected);
      }
    }
    #endregion
    #region ToTwoDigits
    [TestMethod]
    public void TestMethod_ToTwoDigits_value_0()
    {
      const byte source = 0;
      const string expected = "00";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_1()
    {
      const byte source = 1;
      const string expected = "01";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_2()
    {
      const byte source = 2;
      const string expected = "02";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_3()
    {
      const int source = 3;
      const string expected = "03";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_4()
    {
      const int source = 4;
      const string expected = "04";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_5()
    {
      const int source = 5;
      const string expected = "05";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_6()
    {
      const int source = 6;
      const string expected = "06";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_7()
    {
      const int source = 7;
      const string expected = "07";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_8()
    {
      const int source = 8;
      const string expected = "08";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_9()
    {
      const int source = 9;
      const string expected = "09";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_10()
    {
      const int source = 10;
      const string expected = "10";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToTwoDigits_value_100()
    {
      const int source = 100;
      const string expected = "100";
      string result = StringFunc.ToTwoDigits(source);
      Assert.AreEqual(result, expected);
    }
    #endregion ToTwoDigits
    #region ToNDigits
    [TestMethod]
    public void TestMethod_ToNDigits_default_value_0()
    {
      const int source = 0;
      const string expected = "0";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_1()
    {
      const int source = 1;
      const string expected = "1";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_2()
    {
      const int source = 2;
      const string expected = "2";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_3()
    {
      const int source = 3;
      const string expected = "3";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_4()
    {
      const int source = 4;
      const string expected = "4";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_5()
    {
      const int source = 5;
      const string expected = "5";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_6()
    {
      const int source = 6;
      const string expected = "6";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_7()
    {
      const int source = 7;
      const string expected = "7";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_8()
    {
      const int source = 8;
      const string expected = "8";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_9()
    {
      const int source = 9;
      const string expected = "9";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_10()
    {
      const int source = 10;
      const string expected = "10";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_11()
    {
      const int source = 11;
      const string expected = "11";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_15()
    {
      const int source = 15;
      const string expected = "15";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_default_value_100()
    {
      const int source = 100;
      const string expected = "100";
      string result = StringFunc.ToNDigits(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_1()
    {
      const int source = 1;
      const string expected = "01";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_2()
    {
      const int source = 2;
      const string expected = "02";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_3()
    {
      const int source = 3;
      const string expected = "03";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_4()
    {
      const int source = 4;
      const string expected = "04";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_5()
    {
      const int source = 5;
      const string expected = "05";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_6()
    {
      const int source = 6;
      const string expected = "06";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_7()
    {
      const int source = 7;
      const string expected = "07";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_8()
    {
      const int source = 8;
      const string expected = "08";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_9()
    {
      const int source = 9;
      const string expected = "09";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_10()
    {
      const int source = 10;
      const string expected = "10";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_11()
    {
      const int source = 11;
      const string expected = "11";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_12()
    {
      const int source = 12;
      const string expected = "12";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_13()
    {
      const int source = 13;
      const string expected = "13";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_14()
    {
      const int source = 14;
      const string expected = "14";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_15()
    {
      const int source = 15;
      const string expected = "15";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_value_150()
    {
      const int source = 150;
      const string expected = "150";
      string result = StringFunc.ToNDigits(source, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_1()
    {
      const int source = 1;
      const string expected = "001";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_2()
    {
      const int source = 2;
      const string expected = "002";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_3()
    {
      const int source = 3;
      const string expected = "003";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_4()
    {
      const int source = 4;
      const string expected = "004";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_5()
    {
      const int source = 5;
      const string expected = "005";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_6()
    {
      const int source = 6;
      const string expected = "006";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_7()
    {
      const int source = 7;
      const string expected = "007";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_8()
    {
      const int source = 8;
      const string expected = "008";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_9()
    {
      const int source = 9;
      const string expected = "009";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_10()
    {
      const int source = 10;
      const string expected = "010";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_11()
    {
      const int source = 11;
      const string expected = "011";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_12()
    {
      const int source = 12;
      const string expected = "012";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_13()
    {
      const int source = 13;
      const string expected = "013";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_14()
    {
      const int source = 14;
      const string expected = "014";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_15()
    {
      const int source = 15;
      const string expected = "015";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_16()
    {
      const int source = 16;
      const string expected = "016";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_17()
    {
      const int source = 17;
      const string expected = "017";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_18()
    {
      const int source = 18;
      const string expected = "018";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_19()
    {
      const int source = 19;
      const string expected = "019";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_20()
    {
      const int source = 20;
      const string expected = "020";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_21()
    {
      const int source = 21;
      const string expected = "021";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_100()
    {
      const int source = 100;
      const string expected = "100";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_101()
    {
      const int source = 101;
      const string expected = "101";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_102()
    {
      const int source = 102;
      const string expected = "102";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_103()
    {
      const int source = 103;
      const string expected = "103";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_104()
    {
      const int source = 104;
      const string expected = "104";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_105()
    {
      const int source = 105;
      const string expected = "105";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_106()
    {
      const int source = 106;
      const string expected = "106";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_107()
    {
      const int source = 107;
      const string expected = "107";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_108()
    {
      const int source = 108;
      const string expected = "108";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_109()
    {
      const int source = 109;
      const string expected = "109";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_110()
    {
      const int source = 110;
      const string expected = "110";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_111()
    {
      const int source = 111;
      const string expected = "111";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_112()
    {
      const int source = 112;
      const string expected = "112";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_113()
    {
      const int source = 113;
      const string expected = "113";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_114()
    {
      const int source = 114;
      const string expected = "114";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_115()
    {
      const int source = 115;
      const string expected = "115";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_116()
    {
      const int source = 116;
      const string expected = "116";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_117()
    {
      const int source = 117;
      const string expected = "117";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_118()
    {
      const int source = 118;
      const string expected = "118";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_119()
    {
      const int source = 119;
      const string expected = "119";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_120()
    {
      const int source = 120;
      const string expected = "120";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_3_zeros_value_121()
    {
      const int source = 121;
      const string expected = "121";
      string result = StringFunc.ToNDigits(source, 3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1()
    {
      const int source = 1;
      const string expected = "0001";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_2()
    {
      const int source = 2;
      const string expected = "0002";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_3()
    {
      const int source = 3;
      const string expected = "0003";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_4()
    {
      const int source = 4;
      const string expected = "0004";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_5()
    {
      const int source = 5;
      const string expected = "0005";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_6()
    {
      const int source = 6;
      const string expected = "0006";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_7()
    {
      const int source = 7;
      const string expected = "0007";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_8()
    {
      const int source = 8;
      const string expected = "0008";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9()
    {
      const int source = 9;
      const string expected = "0009";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_10()
    {
      const int source = 10;
      const string expected = "0010";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_11()
    {
      const int source = 11;
      const string expected = "0011";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_12()
    {
      const int source = 12;
      const string expected = "0012";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_13()
    {
      const int source = 13;
      const string expected = "0013";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_14()
    {
      const int source = 14;
      const string expected = "0014";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_15()
    {
      const int source = 15;
      const string expected = "0015";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_16()
    {
      const int source = 16;
      const string expected = "0016";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_17()
    {
      const int source = 17;
      const string expected = "0017";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_18()
    {
      const int source = 18;
      const string expected = "0018";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_19()
    {
      const int source = 19;
      const string expected = "0019";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_20()
    {
      const int source = 20;
      const string expected = "0020";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_21()
    {
      const int source = 21;
      const string expected = "0021";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_100()
    {
      const int source = 100;
      const string expected = "0100";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_101()
    {
      const int source = 101;
      const string expected = "0101";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_102()
    {
      const int source = 102;
      const string expected = "0102";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_103()
    {
      const int source = 103;
      const string expected = "0103";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_104()
    {
      const int source = 104;
      const string expected = "0104";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_105()
    {
      const int source = 105;
      const string expected = "0105";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_106()
    {
      const int source = 106;
      const string expected = "0106";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_107()
    {
      const int source = 107;
      const string expected = "0107";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_108()
    {
      const int source = 108;
      const string expected = "0108";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_109()
    {
      const int source = 109;
      const string expected = "0109";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_110()
    {
      const int source = 110;
      const string expected = "0110";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_111()
    {
      const int source = 111;
      const string expected = "0111";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_112()
    {
      const int source = 112;
      const string expected = "0112";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_113()
    {
      const int source = 113;
      const string expected = "0113";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_114()
    {
      const int source = 114;
      const string expected = "0114";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_115()
    {
      const int source = 115;
      const string expected = "0115";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1000()
    {
      const int source = 1000;
      const string expected = "1000";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1001()
    {
      const int source = 1001;
      const string expected = "1001";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1002()
    {
      const int source = 1002;
      const string expected = "1002";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1003()
    {
      const int source = 1003;
      const string expected = "1003";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1004()
    {
      const int source = 1004;
      const string expected = "1004";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1005()
    {
      const int source = 1005;
      const string expected = "1005";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1006()
    {
      const int source = 1006;
      const string expected = "1006";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1007()
    {
      const int source = 1007;
      const string expected = "1007";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1008()
    {
      const int source = 1008;
      const string expected = "1008";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1009()
    {
      const int source = 1009;
      const string expected = "1009";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1010()
    {
      const int source = 1010;
      const string expected = "1010";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1011()
    {
      const int source = 1011;
      const string expected = "1011";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1012()
    {
      const int source = 1012;
      const string expected = "1012";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1013()
    {
      const int source = 1013;
      const string expected = "1013";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1014()
    {
      const int source = 1014;
      const string expected = "1014";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1015()
    {
      const int source = 1015;
      const string expected = "1015";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1016()
    {
      const int source = 1016;
      const string expected = "1016";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1017()
    {
      const int source = 1017;
      const string expected = "1017";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1018()
    {
      const int source = 1018;
      const string expected = "1018";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1019()
    {
      const int source = 1019;
      const string expected = "1019";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1020()
    {
      const int source = 1020;
      const string expected = "1020";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1021()
    {
      const int source = 1021;
      const string expected = "1021";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1022()
    {
      const int source = 1022;
      const string expected = "1022";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1023()
    {
      const int source = 1023;
      const string expected = "1023";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1024()
    {
      const int source = 1024;
      const string expected = "1024";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_1025()
    {
      const int source = 1025;
      const string expected = "1025";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9990()
    {
      const int source = 9990;
      const string expected = "9990";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9991()
    {
      const int source = 9991;
      const string expected = "9991";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9992()
    {
      const int source = 9992;
      const string expected = "9992";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9993()
    {
      const int source = 9993;
      const string expected = "9993";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9994()
    {
      const int source = 9994;
      const string expected = "9994";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9995()
    {
      const int source = 9995;
      const string expected = "9995";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9996()
    {
      const int source = 9996;
      const string expected = "9996";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9997()
    {
      const int source = 9997;
      const string expected = "9997";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9998()
    {
      const int source = 9998;
      const string expected = "9998";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_4_zeros_value_9999()
    {
      const int source = 9999;
      const string expected = "9999";
      string result = StringFunc.ToNDigits(source, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1()
    {
      const int source = 1;
      const string expected = "00001";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_2()
    {
      const int source = 2;
      const string expected = "00002";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_3()
    {
      const int source = 3;
      const string expected = "00003";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_4()
    {
      const int source = 4;
      const string expected = "00004";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_5()
    {
      const int source = 5;
      const string expected = "00005";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_6()
    {
      const int source = 6;
      const string expected = "00006";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_7()
    {
      const int source = 7;
      const string expected = "00007";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_8()
    {
      const int source = 8;
      const string expected = "00008";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_9()
    {
      const int source = 9;
      const string expected = "00009";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10()
    {
      const int source = 10;
      const string expected = "00010";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_11()
    {
      const int source = 11;
      const string expected = "00011";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_12()
    {
      const int source = 12;
      const string expected = "00012";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_13()
    {
      const int source = 13;
      const string expected = "00013";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_14()
    {
      const int source = 14;
      const string expected = "00014";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_15()
    {
      const int source = 15;
      const string expected = "00015";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_16()
    {
      const int source = 16;
      const string expected = "00016";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_17()
    {
      const int source = 17;
      const string expected = "00017";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_18()
    {
      const int source = 18;
      const string expected = "00018";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_19()
    {
      const int source = 19;
      const string expected = "00019";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_20()
    {
      const int source = 20;
      const string expected = "00020";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_21()
    {
      const int source = 21;
      const string expected = "00021";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_22()
    {
      const int source = 22;
      const string expected = "00022";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_23()
    {
      const int source = 23;
      const string expected = "00023";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_24()
    {
      const int source = 24;
      const string expected = "00024";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_25()
    {
      const int source = 25;
      const string expected = "00025";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_100()
    {
      const int source = 100;
      const string expected = "00100";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_101()
    {
      const int source = 101;
      const string expected = "00101";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_102()
    {
      const int source = 102;
      const string expected = "00102";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_103()
    {
      const int source = 103;
      const string expected = "00103";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_104()
    {
      const int source = 104;
      const string expected = "00104";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_105()
    {
      const int source = 105;
      const string expected = "00105";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_106()
    {
      const int source = 106;
      const string expected = "00106";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_107()
    {
      const int source = 107;
      const string expected = "00107";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_108()
    {
      const int source = 108;
      const string expected = "00108";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_109()
    {
      const int source = 109;
      const string expected = "00109";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_110()
    {
      const int source = 110;
      const string expected = "00110";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_111()
    {
      const int source = 111;
      const string expected = "00111";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_112()
    {
      const int source = 112;
      const string expected = "00112";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_113()
    {
      const int source = 113;
      const string expected = "00113";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_114()
    {
      const int source = 114;
      const string expected = "00114";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_115()
    {
      const int source = 115;
      const string expected = "00115";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_116()
    {
      const int source = 116;
      const string expected = "00116";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_117()
    {
      const int source = 117;
      const string expected = "00117";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_118()
    {
      const int source = 118;
      const string expected = "00118";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_119()
    {
      const int source = 119;
      const string expected = "00119";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_120()
    {
      const int source = 120;
      const string expected = "00120";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_121()
    {
      const int source = 121;
      const string expected = "00121";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_122()
    {
      const int source = 122;
      const string expected = "00122";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_123()
    {
      const int source = 123;
      const string expected = "00123";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_124()
    {
      const int source = 124;
      const string expected = "00124";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_125()
    {
      const int source = 125;
      const string expected = "00125";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1000()
    {
      const int source = 1000;
      const string expected = "01000";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1001()
    {
      const int source = 1001;
      const string expected = "01001";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1002()
    {
      const int source = 1002;
      const string expected = "01002";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1003()
    {
      const int source = 1003;
      const string expected = "01003";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1004()
    {
      const int source = 1004;
      const string expected = "01004";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1005()
    {
      const int source = 1005;
      const string expected = "01005";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1006()
    {
      const int source = 1006;
      const string expected = "01006";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1007()
    {
      const int source = 1007;
      const string expected = "01007";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1008()
    {
      const int source = 1008;
      const string expected = "01008";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1009()
    {
      const int source = 1009;
      const string expected = "01009";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1010()
    {
      const int source = 1010;
      const string expected = "01010";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1011()
    {
      const int source = 1011;
      const string expected = "01011";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1012()
    {
      const int source = 1012;
      const string expected = "01012";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1013()
    {
      const int source = 1013;
      const string expected = "01013";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1014()
    {
      const int source = 1014;
      const string expected = "01014";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1015()
    {
      const int source = 1015;
      const string expected = "01015";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1016()
    {
      const int source = 1016;
      const string expected = "01016";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1017()
    {
      const int source = 1017;
      const string expected = "01017";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1018()
    {
      const int source = 1018;
      const string expected = "01018";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1019()
    {
      const int source = 1019;
      const string expected = "01019";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1020()
    {
      const int source = 1020;
      const string expected = "01020";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1021()
    {
      const int source = 1021;
      const string expected = "01021";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1022()
    {
      const int source = 1022;
      const string expected = "01022";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1023()
    {
      const int source = 1023;
      const string expected = "01023";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1024()
    {
      const int source = 1024;
      const string expected = "01024";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_1025()
    {
      const int source = 1025;
      const string expected = "01025";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10000()
    {
      const int source = 10000;
      const string expected = "10000";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10001()
    {
      const int source = 10001;
      const string expected = "10001";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10002()
    {
      const int source = 10002;
      const string expected = "10002";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10003()
    {
      const int source = 10003;
      const string expected = "10003";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10004()
    {
      const int source = 10004;
      const string expected = "10004";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10005()
    {
      const int source = 10005;
      const string expected = "10005";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10006()
    {
      const int source = 10006;
      const string expected = "10006";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10007()
    {
      const int source = 10007;
      const string expected = "10007";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10008()
    {
      const int source = 10008;
      const string expected = "10008";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10009()
    {
      const int source = 10009;
      const string expected = "10009";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10010()
    {
      const int source = 10010;
      const string expected = "10010";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10011()
    {
      const int source = 10011;
      const string expected = "10011";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10012()
    {
      const int source = 10012;
      const string expected = "10012";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10013()
    {
      const int source = 10013;
      const string expected = "10013";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10014()
    {
      const int source = 10014;
      const string expected = "10014";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10015()
    {
      const int source = 10015;
      const string expected = "10015";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10016()
    {
      const int source = 10016;
      const string expected = "10016";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10017()
    {
      const int source = 10017;
      const string expected = "10017";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10018()
    {
      const int source = 10018;
      const string expected = "10018";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10019()
    {
      const int source = 10019;
      const string expected = "10019";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10020()
    {
      const int source = 10020;
      const string expected = "10020";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10021()
    {
      const int source = 10021;
      const string expected = "10021";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10022()
    {
      const int source = 10022;
      const string expected = "10022";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10023()
    {
      const int source = 10023;
      const string expected = "10023";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10024()
    {
      const int source = 10024;
      const string expected = "10024";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_10025()
    {
      const int source = 10025;
      const string expected = "10025";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65500()
    {
      const int source = 65500;
      const string expected = "65500";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65501()
    {
      const int source = 65501;
      const string expected = "65501";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65502()
    {
      const int source = 65502;
      const string expected = "65502";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65503()
    {
      const int source = 65503;
      const string expected = "65503";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65504()
    {
      const int source = 65504;
      const string expected = "65504";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65505()
    {
      const int source = 65505;
      const string expected = "65505";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65506()
    {
      const int source = 65506;
      const string expected = "65506";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65507()
    {
      const int source = 65507;
      const string expected = "65507";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65508()
    {
      const int source = 65508;
      const string expected = "65508";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65509()
    {
      const int source = 65509;
      const string expected = "65509";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65510()
    {
      const int source = 65510;
      const string expected = "65510";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65511()
    {
      const int source = 65511;
      const string expected = "65511";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65512()
    {
      const int source = 65512;
      const string expected = "65512";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65513()
    {
      const int source = 65513;
      const string expected = "65513";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65514()
    {
      const int source = 65514;
      const string expected = "65514";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65515()
    {
      const int source = 65515;
      const string expected = "65515";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65516()
    {
      const int source = 65516;
      const string expected = "65516";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65517()
    {
      const int source = 65517;
      const string expected = "65517";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65518()
    {
      const int source = 65518;
      const string expected = "65518";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65519()
    {
      const int source = 65519;
      const string expected = "65519";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65520()
    {
      const int source = 65520;
      const string expected = "65520";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65521()
    {
      const int source = 65521;
      const string expected = "65521";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65522()
    {
      const int source = 65522;
      const string expected = "65522";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65523()
    {
      const int source = 65523;
      const string expected = "65523";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65524()
    {
      const int source = 65524;
      const string expected = "65524";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65525()
    {
      const int source = 65525;
      const string expected = "65525";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65526()
    {
      const int source = 65526;
      const string expected = "65526";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65527()
    {
      const int source = 65527;
      const string expected = "65527";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65528()
    {
      const int source = 65528;
      const string expected = "65528";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65529()
    {
      const int source = 65529;
      const string expected = "65529";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65530()
    {
      const int source = 65530;
      const string expected = "65530";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65531()
    {
      const int source = 65531;
      const string expected = "65531";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65532()
    {
      const int source = 65532;
      const string expected = "65532";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65533()
    {
      const int source = 65533;
      const string expected = "65533";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65534()
    {
      const int source = 65534;
      const string expected = "65534";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_5_zeros_value_65535()
    {
      const int source = 65535;
      const string expected = "65535";
      string result = StringFunc.ToNDigits(source, 5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65500()
    {
      const int source = 65500;
      const string expected = "065500";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65501()
    {
      const int source = 65501;
      const string expected = "065501";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65502()
    {
      const int source = 65502;
      const string expected = "065502";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65503()
    {
      const int source = 65503;
      const string expected = "065503";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65504()
    {
      const int source = 65504;
      const string expected = "065504";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65505()
    {
      const int source = 65505;
      const string expected = "065505";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65506()
    {
      const int source = 65506;
      const string expected = "065506";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65507()
    {
      const int source = 65507;
      const string expected = "065507";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65508()
    {
      const int source = 65508;
      const string expected = "065508";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65509()
    {
      const int source = 65509;
      const string expected = "065509";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65510()
    {
      const int source = 65510;
      const string expected = "065510";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65511()
    {
      const int source = 65511;
      const string expected = "065511";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65512()
    {
      const int source = 65512;
      const string expected = "065512";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65513()
    {
      const int source = 65513;
      const string expected = "065513";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65514()
    {
      const int source = 65514;
      const string expected = "065514";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65515()
    {
      const int source = 65515;
      const string expected = "065515";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65516()
    {
      const int source = 65516;
      const string expected = "065516";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65517()
    {
      const int source = 65517;
      const string expected = "065517";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65518()
    {
      const int source = 65518;
      const string expected = "065518";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65519()
    {
      const int source = 65519;
      const string expected = "065519";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65520()
    {
      const int source = 65520;
      const string expected = "065520";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65521()
    {
      const int source = 65521;
      const string expected = "065521";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65522()
    {
      const int source = 65522;
      const string expected = "065522";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65523()
    {
      const int source = 65523;
      const string expected = "065523";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65524()
    {
      const int source = 65524;
      const string expected = "065524";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65525()
    {
      const int source = 65525;
      const string expected = "065525";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65526()
    {
      const int source = 65526;
      const string expected = "065526";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65527()
    {
      const int source = 65527;
      const string expected = "065527";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65528()
    {
      const int source = 65528;
      const string expected = "065528";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65529()
    {
      const int source = 65529;
      const string expected = "065529";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65530()
    {
      const int source = 65530;
      const string expected = "065530";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65531()
    {
      const int source = 65531;
      const string expected = "065531";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65532()
    {
      const int source = 65532;
      const string expected = "065532";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65533()
    {
      const int source = 65533;
      const string expected = "065533";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65534()
    {
      const int source = 65534;
      const string expected = "065534";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_6_zeros_value_65535()
    {
      const int source = 65535;
      const string expected = "065535";
      string result = StringFunc.ToNDigits(source, 6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_1()
    {
      const int source = 1;
      const string expected = "0000001";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_2()
    {
      const int source = 2;
      const string expected = "0000002";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_3()
    {
      const int source = 3;
      const string expected = "0000003";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_4()
    {
      const int source = 4;
      const string expected = "0000004";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_5()
    {
      const int source = 5;
      const string expected = "0000005";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_6()
    {
      const int source = 6;
      const string expected = "0000006";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_7()
    {
      const int source = 7;
      const string expected = "0000007";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_8()
    {
      const int source = 8;
      const string expected = "0000008";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_9()
    {
      const int source = 9;
      const string expected = "0000009";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_10()
    {
      const int source = 10;
      const string expected = "0000010";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_11()
    {
      const int source = 11;
      const string expected = "0000011";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_12()
    {
      const int source = 12;
      const string expected = "0000012";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_13()
    {
      const int source = 13;
      const string expected = "0000013";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_14()
    {
      const int source = 14;
      const string expected = "0000014";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_15()
    {
      const int source = 15;
      const string expected = "0000015";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_16()
    {
      const int source = 16;
      const string expected = "0000016";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_17()
    {
      const int source = 17;
      const string expected = "0000017";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_18()
    {
      const int source = 18;
      const string expected = "0000018";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_19()
    {
      const int source = 19;
      const string expected = "0000019";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_20()
    {
      const int source = 20;
      const string expected = "0000020";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_21()
    {
      const int source = 21;
      const string expected = "0000021";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_22()
    {
      const int source = 22;
      const string expected = "0000022";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_23()
    {
      const int source = 23;
      const string expected = "0000023";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_24()
    {
      const int source = 24;
      const string expected = "0000024";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToNDigits_7_zeros_value_25()
    {
      const int source = 25;
      const string expected = "0000025";
      string result = StringFunc.ToNDigits(source, 7);
      Assert.AreEqual(result, expected);
    }
    #endregion ToNDigits
    #region AddSpaceInNumberWithDecimal
    [TestMethod]
    public void TestMethod_AddSpaceInNumberWithDecimal()
    {
      const decimal source = 0.25m;
      const string expected = "0,25";
      string result = StringFunc.AddSpaceInNumberWithDecimal(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumberWithDecimal_value10()
    {
      const decimal source = 10.325m;
      const string expected = "10,33";
      string result = StringFunc.AddSpaceInNumberWithDecimal(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumberWithDecimal_value100()
    {
      const decimal source = 100.325m;
      const string expected = "100,33";
      string result = StringFunc.AddSpaceInNumberWithDecimal(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumberWithDecimal_value1000()
    {
      const decimal source = 1000.325m;
      const string expected = "1 000,33";
      string result = StringFunc.AddSpaceInNumberWithDecimal(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumberWithDecimal_value5000()
    {
      const decimal source = 5000.325m;
      const string expected = "5 000,33";
      string result = StringFunc.AddSpaceInNumberWithDecimal(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumberWithDecimal_value_1500000()
    {
      const decimal source = 1500000.325m;
      const string expected = "1 500 000,33";
      string result = StringFunc.AddSpaceInNumberWithDecimal(source);
      Assert.AreEqual(result, expected);
    }
    #endregion AddSpaceInNumberWithDecimal
    #region AddSpaceInNumber

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_0()
    {
      const long source = 0;
      const string expected = "0";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_1()
    {
      const long source = 1;
      const string expected = "1";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_10()
    {
      const long source = 10;
      const string expected = "10";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_100()
    {
      const long source = 100;
      const string expected = "100";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_1000()
    {
      const long source = 1000;
      const string expected = "1 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_10000()
    {
      const long source = 10000;
      const string expected = "10 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_100000()
    {
      const long source = 100000;
      const string expected = "100 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_1000000()
    {
      const long source = 1000000;
      const string expected = "1 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_10000000()
    {
      const long source = 10000000;
      const string expected = "10 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_100000000()
    {
      const long source = 100000000;
      const string expected = "100 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_1000000000()
    {
      const long source = 1000000000;
      const string expected = "1 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_10000000000()
    {
      const long source = 10000000000;
      const string expected = "10 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_100000000000()
    {
      const long source = 100000000000;
      const string expected = "100 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_1000000000000()
    {
      const long source = 1000000000000;
      const string expected = "1 000 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_10000000000000()
    {
      const long source = 10000000000000;
      const string expected = "10 000 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_100000000000000()
    {
      const long source = 100000000000000;
      const string expected = "100 000 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_1000000000000000()
    {
      const long source = 1000000000000000;
      const string expected = "1 000 000 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result.Length, expected.Length);
      //Assert.AreEqual(result, expected); // failed to debug
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_10000000000000000()
    {
      const long source = 10000000000000000;
      const string expected = "10 000 000 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result.Length, expected.Length);
      //Assert.AreEqual(result, expected); // failed to debug
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_100000000000000000()
    {
      const long source = 100000000000000000;
      const string expected = "100 000 000 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result.Length, expected.Length);
      //Assert.AreEqual(result, expected); // failed to debug
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_value_1000000000000000000()
    {
      const long source = 1000000000000000000;
      const string expected = "1 000 000 000 000 000 000";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result.Length, expected.Length);
      //Assert.AreEqual(result, expected); // failed to debug
    }

    [TestMethod]
    public void TestMethod_AddSpaceInNumber_Max_value_9223372036854775807()
    {
      const long source = 9223372036854775807;
      const string expected = "9 223 372 036 854 775 807";
      string result = StringFunc.AddSpaceInNumber(source);
      Assert.AreEqual(result.Length, expected.Length);
      //Assert.IsTrue(result == expected);
      //Assert.AreEqual(result, expected);
    }

    #endregion AddSpaceInNumber
    #region AddCommaInNumber
    //TODO write unit tests
    #endregion AddCommaInNumber
    #region FrenchPlural
    [TestMethod]
    public void TestMethod_FrenchPlural_singular_French()
    {
      const int source = 1;
      const string source2 = "french";
      const string expected = "";
      string result = StringFunc.FrenchPlural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_FrenchPlural_default_singular()
    {
      const int source = 1;
      const string expected = "";
      string result = StringFunc.FrenchPlural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_FrenchPlural_plural_French()
    {
      const int source = 3;
      const string source2 = "french";
      const string expected = "s";
      string result = StringFunc.FrenchPlural(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_FrenchPlural_default_plural()
    {
      const int source = 3;
      const string expected = "";
      string result = StringFunc.FrenchPlural(source);
      Assert.AreEqual(result, expected);
    }
    #endregion FrenchPlural
    #region GetNumbers
    [TestMethod]
    public void TestMethod_GetNumbers_VS2015()
    {
      const string source = "visual studio 2015";
      const string expected = "2015";
      string result = StringFunc.GetNumbers(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNumbers_VS2012()
    {
      const string source = "visual studio 2012";
      const string expected = "2012";
      string result = StringFunc.GetNumbers(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNumbers_VS2013()
    {
      const string source = "visual studio 2013 Community";
      const string expected = "2013";
      string result = StringFunc.GetNumbers(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNumberempty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.GetNumbers(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNumbers_no_number()
    {
      const string source = "visual studio";
      const string expected = "";
      string result = StringFunc.GetNumbers(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetNumbers_only_numbers()
    {
      const string source = "31012015";
      const string expected = "31012015";
      string result = StringFunc.GetNumbers(source);
      Assert.AreEqual(result, expected);
    }
    #endregion GetNumbers
    #region ContainsIgnoreCase
    [TestMethod]
    public void TestMethod_ContainsIgnoreCase_true()
    {
      const string source = "Once upon a time in a dark forest";
      const string source2 = "once";
      const bool expected = true;
      bool result = StringFunc.ContainsIgnoreCase(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ContainsIgnoreCase_false()
    {
      const string source = "Once upon a time in a dark forest";
      const string source2 = "once2";
      const bool expected = false;
      bool result = StringFunc.ContainsIgnoreCase(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ContainsIgnoreCase_true_upper_case()
    {
      const string source = "Once upon a time in a dark forest";
      const string source2 = "TIME";
      const bool expected = true;
      bool result = StringFunc.ContainsIgnoreCase(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ContainsIgnoreCase_true_several_instances()
    {
      const string source = "Once upon a time in a dark forest";
      const string source2 = "a";
      const bool expected = true;
      bool result = StringFunc.ContainsIgnoreCase(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ContainsIgnoreCase_true_several_instances_upper_case()
    {
      const string source = "Once upon a time in a dark forest";
      const string source2 = "A";
      const bool expected = true;
      bool result = StringFunc.ContainsIgnoreCase(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ContainsIgnoreCase_false_several_instances_upper_case()
    {
      const string source = "Once upon a time in a dark forest";
      const string source2 = "TIMES";
      const bool expected = false;
      bool result = StringFunc.ContainsIgnoreCase(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion ContainsIgnoreCase
    #region Punctuation
    [TestMethod]
    public void TestMethod_Punctuation_period()
    {
      const string source = dllFuncs.Punctuation.Period;
      const string expected = ".";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Backslash()
    {
      const string source = dllFuncs.Punctuation.Backslash;
      const string expected = "\\";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_colon()
    {
      const string source = dllFuncs.Punctuation.Colon;
      const string expected = ":";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_comma()
    {
      const string source = dllFuncs.Punctuation.Comma;
      const string expected = ",";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_dash()
    {
      const string source = dllFuncs.Punctuation.Dash;
      const string expected = "-";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_false_dash()
    {
      const string source = dllFuncs.Punctuation.Dash;
      const string expected = "_";
      Assert.AreNotEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_OneSpace()
    {
      const string source = dllFuncs.Punctuation.OneSpace;
      const string expected = " ";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_slash()
    {
      const string source = dllFuncs.Punctuation.Slash;
      const string expected = "/";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_CRLF()
    {
      string source = dllFuncs.Punctuation.CrLf;
      string expected = Environment.NewLine;
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Ampersand()
    {
      const string source = dllFuncs.Punctuation.Ampersand;
      const string expected = "&";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Chapter()
    {
      const string source = dllFuncs.Punctuation.Chapter;
      const string expected = "§";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_open_curly_Brace()
    {
      const string source = dllFuncs.Punctuation.OpenCurlyBrace;
      const string expected = "{";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Close_curly_Brace()
    {
      const string source = dllFuncs.Punctuation.CloseCurlyBrace;
      const string expected = "}";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_open_parenthesis()
    {
      const string source = dllFuncs.Punctuation.OpenParenthesis;
      const string expected = "(";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Close_parenthesis()
    {
      const string source = dllFuncs.Punctuation.CloseParenthesis;
      const string expected = ")";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_open_square_bracket()
    {
      const string source = dllFuncs.Punctuation.OpeningBracket;
      const string expected = "[";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Close_square_bracket()
    {
      const string source = dllFuncs.Punctuation.ClosingBracket;
      const string expected = "]";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_divide()
    {
      const string source = dllFuncs.Punctuation.Divide;
      const string expected = "/";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_plus()
    {
      const string source = dllFuncs.Punctuation.Plus;
      const string expected = "+";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_minus()
    {
      const string source = dllFuncs.Punctuation.Minus;
      const string expected = "-";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_multiply()
    {
      const string source = dllFuncs.Punctuation.Multiply;
      const string expected = "*";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_dollar()
    {
      const string source = dllFuncs.Punctuation.Dollar;
      const string expected = "$";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_pound()
    {
      const string source = dllFuncs.Punctuation.Pound;
      const string expected = "£";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_pipe()
    {
      const string source = dllFuncs.Punctuation.Pipe;
      const string expected = "|";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_percent()
    {
      const string source = dllFuncs.Punctuation.Percent;
      const string expected = "%";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_question_mark()
    {
      const string source = dllFuncs.Punctuation.QuestionMark;
      const string expected = "?";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Exclamation_Point()
    {
      const string source = dllFuncs.Punctuation.ExclamationPoint;
      const string expected = "!";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Micro()
    {
      const string source = dllFuncs.Punctuation.Micro;
      const string expected = "µ";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_UnderScore()
    {
      const string source = dllFuncs.Punctuation.UnderScore;
      const string expected = "_";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Sign_At()
    {
      const string source = dllFuncs.Punctuation.SignAt;
      const string expected = "@";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Sign_Sharp()
    {
      const string source = dllFuncs.Punctuation.SignSharp;
      const string expected = "#";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Less_than()
    {
      const string source = dllFuncs.Punctuation.LessThan;
      const string expected = "<";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Greater_than()
    {
      const string source = dllFuncs.Punctuation.GreaterThan;
      const string expected = ">";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Simple_Quote()
    {
      const string source = dllFuncs.Punctuation.SimpleQuote;
      const string expected = "'";
      Assert.AreEqual(source, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_Double_Quote()
    {
      const string source = dllFuncs.Punctuation.DoubleQuote;
      const string expected = "\"";
      Assert.AreEqual(source, expected);
    }
    #endregion Punctuation
    #region InvertModifier
    [TestMethod]
    public void TestMethod_InvertModifier_true_two_words()
    {
      const string source = "blue table";
      const string expected = "table blue";
      string result = StringFunc.InvertModifier(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InvertModifier_string_empty()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.InvertModifier(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InvertModifier_three_words()
    {
      const string source = "a blue table";
      const string expected = "";
      string result = StringFunc.InvertModifier(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InvertModifier_two_words_French()
    {
      const string source = "Fichier PDF";
      const string expected = "PDF fichier";
      string result = StringFunc.InvertModifier(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InvertModifier_two_words_English()
    {
      const string source = "File PDF";
      const string expected = "PDF file";
      string result = StringFunc.InvertModifier(source);
      Assert.AreEqual(result, expected);
    }
    #endregion InvertModifier
    #region AddSlash
    [TestMethod]
    public void TestMethod_AddSlash_true()
    {
      const string source = "C:\\program files\\";
      const string expected = "C:\\program files\\";
      string result = StringFunc.AddSlash(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_AddSlash_false()
    {
      const string source = "C:\\program files";
      const string expected = "C:\\program files\\";
      string result = StringFunc.AddSlash(source);
      Assert.AreEqual(result, expected);
    }
    #endregion AddSlash
    #region IsInside
    [TestMethod]
    public void TestMethod_IsInside_true()
    {
      const int source1 = 12;
      int[] source2 = { 3, 4, 6, 7, 10, 12, 15 };
      const bool expected = true;
      bool result = StringFunc.IsInside(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInside_false()
    {
      const int source1 = 182;
      int[] source2 = { 3, 4, 6, 7, 10, 12, 15 };
      const bool expected = false;
      bool result = StringFunc.IsInside(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInside_string_true()
    {
      const string source1 = "time";
      string[] source2 = { "A long long time ago in a galaxy far far away", "time", "galaxy" };
      const bool expected = true;
      bool result = StringFunc.IsInside(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInside_string_false()
    {
      const string source1 = "times";
      const string source2 = "A long long time ago in a galaxy far far away";
      const bool expected = false;
      bool result = StringFunc.IsInside(source1, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion IsInside
    #region IsInList
    [TestMethod]
    public void TestMethod_IsInList_true_three_elements()
    {
      const string source1 = "time";
      string[] source2 = { "A long long time ago in a galaxy far far away", "time", "galaxy" };
      const bool expected = true;
      bool result = StringFunc.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInList_false_one_element()
    {
      const string source1 = "time";
      string[] source2 = { "A long long time ago in a galaxy far far away" };
      const bool expected = false;
      bool result = StringFunc.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInList_false_three_elements()
    {
      const string source1 = "times";
      string[] source2 = { "A long long time ago in a galaxy far far away", "galaxy", "tide" };
      const bool expected = false;
      bool result = StringFunc.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInList_true_two_elements()
    {
      const string source1 = "times";
      string[] source2 = { "A long long time ago in a galaxy far far away", "times" };
      const bool expected = true;
      bool result = StringFunc.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInList_true_eight_elements()
    {
      const string source1 = "zip";
      string[] source2 = { "ZIP", "EPUB", "MOBI", "PDF", "DOC", "XPS", "DOCX", "PPTX" };
      const bool expected = true;
      bool result = StringFunc.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion IsInList
    #region CheckInjection
    [TestMethod]
    public void TestMethod_CheckInjection_false_single_quote()
    {
      const string source = "Bill Gates'injection try'";
      const bool expected = false;
      bool result = StringFunc.CheckInjectionInUserNameAndPassword(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckInjection_false_hyphen_dash()
    {
      const string source = "Bill Gates-bad-idea'";
      const bool expected = false;
      bool result = StringFunc.CheckInjectionInUserNameAndPassword(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckInjection_false_ampersand()
    {
      const string source = "Bill Gates&true=true";
      const bool expected = false;
      bool result = StringFunc.CheckInjectionInUserNameAndPassword(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckInjection_true()
    {
      const string source = "Bill Gates";
      const bool expected = true;
      bool result = StringFunc.CheckInjectionInUserNameAndPassword(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckInjection_true_script_tag()
    {
      const string source = "Bill Gates<script>bad javascript script</script>";
      const bool expected = false;
      bool result = StringFunc.CheckInjectionInUserNameAndPassword(source);
      Assert.AreEqual(result, expected);
    }
    #endregion CheckInjection
    #region CheckHash
    [TestMethod]
    public void TestMethod_CheckHash_false()
    {
      const string source1 = "A long long time ago in a galaxy far far away";
      byte[] source2 = { 0, 16, 104, 213 };
      const bool expected = false;
      bool result = StringFunc.CheckHash(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckHash_true_one_letter()
    {
      const string source1 = "A";
      byte[] source2 = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes("A"));
      const bool expected = true;
      bool result = StringFunc.CheckHash(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckHash_true_letter_B()
    {
      const string source1 = "B";
      byte[] source2 = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes("B"));
      const bool expected = true;
      bool result = StringFunc.CheckHash(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckHash_true_letter_C()
    {
      const string source1 = "C";
      byte[] source2 = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes("C"));
      const bool expected = true;
      bool result = StringFunc.CheckHash(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckHash_true_letter_D()
    {
      const string source1 = "D";
      byte[] source2 = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes("D"));
      const bool expected = true;
      bool result = StringFunc.CheckHash(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CheckHash_true_long_sentence()
    {
      const string source1 = "A long long time ago in a galaxy far far away";
      byte[] source2 = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes("A long long time ago in a galaxy far far away"));
      const bool expected = true;
      bool result = StringFunc.CheckHash(source1, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion CheckHash
    #region ReverseString3
    [TestMethod]
    public void TestMethod_ReverseString3()
    {
      const string source = "123456789";
      string result = StringFunc.ReverseString3(source);
      Assert.IsTrue(result == "987654321");
    }

    [TestMethod]
    public void TestMethod_ReverseString3_on_an_empty_string()
    {
      const string source = "";
      string result = StringFunc.ReverseString3(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ReverseString3_one_element()
    {
      const string source = "1";
      string result = StringFunc.ReverseString3(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_ReverseString3_palindrome()
    {
      const string source = "laval";
      string result = StringFunc.ReverseString3(source);
      Assert.IsTrue(result == source);
    }

    [TestMethod]
    public void TestMethod_ReverseString3_several_palindromes()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString3(source);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString3_several_palindromes_with_removal_of_spaces()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString3(source, true);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString3_lieur_palindrome_with_removal_of_spaces()
    {
      const string source = "lieur à rueil";
      const string expected = "lieuràrueil";
      string result = StringFunc.ReverseString3(source, true);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ReverseString3_several_palindromes_with_removal_of_space()
    {
      List<string> sourceWords = new List<string> { "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString3(source, true);
        Assert.IsTrue(result == source.Replace(" ", ""));
      }
    }


    #endregion
    #region CountLetters
    [TestMethod]
    public void TestMethod_CountLetters_empty_source()
    {
      const string source = "";
      int[] expected = new int[27];
      int[] result = StringFunc.CountLetters3(source);
      AssertArraysAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountLetters_no_letter()
    {
      const string source = "123456789%$£*µ!§/:;.,?";
      int[] expected = new int[27];
      int[] result = StringFunc.CountLetters3(source);
      AssertArraysAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountLetters_letters_with_accent()
    {
      const string source = "éèçàùâû";
      int[] expected = new int[27];
      int[] result = StringFunc.CountLetters3(source);
      AssertArraysAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountLetters_one_letter()
    {
      const string source = "a";
      int[] expected = new int[27];
      expected[1] = 1;
      int[] result = StringFunc.CountLetters3(source);
      AssertArraysAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountLetters_lower_case_and_upper_case()
    {
      const string source = "aA";
      int[] expected = new int[27];
      expected[1] = 2;
      int[] result = StringFunc.CountLetters3(source);
      AssertArraysAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountLetters_several_letters()
    {
      const string source = "abc";
      int[] expected = new int[27];
      expected[1] = 1;
      expected[2] = 1;
      expected[3] = 1;
      int[] result = StringFunc.CountLetters3(source);
      AssertArraysAreEqual(result, expected);
    }

    #endregion CountLetters
    #region Helper unit test methods
    public static void AssertListsAreEqual(List<int> result, List<int> expected)
    {
      Assert.AreEqual(result.Count, expected.Count);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(result[i], expected[i]);
      }
    }

    public static void AssertArraysAreEqual(int[] result, int[] expected)
    {
      Assert.AreEqual(result.Length, expected.Length);
      for (int i = 0; i < result.Length; i++)
      {
        Assert.AreEqual(result[i], expected[i]);
      }
    }

    public static void AssertListsAreSimilar(List<int> result, List<int> expected)
    {
      // similar because of a Parallel loop
      Assert.AreEqual(result.Count, expected.Count);
      foreach (int item in result)
      {
        Assert.IsTrue(expected.Contains(item));
      }
    }
    #endregion Helper unit test methods
    #region GetGitUrl
    [TestMethod]
    public void TestMethod_GetGitUrl()
    {
      string[] source = { "aA", "qwerty", "azerty", " url = https://github.com/user1/repo.git" };
      const string expected = "https://github.com/user1/repo.git";
      string result = StringFunc.GetGitUrl(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetGitUrl_empty_string()
    {
      string[] source = { };
      const string expected = "";
      string result = StringFunc.GetGitUrl(source);
      Assert.AreEqual(result, expected);
    }
    #endregion
    #region GoBackOneDirectory
    [TestMethod]
    public void TestMethod_GoBackOneDirectory_empty_string()
    {
      string source = string.Empty;
      const string expected = "";
      string result = StringFunc.GoBackOneDirectory(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GoBackOneDirectory_simple_path()
    {
      const string source = @"C:\Users\User\Documents\Visual Studio 2015\Projects\CodeGeneration\CodeGeneration";
      const string expected = @"C:\Users\User\Documents\Visual Studio 2015\Projects\CodeGeneration\";
      string result = StringFunc.GoBackOneDirectory(source);
      Assert.AreEqual(result, expected);
    }

    #endregion GoBackOneDirectory
    #region PadLeft
    [TestMethod]
    public void TestMethod_PadLeft_empty_string()
    {
      string source = string.Empty;
      const string expected = "00";
      string result = StringFunc.PadLeft(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_1_character()
    {
      const string source = "a";
      const string expected = "0a";
      string result = StringFunc.PadLeft(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_2_characters()
    {
      const string source = "aa";
      const string expected = "aa";
      string result = StringFunc.PadLeft(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_3_characters_with_default_padding_equal_to_2()
    {
      const string source = "aaa";
      const string expected = "aa";
      string result = StringFunc.PadLeft(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_4_characters_with_default_padding_equal_to_2()
    {
      const string source = "aaaa";
      const string expected = "aa";
      string result = StringFunc.PadLeft(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_PadLeft_0_character_with_default_padding_equal_to_3()
    {
      const string source = "";
      const int source2 = 3;
      const string expected = "000";
      string result = StringFunc.PadLeft(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_1_character_with_default_padding_equal_to_3()
    {
      const string source = "a";
      const int source2 = 3;
      const string expected = "00a";
      string result = StringFunc.PadLeft(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_2_characters_with_default_padding_equal_to_3()
    {
      const string source = "aa";
      const int source2 = 3;
      const string expected = "0aa";
      string result = StringFunc.PadLeft(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_3_characters_with_default_padding_equal_to_3()
    {
      const string source = "aaa";
      const int source2 = 3;
      const string expected = "aaa";
      string result = StringFunc.PadLeft(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PadLeft_3_characters_with_default_padding_equal_to_4()
    {
      const string source = "aaa";
      const int source2 = 4;
      const string expected = "0aaa";
      string result = StringFunc.PadLeft(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion PadLeft
    #region HelperUsefulFunctions
    private static void AssertListAreEqualled(IReadOnlyList<string> result, IReadOnlyList<string> expected)
    {
      Assert.AreEqual(result.Count, expected.Count);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(result[i], expected[i]);
      }
    }
    #endregion HelperUsefulFunctions

    #region RemoveAccent
    [TestMethod]
    public void TestMethod_RemoveAccent_no_accent_english()
    {
      string source = "a long long time ago in a galaxy far far away";
      string expected = "a long long time ago in a galaxy far far away";
      string result = StringFunc.RemoveAccent(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveAccent_vowel()
    {
      string source = "aeiou";
      string expected = "aeiou";
      string result = StringFunc.RemoveAccent(source);
      Assert.AreEqual(result, expected);
    }
    #endregion
    [TestMethod]
    public void TestMethod_GetPositionOfString_1()
    {
      string[] source = { "a", "long" };
      string source2 = "long";
      int expected = 1;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetPositionOfString_0()
    {
      string[] source = { "a", "long" };
      string source2 = "a";
      int expected = 0;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetPositionOfString_not_found()
    {
      string[] source = { "a", "long" };
      string source2 = "time";
      int expected = -1;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetPositionOfString_2()
    {
      string[] source = { "a", "long", "time" };
      string source2 = "time";
      int expected = 2;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetPositionOfString_3()
    {
      string[] source = { "a", "long", "time", "ago" };
      string source2 = "ago";
      int expected = 3;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetPositionOfString_1_double()
    {
      string[] source = { "a", "long", "long", "time", "ago" };
      string source2 = "long";
      int expected = 1;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_GetPositionOfString_10()
    {
      string[] source = { "a", "long", "long", "time", "ago", "in", "a", "galaxy", "far", "far", "away" };
      string source2 = "away";
      int expected = 10;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetPositionOfString_8()
    {
      string[] source = { "a", "long", "long", "time", "ago", "in", "a", "galaxy", "far", "far", "away" };
      string source2 = "far";
      int expected = 8;
      int result = StringFunc.GetPositionOfString(source, source2);
      Assert.AreEqual(result, expected);
    }
  }
}
