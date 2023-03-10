using System;
using System.Windows.Forms;
using UI.Component;

namespace UI
{
  public partial class Main : Form
  {
    #region init
    public Main()
    {
      InitializeComponent();

      Form childForm = new Announce();
      childForm.MdiParent = this;
      childForm.Show();
    }
    #endregion

    #region addianital
    private void Main_Load(object sender, EventArgs e)
    {
      this.FormClosed += Main_FormClosed;
    }


    private void Main_FormClosed(object sender, FormClosedEventArgs e)
    {
      //exit application when form is closed

      Application.Exit();
    }
    #endregion

    #region menu
    private void toolStripLabel1_Click(object sender, EventArgs e)
    {
      Form childForm = new Fn1();
      childForm.MdiParent = this;
      childForm.Show();
    }

    private void toolStripLabel2_Click(object sender, EventArgs e)
    {
      Form childForm = new Fn2();
      childForm.MdiParent = this;
      childForm.Show();
    }

    private void toolStripLabel3_Click(object sender, EventArgs e)
    {
      Form childForm = new Fn3();
      childForm.MdiParent = this;
      childForm.Show();
    }

    private void toolStripLabel4_Click(object sender, EventArgs e)
    {
      Form childForm = new Fn4();
      childForm.MdiParent = this;
      childForm.Show();
    }

    private void toolStripLabel5_Click(object sender, EventArgs e)
    {
      Form childForm = new Fn5();
      childForm.MdiParent = this;
      childForm.Show();
    }
    #endregion
  }
}
