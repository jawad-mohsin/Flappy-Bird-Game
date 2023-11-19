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
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();

            wplayer.URL = (@"C:\Users\jawad\OneDrive\Desktop\Flappy-Bird\Flappy-Bird\Resources\Driving Rock - AShamaluevMusic.wav");
            MediaPlayer.Hide();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void btn_options_Click(object sender, EventArgs e)
        {
            Option_Form option = new Option_Form();
            this.Hide();
            option.Show();
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            Option_Form option = new Option_Form();
            this.Hide();
            option.Show();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Quit_Form quit = new Quit_Form();
            this.Hide();
            quit.Show();
        }

        private void btn_highscore_Click(object sender, EventArgs e)
        {
            Highscore_Form highscore = new Highscore_Form();
            this.Hide();
            highscore.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Ready_Form ready = new Ready_Form();
            this.Hide();
            ready.Show();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.Yellow;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.Black;
        }

        private void btn_option_MouseHover(object sender, EventArgs e)
        {
            btn_option.ForeColor = Color.Yellow;
        }

        private void btn_option_MouseLeave(object sender, EventArgs e)
        {
            btn_option.ForeColor = Color.Black;
        }

        private void btn_highscore_MouseHover(object sender, EventArgs e)
        {
            btn_highscore.ForeColor = Color.Yellow;
        }

        private void btn_highscore_MouseLeave(object sender, EventArgs e)
        {
            btn_highscore.ForeColor = Color.Black;
        }

        private void btn_quit_MouseHover(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.Yellow;
        }

        private void btn_quit_MouseLeave(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.Black;
        }
    }
}
