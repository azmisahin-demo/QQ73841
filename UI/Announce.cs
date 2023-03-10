using Helper;
using System.Windows.Forms;

namespace UI
{
  public partial class Announce : Form
  {
    public Announce()
    {
      InitializeComponent();

      button1.Text = Resource.Convert;

      richTextBox1.Text = Resource.Similarity_between_programming_languages;
    }

    private async void button1_Click(object sender, System.EventArgs e)
    {

      richTextBox2.Text = await new Translate().Query(richTextBox1.Text.ToString());
    }
  }
}
