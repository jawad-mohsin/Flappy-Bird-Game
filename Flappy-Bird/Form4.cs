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
    public partial class Highscore_Form : Form
    {
        public Highscore_Form()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Menu_Form mainmenu = new Menu_Form();
            this.Hide();
            mainmenu.Show();
        }
        private void Highscore_Form_Load(object sender, EventArgs e)
        {
            lbl_highscore1.Text = Properties.Settings.Default.h_score1;
            lbl_highscore2.Text = Properties.Settings.Default.h_score2;
            lbl_highscore3.Text = Properties.Settings.Default.h_score3;
            lbl_highscore4.Text = Properties.Settings.Default.h_score4;
            lbl_highscore5.Text = Properties.Settings.Default.h_score5;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.ForeColor = Color.Yellow;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.ForeColor = Color.Black;
        }
    }
}
