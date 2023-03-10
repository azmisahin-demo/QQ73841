using Helper;
using System;
using System.Windows.Forms;

namespace UI.Component
{
  public partial class Fn4 : Form
  {
    #region init
    Calculator calculator;
    public Fn4()
    {
      InitializeComponent();

      button1.Text = Resource.Calculate_It;

      calculator = new Calculator();
    }
    #endregion

    #region event
    private void button1_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();

      // 
      openFileDialog1.Filter = "Text file|*.txt";

      //
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        string filePath = openFileDialog1.FileName;
        double[] numbers = calculator.Fn4(filePath);
        try
        {
          foreach (var item in numbers)
          {
            listBox1.Items.Add(item);
          }
        }
        catch { }

      }
    }
    #endregion
  }
}
