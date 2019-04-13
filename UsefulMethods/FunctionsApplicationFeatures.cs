using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace UsefulMethods
{
  public class FunctionsApplicationFeatures
  {
    public static string GetStartupPath()
    {
      try
      {
        return string.IsNullOrEmpty(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)) ? string.Empty :
          Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
      }
      catch (Exception)
      {
        return string.Empty;
      }
    }

    private static Control FindFocusedControl(IEnumerable<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }
  }
}