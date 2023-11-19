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
    public partial class LogoForm : Form
    {
        public LogoForm()
        {
            InitializeComponent();
        }


        private void Timer(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width == panel2.Width)
            {
                Loading_Timer.Stop();
                Menu_Form mainmmenu = new Menu_Form();
                this.Hide();
                mainmmenu.Show();
            }
        }
    }
}
