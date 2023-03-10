using Helper;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI.Component
{
  public partial class Fn5 : Form
  {
    #region init
    Calculator calculator;
    public int number1
    {
      get { return Convert.ToInt32(textBox1.Text); }
      set { textBox1.Text = value.ToString(); }
    }
    public Fn5()
    {
      InitializeComponent();

      button1.Text = Resource.Calculate_It;
      label1.Text = "";

      calculator = new Calculator();
    }
    #endregion

    #region control

    private void validateInt(object sender, KeyPressEventArgs e)
    {
      // just digit
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
      {
        e.Handled = true;
      }
    }

    private void validateIsNull(object sender, CancelEventArgs e)
    {
      // check white space
      if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
      {
        e.Cancel = true;
        textBox1.Focus();
        errorProvider1.SetError(sender as TextBox, Resource.This_field_should_not_be_empty);
      }
      else
      {
        // everything is ok
        e.Cancel = false;
        errorProvider1.SetError(sender as TextBox, "");
      }
    }
    #endregion

    #region Event
    private void button1_Click(object sender, EventArgs e)
    {

      if (!ValidateChildren(ValidationConstraints.Enabled))
      {
        MessageBox.Show(Resource.Validation_Error, Resource.Error);
      }
      else
      {
        label1.Text = calculator.Fn5(number1).ToString();
      }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      validateInt(sender, e);
    }

    private void textBox1_Validating(object sender, CancelEventArgs e)
    {
      validateIsNull(sender, e);
    }
    #endregion
  }
}
