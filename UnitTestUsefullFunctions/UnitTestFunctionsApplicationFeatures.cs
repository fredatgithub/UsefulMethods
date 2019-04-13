using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulMethods;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestFunctionsApplicationFeatures
  {
    #region GetStartupPath
    [TestMethod]
    public void TestMethod_GetStartupPath()
    {
      string expected = "";
      string result = FunctionsApplicationFeatures.GetStartupPath();
      Assert.AreEqual(expected, result);
    }
    #endregion GetStartupPath
  }
}
