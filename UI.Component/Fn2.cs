using Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Component
{
  public partial class Fn2 : Form
  {
    #region init
    Calculator calculator;
    public Fn2()
    {
      InitializeComponent();
      calculator = new Calculator();
      button1.Text = Resource.Calculate_It;
    }
    #endregion

    #region event
    private void button1_Click(object sender, EventArgs e)
    {
      List<String> collection = calculator.Fn2();
      listBox1.Items.AddRange(collection.ToArray());
    }
    #endregion
  }
}
