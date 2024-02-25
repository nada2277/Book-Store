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
    public partial class OrderPlacedForm : Form
    {
        HomeForm homeForm;
        public OrderPlacedForm(HomeForm homeForm)
        {
            this.homeForm = homeForm;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homeForm.ShowBooks();
        }
    }
}
