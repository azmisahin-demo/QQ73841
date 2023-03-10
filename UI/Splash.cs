using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
  public partial class Splash : Form
  {
    Timer timer;
    public Splash()
    {
      InitializeComponent();
    }

    private void Splash_Shown(object sender, EventArgs e)
    {
      timer = new Timer();

      // Wait
      timer.Interval = 5000;

      //starts the timer

      timer.Start();

      timer.Tick += Timer_Tick; ;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      //after 3 sec stop the timer

      timer.Stop();

      //display mainform

      Main main = new Main();

      main.Show();

      //hide this form

      this.Hide();
    }
  }
}
