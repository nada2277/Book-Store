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
  public partial class CategoriesForm : Form
  {
    public CategoriesForm()
    {
      InitializeComponent();
      System.Drawing.Drawing2D.GraphicsPath graphicsPath = new();
      graphicsPath.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
      Region region = new Region(graphicsPath);
      pictureBox1.Region = region;
    }
  }
}
