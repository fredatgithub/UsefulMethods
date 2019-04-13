namespace UsefulMethods
{
  public enum TimeSpanElement
  {
    Millisecond,
    Second,
    Minute,
    Hour,
    Day
  }

  public enum LetterCasingSequence
  {
    LowerUpperDigit,
    UpperLowerDigit,
    DigitLowerUpper,
    DigitUpperLower,
    LowerDigitUpper,
    UpperDigitLower
  }

  public enum RandomCharacters
  {
    LowerCase = 1,
    UpperCase = 2,
    Digit = 3,
    SpecialCharacter = 4,
    UpperLower = 5, //LowerCase & UpperCase,
    LowerDigit = 6, //LowerCase & Digit,
    UpperDigit = 7, //UpperCase & Digit,
    UpperLowerDigit = 8, //UpperLower & Digit,
    LowerSpecialChar = 9, //LowerCase & SpecialCharacter,
    UpperSpecialChar = 10, //UpperCase & SpecialCharacter,
    DigitSpecialChar = 11, //Digit & SpecialCharacter
    UpperLowerSpecial = 12,
    UpperDigitSpecial = 13,
    UpperLowerDigitSpecial = 14 // kept numbering because of a possible future change
  }

  public enum TranslationLanguage
  {
    NoTranslation = 0,
    ToFrench = 1,
    ToEnglish = 2,
    ToBothFrenchAndEnglish = ToFrench & ToEnglish,
    All = ToFrench & ToEnglish, // & any other language if you have any
    //ToBothFrenchAndEnglish = ToFrench & ToEnglish
  }

  public enum DefaultCasing
  {
    DefaultLowerCase,
    DefaultUpperCase,
    DefaultAsIs
  }

  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,
    Access = 1,
    Assign = 2,
    InstantiatedWithFixedConstructorSignature = 4,
    InstantiatedNoFixedConstructorSignature = 8,
  }

  public enum ImplicitUseTargetFlags
  {
    Default = Itself,
    Itself = 1,
    Members = 2,
    WithMembers = Itself | Members
  }

  public enum SearchedLanguage
  {
    NoLanguageChosen = 0,
    French = 1,
    English = 2,
    FrenchAndEnglish = 3 //French & English // = 3
  }
}