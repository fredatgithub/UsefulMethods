using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace UsefulMethods
{
  internal class RandomStringGenerator
  {
    public RandomStringGenerator(bool useUpperCaseCharacters = true,
    bool useLowerCaseCharacters = true,
    bool useNumericCharacters = true,
    bool useSpecialCharacters = true)
    {
      m_UseUpperCaseCharacters = useUpperCaseCharacters;
      m_UseLowerCaseCharacters = useLowerCaseCharacters;
      m_UseNumericCharacters = useNumericCharacters;
      m_UseSpecialCharacters = useSpecialCharacters;
      CurrentGeneralCharacters = new char[0]; // avoiding null exceptions
      UpperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
      LowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
      NumericCharacters = "0123456789".ToCharArray();
      SpecialCharacters = ",.;:?!/@#$%^&()=+*-_{}[]|~".ToCharArray();
      MinUpperCaseCharacters = MinLowerCaseCharacters = MinNumericCharacters = MinSpecialCharacters = 0;
      RepeatCharacters = true;
      PatternDriven = false;
      Pattern = "";
      Random = new RNGCryptoServiceProvider();
      ExistingStrings = new List<string>();
    }

    #region character sets managers
    ///
    /// True if we need to use upper case characters
    ///
    public bool UseUpperCaseCharacters
    {
      get
      {
        return m_UseUpperCaseCharacters;
      }
      set
      {
        if (CurrentUpperCaseCharacters != null)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentUpperCaseCharacters).ToArray();
        }
        if (value)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(CurrentUpperCaseCharacters).ToArray();
        }

        m_UseUpperCaseCharacters = value;
      }
    }
    ///
    /// Sets or gets upper case character set.
    ///
    public char[] UpperCaseCharacters
    {
      get
      {
        return CurrentUpperCaseCharacters;
      }
      set
      {
        if (UseUpperCaseCharacters)
        {
          if (CurrentUpperCaseCharacters != null)
          {
            CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentUpperCaseCharacters).ToArray();
          }

          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(value).ToArray();
        }

        CurrentUpperCaseCharacters = value;
      }
    }
    ///
    /// True if we need to use lower case characters
    ///
    public bool UseLowerCaseCharacters
    {
      get
      {
        return m_UseLowerCaseCharacters;
      }
      set
      {
        if (CurrentLowerCaseCharacters != null)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentLowerCaseCharacters).ToArray();
        }
        if (value)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(CurrentLowerCaseCharacters).ToArray();
        }

        m_UseLowerCaseCharacters = value;
      }
    }
    ///
    /// Sets or gets lower case character set.
    ///
    public char[] LowerCaseCharacters
    {
      get
      {
        return CurrentLowerCaseCharacters;
      }
      set
      {
        if (UseLowerCaseCharacters)
        {
          if (CurrentLowerCaseCharacters != null)
          {
            CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentLowerCaseCharacters).ToArray();
          }

          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(value).ToArray();
        }

        CurrentLowerCaseCharacters = value;
      }
    }
    ///
    /// True if we need to use numeric characters
    ///
    public bool UseNumericCharacters
    {
      get
      {
        return m_UseNumericCharacters;
      }
      set
      {
        if (CurrentNumericCharacters != null)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentNumericCharacters).ToArray();
        }
        if (value)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(CurrentNumericCharacters).ToArray();
        }

        m_UseNumericCharacters = value;
      }
    }
    ///
    /// Sets or gets numeric character set.
    ///
    public char[] NumericCharacters
    {
      get
      {
        return CurrentNumericCharacters;
      }
      set
      {
        if (UseNumericCharacters)
        {
          if (CurrentNumericCharacters != null)
          {
            CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentNumericCharacters).ToArray();
          }

          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(value).ToArray();
        }

        CurrentNumericCharacters = value;
      }
    }
    ///
    /// True if we need to use special characters
    ///
    public bool UseSpecialCharacters
    {
      get
      {
        return m_UseSpecialCharacters;
      }
      set
      {
        if (CurrentSpecialCharacters != null)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentSpecialCharacters).ToArray();
        }
        if (value)
        {
          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(CurrentSpecialCharacters).ToArray();
        }

        m_UseSpecialCharacters = value;
      }
    }
    ///
    /// Sets or gets special character set.
    ///
    public char[] SpecialCharacters
    {
      get
      {
        return CurrentSpecialCharacters;
      }
      set
      {
        if (UseSpecialCharacters)
        {
          if (CurrentSpecialCharacters != null)
          {
            CurrentGeneralCharacters = CurrentGeneralCharacters.Except(CurrentSpecialCharacters).ToArray();
          }

          CurrentGeneralCharacters = CurrentGeneralCharacters.Concat(value).ToArray();
        }

        CurrentSpecialCharacters = value;
      }
    }
    #endregion
    #region character limits
    ///
    /// Sets or gets minimal number of the upper case characters in generated strings.
    ///
    public int MinUpperCaseCharacters
    {
      get { return m_MinUpperCaseCharacters; }
      set { m_MinUpperCaseCharacters = value; }
    }
    ///
    /// Sets or gets minimal number of the lower case characters in generated strings.
    ///
    public int MinLowerCaseCharacters
    {
      get { return m_MinLowerCaseCharacters; }
      set { m_MinLowerCaseCharacters = value; }
    }
    ///
    /// Sets or gets minimal number of the numeric characters in generated strings.
    ///
    public int MinNumericCharacters
    {
      get { return m_MinNumericCharacters; }
      set { m_MinNumericCharacters = value; }
    }
    ///
    /// Sets or gets minimal number of the special characters in generated strings.
    ///
    public int MinSpecialCharacters
    {
      get { return m_MinSpecialCharacters; }
      set { m_MinSpecialCharacters = value; }
    }
    #endregion
    #region pattern
    private string m_pattern;
    ///
    /// Defines the pattern to be followed to generate a string.
    /// This value is ignored if it equals empty string.
    /// Patterns are:
    /// L - for upper case letter
    /// l - for lower case letter
    /// n - for number
    /// s - for special character
    /// * - for any character
    ///
    private string Pattern
    {
      get
      {
        return m_pattern;
      }
      set
      {
        PatternDriven = !value.Equals(string.Empty);

        m_pattern = value;
      }
    }
    #endregion
    #region generators
    ///
    /// Generate a string which follows the pattern.
    /// Possible characters are:
    /// L - for upper case letter
    /// l - for lower case letter
    /// n - for number
    /// s - for special character
    /// * - for any character
    ///
    /// The pattern to follow while generation
    /// A random string which follows the pattern
    public string Generate(string pattern)
    {
      Pattern = pattern;
      string res = GenerateString(pattern.Length);
      Pattern = string.Empty;
      return res;
    }
    ///
    /// Generate a string of a variable length from MinLength to MaxLength. The possible
    /// character sets should be defined before calling this function.
    ///
    /// Minimal length of a string
    /// Maximal length of a string
    /// A random string from the selected range of length
    public string Generate(int minLength, int maxLength)
    {
      if (maxLength < minLength)
      {
        //throw new ArgumentException("Maximal length should be greater than minimal");
        maxLength = minLength + 1;
      }

      int length = minLength + GetRandomInt() % (maxLength - minLength);
      return GenerateString(length);
    }
    ///
    /// Generate a string of a fixed length. The possible
    /// character sets should be defined before calling this function.
    ///
    /// The length of a string
    /// A random string of the desirable length
    public string Generate(int fixedLength)
    {
      return GenerateString(fixedLength);
    }
    ///
    /// Main generation method which chooses the algorithm to use for the generation.
    /// It checks some exceptional situations as well.
    ///
    private string GenerateString(int length)
    {
      if (length == 0)
      {
        //throw new ArgumentException("You can't generate a string of a zero length");
        length = 1;
      }
      if (!UseUpperCaseCharacters && !UseLowerCaseCharacters && !UseNumericCharacters && !UseSpecialCharacters)
      {
        //throw new ArgumentException("There should be at least one character set in use");
        UseLowerCaseCharacters = true;
      }

      //if (!RepeatCharacters && (CurrentGeneralCharacters.Length 3 chars).
      //if (UniqueStrings && ExistingStrings.Contains(result))
      //       return GenerateString(length);
      //     AddExistingString(result); // Saving history
      //     return result;
      return string.Empty; // while debug needed
    }

    ///
    /// Generate a random string following the pattern
    ///
    private string PatternDrivenAlgo(string pattern)
    {
      string result = "";
      var characters = new List<string>();
      foreach (char character in pattern.ToCharArray())
      {
        char newChar = ' ';
        switch (character)
        {
          case 'L':
            {
              newChar = GetRandomCharFromArray(CurrentUpperCaseCharacters, characters);
              break;
            }
          case 'l':
            {
              newChar = GetRandomCharFromArray(CurrentLowerCaseCharacters, characters);
              break;
            }
          case 'n':
            {
              newChar = GetRandomCharFromArray(CurrentNumericCharacters, characters);
              break;
            }
          case 's':
            {
              newChar = GetRandomCharFromArray(CurrentSpecialCharacters, characters);
              break;
            }
          case '*':
            {
              newChar = GetRandomCharFromArray(CurrentGeneralCharacters, characters);
              break;
            }
          default:
            {
              throw new Exception("The character '" + character + "' is not supported");
            }
        }

        characters.Add(newChar.ToString());
        result += newChar;
      }
      return result;
    }
    ///
    /// The simplest algorithm of the random string generation. It doesn't pay attention to
    /// limits and patterns.
    ///
    private string SimpleGenerateAlgo(int length)
    {
      string result = "";
      // No special limits
      for (int i = 0; i < length; i++)
      {
        char newChar = CurrentGeneralCharacters[GetRandomInt() % CurrentGeneralCharacters.Length];
        if (!RepeatCharacters && result.Contains(newChar))
        {
          do
          {
            newChar = CurrentGeneralCharacters[GetRandomInt() % CurrentGeneralCharacters.Length];
          } while (result.Contains(newChar));
        }
        result += newChar;
      }
      return result;
    }

    ///
    /// Generate a random string with specified number of minimal characters of each character set.
    ///
    private string GenerateAlgoWithLimits(int length)
    {
      // exceptional situations
      if (MinUpperCaseCharacters + MinLowerCaseCharacters +
      MinNumericCharacters + MinSpecialCharacters > length)
      {
        throw new ArgumentException("Sum of MinUpperCaseCharacters, MinLowerCaseCharacters," +
        " MinNumericCharacters and MinSpecialCharacters is greater than length");
      }
      if (!RepeatCharacters && MinUpperCaseCharacters > CurrentUpperCaseCharacters.Length)
        throw new ArgumentException("Can't generate a string with this number of MinUpperCaseCharacters");
      if (!RepeatCharacters && MinLowerCaseCharacters > CurrentLowerCaseCharacters.Length)
        throw new ArgumentException("Can't generate a string with this number of MinLowerCaseCharacters");
      if (!RepeatCharacters && MinNumericCharacters > CurrentNumericCharacters.Length)
        throw new ArgumentException("Can't generate a string with this number of MinNumericCharacters");
      if (!RepeatCharacters && MinSpecialCharacters > CurrentSpecialCharacters.Length)
        throw new ArgumentException("Can't generate a string with this number of MinSpecialCharacters");
      int allowedNumberOfGeneralChatacters = length - MinUpperCaseCharacters - MinLowerCaseCharacters
      - MinNumericCharacters - MinSpecialCharacters;
      string result = "";
      // generation character set in order to support unique characters
      var characters = new List<string>();
      // adding chars to an array
      //for (int i = 0; i < MinUpperCaseCharacters; i++)
      //  Characters.Add(GetRandomCharFromArray(UpperCaseCharacters, Characters.ToString()));
      //for (int i = 0; i < MinLowerCaseCharacters; i++)
      //  Characters.Add(GetRandomCharFromArray(LowerCaseCharacters.ToString(), Characters));
      //for (int i = 0; i < MinNumericCharacters; i++)
      //  Characters.Add(GetRandomCharFromArray(NumericCharacters, Characters));
      //for (int i = 0; i < MinSpecialCharacters; i++)
      //  Characters.Add(GetRandomCharFromArray(SpecialCharacters, Characters));
      //for (int i = 0; i < AllowedNumberOfGeneralChatacters; i++)
      //  Characters.Add(GetRandomCharFromArray(CurrentGeneralCharacters, Characters));
      // generating result
      for (int i = 0; i < length; i++)
      {
        int position = GetRandomInt() % characters.Count;
        //char CurrentChar = Characters[position];
        characters.RemoveAt(position);
        //result += CurrentChar;
      }
      return result;
    }
    #endregion
    ///
    /// True if characters can be repeated.
    ///
    public bool RepeatCharacters;
    ///
    /// True if it's not possible to create similar strings.
    ///
    //public bool UniqueStrings;
    ///
    /// Adding the string to the history array to support unique string generation.
    ///
    public void AddExistingString(string s)
    {
      ExistingStrings.Add(s);
    }
    #region misc tools
    ///
    /// A 16bit integer number generator.
    ///
    /// A random integer value from 0 to 65576
    private int GetRandomInt()
    {
      byte[] buffer = new byte[2]; // 16 bit = 2^16 = 65576 (more than necessary)
      Random.GetNonZeroBytes(buffer);
      int index = BitConverter.ToInt16(buffer, 0);
      if (index < 0)
        index = -index; // manage negative random values
      return index;
    }
    ///
    /// Get a random char from the selected array of chars. It pays attention to
    /// the RepeatCharacters flag.
    ///
    /// Source of symbols
    /// Existing symbols. Can be null if RepeatCharacters flag is false
    /// A random character from the array
    private char GetRandomCharFromArray(char[] array, List<string> existentItems)
    {
      char character = ' ';
      do
      {
        character = array[GetRandomInt() % array.Length];
      } while (!RepeatCharacters && existentItems.Contains(character.ToString()));

      return character;
    }
    #endregion
    #region internal state
    private bool m_UseUpperCaseCharacters, m_UseLowerCaseCharacters, m_UseNumericCharacters, m_UseSpecialCharacters;
    private int m_MinUpperCaseCharacters, m_MinLowerCaseCharacters, m_MinNumericCharacters, m_MinSpecialCharacters;
    private bool PatternDriven;
    private char[] CurrentUpperCaseCharacters;
    private char[] CurrentLowerCaseCharacters;
    private char[] CurrentNumericCharacters;
    private char[] CurrentSpecialCharacters;
    private char[] CurrentGeneralCharacters; // All used characters
    private RNGCryptoServiceProvider Random;
    private List<string> ExistingStrings; // History
    #endregion
  }
}