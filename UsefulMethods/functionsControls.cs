using System.Windows.Forms;

namespace UsefulMethods
{
  public class FunctionsControls
  {
    public TextBoxBase WhatTextBoxHasFocus()
    {
      TextBoxBase result = null;
      //foreach (var control in Control.ControlCollection.Controls.OfType<TextBoxBase>())
      //{
      //  if (control.Focused)
      //  {
      //    result = control;
      //    break;
      //  }
      //}

      return result;
    }

    public static void AcceptOnlyNumbers(Control textBox)
    {
      int value;
      if (!int.TryParse(textBox.Text, out value))
      {
        textBox.Text = string.Empty;
      }
    }

    public static bool IsInlistView(ListView listView, ListViewItem lviItem, int columnNumber = 1)
    {
      // return listView.Items.Cast<ListViewItem>().All(item => item.SubItems[columnNumber].Text != lviItem.SubItems[columnNumber].Text);
      bool result = false;
      foreach (ListViewItem item in listView.Items)
      {
        if (item.SubItems[columnNumber].Text == lviItem.SubItems[columnNumber].Text)
        {
          result = true;
          break;
        }
      }

      return result;
    }
  }
}