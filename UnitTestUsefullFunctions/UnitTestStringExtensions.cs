using Microsoft.VisualStudio.TestTools.UnitTesting;
using dllFuncs = UsefulMethods;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestStringExtensions
  {
    #region ToCamelCase
    [TestMethod]
    public void TestMethod_ToCamelCase()
    {
      const string source = "a long long time ago in a galaxy far far away";
      const string expected = "A long long time ago in a galaxy far far away";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_Empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_underscore()
    {
      const string source = "a_long_long_time_ago_in_a_galaxy_far_far_away";
      const string expected = "ALongLongTimeAgoInAGalaxyFarFarAway";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_one_underscore()
    {
      const string source = "a long long time ago_in a galaxy far far away";
      const string expected = "A long long time agoIn a galaxy far far away";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_one_underscore_Upper_case()
    {
      const string source = "A long long time ago_In a galaxy far far away";
      const string expected = "A long long time agoIn a galaxy far far away";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }
    #endregion ToCamelCase
    #region Uncapitalize
    [TestMethod]
    public void TestMethod_Uncapitalize_Empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = dllFuncs.StringExtensions.Uncapitalize(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Uncapitalize()
    {
      const string source = "A long long time ago in a galaxy far far away";
      const string expected = "a long long time ago in a galaxy far far away";
      string result = dllFuncs.StringExtensions.Uncapitalize(source);
      Assert.AreEqual(result, expected);
    }
    #endregion Uncapitalize
    #region ToCodeSummary
    //[TestMethod]
    //public void TestMethod_ToCodeSummary()
    //{
    //  const string source1 = "code1\ncodeline2";
    //  const int source2 = 1;
    //  string expected = "code1" + Environment.NewLine +  "/// codeline2";
    //  string result = dllFuncs.StringExtensions.ToCodeSummary(source1, source2);
    //  Assert.AreEqual(result, expected);
    //}
    #endregion ToCodeSummary


  }
}
