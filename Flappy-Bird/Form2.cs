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
    public partial class Option_Form : Form
    {
        public Option_Form()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Menu_Form mainmenu = new Menu_Form();
            this.Hide();
            mainmenu.Show(); 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Menu_Form.wplayer.controls.play();
            btn_sound.Image = Properties.Resources.sound_on;
            Menu_Form.wplayer.settings.volume = trackBar1.Value;

            if (trackBar1.Value == 0)
            {
                btn_sound.Image = Properties.Resources.sound_off;
            }


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
