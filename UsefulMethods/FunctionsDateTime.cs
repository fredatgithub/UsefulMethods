using System;
using System.Linq;
using System.Text;

namespace UsefulMethods
{
  using StringFunc = FunctionsString;

  public class FunctionsDateTime
  {
    public static bool IsOutsideWeekEnd()
    {
      return DateTime.Now.DayOfWeek != DayOfWeek.Sunday && DateTime.Now.DayOfWeek != DayOfWeek.Saturday;
    }

    public static bool IsOutsideWeekEnd(DateTime dt)
    {
      return dt.DayOfWeek != DayOfWeek.Sunday && dt.DayOfWeek != DayOfWeek.Saturday;
    }

    public static bool IsWeekEnd()
    {
      return !IsOutsideWeekEnd();
    }

    public static bool IsWeekEnd(DateTime dt)
    {
      return !IsOutsideWeekEnd(dt);
    }

    public static bool IsMorning(DateTime time)
    {
      return time.Hour < 12;
    }

    public static string ConvertTimeSpanToString(TimeSpan ts)
    {
      return $"{ts.Days}:{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}";
    }

    public static string DisplayElapseTime(TimeSpan ts)
    {
      return $"{ts.Days:000}:{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
    }

    public static string TimeSpanToLongTimeNotNull(TimeSpan timeSpan)
    {
      return TimeSpanToFriendlyDisplay(timeSpan) == string.Empty ? "1 millisecond" :
        TimeSpanToFriendlyDisplay(timeSpan);
    }

    public static string TimeSpanToFriendlyDisplay(TimeSpan timeSpan, int maxNrOfElements = 5)
    {
      maxNrOfElements = Math.Max(Math.Min(maxNrOfElements, 5), 1);
      var parts = new[]
        {
          Tuple.Create(TimeSpanElement.Day, timeSpan.Days),
          Tuple.Create(TimeSpanElement.Hour, timeSpan.Hours),
          Tuple.Create(TimeSpanElement.Minute, timeSpan.Minutes),
          Tuple.Create(TimeSpanElement.Second, timeSpan.Seconds),
          Tuple.Create(TimeSpanElement.Millisecond, timeSpan.Milliseconds)
        }
      .SkipWhile(i => i.Item2 <= 0).Take(maxNrOfElements);

      return string.Join(
        ", ",
        parts.Select(p => $"{p.Item2} {p.Item1}{(p.Item2 > 1 ? "s" : string.Empty)}"));
    }

    /// <summary>
    /// The date to byte array.
    /// </summary>
    /// Convert a DateTime to the equivalent long (Win32 FileTime) byte array
    /// <param name="date">
    /// DateTime to convert
    /// </param>
    /// <returns>
    /// "long" byte array representing the DateTime
    /// </returns>
    public static byte[] DateToByteArray(DateTime date)
    {
      long longDate = date.ToFileTime();
      return BitConverter.GetBytes(longDate);
    }

    /// <summary>
    /// The byte array to date.
    /// </summary>
    /// Coverts a long (aka Win32 FileTime) byte array to a DateTime
    /// <param name="bytes">
    /// Bytes to convert
    /// </param>
    /// <returns>
    /// DateTime representation of the "long" bytes
    /// </returns>
    public static DateTime ByteArrayToDate(byte[] bytes)
    {
      if (bytes.Length != 8)
      {
        return new DateTime();
      }

      long longDate = BitConverter.ToInt64(bytes, 0);
      return DateTime.FromFileTime(longDate);
    }

    public static double GetHoursMinutes(string hours, string minutes)
    {
      double minutesB60 = double.Parse(minutes);
      double minutesB10 = minutesB60 / 60;
      var result = double.Parse(hours) + minutesB10;
      return result;
    }

    public static double GetHoursMinutes(int hours, int minutes)
    {
      return hours + (double)minutes / 60;
    }

    public static string BuildUpTime(int time, bool removeZeros = false)
    {
      StringBuilder result = new StringBuilder();
      if (HasHours(time))
      {
        result.Append(time / 3600000);
        result.Append(" hour");
        result.Append(StringFunc.Plural(time / 3600000));
        time %= 3600000;
      }
      else if (!removeZeros)
      {
        result.Append("0 hour");
      }

      if (HasMinutes(time))
      {
        result.Append(" ");
        result.Append(time / 60000);
        result.Append(" minute");
        result.Append(StringFunc.Plural(time / 60000));
        time %= 60000;
      }
      else if (!removeZeros)
      {
        result.Append(" 0 minute");
      }

      if (HasSeconds(time))
      {
        result.Append(" ");
        result.Append(time / 1000);
        result.Append(" second");
        result.Append(StringFunc.Plural(time / 1000));
        time %= 1000;
      }
      else if (!removeZeros)
      {
        result.Append(" 0 second");
      }

      if (HasMilliSeconds(time))
      {
        result.Append(" ");
        result.Append(time);
        result.Append(" millisecond");
        result.Append(StringFunc.Plural(time));
      }
      else if (!removeZeros)
      {
        result.Append(" 0 millisecond");
      }

      return result.ToString().Trim();
    }

    public static bool HasHours(int time)
    {
      return time / 3600000 > 0;
    }

    public static bool HasMinutes(int time)
    {
      return time / 60000 > 0;
    }

    public static bool HasSeconds(int time)
    {
      return time / 1000 > 0;
    }

    public static bool HasMilliSeconds(int time)
    {
      return time > 0;
    }

    public static bool IsBissextile(DateTime theDate)
    {
      if (theDate.Year % 4 == 0)
      {
        return true;
      }

      // return theDate.Year % 100 != 0 && theDate.Year % 400 == 0;
      if (theDate.Year % 100 != 0 && theDate.Year % 400 == 0)
      {
        return true;
      }

      return false;
    }
  }
}