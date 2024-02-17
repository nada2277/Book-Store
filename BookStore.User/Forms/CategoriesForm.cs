using BookStore.Models;
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
        HomeForm HomeForm;
        public CategoriesForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.HomeForm = homeForm;
        }

        private void code_Click(object sender, EventArgs e)
        {
            HomeForm.ShowCat("code");
        }

        private void Fiction_Click(object sender, EventArgs e)
        {
            HomeForm.ShowCat("Fiction");
        }

        private void Suspense_Click(object sender, EventArgs e)
        {
            HomeForm.ShowCat("Suspense");
        }

        private void Beauty_Click(object sender, EventArgs e)
        {
            HomeForm.ShowCat("Beauty");
        }
        private void Science_Click(object sender, EventArgs e)
        {
            HomeForm.ShowCat("Science"); 
        }

    }
}
