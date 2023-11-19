using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Quit_Form : Form
    {
        public Quit_Form()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            Menu_Form mainmenu = new Menu_Form();
            this.Hide();
            mainmenu.Show();

        }

        private void btn_yes_MouseHover(object sender, EventArgs e)
        {
            btn_yes.ForeColor = Color.Yellow;
        }

        private void btn_yes_MouseLeave(object sender, EventArgs e)
        {
            btn_yes.ForeColor = Color.Black;
        }

        private void btn_no_MouseHover(object sender, EventArgs e)
        {
            btn_no.ForeColor = Color.Yellow;
        }

        private void btn_no_MouseLeave(object sender, EventArgs e)
        {
            btn_no.ForeColor = Color.Black;
        }
    }
}
