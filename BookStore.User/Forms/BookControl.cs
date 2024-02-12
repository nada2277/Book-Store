using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.User.Forms
{
  public partial class BookControl : UserControl
  {
    public BookControl()
    {
      InitializeComponent();
      pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
    }
    public string BookName { get => label1.Text; set => label1.Text = value; }
    public string BookPrice { get => label2.Text; set => label2.Text = value; }

    public Image BookImage { get => pictureBox1?.BackgroundImage; set => pictureBox1.BackgroundImage = value; }

  }
}
