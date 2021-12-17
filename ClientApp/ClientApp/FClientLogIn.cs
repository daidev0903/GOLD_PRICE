using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class FClientLogIn : Form
    {
        public FClientLogIn()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMainMenu fMainMenu = new FMainMenu();
            fMainMenu.ShowDialog();
            this.Show();
        }
    }
}
