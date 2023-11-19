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
    public partial class GameOver_Form : Form
    {
        public GameOver_Form()
        {
            InitializeComponent();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Quit2_Form quit = new Quit2_Form();
            quit.Show();
        }

        private void lbl_mainmenu_Click(object sender, EventArgs e)
        {
            Menu_Form menu = new Menu_Form();
            this.Hide();
            menu.Show();
        }

        private void lbl_retry_Click(object sender, EventArgs e)
        {
            Ready_Form ready = new Ready_Form();
            this.Hide();
            ready.Show();
        }

        private void GameOver_Form_Load(object sender, EventArgs e)
        {
            lbl_score.Text = Properties.Settings.Default.Score;
        }

        private void btn_quit_MouseHover(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.Yellow;
        }

        private void btn_quit_MouseLeave(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.Black;
        }

        private void lbl_retry_MouseHover(object sender, EventArgs e)
        {
            lbl_retry.ForeColor = Color.Yellow;         
        }

        private void lbl_retry_MouseLeave(object sender, EventArgs e)
        {
            lbl_retry.ForeColor = Color.Black;
        }

        private void lbl_mainmenu_MouseHover(object sender, EventArgs e)
        {
            lbl_mainmenu.ForeColor = Color.Yellow;
        }

        private void lbl_mainmenu_MouseLeave(object sender, EventArgs e)
        {
            lbl_mainmenu.ForeColor = Color.Black;
        }




        
    }
}
