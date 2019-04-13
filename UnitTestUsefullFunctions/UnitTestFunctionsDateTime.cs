using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DateFunc = UsefulMethods.FunctionsDateTime;

namespace UnitTestUsefulMethods
{
  [TestClass]
  public class UnitTestFunctionsDateTime
  {
    #region GetHoursMinutes with strings parameters
    // ******GetHoursMinutes with strings parameters****************
    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_half_an_hour()
    {
      const string source = "0";
      const string source2 = "30";
      const double expected = 0.5d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_fifteen_minutes()
    {
      const string source = "0";
      const string source2 = "15";
      const double expected = 0.25d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_forty_five_minutes()
    {
      const string source = "0";
      const string source2 = "45";
      const double expected = 0.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_ten_hours_and_forty_five_minutes()
    {
      const string source = "10";
      const string source2 = "45";
      const double expected = 10.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion GetHoursMinutes with strings parameters
    #region GetHoursMinutes with int parameters
    // ******GetHoursMinutes with int parameters****************
    [TestMethod]
    public void TestMethod_GetHoursMinutes_with_int_true_half_an_hour()
    {
      const int source = 0;
      const int source2 = 30;
      const double expected = 0.5d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_int_true_fifteen_minutes()
    {
      const int source = 0;
      const int source2 = 15;
      const double expected = 0.25d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_int_true_forty_five_minutes()
    {
      const int source = 0;
      const int source2 = 45;
      const double expected = 0.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_int_true_ten_hours_and_forty_five_minutes()
    {
      const int source = 10;
      const int source2 = 45;
      const double expected = 10.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion GetHoursMinutes with strings parameters
    #region BuildUpTime
    // ******BuildUpTime****************
    [TestMethod]
    public void TestMethod_BuildUpTime_true_zero()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const string expected = "0 hour 0 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const string expected = "0 hour 0 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const string expected = "0 hour 0 minute 0 second 100 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const string expected = "0 hour 0 minute 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const string expected = "0 hour 0 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = (0 * hour) + (0 * minute) + (1 * second) + (2 * millisecond);
      const string expected = "0 hour 0 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const string expected = "0 hour 0 minute 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const string expected = "0 hour 0 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const string expected = "0 hour 0 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const string expected = "0 hour 1 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const string expected = "0 hour 1 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const string expected = "0 hour 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const string expected = "0 hour 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const string expected = "0 hour 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const string expected = "0 hour 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const string expected = "0 hour 2 minutes 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const string expected = "0 hour 2 minutes 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const string expected = "0 hour 2 minutes 0 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const string expected = "0 hour 2 minutes 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const string expected = "0 hour 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const string expected = "0 hour 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const string expected = "0 hour 2 minutes 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const string expected = "0 hour 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const string expected = "0 hour 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_zero_one_hour()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const string expected = "1 hour 0 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const string expected = "1 hour 0 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const string expected = "1 hour 0 minute 0 second 100 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const string expected = "1 hour 0 minute 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const string expected = "1 hour 0 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const string expected = "1 hour 0 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const string expected = "1 hour 0 minute 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const string expected = "1 hour 0 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const string expected = "1 hour 0 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const string expected = "1 hour 1 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const string expected = "1 hour 1 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const string expected = "1 hour 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const string expected = "1 hour 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const string expected = "1 hour 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const string expected = "1 hour 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const string expected = "1 hour 2 minutes 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const string expected = "1 hour 2 minutes 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const string expected = "1 hour 2 minutes 0 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const string expected = "1 hour 2 minutes 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const string expected = "1 hour 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const string expected = "1 hour 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const string expected = "1 hour 2 minutes 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const string expected = "1 hour 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const string expected = "1 hour 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_zero_two_hours()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const string expected = "2 hours 0 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const string expected = "2 hours 0 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const string expected = "2 hours 0 minute 0 second 100 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const string expected = "2 hours 0 minute 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const string expected = "2 hours 0 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const string expected = "2 hours 0 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const string expected = "2 hours 0 minute 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const string expected = "2 hours 0 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const string expected = "2 hours 0 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const string expected = "2 hours 1 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const string expected = "2 hours 1 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const string expected = "2 hours 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const string expected = "2 hours 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const string expected = "2 hours 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const string expected = "2 hours 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const string expected = "2 hours 2 minutes 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const string expected = "2 hours 2 minutes 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const string expected = "2 hours 2 minutes 0 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const string expected = "2 hours 2 minutes 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const string expected = "2 hours 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const string expected = "2 hours 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const string expected = "2 hours 2 minutes 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const string expected = "2 hours 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const string expected = "2 hours 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    //*********************BuildUpTime with removal of zeros****************************
    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_zero()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const bool source2 = true;
      const string expected = "100 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_zero_one_hour()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 100 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_zero_two_hours()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 100 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    #endregion BuildUpTime
    #region HasHours
    // ******HasHours****************
    [TestMethod]
    public void TestMethod_HasHours_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasHours(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasHours_true()
    {
      const int source = 216000000;
      const bool expected = true;
      bool result = DateFunc.HasHours(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasHours
    #region HasMinutes
    // ******HasMinutes****************
    [TestMethod]
    public void TestMethod_HasMinutes_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasMinutes(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasMinutes_true()
    {
      const int source = 3600000;
      const bool expected = true;
      bool result = DateFunc.HasMinutes(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasMinutes
    #region HasSeconds
    // ******HasSeconds****************
    [TestMethod]
    public void TestMethod_HasSeconds_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasSeconds(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSeconds_true()
    {
      const int source = 60000;
      const bool expected = true;
      bool result = DateFunc.HasSeconds(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasSeconds
    #region HasMilliSeconds
    // ******HasMilliSeconds****************
    [TestMethod]
    public void TestMethod_HasMilliSeconds_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasMilliSeconds(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasMilliSeconds_true()
    {
      const int source = 1;
      const bool expected = true;
      bool result = DateFunc.HasMilliSeconds(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasMilliSeconds
    #region OutsideWeekEnd Methods

    // **********************OutsideWeekEnd Methods***************

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = false;
      bool result = DateFunc.IsOutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true()
    {
      DateTime source = new DateTime(2015, 03, 23, 14, 58, 00);
      const bool expected = true;
      bool result = DateFunc.IsOutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_false_January_first_2000()
    {
      DateTime source = new DateTime(2000, 01, 01, 14, 58, 00);
      const bool expected = false;
      bool result = DateFunc.IsOutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true_nine_eleven_2001()
    {
      DateTime source = new DateTime(2001, 09, 11, 10, 11, 00);
      const bool expected = true;
      bool result = DateFunc.IsOutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true_Jesus_birth()
    {
      DateTime source = new DateTime(1, 12, 25, 1, 0, 0);
      const bool expected = true;
      bool result = DateFunc.IsOutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsOutsideWeekEnd_true_or_false()
    {
      const bool expected = true;
      bool result = DateFunc.IsOutsideWeekEnd();
      if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
      {
        Assert.AreNotEqual(result, expected);
      }
      else
      {
        Assert.AreEqual(result, expected);
      }
    }

    [TestMethod]
    public void TestMethod_IsOutsideWeekEnd_with_a_date_true()
    {
      var source = new DateTime(2015, 06, 01); // Monday, the day I wrote this unit test :O)
      const bool expected = true;
      bool result = DateFunc.IsOutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsOutsideWeekEnd_with_a_date_false()
    {
      var source = new DateTime(2015, 05, 31); // Sunday, the day before I wrote this unit test :o)
      const bool expected = false;
      bool result = DateFunc.IsOutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    #endregion OutsideWeekEnd Methods
    #region IsMorning Methods
    // **********************IsMorning Methods***************
    [TestMethod]
    public void TestMethod_IsMorning_true()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = true;
      bool result = DateFunc.IsMorning(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsMorning_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 14, 58, 00);
      const bool expected = false;
      bool result = DateFunc.IsMorning(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsMorning_noon_is_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 12, 00, 00);
      const bool expected = false;
      bool result = DateFunc.IsMorning(source);
      Assert.AreEqual(result, expected);
    }
    #endregion IsMorning Methods
    #region IsWeekEnd Methods
    // **********************IsWeekEnd Methods*********************
    [TestMethod]
    public void TestMethod_IsWeekEnd_true()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = true;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false()
    {
      DateTime source = new DateTime(2015, 03, 23, 14, 58, 00);
      const bool expected = false;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_true_January_first_2000()
    {
      DateTime source = new DateTime(2000, 01, 01, 14, 58, 00);
      const bool expected = true;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false_nine_eleven_2001()
    {
      DateTime source = new DateTime(2001, 09, 11, 10, 11, 00);
      const bool expected = false;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false_Jesus_birth()
    {
      DateTime source = new DateTime(1, 12, 25, 1, 0, 0);
      const bool expected = false;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }
    #endregion IsWeekEnd Methods
    #region DisplayElapseTime
    [TestMethod]
    public void TestMethod_DisplayElapseTime()
    {
      TimeSpan source = new TimeSpan(0, 3, 2, 1, 58);
      const string expected = "000:03:02:01.05";
      string result = DateFunc.DisplayElapseTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DisplayElapseTime_zero_all()
    {
      TimeSpan source = new TimeSpan(0, 0, 0, 0, 0);
      const string expected = "000:00:00:00.00";
      string result = DateFunc.DisplayElapseTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DisplayElapseTime_value_9999_milliseconds()
    {
      TimeSpan source = new TimeSpan(0, 0, 0, 0, 9999);
      const string expected = "000:00:00:09.99";
      string result = DateFunc.DisplayElapseTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DisplayElapseTime_value_200_1_2_3_0()
    {
      TimeSpan source = new TimeSpan(200, 1, 2, 3, 0);
      const string expected = "200:01:02:03.00";
      string result = DateFunc.DisplayElapseTime(source);
      Assert.AreEqual(result, expected);
    }
    #endregion DisplayElapseTime

    #region Bissextile
    // Les années bissextiles du 21ème siècle
    // 2036
    // 2040 - 2044 - 2048 - 2052 - 2056 - 2060 - 2064 - 2068 - 2072
    // 2076 - 2080 - 2084 - 2088 - 2092 - 2096 - 2100
    [TestMethod]
    public void TestMethod_Bissextile_2000()
    {
      DateTime source = new DateTime(2000, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2001()
    {
      DateTime source = new DateTime(2001, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2002()
    {
      DateTime source = new DateTime(2002, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2003()
    {
      DateTime source = new DateTime(2003, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2004()
    {
      DateTime source = new DateTime(2004, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2005()
    {
      DateTime source = new DateTime(2005, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2006()
    {
      DateTime source = new DateTime(2006, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2007()
    {
      DateTime source = new DateTime(2007, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2008()
    {
      DateTime source = new DateTime(2004, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2009()
    {
      DateTime source = new DateTime(2009, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2010()
    {
      DateTime source = new DateTime(2010, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2011()
    {
      DateTime source = new DateTime(2011, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2012()
    {
      DateTime source = new DateTime(2012, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2013()
    {
      DateTime source = new DateTime(2013, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2014()
    {
      DateTime source = new DateTime(2014, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2015()
    {
      DateTime source = new DateTime(2015, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2016()
    {
      DateTime source = new DateTime(2016, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2017()
    {
      DateTime source = new DateTime(2017, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2018()
    {
      DateTime source = new DateTime(2018, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2019()
    {
      DateTime source = new DateTime(2019, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2020()
    {
      DateTime source = new DateTime(2020, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2021()
    {
      DateTime source = new DateTime(2021, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2022()
    {
      DateTime source = new DateTime(2022, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2023()
    {
      DateTime source = new DateTime(2023, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2024()
    {
      DateTime source = new DateTime(2024, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2025()
    {
      DateTime source = new DateTime(2025, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2026()
    {
      DateTime source = new DateTime(2026, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2027()
    {
      DateTime source = new DateTime(2027, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2028()
    {
      DateTime source = new DateTime(2028, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2029()
    {
      DateTime source = new DateTime(2029, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2030()
    {
      DateTime source = new DateTime(2030, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2031()
    {
      DateTime source = new DateTime(2031, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2032()
    {
      DateTime source = new DateTime(2032, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2033()
    {
      DateTime source = new DateTime(2033, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2034()
    {
      DateTime source = new DateTime(2034, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2035()
    {
      DateTime source = new DateTime(2035, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2036()
    {
      DateTime source = new DateTime(2036, 1, 1);
      const bool expected = true;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2037()
    {
      DateTime source = new DateTime(2037, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Bissextile_2038()
    {
      DateTime source = new DateTime(2038, 1, 1);
      const bool expected = false;
      bool result = DateFunc.IsBissextile(source);
      Assert.AreEqual(result, expected);
    }

    #endregion
  }
}