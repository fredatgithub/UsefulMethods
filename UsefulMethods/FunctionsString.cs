using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace UsefulMethods
{
  using MathFunc = FunctionsMath;

  public class FunctionsString
  {
    /// <summary>
    /// List all the public methods available from this DLL
    /// </summary>
    /// <returns>
    /// Returns a list of all the methods used in this DLL with their signature.
    /// </returns>
    public static string Manifest()
    {
      const string newLine = "\n";
      StringBuilder result = new StringBuilder();
      result.Append(newLine + "Name= FonctionsUtiles.Fred.Csharp" + newLine);
      result.Append("Version= 1.0.0.0" + newLine);
      result.Append("String methods:" + newLine);
      result.Append("Method= bool HasDuplicate(params int[] liste)" + newLine);
      result.Append("Method= bool HasNoDuplicate(params int[] liste)" + newLine);
      result.Append("Method= string EndPadding(string chaine, byte blankLength)" + newLine);
      result.Append("Method= string GetLastName(string chaine, char dernierCaractereRecherche)" + newLine);
      result.Append("Method= string GetFileNameAfterLastSlash(string longCheminFichier)" + newLine);
      result.Append("Method= string RemoveInString(string stringToBeRemoved, string inString, bool trimEnd = false)" + newLine);
      result.Append("Method= string CamelCase(string myString)" + newLine);
      result.Append("Method= bool IsNumeric(char letter)" + newLine);
      result.Append("Method= bool IsLetter(char myLetter)" + newLine);
      result.Append("Method= string Plural(int    number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(byte   number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(Int16  number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(Int64  number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(uint   number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(UInt16 number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(UInt64 number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= int StringOccurrenceWithIndexOf(string wholeString, string searchedString)" + newLine);
      result.Append("Method= int StringOccurrenceWithContains(string myString, string searchedString)" + newLine);
      result.Append("Method= string ByteArrayToHexaString(byte[] bytes, bool oneDigitOnly = false)" + newLine);
      result.Append("Method= byte[] HexaStringToByteArray(string hexaString)" + newLine);
      result.Append("Method= string ReverseString(string strValue, bool removeSpace = false)" + newLine);
      result.Append("Method= bool IsPalindrome(string myString, bool spaceRemoval = false)" + newLine);
      result.Append("Method= string ReverseString2(string input, bool removeSpace = false)" + newLine);
      result.Append("Method= string CompletePrefixWithZero(string numberInString, byte numberOfZero = 0)" + newLine);
      result.Append("Method= string CompletePrefixWithZeroInt(int nombre, byte numberOfZero = 0)" + newLine);
      result.Append("Method= string ArrayToString(IList array)" + newLine);
      result.Append("Method= string ArrayToString(IList array, string separator)" + newLine);
      result.Append("Method= byte[] HexaStringToByteArray(string hexaString)" + newLine);
      result.Append("Method= string ArrayToStringWithStringBuilder(IList array)" + newLine);
      result.Append("Method= string ArrayToStringWithStringBuilder(IList array, string separator)" + newLine);
      result.Append("Method= string InsertSeparatorForEachCharacter(string input, string separator = \" \")" + newLine);
      result.Append("Method= string InsertSeparatorAtInterval(string input, string separator, int interval)" + newLine);
      result.Append("Method= string RemoveVowels(string input)" + newLine);
      result.Append("Method= string KeepVowels(string input)" + newLine);
      result.Append("Method= string OppositeCase(string input)" + newLine);
      result.Append("Method= string SwapCases(string input)" + newLine);
      result.Append("Method= string Capitalize(string input)" + newLine);
      result.Append("Method= string GetInitials(string input, bool capitalizeInitials, bool preserveSpaces, bool includePeriod)" + newLine);
      result.Append("Method= string GetInitials(string input, string separator, bool capitalizeInitials, bool preserveSeparator, bool includePeriod)" + newLine);
      result.Append("Method= string GetTitle(string input)" + newLine);
      result.Append("Method= string GetTitle(string input, string separator)" + newLine);
      result.Append("Method= string SubStringEnd(string input, int start, int end)" + newLine);
      result.Append("Method= char CharRight(string input, int index)" + newLine);
      result.Append("Method= char CharMid(string input, int startingIndex, int count)" + newLine);
      result.Append("Method= int CountString(string input, string sequence, bool ignoreCase)" + newLine);
      result.Append("Method= int[] IndexOfAll(string input, string sequence, bool ignoreCase)" + newLine);
      result.Append("Method= int[] IndexOfAll(string input, string sequence, int startIndex, bool ignoreCase)" + newLine);
      result.Append("Method= bool IsAlternateCases" + newLine);
      result.Append("Method= bool IsCapitalized(string input)" + newLine);
      result.Append("Method= bool IsLowerCase(string input)" + newLine);
      result.Append("Method= bool HasConsonants(string input)" + newLine);
      result.Append("Method= bool IsSpaces(string input)" + newLine);
      result.Append("Method= bool IsRepeatedChar(string input)" + newLine);
      result.Append("Method= bool IsNumeric2(string input)" + newLine);
      result.Append("Method= bool IsNumeric(string valueInNumeric)" + newLine);
      result.Append("Method= bool IsNumeric3(string val, NumberStyles numberStyle)" + newLine);
      result.Append("Method= bool HasNumeric(string input)" + newLine);
      result.Append("Method= bool IsAlphaNumeric(string input)" + newLine);
      result.Append("Method= bool IsOnlyLetters(string input)" + newLine);
      result.Append("Method= bool HasSomeLetters(string input)" + newLine);
      result.Append("Method= bool HasSomeLowerCaseLetters(string input)" + newLine);
      result.Append("Method= bool HasSomeUpperCaseLetters(string input)" + newLine);
      result.Append("Method= bool HasLettersOrDigits(string input)" + newLine);
      result.Append("Method= bool HasSymbols(string input)" + newLine);
      result.Append("Method= bool IsTitle(string input)" + newLine);
      result.Append("Method= bool IsTitle(string input, string separator)" + newLine);
      result.Append("Method= bool IsEmailAddress(string input)" + newLine);
      result.Append("Method= bool IsEmailAddressValid(string s)" + newLine);
      result.Append("Method= char[] LoadAlphabetInCharArray(bool addDigit = true, bool addLowerCaseLetters = true, bool addUpperCaseLetters = false)string[] LoadAlphabetInStringArray(string[] list)" + newLine);
      result.Append("Method= List<string> GetAlphabetToList(bool addLowerCaseLetters = true, bool addUpperCaseLetters = false, bool addDigit = true, LetterCasingSequence letterSequence = LetterCasingSequence.LowerUpperDigit)" + newLine);
      result.Append("Method= List<string> AddDigits(List<string> startingList)" + newLine);
      result.Append("Method= List<string> AddLowerCaseLetters(List<string> startingList)" + newLine);
      result.Append("Method= List<string> AddUpperCaseLetters(List<string> startingList)" + newLine);
      result.Append("Method= string NumberToEnglishWords(int number)" + newLine);
      result.Append("Method= string NumberToEnglishWords(long number)" + newLine);
      result.Append("Method= string NumberToEnglishWords(ulong number)" + newLine);
      result.Append("Method= string NumberToFrenchWords(int number)" + newLine);
      result.Append("Method= string NumberToFrenchWords(long number)" + newLine);
      result.Append("Method= string NumberToFrenchWords(ulong number)" + newLine);
      result.Append("Method= Dictionary<int, string> DicoNumberToFrenchWords(int startNumber, int endNumber)" + newLine);
      result.Append("Method= Dictionary<int, string> DicoNumberToEnglishWords(int startNumber, int endNumber)" + newLine);
      result.Append("Method= bool IsInside(int number, params int[] array)" + newLine);
      result.Append("Method= string ToTitleCase(string myString)" + newLine);
      result.Append("Method= string UpperCaseFirstLetter(string value)" + newLine);
      result.Append("Method= char[] GetAlphabet(bool lowerCase = true)" + newLine);
      result.Append("Method= string ReplaceCharacters(string originalString, char oldChar = ' ', char newChar = ' ')" + newLine);
      result.Append("Method= string GenerateGuid()" + newLine);
      result.Append("Method= string GenerateUniqueFilename(string directoryPath, RandomCharacters rdnCharacters = RandomCharacters.LowerCase, byte length = 8, bool withFileExtension = false, string fileExtension = \"txt\")" + newLine);
      result.Append("Method= string GenerateRandomLongString(char[] forbiddenCharacters, bool hasForbiddenCharacters = false, RandomCharacters rdnCharacters = RandomCharacters.LowerCase, int length = 8, bool isWindowsFileName = false)" + newLine);
      result.Append("Method= string GenerateRandomString(char[] forbiddenCharacters, bool hasForbiddenCharacters = false, RandomCharacters rdnCharacters = RandomCharacters.LowerCase, byte length = 8, bool isWindowsFileName = false)" + newLine);
      result.Append("Method= string FillSearchedCharWithoutForbiddenChar(char[] source, char[] forbiddenCharacters)" + newLine);
      result.Append("Method= char[] AddCharArray(char[] source, char[] toBeAdded, char[] forbiddenCharacters)" + newLine);
      result.Append("Method= string GenerateCharactersFromSource(List<string> source, int numberOfCharacters = 1)" + newLine);
      result.Append("Method= string ByteArrayToString(byte[] bytes)" + newLine);
      result.Append("Method= byte[] HexStringToByteArray(string hexaString)" + newLine);
      result.Append("Method= string ReplaceWindowsForbiddenCharacters(string input, string charToReplaced = \"\")" + newLine);
      result.Append("Method= string RemoveAllNonLetterCharacters(string input, string[] charsToRemove)" + newLine);
      result.Append("Method= string RemoveAllNonLetterCharacters(string input, char[] charsToRemove)" + newLine);
      result.Append("Method= string RemoveAllNonLetterCharacters(string input)" + newLine);
      result.Append("Method= string InsertStringAtBegining(string myString, string stringToBeinserted, char characterToSkip = ' ')" + newLine);
      result.Append("Method= string AddTabulation(int numberOfTabulationSpace = 1)" + newLine);
      result.Append("Method= Dictionary<char, int> CountLetters(string myString, bool wholeDictionary = true)" + newLine);
      result.Append("Method= int CountWords(string input)" + newLine);
      result.Append("Method= Dictionary<string, int> GetDictionaryWords(string input, bool caseSensitive = true, DefaultCasing defaultLowerCase = DefaultCasing.defaultLowerCase)" + newLine);
      result.Append("Method= string[] SeparateQuote(string wholeQuote)" + newLine);
      result.Append("Method= string GetCapitalLetters(string input)" + newLine);
      result.Append("Method= string ToPascalCase(string s)" + newLine);
      result.Append("Method= string ToTitleCase2(string s)" + newLine);
      result.Append("Method= string ToTwoDigits(ushort number)" + newLine);
      result.Append("Method= string ToNDigits(ushort number, byte numberLength = 1)" + newLine);
      result.Append("Method= string AddSpaceInNumberWithDecimal(decimal number)");
      result.Append("Method= string AddSpaceInNumber(long number)");
      result.Append("Method= string AddCommaInNumber(long number)");
      result.Append("Method= string FrenchPlural(int number, string currentLanguage = \"english\")");
      result.Append("Method= string GetNumbers(string myString)");
      result.Append("Method= ");
      result.Append("Method= ");
      result.Append("Method= ");
      result.Append("Method= ");
      result.Append("Method= ");
      result.Append("Method= ");
      result.Append("DateTime methods:" + newLine);
      result.Append("Files methods:" + newLine);
      result.Append("Internet methods:" + newLine);
      result.Append("Math methods:" + newLine);
      result.Append("Useful methods:" + newLine);

      return result.ToString();
    }

    public static bool HasDuplicate(params int[] liste)
    {
      if (liste == null)
      {
        return false;
      }

      return liste.Distinct().Count() != liste.Length;
    }
    public static bool HasNoDuplicate(params int[] liste)
    {
      if (liste == null)
      {
        return true;
      }

      return liste.Distinct().Count() == liste.Length;
    }
    public static string EndPadding(string chaine, byte blankLength)
    {
      if (chaine.Length == blankLength)
      {
        return chaine;
      }

      string blanc = string.Empty;
      for (int i = 0; i < blankLength - chaine.Length; i++)
      {
        blanc += " ";
      }

      return chaine + blanc;
    }
    public static string GetLastName(string chaine, char dernierCaractereRecherche)
    {
      int at = 0;
      int atBackup = 0;
      int start = 0;
      while (start < chaine.Length && at > -1)
      {

        at = chaine.IndexOf(dernierCaractereRecherche, start);
        if (at == -1)
        {
          at = atBackup;
          break;
        }
        atBackup = at;
        start = at + 1;
      }

      return chaine.Substring(at + 1);
    }
    public static string GetFileNameAfterLastSlash(string longCheminFichier)
    {
      return Path.GetFileName(longCheminFichier);
    }
    public static string RemoveInString(string stringToBeRemoved, string inString, bool trimEnd = false)
    {
      string tmpString = inString.Replace(stringToBeRemoved, string.Empty);
      return trimEnd ? tmpString.TrimEnd() : tmpString;
    }
    public static string CamelCase(string myString)
    {
      string result = string.Empty;
      bool isPreviousLetter = false;
      foreach (var item in myString)
      {
        if (isPreviousLetter && IsLetter(item))
        {
          result += item.ToString(CultureInfo.InvariantCulture).ToLower();
        }
        else
        {
          result += item.ToString(CultureInfo.InvariantCulture).ToUpper();
        }

        isPreviousLetter = IsLetter(item);
      }

      return result;
    }
    public static bool IsNumeric(char letter)
    {
      var digits = new List<int>();
      for (short digit = 0; digit < 10; digit++)
      {
        digits.Add(digit);
      }

      return digits.Contains(letter);
    }
    public static bool IsLetter(char myLetter)
    {
      return char.IsLetter(myLetter);
    }
    public static string Plural(int number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bijoux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case " is":
          return number > 1 ? "s are" : " is"; // with a space before
        case "is":
          return number > 1 ? "are" : "is"; // without a space before
        case "are":
          return number > 1 ? "are" : "is"; // without a space before
        case "has":
          return number > 1 ? "have" : "has";
        case "have":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural
        default:
          return number > 1 ? "s" : string.Empty;
      }
    }

    public static string Plural(byte number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case "is":
          return number > 1 ? "are" : "is";
        case "are":
          return number > 1 ? "are" : "is";
        case "has":
          return number > 1 ? "have" : "has";
        case "have":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(short number, string irregularNoun = "") // int16
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case "is":
          return number > 1 ? "are" : "is";
        case "are":
          return number > 1 ? "are" : "is";
        case "has":
          return number > 1 ? "have" : "has";
        case "have":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(long number, string irregularNoun = "") //Int64
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case "is":
          return number > 1 ? "are" : "is";
        case "are":
          return number > 1 ? "are" : "is";
        case "has":
          return number > 1 ? "have" : "has";
        case "have":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(uint number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case "is":
          return number > 1 ? "are" : "is";
        case "are":
          return number > 1 ? "are" : "is";
        case "has":
          return number > 1 ? "have" : "has";
        case "have":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(ushort number, string irregularNoun = "") // UInt16
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case "is":
          return number > 1 ? "are" : "is";
        case "are":
          return number > 1 ? "are" : "is";
        case "has":
          return number > 1 ? "have" : "has";
        case "have":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(ulong number, string irregularNoun = "") // UInt64
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bijoux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case "is":
          return number > 1 ? "are" : "is";
        case "are":
          return number > 1 ? "are" : "is";
        case "has":
          return number > 1 ? "have" : "has";
        case "have":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static int StringOccurrenceWithIndexOf(string wholeString, string searchedString)
    {
      if (wholeString == string.Empty || searchedString == string.Empty)
      {
        return 0;
      }

      int occurrence = 0;
      int str2Length = searchedString.Length;
      int index = 0;
      while ((index = wholeString.IndexOf(searchedString, index, StringComparison.Ordinal)) > -1)
      {
        occurrence++;
        index += str2Length;
      }

      return occurrence;
    }
    public static int StringOccurrenceWithContains(string myString, string searchedString)
    {
      if (searchedString == string.Empty || myString == string.Empty)
      {
        return 0;
      }

      int occurrence = 0;
      int chaineRechercheeLength = searchedString.Length;
      int index = 0;
      string chaineTempo = myString.Substring(index, chaineRechercheeLength);
      while (index < myString.Length)
      {
        if (chaineTempo.Contains(searchedString))
        {
          occurrence++;
        }

        if (index + chaineRechercheeLength > myString.Length)
        {
          return occurrence;
        }

        index += 1;
        if (index + chaineRechercheeLength > myString.Length)
        {
          return occurrence;
        }

        chaineTempo = myString.Substring(index, chaineRechercheeLength);
      }

      return occurrence;
    }
    public static string ByteArrayToHexaString(byte[] bytes, bool oneDigitOnly = false)
    {
      var sb = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        sb.Append(oneDigitOnly ? bytes[i].ToString("X1") : bytes[i].ToString("X2"));
      }

      return sb.ToString();
    }
    public static byte[] HexaStringToByteArray(string hexaString)
    {
      if (hexaString == string.Empty)
      {
        return new byte[0];
      }

      var returnBytes = new byte[hexaString.Length / 2];
      for (int i = 0; i < returnBytes.Length; i++)
      {
        returnBytes[i] = Convert.ToByte(hexaString.Substring(i * 2, 2));
      }

      return returnBytes;
    }
    public static string ReverseString2(string strValue, bool removeSpace = false)
    {
      //  LINQ: return strValue.Aggregate(string.Empty, (current, caracter) => caracter + current);
      if (removeSpace)
      {
        strValue = strValue.Replace(" ", "");
      }

      string reversedString = string.Empty;
      foreach (char caracter in strValue)
      {
        reversedString = caracter + reversedString;
      }

      return reversedString;
    }
    public static string ReverseString3(string strValue, bool removeSpace = false)
    {
      if (removeSpace)
      {
        strValue = strValue.Replace(" ", "");
      }

      int length = strValue.Length;
      if (length > 1)
      {
        var first = strValue.Substring(1);
        var last = strValue.Substring(0, 1);
        var reverseString = ReverseString3(first) + last;
        return reverseString;
      }

      return strValue;
    }

    public string ReverseString4(string srtVarable)
    {
      return new string(srtVarable.Reverse().ToArray());
    }

    public string Reverse4(string text)
    {
      //return Microsoft.VisualBasic.Strings.StrReverse(text);
      return string.Empty;
    }


    public static string ReverseString(string input, bool removeSpace = false)
    {
      //  Validate input
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      if (removeSpace)
      {
        input = input.Replace(" ", "");
      }

      char[] outputChars = input.ToCharArray();
      //  Reverse
      Array.Reverse(outputChars);

      //  build a string from the processed characters and return it
      return new string(outputChars);
    }
    public static bool IsPalindrome(string myString, bool spaceRemoval = false)
    {
      if (spaceRemoval) // can you use ternary twice ?
      {
        return ReverseString(myString, spaceRemoval) == myString.Replace(" ", "");
      }

      return ReverseString(myString, spaceRemoval) == myString;
    }
    public static string CompletePrefixWithZero(string numberInString, byte numberOfZero = 0)
    {
      string numberOfZeroString = "";
      for (byte i = 0; i < numberOfZero; i++)
      {
        numberOfZeroString += "0";
      }

      return numberInString.Length >= 1 ? numberOfZeroString + numberInString : numberInString;
    }
    public static string CompletePrefixWithZeroInt(int nombre, byte numberOfZero = 0)
    {
      string numberOfZeroString = "";
      for (byte i = 0; i < numberOfZero; i++)
      {
        numberOfZeroString += "0";
      }

      return numberOfZeroString + nombre;
    }
    public static string ArrayToString(IList array)
    {
      // Returns a string representation of an array. 
      // Each element is written on a new line.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      string output = string.Empty;
      for (int i = 0; i < array.Count; i++)
      {
        output += array[i].ToString();
        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output += Environment.NewLine;
        }
      }

      return output;
    }
    public static string ArrayToString(IList array, string separator)
    {
      // Returns a string representation of an array. 
      // Each element is written on a new line.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      string output = string.Empty;
      for (int i = 0; i < array.Count; i++)
      {
        output += array[i].ToString();

        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output += separator;
        }
      }

      return output;
    }
    public static string ArrayToStringWithStringBuilder(IList array)
    {
      // Returns a string representation of an array. 
      // Each element is written on a new line. Effective for large strings.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      var output = new StringBuilder(array.Count * 2);
      for (int i = 0; i < array.Count; i++)
      {
        output.Append(array[i]);

        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output.Append(Environment.NewLine);
        }
      }

      return output.ToString();
    }
    public static string ArrayToStringWithStringBuilder(IList array, string separator)
    {
      // Returns a string representation of an array. 
      // Each element is separated by the specified string.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      var output = new StringBuilder(array.Count * 2);
      for (int i = 0; i < array.Count; i++)
      {
        output.Append(array[i]);

        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output.Append(separator);
        }
      }

      return output.ToString();
    }
    public static string InsertSeparatorForEachCharacter(string input, string separator = " ")
    {
      //  Validate string
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      var outputChars = new List<char>(input.ToCharArray());
      char[] separatorChars = separator.ToCharArray();
      int i = 1;
      while (i < outputChars.Count)
      {
        if (i != outputChars.Count) // don't add separator to the end of string
        {
          outputChars.InsertRange(i, separatorChars);
        }

        i += 1 + separator.Length; // go up the interval amount plus separator
      }

      return new string(outputChars.ToArray());
    }
    public static string InsertSeparatorAtInterval(string input, string separator, int interval)
    {
      // Validate string
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      List<char> outputChars = new List<char>(input.ToCharArray());
      char[] separatorChars = separator.ToCharArray();
      int i = interval;
      while (i < outputChars.Count)
      {
        if (i != outputChars.Count) // don't add separator to the end of string
        {
          outputChars.InsertRange(i, separatorChars);
        }

        i += interval + separator.Length; // go up the interval amount plus separator
      }

      return new string(outputChars.ToArray());
    }
    public static string RemoveVowels(string input)
    {
      // Validate input
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      List<char> outputChars = new List<char>(input.ToCharArray());
      // Iterate backwards to avoid problems when removing characters
      for (int i = outputChars.Count - 1; i >= 0; i--)
      {
        if (outputChars[i] == 'a' || outputChars[i] == 'A' ||
            outputChars[i] == 'e' || outputChars[i] == 'E' ||
            outputChars[i] == 'i' || outputChars[i] == 'I' ||
            outputChars[i] == 'o' || outputChars[i] == 'O' ||
            outputChars[i] == 'u' || outputChars[i] == 'U' ||
            outputChars[i] == 'y' || outputChars[i] == 'Y')
          // not a vowel, remove it
          outputChars.RemoveAt(i);
      }

      return new string(outputChars.ToArray());
    }
    public static string KeepVowels(string input)
    {
      // Validate input
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      List<char> outputChars = new List<char>(input.ToCharArray());
      // Iterate backwards to avoid problems from removing characters
      for (int i = outputChars.Count - 1; i >= 0; i--)
      {
        if (!(outputChars[i] == 'a' || outputChars[i] == 'A' ||
              outputChars[i] == 'e' || outputChars[i] == 'E' ||
              outputChars[i] == 'i' || outputChars[i] == 'I' ||
              outputChars[i] == 'o' || outputChars[i] == 'O' ||
              outputChars[i] == 'u' || outputChars[i] == 'U' ||
              outputChars[i] == 'y' || outputChars[i] == 'Y'))
          // a vowel, remove it
          outputChars.RemoveAt(i);
      }

      return new string(outputChars.ToArray());
    }
    public static string AlternateCases(string input)
    {
      if (string.IsNullOrEmpty(input)) return string.Empty;
      if (input.Length == 1) return input; // Nothing to alternate
      char[] inputChars = input.ToCharArray(); // character array representing the string
      bool toUpper = !char.IsUpper(inputChars[0]);
      for (int i = 1; i < inputChars.Length; i++) // start with the section character
      {
        if (toUpper)
        {
          inputChars[i] = char.ToUpper(inputChars[i]);
        }
        else
        {
          inputChars[i] = char.ToLower(inputChars[i]);
        }

        toUpper = !toUpper; // alternate
      }

      return new string(inputChars);
    }
    public static string OppositeCase(string input)
    {
      if (string.IsNullOrEmpty(input)) return string.Empty;
      if (input.Length == 1) return input; // Nothing to alternate
      char[] inputChars = new char[input.Length]; // character array representing the string
      for (int i = 0; i < input.Length; i++) // start with the section character
      {
        if (char.IsLower(input[i]))
        {
          inputChars[i] = char.ToUpper(input[i]);
        }
        else
        {
          inputChars[i] = char.ToLower(input[i]);
        }
      }

      return new string(inputChars);
    }
    public static string SwapCases(string input)
    {
      // Returns a string with the opposite letter casing for each character.
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      if (input.Length == 1) return input; // Nothing to alternate
      char[] inputChars = input.ToCharArray();
      for (int i = 0; i < inputChars.Length; i++)
      {
        // Apply the opposite letter casing
        if (char.IsUpper(inputChars[i]))
        {
          inputChars[i] = char.ToLower(inputChars[i]);
        }
        else
        {
          inputChars[i] = char.ToUpper(inputChars[i]);
        }
      }

      return new string(inputChars);
    }
    public static string Capitalize(string input)
    {
      //  Capitalizes the first character in a string.
      if (string.IsNullOrEmpty(input)) return string.Empty;
      if (input.Length == 1) return input.ToUpper();

      return input[0].ToString(CultureInfo.CurrentCulture).ToUpper() + input.Substring(1);
    }
    /// <summary>
    /// Returns the initials of each word in a string. Words must be separated with spaces.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="capitalizeInitials">
    /// True to capitalize each initial in the output string.
    /// </param>
    /// <param name="preserveSpaces">
    /// True to preserver the spaces between initials in the output string.
    /// </param>
    /// <param name="includePeriod">
    /// True to include a '.' after each intialize
    /// </param>
    /// <returns></returns>
    public static string GetInitials(string input, bool capitalizeInitials, bool preserveSpaces, bool includePeriod)
    {
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      string[] words = input.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (capitalizeInitials)
          {
            words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture); // only keep the first letter
          }
          else
          {
            words[i] = words[i][0].ToString(CultureInfo.CurrentCulture); // only keep the first letter
          }

          if (includePeriod)
          {
            words[i] += ".";
          }
        }
      }

      if (preserveSpaces)
      {
        return string.Join(" ", words);
      }

      return string.Join(string.Empty, words);
    }
    /// <summary>
    /// Returns the initials of each word in a string. Words are separated according to the sepecified string sequence.
    /// </summary>
    /// <param name="input">
    /// The original string.
    /// </param>
    /// <param name="separator">
    /// The string sequence that separates words.
    /// </param>
    /// <param name="capitalizeInitials">
    /// True to capitalize each initial in the output string.
    /// </param>
    /// <param name="preserveSeparator">
    /// True to preserver the spaces between initials in the output string.
    /// </param>
    /// <param name="includePeriod"></param>
    /// <returns>
    /// Returns the initials of each word in a string. Words are separated according to the sepecified string sequence.
    /// </returns>
    public static string GetInitials(string input, string separator, bool capitalizeInitials, bool preserveSeparator, bool includePeriod)
    {
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      string[] words = input.Split(separator.ToCharArray());
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (capitalizeInitials)
            words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture); // only keep the first letter
          else
            words[i] = words[i][0].ToString(CultureInfo.CurrentCulture); // only keep the first letter
          if (includePeriod)
            words[i] += ".";
        }
      }

      return string.Join(preserveSeparator ? separator : string.Empty, words);
    }
    /// <summary>
    /// Returns a string with each word's first character capitalized. Words must be separated by spaces.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string GetTitle(string input)
    {
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      string[] words = input.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        // Capitalize each word
        if (words[i].Length > 0)
          words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture) + words[i].Substring(1);
      }

      return string.Join(" ", words);
    }
    /// <summary>
    /// Returns a string with each word's first character capitalized. Words are separated according to the sepecified string sequence.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string GetTitle(string input, string separator)
    {
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      string[] words = input.Split(separator.ToCharArray());
      for (int i = 0; i < words.Length; i++)
      {
        // Capitalize each word
        if (words[i].Length > 0)
        {
          words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture) + words[i].Substring(1);
        }
      }

      return string.Join(separator, words);
    }
    /// <summary>
    /// Returns a segment of a string, marked by the start and end index (exclusive).
    /// </summary>
    /// <param name="input"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static string SubStringEnd(string input, int start, int end)
    {
      if (string.IsNullOrEmpty(input) || start == end) return string.Empty;
      if (start == 0 && end == input.Length) return input; // entire string
      if (start < 0) return string.Empty;
      if (start > input.Length) return string.Empty;
      if (end < 0) return string.Empty;
      if (end > input.Length) return string.Empty;

      return input.Substring(start, end);
    }
    /// <summary>
    /// Returns the character in a string at a given index counting from the right.
    /// </summary>
    /// <param name="input">
    /// The starting position from the right. (Index 0 = last character)
    /// </param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static char CharRight(string input, int index)
    {
      if (string.IsNullOrEmpty(input)) return new char();
      if (input.Length - index - 1 >= input.Length) return new char();
      if (input.Length - index - 1 < 0) return new char();
      return input[input.Length - index - 1];
    }
    /// <summary>
    /// Returns the character at a position given by the startingIndex plus the given count.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="startingIndex"></param>
    /// <param name="count">
    /// The number of characters to count from the starting position.
    /// </param>
    /// <returns></returns>
    public static char CharMid(string input, int startingIndex, int count)
    {
      if (string.IsNullOrEmpty(input)) return new char();
      if (startingIndex < 0) return new char();
      if (startingIndex >= input.Length) return new char();
      if (startingIndex + count < 0) return new char();
      if (startingIndex + count >= input.Length) return new char();
      return input[startingIndex + count];
    }
    /// <summary>
    /// Returns the total number of times a given sequence appears in a string.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="sequence"></param>
    /// <param name="ignoreCase">
    /// True, to ignore the difference in case between the sequence and the original string.
    /// </param>
    /// <returns>
    /// An integer showing the number of sequence in the input
    /// </returns>
    public static int CountString(string input, string sequence, bool ignoreCase)
    {
      if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(sequence)) return 0;
      int count = 0;
      for (int i = 0; i < input.Length; i++)
      {
        if (i + sequence.Length > input.Length)
        {
          break; // sequence doesn't fit anymore
        }

        string inputSegment = input.Substring(i, sequence.Length); // holds the current segment being compared
        if (string.Compare(inputSegment, sequence, ignoreCase) == 0)
        {
          count++; // another match found
        }
      }

      return count;
    }
    /// <summary>
    /// Returns an array of every index where a sequence is found on the specified string. Note: Overlaps will be counted.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="sequence"></param>
    /// <param name="ignoreCase">
    /// True, to ignore the difference in case between the sequence and the original string.
    /// </param>
    /// <returns></returns>
    public static int[] IndexOfAll(string input, string sequence, bool ignoreCase)
    {
      if (string.IsNullOrEmpty(input)) return new int[0]; // empty array
      var indices = new List<int>();
      for (int i = 0; i < input.Length; i++)
      {
        if (i + sequence.Length > input.Length) break; // sequence doesn't fit anymore
        string inputSegment = input.Substring(i, sequence.Length); // holds the current segment being compared
        if (string.Compare(inputSegment, sequence, ignoreCase) == 0) indices.Add(i);
      }

      // Copy entries over to an array
      int[] output = indices.ToArray();
      indices.Clear();
      return output;
    }

    /// <summary>
    /// Returns an array of every index where a sequence is found on the specified string. Note: Overlaps will be counted.
    /// </summary>
    /// <param name="input">
    /// The original string.
    /// </param>
    /// <param name="sequence">
    /// The string sequence to seek.
    /// </param>
    /// <param name="startIndex">
    /// Index from which to start seeking.
    /// </param>
    /// <param name="ignoreCase">
    /// True, to ignore the difference in case between the sequence and the original string.
    /// </param>
    /// <returns>
    /// Returns an array of every index where a sequence is found on the specified string. Note: Overlaps will be counted.
    /// </returns>
    public static int[] IndexOfAll(string input, string sequence, int startIndex, bool ignoreCase)
    {
      if (string.IsNullOrEmpty(input))
      {
        return new int[0]; // empty array
      }

      var indices = new List<int>();
      for (int i = startIndex; i < input.Length; i++)
      {
        if (i + sequence.Length > input.Length)
          break; // sequence doesn't fit anymore
        string inputSegment = input.Substring(i, sequence.Length); // holds the current segment being compared
        if (string.Compare(inputSegment, sequence, ignoreCase) == 0)
        {
          indices.Add(i);
        }
      }

      // Copy entries over to an array
      int[] output = indices.ToArray();
      indices.Clear();
      return output;
    }

    /// <summary>
    /// Returns whether the letter casing in a string is alternating.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>
    /// Returns whether the letter casing in a string is alternating.
    /// </returns>
    public static bool IsAlternateCases(string input)
    {
      if (string.IsNullOrEmpty(input) || input.Length == 1) return false;
      bool isLastUpper = char.IsUpper(input[0]);
      for (int i = 1; i < input.Length; i++)
      {
        if (isLastUpper)
        {
          if (char.IsUpper(input[i]))
          {
            return false; // two upper-cases in a row
          }
        }
        else
        {
          if (char.IsLower(input[i]))
          {
            return false; // two lower-cases in a row
          }
        }

        isLastUpper = !isLastUpper; // alternate
      }

      return true;
    }

    /// <summary>
    /// Returns true if the first character in a string is upper case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>
    /// Returns true if the first character in a string is upper case.
    /// </returns>
    public static bool IsCapitalized(string input)
    {
      return !string.IsNullOrEmpty(input) && char.IsUpper(input[0]);
    }

    /// <summary>
    /// Returns whether a string is in all lower case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>
    /// Returns whether a string is in all lower case.
    /// </returns>
    public static bool IsLowerCase(string input)
    {
      if (string.IsNullOrEmpty(input)) return false;
      for (int i = 0; i < input.Length; i++)
      {
        // A single non-lower case character makes function false,
        // unless it is a chracter other than a letter
        if (!char.IsLower(input[i]) && char.IsLetter(input[i]))
        {
          return false;
        }
      }

      return true;
    }

    public static bool IsLowerCase2(string input)
    {
      //  Returns whether a string is in all lower case.
      if (string.IsNullOrEmpty(input)) return false;
      return input.ToLower() == input;
    }

    /// <summary>
    /// Returns whether a string is in all upper case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>
    /// Returns whether a string is in all upper case.
    /// </returns>
    public static bool IsUpperCase(string input)
    {
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      for (int i = 0; i < input.Length; i++)
      {
        // A single non-upper case character makes function false,
        // unless it is a chracter other than a letter
        if (!char.IsUpper(input[i]) && char.IsLetter(input[i]))
        {
          return false;
        }
      }

      return true;
    }

    /// <summary>
    /// Returns whether a string is in all upper case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>
    /// Returns whether a string is in all upper case.
    /// </returns>
    public static bool IsUpperCase2(string input)
    {
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      return input.ToUpper() == input;
    }

    /// <summary>
    /// Returns whether a string contains any vowel letters
    /// </summary>
    /// <param name="input"></param>
    /// <returns>
    /// Returns whether a string contains any vowel letters
    /// </returns>
    public static bool HasVowels(string input)
    {
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      return input.Any(t => t == 'a' || t == 'A' || t == 'e' || t == 'E' || t == 'i' || t == 'I' || t == 'o' || t == 'O' || t == 'u' || t == 'U' || t == 'y' || t == 'Y');
    }

    public static bool HasConsonants(string input)
    {
      // Returns whether a string contains any consonant letters
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      return input.Any(t => t == 'b' || t == 'B' ||
      t == 'c' || t == 'C' ||
      t == 'd' || t == 'D' ||
      t == 'f' || t == 'F' ||
      t == 'g' || t == 'G' ||
      t == 'h' || t == 'H' ||
      t == 'j' || t == 'J' ||
      t == 'k' || t == 'K' ||
      t == 'l' || t == 'L' ||
      t == 'm' || t == 'M' ||
      t == 'n' || t == 'N' ||
      t == 'p' || t == 'P' ||
      t == 'q' || t == 'Q' ||
      t == 'r' || t == 'R' ||
      t == 's' || t == 'S' ||
      t == 't' || t == 'T' ||
      t == 'v' || t == 'V' ||
      t == 'w' || t == 'W' ||
      t == 'x' || t == 'X' ||
      t == 'z' || t == 'Z');
    }

    public static bool IsSpaces(string input)
    {
      // //  Returns whether a string is all empty spaces
      return string.IsNullOrEmpty(input) || input.Replace(" ", string.Empty).Length == 0;
    }

    public static bool IsRepeatedChar(string input)
    {
      // //  Returns whether a string is composed of only a single character.
      return string.IsNullOrEmpty(input) || input.Replace(input[0].ToString(CultureInfo.InvariantCulture), string.Empty).Length == 0;
    }

    public static bool IsNumeric2(string input)
    {
      // Returns whether a string is composed of only numeric characters.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      for (int i = 0; i < input.Length; i++)
      {
        if (!char.IsNumber(input[i]))
        {
          // single non-numeric integer makes function false
          return false;
        }
      }

      return true;
    }

    public static bool IsNumeric(string valueInNumeric)
    {
      if (valueInNumeric == string.Empty)
      {
        return false;
      }

      bool isFine = true;
      foreach (char caracter in valueInNumeric)
      {
        if (!(caracter >= '0' && caracter <= '9'))
        {
          isFine = false;
        }
      }

      return isFine;
    }

    public static bool IsNumeric3(string val, NumberStyles numberStyle)
    {
      double result;
      return double.TryParse(val, numberStyle, CultureInfo.CurrentCulture, out result);
    }

    public static bool HasNumeric(string input)
    {
      // Returns whether a string contains any numberic characters.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      for (int i = 0; i < input.Length; i++)
      {
        if (char.IsNumber(input[i]))
        {
          return true; //  single numeric integer makes function true
        }
      }

      return false;
    }

    public static bool IsAlphaNumeric(string input)
    {
      //  Returns whether a string is composed of only letter and digit characters.
      if (string.IsNullOrEmpty(input)) return false;
      for (int i = 0; i < input.Length; i++)
      {
        if (!char.IsLetter(input[i]) && !char.IsNumber(input[i]))
          return false;
      }

      return true;
    }

    /// <summary>
    /// Returns whether a string is composed of only letter characters.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsOnlyLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
    }

    public static bool HasSomeLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsLetter);
    }

    public static bool HasSomeLowerCaseLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsLower);
    }

    /// <summary>
    /// Returns whether a string has at least one upper case letter.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool HasSomeUpperCaseLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsUpper);
    }

    public static bool HasLettersOrDigits(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsLetterOrDigit);
    }

    public static bool HasSymbols(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsSymbol);
    }

    public static bool IsTitle(string input)
    {
      // //  Returns whether a string is formatted like a title, ie the first chracter of each word is capitalized. 
      // //  Words must be separated by spaces.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      string[] words = input.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (!char.IsUpper(words[i][0]))
          {
            return false;
          }
        }
      }

      return true;
    }

    public static bool IsTitle(string input, string separator)
    {
      //  Returns whether a string is formatted like a title, ie the first chracter of each word is capitalized. 
      //  Words are separated according to the sepecified string sequence.
      //  <param name="input">The original string.</param>
      //  <param name="separator">The string sequence that separates words.</param>
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      string[] words = input.Split(separator.ToCharArray());
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (!char.IsUpper(words[i][0]))
          {
            return false;
          }
        }
      }

      return true;
    }

    public static bool IsEmailAddress(string input)
    {
      // //  Returns whether a string is in a valid email address format.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      //  any email address will be at least 5 characters (a@a.fr)
      if (input.IndexOf('@') != -1 && input.Length >= 8)
      {
        int indexOfDot = input.LastIndexOf('.');

        //  last period must be after the @ 
        //  valid for a firstName.LastName@someFAI.com
        if (indexOfDot > input.IndexOf('@'))
        {
          return true;
        }
      }

      return false;
    }

    public static bool IsEmailAddressValid(string s)
    {
      Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,13}$"); // 13 characters since .international
      return regex.IsMatch(s);
    }

    public static char[] LoadAlphabetInCharArray(bool addDigit = true, bool addLowerCaseLetters = true, bool addUpperCaseLetters = false)
    {
      char[] list = new char[26 + 26 + 10]; // lower case + upper case letters + 10 digits
      int counter = 0;
      if (addLowerCaseLetters)
      {
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
          list[counter] = letter;
          counter++;
        }
      }

      if (addUpperCaseLetters)
      {
        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
          list[counter] = letter;
          counter++;
        }
      }

      if (addDigit)
      {
        for (short digit = 48; digit < 58; digit++) // 48 = asc('0')
        {
          list[counter] = (char)digit;
          counter++;
        }
      }

      return list;
    }

    public static string[] LoadAlphabetInStringArray(string[] list)
    {
      if (list.Length == 0)
      {
        return new string[0];
      }

      int counter = 0;
      for (char letter = 'a'; letter <= 'z'; letter++)
      {
        list[counter] = letter.ToString(CultureInfo.InvariantCulture);
        counter++;
      }

      for (short digit = 0; digit < 10; digit++)
      {
        list[counter] = digit.ToString(CultureInfo.InvariantCulture);
        counter++;
      }

      return list;
    }

    public static List<string> GetAlphabetToList(bool addLowerCaseLetters = true, bool addUpperCaseLetters = false,
      bool addDigit = true, LetterCasingSequence letterSequence = LetterCasingSequence.LowerUpperDigit)
    {
      List<string> list = new List<string>();
      switch (letterSequence)
      {
        case LetterCasingSequence.LowerUpperDigit:
          list = AddLowerCaseLetters(list);
          list = AddUpperCaseLetters(list);
          list = AddDigits(list);
          break;
        case LetterCasingSequence.UpperLowerDigit:
          list = AddUpperCaseLetters(list);
          list = AddLowerCaseLetters(list);
          list = AddDigits(list);
          break;
        case LetterCasingSequence.DigitLowerUpper:
          list = AddDigits(list);
          list = AddLowerCaseLetters(list);
          list = AddUpperCaseLetters(list);
          break;
        case LetterCasingSequence.DigitUpperLower:
          list = AddDigits(list);
          list = AddUpperCaseLetters(list);
          list = AddLowerCaseLetters(list);
          break;
        case LetterCasingSequence.LowerDigitUpper:
          list = AddLowerCaseLetters(list);
          list = AddDigits(list);
          list = AddUpperCaseLetters(list);
          break;
        case LetterCasingSequence.UpperDigitLower:
          list = AddUpperCaseLetters(list);
          list = AddDigits(list);
          list = AddLowerCaseLetters(list);
          break;
      }

      return list;
    }

    public static List<string> AddDigits(List<string> startingList)
    {
      for (short digit = 0; digit < 10; digit++)
      {
        startingList.Add(digit.ToString(CultureInfo.InvariantCulture));
      }

      return startingList;
    }

    public static List<string> AddLowerCaseLetters(List<string> startingList)
    {
      for (char letter = 'a'; letter <= 'z'; letter++)
      {
        startingList.Add(letter.ToString(CultureInfo.InvariantCulture));
      }

      return startingList;
    }

    public static List<string> AddUpperCaseLetters(List<string> startingList)
    {
      for (char letter = 'A'; letter <= 'Z'; letter++)
      {
        startingList.Add(letter.ToString(CultureInfo.InvariantCulture));
      }

      return startingList;
    }

    public static string NumberToEnglishWords(int number)
    {
      if (number == 0)
      {
        return "zero";
      }

      if (number < 0)
      {
        return "minus " + NumberToEnglishWords(Math.Abs(number));
      }

      string words = string.Empty;

      if (number / 1000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000) + " billion ";
        number %= 1000000000;
      }

      if (number / 1000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if (number / 1000 > 0)
      {
        words += NumberToEnglishWords(number / 1000) + " thousand ";
        number %= 1000;
      }

      if (number / 100 > 0)
      {
        words += NumberToEnglishWords(number / 100) + " hundred ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "and ";
        }

        var unitsMap = new[]
          {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
          };
        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if (number % 10 > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words.Trim();
    }

    public static string NumberToEnglishWords(long number)
    {
      if (number == 0)
      {
        return "zero";
      }

      if (number < 0)
      {
        return "minus " + NumberToEnglishWords(Math.Abs(number));
      }

      string words = string.Empty;

      if (number / 1000000000000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000000) + " quintillion ";
        number %= 1000000000000000000;
      }

      if (number / 1000000000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000) + " quadrillion ";
        number %= 1000000000000000;
      }

      if (number / 1000000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000) + " trillion ";
        number %= 1000000000000;
      }

      if (number / 1000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000) + " billion ";
        number %= 1000000000;
      }

      if (number / 1000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if (number / 1000 > 0)
      {
        words += NumberToEnglishWords(number / 1000) + " thousand ";
        number %= 1000;
      }

      if (number / 100 > 0)
      {
        words += NumberToEnglishWords(number / 100) + " hundred ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "and ";
        }

        var unitsMap = new[]
          {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
          };
        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if (number % 10 > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words.Trim();
    }

    public static string NumberToEnglishWords(ulong number)
    {
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      if (number == 0)
      {
        return "zero";
      }

      string words = string.Empty;

      if (number / 1000000000000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000000) + " quintillion ";
        number %= 1000000000000000000;
      }

      if (number / 1000000000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000) + " quadrillion ";
        number %= 1000000000000000;
      }

      if (number / 1000000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000) + " trillion ";
        number %= 1000000000000;
      }

      if (number / 1000000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000000) + " billion ";
        number %= 1000000000;
      }

      if (number / 1000000 > 0)
      {
        words += NumberToEnglishWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if (number / 1000 > 0)
      {
        words += NumberToEnglishWords(number / 1000) + " thousand ";
        number %= 1000;
      }

      if (number / 100 > 0)
      {
        words += NumberToEnglishWords(number / 100) + " hundred ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "and ";
        }

        var unitsMap = new[]
          {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
          };
        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if (number % 10 > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words.Trim();
    }

    public static string NumberToFrenchWords(int number)
    {
      if (number == 0)
      {
        return "zéro";
      }

      if (number < 0)
      {
        return "moins " + NumberToFrenchWords(Math.Abs(number));
      }

      string words = string.Empty;

      if (number / 1000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000) + " milliard ";
        number %= 1000000000;
      }

      if (number / 1000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if (number / 1000 > 0)
      {
        words += NumberToFrenchWords(number / 1000) + " mille ";
        number %= 1000;
      }

      if (number / 100 > 0)
      {
        words += NumberToFrenchWords(number / 100) + " cent ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "et ";
        }

        var unitsMap = new[]
          {
            "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze",
            "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"
          };
        var tensMap = new[]
          {
            "zéro", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt",
            "quatre-vingt-dix"
          };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if (number % 10 > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words.Trim();
    }

    public static string NumberToFrenchWords(long number)
    {
      if (number == 0)
      {
        return "zéro";
      }

      if (number < 0)
      {
        return "moins " + NumberToFrenchWords(Math.Abs(number));
      }

      string words = string.Empty;

      if (number / 1000000000000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000000) + " trillion ";
        number %= 1000000000000000000;
      }

      if (number / 1000000000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000) + " billiard ";
        number %= 1000000000000000;
      }

      if (number / 1000000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000) + " billion ";
        number %= 1000000000000;
      }

      if (number / 1000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000) + " milliard ";
        number %= 1000000000;
      }

      if (number / 1000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if (number / 1000 > 0)
      {
        words += NumberToFrenchWords(number / 1000) + " mille ";
        number %= 1000;
      }

      if (number / 100 > 0)
      {
        words += NumberToFrenchWords(number / 100) + " cent ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "et ";
        }

        var unitsMap = new[]
          {
            "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze",
            "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"
          };
        var tensMap = new[]
          {
            "zéro", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt",
            "quatre-vingt-dix"
          };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if (number % 10 > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words.Trim();
    }

    public static string NumberToFrenchWords(ulong number)
    {
      if (number == 0)
      {
        return "zéro";
      }

      string words = string.Empty;

      if (number / 1000000000000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000000) + " trillion ";
        number %= 1000000000000000000;
      }

      if (number / 1000000000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000) + " billiard ";
        number %= 1000000000000000;
      }

      if (number / 1000000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000) + " billion ";
        number %= 1000000000000;
      }

      if (number / 1000000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000000) + " milliard ";
        number %= 1000000000;
      }

      if (number / 1000000 > 0)
      {
        words += NumberToFrenchWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if (number / 1000 > 0)
      {
        words += NumberToFrenchWords(number / 1000) + " mille ";
        number %= 1000;
      }

      if (number / 100 > 0)
      {
        words += NumberToFrenchWords(number / 100) + " cent ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "et ";
        }

        var unitsMap = new[]
          {
            "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze",
            "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"
          };
        var tensMap = new[]
          {
            "zéro", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt",
            "quatre-vingt-dix"
          };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if (number % 10 > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words.Trim();
    }

    public static Dictionary<int, string> DicoNumberToFrenchWords(int startNumber, int endNumber)
    {
      Dictionary<int, string> result = new Dictionary<int, string>();
      for (int i = startNumber; i < endNumber; i++)
      {
        result.Add(i, NumberToFrenchWords(i));
      }

      return result;
    }

    public static Dictionary<int, string> DicoNumberToEnglishWords(int startNumber, int endNumber)
    {
      Dictionary<int, string> result = new Dictionary<int, string>();
      for (int i = startNumber; i < endNumber; i++)
      {
        result.Add(i, NumberToEnglishWords(i));
      }

      return result;
    }

    public static bool IsInside(int number, params int[] array)
    {
      return array.Where(item => number == item).Any();
    }

    public static bool IsInside(string number, params string[] array)
    {
      return array.Any(item => number == item);
    }

    public static bool IsInList(string word, string[] listOfWords)
    {
      bool result = false;
      // LINQ return listOfWords.Any(wordInList => string.Compare(word, wordInList, StringComparison.InvariantCultureIgnoreCase) == 0);
      foreach (string wordInList in listOfWords)
      {
        if (string.Compare(word, wordInList, StringComparison.InvariantCultureIgnoreCase) == 0)
        {
          result = true;
          break;
        }
      }

      return result;
    }

    public static string ToTitleCase(string myString)
    {
      return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myString.ToLower());
    }

    public static string UpperCaseFirstLetter(string value)
    {
      // Uppercase the first letter in the string this extension is called on.
      if (value.Length > 0)
      {
        char[] array = value.ToCharArray();
        array[0] = char.ToUpper(array[0]);
        return new string(array);
      }

      return value;
    }

    public static char[] GetAlphabet(bool lowerCase = true)
    {
      char[] list = new char[26];
      int counter = 0;
      for (char letter = 'a'; letter <= 'z'; letter++)
      {
        list[counter] = lowerCase ? letter : char.ToUpper(letter);
        counter++;
      }

      return list;
    }

    public static string ReplaceCharacters(string originalString, char oldChar = ' ', char newChar = ' ')
    {
      return originalString.Replace(oldChar, newChar);
    }

    public static string GenerateGuid()
    {
      return new Guid().ToString();
    }

    public static string GenerateUniqueFilename(string directoryPath,
      RandomCharacters rdnCharacters = RandomCharacters.LowerCase,
      byte length = 8,
      bool withFileExtension = false,
      string fileExtension = "txt")
    {
      if (directoryPath == string.Empty)
      {
        return string.Empty;
      }

      if (!Directory.Exists(directoryPath))
      {
        return string.Empty;
      }

      string result = string.Empty;
      do
      {
        result = GenerateRandomString(new[] { ' ' }, true, rdnCharacters, length, true);
        if (withFileExtension)
        {
          result += "." + fileExtension;
        }
      } while (File.Exists(Path.Combine(directoryPath, result)));

      return result;
    }

    public static string GenerateRandomLongString(char[] forbiddenCharacters,
      bool hasForbiddenCharacters = false,
      RandomCharacters rdnCharacters = RandomCharacters.LowerCase, int length = 8,
      bool isWindowsFileName = false)
    {
      if (length < byte.MaxValue)
      {
        return GenerateRandomString(forbiddenCharacters, hasForbiddenCharacters, rdnCharacters, (byte)length, isWindowsFileName);
      }

      string result = string.Empty;
      int leftOver = length % 254;
      for (int i = 1; i <= Math.Floor((decimal)(length / 254)); i++)
      {
        result += GenerateRandomString(forbiddenCharacters, hasForbiddenCharacters, rdnCharacters, 254, isWindowsFileName);
      }

      if (leftOver != 0)
      {
        result += GenerateRandomString(forbiddenCharacters, hasForbiddenCharacters, rdnCharacters, (byte)leftOver, isWindowsFileName);
      }

      return result;
    }

    public static string GenerateRandomString(char[] forbiddenCharacters,
      bool hasForbiddenCharacters = false,
      RandomCharacters rdnCharacters = RandomCharacters.LowerCase, byte length = 8,
      bool isWindowsFileName = false)
    {
      if (length > byte.MaxValue)
      {
        length = byte.MaxValue;
      }

      char[] forbiddenWindowsFilenameCharacters = { '\\', '/', ':', '*', '?', '\"', '<', '>', '|' };
      char[] upperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
      char[] lowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
      char[] digitCharacters = "0123456789".ToCharArray();
      char[] specialCharacters = ",.;:?!/@#$%^&()=+*-_{}[]|~".ToCharArray();
      char[] searchedCharacters = new char[26 + 26 + 10 + 26]; // max size

      // int numberOfCharactersToPickFrom = (int)rdnCharacters;
      if (isWindowsFileName)
      {
        forbiddenCharacters = AddCharArray(forbiddenCharacters, forbiddenWindowsFilenameCharacters, new[] { ' ' });
        char[] badWindowsFileName = { ',', '!', '.', ';', '@', '#', '$', '%', '^', '&', '(', ')', '=', '+', '{', '}', '~' };
        forbiddenCharacters = AddCharArray(forbiddenCharacters, badWindowsFileName, new[] { ' ' });
      }

      switch (rdnCharacters)
      {
        case RandomCharacters.LowerCase:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.UpperCase:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.Digit:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.SpecialCharacter:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.UpperLower:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.DigitSpecialChar:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.LowerDigit:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.LowerSpecialChar:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperDigit:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperLowerDigit:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperSpecialChar:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperLowerSpecial:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperDigitSpecial:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperLowerDigitSpecial:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;

        default:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters).ToCharArray();
          break;
      }

      // once we have the SearchedCharacters filled out, we can select random characters from it
      string result = string.Empty;
      for (int i = 0; i < length; i++)
      {
        result += searchedCharacters[MathFunc.GenerateRandomNumberUsingCrypto(0, searchedCharacters.Length - 1)];
      }

      return result;
    }

    public static string FillSearchedCharWithoutForbiddenChar(char[] source, char[] forbiddenCharacters)
    {
      string result = string.Empty;
      foreach (char item in source)
      {
        if (forbiddenCharacters != null)
        {
          if (!forbiddenCharacters.Contains(item))
          {
            result += item.ToString();
          }
        }
        else
        {
          result += item.ToString();
        }
      }

      return result;
    }

    public static char[] AddCharArray(char[] source, char[] toBeAdded, char[] forbiddenCharacters)
    {
      List<char> tmpSource = source.ToList();
      List<char> tmpToBeAdded = toBeAdded.ToList();
      List<char> tmpforbiddenChar = forbiddenCharacters.ToList();
      foreach (char item in tmpToBeAdded)
      {
        if (!tmpforbiddenChar.Contains(item))
        {
          tmpSource.Add(item);
        }
      }

      return tmpSource.ToArray();
    }

    public static string GenerateCharactersFromSource(List<string> source, int numberOfCharacters = 1)
    {
      if (source == null || source.Count == 0)
      {
        return string.Empty;
      }

      string result = string.Empty;
      for (int i = 0; i < numberOfCharacters; i++)
      {
        result += source[MathFunc.GenerateRandomNumberUsingCrypto(0, source.Count - 1)];
      }

      return result;
    }

    public static string ByteArrayToString(byte[] bytes)
    {
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        sb.Append(bytes[i].ToString("X2"));
      }

      return sb.ToString();
    }

    /// Converts a hex string to a byte array
    /// <param name="hexaString">The hex string to convert</param>
    /// <returns>A byte array representing the hex string</returns>
    public static byte[] HexStringToByteArray(string hexaString)
    {
      if (hexaString.Length % 2 != 0)
      {
        return new byte[] { };
      }

      byte[] returnBytes = new byte[hexaString.Length / 2];
      for (int i = 0; i < returnBytes.Length; i++)
      {
        returnBytes[i] = Convert.ToByte(hexaString.Substring(i * 2, 2), 16);
      }

      return returnBytes;
    }

    public static string ReplaceWindowsForbiddenCharacters(string input, string charToReplaced = "")
    {
      string result = input;
      string[] forbiddenWindowsFilenameCharacters = { "\\", "/", ":", "*", "?", "\"", "<", ">", "|" };
      foreach (var item in forbiddenWindowsFilenameCharacters)
      {
        result = result.Replace(item, charToReplaced);
      }

      return result;
    }

    public static string RemoveAllNonLetterCharacters(string input, string[] charsToRemove)
    {
      // return String.Join("", input.Split('@', ',' ,'.' ,';', '\''));
      foreach (var c in charsToRemove)
      {
        input = input.Replace(c, string.Empty);
      }

      return input;
    }

    public static string RemoveAllNonLetterCharacters(string input, char[] charsToRemove)
    {
      return string.Join("", input.Split(charsToRemove));
    }

    public static string RemoveAllNonLetterCharacters(string input)
    {
      return new string((from c in input
                         where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                         select c
       ).ToArray());
    }

    public static string InsertStringAtBegining(string myString, string stringToBeinserted, char characterToSkip = ' ')
    {
      // TODO In PARAMETER char[]
      if (myString == string.Empty)
      {
        return string.Empty;
      }

      string result = myString;
      int firstIndexOf = 0;
      for (int i = 0; i < myString.Length; i++)
      {
        if (myString[i] == characterToSkip || myString[i] == '\t')
        {
          firstIndexOf++;
        }
        else
        {
          break;
        }
      }

      string blanks = myString.Substring(0, firstIndexOf);
      string afterBlanks = myString.Substring(firstIndexOf, myString.Length - blanks.Length);
      result = blanks + stringToBeinserted + afterBlanks;
      return result;
    }

    public static string AddTabulation(int numberOfTabulationSpace = 1)
    {
      if (numberOfTabulationSpace < 0)
      {
        numberOfTabulationSpace = 0;
      }

      string result = string.Empty;
      for (int i = 0; i < numberOfTabulationSpace; i++)
      {
        result += " ";
      }

      return result;
    }

    public static string Space(byte numberOfSpace = 1)
    {
      string result = string.Empty;
      for (int i = 0; i < numberOfSpace; i++)
      {
        result += " ";
      }

      return result;
    }

    public static Dictionary<char, int> CountLetters(string myString, bool wholeDictionary = true)
    {
      var input = myString.ToLower();
      var result = new Dictionary<char, int>();
      if (wholeDictionary)
      {
        for (char i = 'a'; i <= 'z'; i++)
        {
          result.Add(i, 0);
        }
      }

      for (int i = 0; i <= input.Length - 1; i++)
      {
        if (result.ContainsKey(input[i]))
        {
          result[input[i]]++;
        }
        else
        {
          if (char.IsLetter(input[i]))
          {
            if (!wholeDictionary)
            {
              result.Add(input[i], 1);
            }
            else
            {
              result[input[i]]++;
            }

          }
        }
      }

      return result;
    }

    public static int[] CountLetters2(string text)
    {
      int[] resultTmp = new int[240];
      foreach (char letter in text)
      {
        if (char.IsLetter(letter))
        {
          resultTmp[letter]++;
        }
      }

      int[] result = new int[27];
      for (int i = 1; i < 27; i++)
      {
        // ASCII code table
        // A = 65
        // Z = 90
        // a = 97
        // z = 122
        result[i] = resultTmp[i + 64] + resultTmp[i + 96];
      }

      return result;
    }

    public static int[] CountLetters3(string text)
    {
      int[] result = new int[27];
      foreach (char letter in text)
      {
        if (char.IsLetter(letter)) // exclude numerics, special char
        {
          char letterTmp = letter.ToString().ToLower().ToCharArray()[0];
          if (letterTmp >= 97 && letterTmp <= 122) // exclude accented letters
          {
            result[letterTmp - 96]++;
          }
        }
      }

      return result;
    }

    public static int CountWords(string input)
    {
      return input.Split(' ').Length;
    }

    public static Dictionary<string, int> GetDictionaryWords(string input,
      bool caseSensitive = true, DefaultCasing defaultLowerCase = DefaultCasing.DefaultLowerCase)
    {
      if (input == "")
      {
        return new Dictionary<string, int>();
      }

      var result = new Dictionary<string, int>();
      string[] words = input.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        if (caseSensitive)
        {
          if (result.ContainsKey(words[i]))
          {
            result[words[i]]++;
          }
          else
          {
            result.Add(words[i], 1);
          }
        }
        else
        {
          if (defaultLowerCase == DefaultCasing.DefaultLowerCase)
          {
            if (result.ContainsKey(words[i]) || result.ContainsKey(words[i].ToLower()))
            {
              result[words[i].ToLower()]++;
            }
            else
            {
              result.Add(words[i].ToLower(), 1);
            }
          }
          else if (defaultLowerCase == DefaultCasing.DefaultUpperCase)
          {
            if (result.ContainsKey(words[i]) || result.ContainsKey(words[i].ToUpper()))
            {
              result[words[i].ToUpper()]++;
            }
            else
            {
              result.Add(words[i].ToUpper(), 1);
            }
          }
          else if (defaultLowerCase == DefaultCasing.DefaultAsIs)
          {
            if (result.ContainsKey(words[i]))
            {
              result[words[i]]++;
            }
            else
            {
              result.Add(words[i], 1);
            }
          }
        }
      }

      return result;
    }

    public static string[] SeparateQuote(string wholeQuote)
    {
      string[] result = new string[2];
      if (wholeQuote.Length < 4)
      {
        return result;
      }

      if (!wholeQuote.Contains('-'))
      {
        return result;
      }

      var lastIndex = wholeQuote.LastIndexOf('-');
      result[0] = wholeQuote.Substring(0, lastIndex - 1);
      result[1] = wholeQuote.Substring(lastIndex + 2);
      return result;
    }

    public static string GetCapitalLetters(string input)
    {
      return input.Where(char.IsUpper).Aggregate(string.Empty, (current, t) => current + t);
      //string result = string.Empty;
      //for (int i = 0; i < input.Length; i++)
      //{
      //  if (char.IsUpper(input[i]))
      //  {
      //    result += input[i];
      //  }
      //}

      //return result;
    }

    public static string ToPascalCase(string s)
    {
      if (s == string.Empty)
      {
        return string.Empty;
      }

      return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
    }

    public static string ToTitleCase2(string s)
    {
      var upperCase = s.ToUpper();
      var words = upperCase.Split(' ');
      var minorWords = new[] {"ON", "IN", "AT", "OFF", "WITH", "TO", "AS", "BY",//prepositions
                                       "THE", "A", "OTHER", "ANOTHER",//articles
                                       "AND", "BUT", "ALSO", "ELSE", "FOR", "IF"};//conjunctions

      var acronyms = new[] {"UK", "USA", "US", "UN", //countries
                                       "BBC", "TF1",//TV stations
                                       "TV"}; //others

      //The first word.
      //The first letter of the first word is always capital.
      if (acronyms.Contains(words[0]))
      {
        words[0] = words[0].ToUpper();
      }
      else
      {
        words[0] = ToPascalCase(words[0]);
      }

      //The rest words.
      for (int i = 0; i < words.Length; i++)
      {
        if (minorWords.Contains(words[i]))
        {
          words[i] = words[i].ToLower();
        }
        else if (acronyms.Contains(words[i]))
        {
          words[i] = words[i].ToUpper();
        }
        else
        {
          words[i] = ToPascalCase(words[i]);
        }
      }

      return string.Join(" ", words);
    }

    public static string ToTwoDigits(ushort number)
    {
      return number < 10 ? "0" + number : number.ToString();
    }

    public static string ToNDigits(ushort number, byte numberLength = 1)
    {
      string zeros = string.Empty;
      for (int i = 0; i < numberLength - number.ToString().Length; i++)
      {
        zeros += "0";
      }

      return zeros + number;
    }

    public static string AddSpaceInNumberWithDecimal(decimal number)
    {
      return $"{number:n}";
    }

    public static string AddSpaceInNumber(long number)
    {
      return $"{number:n0}";
    }

    public static string AddCommaInNumber(long number)
    {
      return $"{number:#,#}";
    }

    public static string FrenchPlural(int number, string currentLanguage = "english")
    {
      return number > 1 && currentLanguage.ToLower() == "french" ? "s" : string.Empty;
    }

    public static string GetNumbers(string myString)
    {
      return myString.Where(char.IsNumber).Aggregate(string.Empty, (current, c) => current + c);
    }

    public static bool ContainsIgnoreCase(string source, string toCheck)
    {
      return source.IndexOf(toCheck, StringComparison.InvariantCultureIgnoreCase) >= 0;
    }

    public static string InvertModifier(string text, bool correctCasing = true)
    {
      if (text == string.Empty)
      {
        return string.Empty;
      }

      if (text.Split(' ').Length != 2)
      {
        return string.Empty;
      }

      string result = text.Split(' ')[1] + " ";
      result += correctCasing ? text.Split(' ')[0].ToLower() : text.Split(' ')[0];
      return result;
    }

    public static string AddSlash(string myString)
    {
      return myString.EndsWith("\\") ? myString : myString + "\\";
    }

    public static bool CheckInjectionInUserNameAndPassword(string input)
    {
      try
      {
        for (int i = 0; i < input.Length; i++)
        {
          string oneChar = input[i].ToString();
          if (oneChar == "'" || oneChar == "-" || oneChar == "&")
          {
            return false;
          }
        }

        int position = input.IndexOf("<script>", StringComparison.InvariantCultureIgnoreCase);
        if (position > -1)
        {
          return false;
        }

        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public static bool CheckHash(string sourceData, byte[] compareTo)
    {
      // Create a byte array from the source data
      byte[] tmpSource = Encoding.ASCII.GetBytes(sourceData);

      //Compute hash based on the source data
      byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
      //return tmpHash == compareTo; // returns false because 2 different objects
      return CompareByteArray(tmpHash, compareTo);
    }

    public static bool CompareByteArray(byte[] b1, byte[] b2)
    {
      bool result = b1.Length == b2.Length;

      for (int i = 0; i < Math.Min(b1.Length, b2.Length); i++)
      {
        if (b1[i] != b2[i])
        {
          result = false;
        }
      }

      return result;
    }

    public static string GetGitUrl(string[] lines)
    {
      string result = string.Empty;
      foreach (string line in lines)
      {
        if (line.Contains("url = https://github.com/"))
        {
          result = line.Split('=')[1].Trim();
        }
      }

      return result;
    }

    public static string CreateFilterString(string extension)
    {
      //TODO unit tests to be written
      // sample:
      //"solution files (*.sln)|*.sln|Projects files (*.csproj)|*.csproj";
      var result = new StringBuilder();
      result.Append(Punctuation.OneSpace);
      result.Append(Punctuation.OpenParenthesis);
      result.Append(Punctuation.Multiply);
      result.Append(Punctuation.Period);
      result.Append(extension);
      result.Append(Punctuation.CloseParenthesis);
      result.Append(Punctuation.Pipe);
      result.Append(Punctuation.Multiply);
      result.Append(Punctuation.Period);
      result.Append(extension);
      return result.ToString();
    }

    public static string GoBackOneDirectory(string rootPath)
    {
      if (rootPath == string.Empty)
      {
        return string.Empty;
      }

      string result = string.Empty;
      var tmpResult = rootPath.Split('\\');
      for (int i = 0; i < tmpResult.Length - 1; i++)
      {
        result += tmpResult[i] + "\\";
      }

      return result;
    }

    public static string PadLeft(string inputString, int stringLength = 2)
    {
      string result = inputString;
      // If inputString is less than stringLength characters, pad with leading zeroes.
      if (result.Length < stringLength)
      {
        result = result.PadLeft(stringLength, '0');
      }

      // If inputString is more than stringLength characters, truncate to 12 characters.
      if (result.Length > stringLength)
      {
        result = result.Substring(0, stringLength);
      }

      return result;
    }

    public static string RemoveAccent(string sentence)
    {
      return sentence.Replace('é', 'e').Replace('è', 'e').Replace('ê', 'e').Replace('ù', 'u').Replace('ç', 'c').Replace('à', 'a').Replace('ô', 'o').Replace('â', 'a');

    }

    public static int NumberOfOccurrences(string searchedString, string inString)
    {
      if ((searchedString + "").Length == 0 | (inString + "").Length == 0)
      {
        return 0;
      }

      return (inString.Length - inString.ToLower().Replace(searchedString.ToLower(), "").Length) / searchedString.Length;
    }

    public static int GetPositionOfString(string[] oneArray, string stringToSearch)
    {
      int result = -1; // -1 for no result
      for (int i = 0; i < oneArray.Length; i++)
      {
        if (oneArray[i] == stringToSearch)
        {
          result = i;
          break;
        }
      }

      return result;
    }

    public static string InsertSpaces(string source, bool toLowerCase = false, bool keepFirstLetterInUpperCase = true)
    {
      string result = string.Empty;
      if (!String.IsNullOrEmpty(source))
      {
        int letterCursor = 0;
        foreach (char letter in source)
        {

          if (Char.IsUpper(letter))
          {
            if (letterCursor != 0)
            {
              result += " ";
            }
          }
          
          if (toLowerCase)
          {
            if (letterCursor == 0 && keepFirstLetterInUpperCase)
            {
              result += letter;
            }
            else
            {
              result += letter.ToString().ToLower();
            }
          }
          else
          {
            result += letter;
          }
          
          letterCursor++;
        }
      }

      return result.TrimStart();
    }
  }
}