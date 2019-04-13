using Microsoft.VisualStudio.TestTools.UnitTesting;
using InternetFunc = UsefulMethods.FunctionsInternet;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestFunctionsInternet
  {
    #region IsInternetConnected

    //**********************IsInternetConnected***************
    [TestMethod]
    public void TestMethod_IsInternetConnected_true()
    {
      const bool expected = true;
      bool result = InternetFunc.IsInternetConnected();
      Assert.AreEqual(result, expected);
    }

    #endregion IsInternetConnected
    #region IsNetworkLikelyAvailable

    //**********************IsNetworkLikelyAvailable***************
    [TestMethod]
    public void TestMethod_IsNetworkLikelyAvailable_true()
    {
      const bool expected = true;
      bool result = InternetFunc.IsNetworkLikelyAvailable();
      Assert.AreEqual(result, expected);
    }

    #endregion IsNetworkLikelyAvailable
    #region IsNetworkLikelyAvailable

    //**********************IsOnenNetworkCardAvailable***************
    [TestMethod]
    public void TestMethod_IsOnenNetworkCardAvailable_true()
    {
      const bool expected = true;
      bool result = InternetFunc.IsOnenNetworkCardAvailable();
      Assert.AreEqual(result, expected);
    }

    #endregion IsOnenNetworkCardAvailable
    #region SubstringHtml
    [TestMethod]
    public void TestMethod_SubstringHtml()
    {
      const string source1 = "<p>hellooo codeproject<a href='blah'> blah</a><strong> blahblahh</strong> dsafsdf</p>";
      const int source2 = 30;
      const string expected = "<p>hellooo codeproject<a href='blah'> blah</a><strong> blahb</strong></p>";
      string result = InternetFunc.SubstringHtml(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringHtml2()
    {
      const string source1 = "<p>hello codeproject<a href='image1'> image1</a><strong> this is good code</strong> indeed</p>";
      const int source2 = 30;
      const string expected = "<p>hello codeproject<a href='image1'> image1</a><strong> this </strong></p>";
      string result = InternetFunc.SubstringHtml(source1, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion SubstringHtml
  }
}