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
    public partial class Ready_Form : Form
    {
        public Ready_Form()
        {
            InitializeComponent();
        }

        private void btn_ready_Click(object sender, EventArgs e)
        {
            Menu_Form.wplayer.controls.stop();
            Start_Form start = new Start_Form();
            this.Hide();
            start.Show();
        }

    }
}
