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
  public partial class EmptyCart : Form
  {
    HomeForm homeForm;
    public EmptyCart(HomeForm form)
    {
      homeForm = form;
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      homeForm.ShowBooks();
    }
  }
}
