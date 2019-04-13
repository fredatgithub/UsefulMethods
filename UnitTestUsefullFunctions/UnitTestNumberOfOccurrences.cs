using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFunc = UsefulMethods.FunctionsString;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestNumberOfOccurrences
  {
    [TestMethod]
    public void TestMethod_NumberOfOccurrences_1()
    {
      const string source1 = "One";
      const string source2 = "OneTwoThreeTwo";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_2()
    {
      const string source1 = "One";
      const string source2 = "OneTwoThreeTwoOne";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_2_different_place()
    {
      const string source1 = "One";
      const string source2 = "OneTwoOneThreeTwo";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_3()
    {
      const string source1 = "One";
      const string source2 = "OneTwoOneThreeTwoOne";
      const int expected = 3;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_NumberOfOccurrences_3_with_lower_case()
    {
      const string source1 = "One";
      const string source2 = "oneTwooneThreeTwoone";
      const int expected = 3;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_3_with_upper_and_lower_case()
    {
      const string source1 = "One";
      const string source2 = "oneTwoOneThreeTwoone";
      const int expected = 3;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_numbers()
    {
      const string source1 = "6";
      const string source2 = "123456789OneTwoThreeFourFive";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_ago_1()
    {
      const string source1 = "ago";
      const string source2 = "a long long time ago in a galaxy far far away";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_NumberOfOccurrences_long_2()
    {
      const string source1 = "long";
      const string source2 = "a long long time ago in a galaxy far far away";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_far_2()
    {
      const string source1 = "far";
      const string source2 = "a long long time ago in a galaxy far far away";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_ar_2()
    {
      const string source1 = "ar";
      const string source2 = "a long long time ago in a galaxy far far away";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_a_9()
    {
      const string source1 = "a";
      const string source2 = "a long long time ago in a galaxy far far away";
      const int expected = 9;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_l_3()
    {
      const string source1 = "l";
      const string source2 = "a long long time ago in a galaxy far far away";
      const int expected = 3;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_o_3()
    {
      const string source1 = "o";
      const string source2 = "a long long time ago in a galaxy far far away";
      const int expected = 3;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_a_1()
    {
      const string source1 = "a";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_b_1()
    {
      const string source1 = "b";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_c_1()
    {
      const string source1 = "c";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_d_1()
    {
      const string source1 = "d";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_e_3()
    {
      const string source1 = "e";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 3;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_f_1()
    {
      const string source1 = "f";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_g_1()
    {
      const string source1 = "g";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_h_1()
    {
      const string source1 = "h";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_i_1()
    {
      const string source1 = "i";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_j_1()
    {
      const string source1 = "j";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_k_1()
    {
      const string source1 = "k";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_l_1()
    {
      const string source1 = "l";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_m_1()
    {
      const string source1 = "m";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_n_1()
    {
      const string source1 = "n";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_o_4()
    {
      const string source1 = "o";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 4;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_p_1()
    {
      const string source1 = "p";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_q_1()
    {
      const string source1 = "q";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_r_1()
    {
      const string source1 = "r";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_s_1()
    {
      const string source1 = "s";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_t_1()
    {
      const string source1 = "t";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_u_2()
    {
      const string source1 = "u";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 2;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_v_1()
    {
      const string source1 = "v";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_w_1()
    {
      const string source1 = "w";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_x_1()
    {
      const string source1 = "x";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_y_1()
    {
      const string source1 = "y";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfOccurrences_brown_fox_z_1()
    {
      const string source1 = "z";
      const string source2 = "The quick brown fox jumps over the lazy dog";
      const int expected = 1;
      int result = StringFunc.NumberOfOccurrences(source1, source2);
      Assert.AreEqual(result, expected);
    }
  }
}