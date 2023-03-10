using Helper;
using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UI.Component
{
  public partial class Fn3 : Form
  {
    #region init
    public Calculator calculator;

    public int number1
    {
      get { return Convert.ToInt32(textBox1.Text); }
      set { textBox1.Text = value.ToString(); }
    }

    public Fn3()
    {
      InitializeComponent();

      button1.Text = Resource.Calculate_It;

      calculator = new Calculator();
    }
    #endregion

    #region event
    private void button1_Click(object sender, EventArgs e)
    {
      if (!ValidateChildren(ValidationConstraints.Enabled))
      {
        MessageBox.Show(Resource.Validation_Error, Resource.Error);
      }
      else
      {
        // define matris
        int[,] matris = calculator.Fn3(number1);
        // set
        dataGridView1.DataSource = new Adaptor().ConvertToDataTable(matris);
      }
    }

    private void textBox1_Validating(object sender, CancelEventArgs e)
    {
      if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
      {
        e.Cancel = true;
        textBox1.Focus();
        errorProvider1.SetError(sender as TextBox, Resource.This_field_should_not_be_empty);
      }
      else
      {
        e.Cancel = false;
        errorProvider1.SetError(sender as TextBox, "");
      }
    }
    #endregion
  }
}
