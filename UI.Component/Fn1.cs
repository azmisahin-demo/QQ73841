using Helper;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI.Component
{
  public partial class Fn1 : Form
  {
    #region init
    public Calculator calculator;

    public decimal number1
    {
      get { return Convert.ToDecimal(textBox1.Text); }
      set { textBox1.Text = string.Format("{0:N2}", value); }
    }

    public decimal number2
    {
      get { return Convert.ToDecimal(textBox2.Text); }
      set { textBox2.Text = string.Format("{0:N2}", value); }
    }

    public decimal number3
    {
      get { return Convert.ToDecimal(textBox3.Text); }
      set { textBox3.Text = string.Format("{0:N2}", value); }
    }

    public decimal number4
    {
      get { return Convert.ToDecimal(textBox4.Text); }
      set { textBox4.Text = string.Format("{0:N2}", value); }
    }

    public Fn1()
    {
      InitializeComponent();

      // default resource
      button1.Text = Resource.Calculate_It;
      label1.Text = Resource.Number_1;
      label2.Text = Resource.Number_2;
      label3.Text = Resource.Number_3;
      label4.Text = Resource.Number_4;
      // instance create
      calculator = new Calculator();

    }
    #endregion

    #region control
    private void validateDecimal(object sender, KeyPressEventArgs e)
    {
      // just digit
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
      {
        e.Handled = true;
      }

      // just "." 
      if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
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

    #region event
    private void button1_Click(object sender, EventArgs e)
    {

      if (!ValidateChildren(ValidationConstraints.Enabled))
      {
        MessageBox.Show(Resource.Validation_Error, Resource.Error);
      }
      else
      {
        number4 = calculator.Fn1(number1, number2, number3);
      }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      validateDecimal(sender, e);
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      validateDecimal(sender, e);
    }

    private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
    {
      validateDecimal(sender, e);
    }

    private void textBox1_Validating(object sender, CancelEventArgs e)
    {
      validateIsNull(sender, e);
    }

    private void textBox2_Validating(object sender, CancelEventArgs e)
    {
      validateIsNull(sender, e);
    }

    private void textBox3_Validating(object sender, CancelEventArgs e)
    {
      validateIsNull(sender, e);
    }
    #endregion
  }
}
