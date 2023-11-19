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
    public partial class Start_Form : Form
    {
        int pipe_speed = 5;
        int gravity = 5;
        int score = 0;
        bool Paused = false;

        public Start_Form()
        {
            InitializeComponent();
        }


        private void GameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipe_down1.Left -= pipe_speed;
            pipe_up1.Left -= pipe_speed;
            pipe_down2.Left -= pipe_speed;
            pipe_up2.Left -= pipe_speed;
            pipe_down3.Left -= pipe_speed;
            pipe_up3.Left -= pipe_speed;
            pipe_down4.Left -= pipe_speed;
            pipe_up4.Left -= pipe_speed;

            if (pipe_down1.Left < -300)
            {
                pipe_down1.Left = 700;
                ++score;
                lbl_score.Text = score.ToString();
            }
            if (pipe_up1.Left < -200)
            {
                pipe_up1.Left = 950;
                ++score;
                lbl_score.Text = score.ToString();
              }


            if (pipe_down2.Left < -300)
            {
                pipe_down2.Left = 700;
                ++score;
                lbl_score.Text = score.ToString();
            }
            if (pipe_up2.Left < -200)
            {
                pipe_up2.Left = 950;
                ++score;
                lbl_score.Text = score.ToString();
            }


            if (pipe_down3.Left < -300)
            {
                pipe_down3.Left = 700;
                ++score;
                lbl_score.Text = score.ToString();
            }
            if (pipe_up3.Left < -200)
            {
                pipe_up3.Left = 950;
                ++score;
                lbl_score.Text = score.ToString();
            }


            if (pipe_down4.Left < -300)
            {
                pipe_down4.Left = 700;
                ++score;
                lbl_score.Text = score.ToString();
            }
            if (pipe_up4.Left < -200)
            {
                pipe_up4.Left = 950;
                ++score;
                lbl_score.Text = score.ToString();
            }
            //------Levels---------
            //level 2
            if (score > 15)
            {
                pipe_speed = 7;
                lbl_level.Text = "2";
            }
            //level 3
            if (score > 30)
            {
                pipe_speed = 9;
                lbl_level.Text = "3";
            }
            //level 4
            if (score > 45)
            {
                pipe_speed = 11;
                lbl_level.Text = "4";
            }
            //level 5
            if (score > 60)
            {
                pipe_speed = 13;
                lbl_level.Text = "5";
            }
            //level 6
            if (score > 75)
            {
                pipe_speed = 15;
                lbl_level.Text = "6";
            }
            //level 7
            if (score > 100)
            {
                pipe_speed = 17;
                lbl_level.Text = "7";
            }
            //level 8
            if (score > 115)
            {
                pipe_speed = 19;
                lbl_level.Text = "8";
            }
            //level 9
            if (score > 130)
            {
                pipe_speed = 21;
                lbl_level.Text = "9";
            }
            //level 10
            if (score > 145)
            {
                pipe_speed = 23;
                lbl_level.Text = "10";
            }

            //Bird Touching ground or Pipes
            if (bird.Bounds.IntersectsWith(pipe_down1.Bounds) || bird.Bounds.IntersectsWith(pipe_up1.Bounds) || bird.Bounds.IntersectsWith(pipe_down2.Bounds)
               || bird.Bounds.IntersectsWith(pipe_up2.Bounds) || bird.Bounds.IntersectsWith(pipe_down3.Bounds) || bird.Bounds.IntersectsWith(pipe_up3.Bounds)
               || bird.Bounds.IntersectsWith(pipe_down4.Bounds) || bird.Bounds.IntersectsWith(pipe_up4.Bounds) || bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                GameEnd();
            }
        }


        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Down)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\jawad\OneDrive\Desktop\Flappy-Bird\Flappy-Bird\Resources\wing.wav");
                sound.Play();
                gravity = 5;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\jawad\OneDrive\Desktop\Flappy-Bird\Flappy-Bird\Resources\wing.wav");
                sound.Play();
                gravity = -5;
            }
        }

        public void GameEnd()
        {
            System.Media.SoundPlayer sound1 = new System.Media.SoundPlayer(@"C:\Users\jawad\OneDrive\Desktop\Flappy-Bird\Flappy-Bird\Resources\hit.wav");
            sound1.Play();

            Menu_Form.wplayer.controls.play();
           
            GameTimer.Stop();
            Properties.Settings.Default.Score =
            Properties.Settings.Default.Score = score.ToString();
            if (score > Convert.ToInt32(Properties.Settings.Default.h_score1))
            {
                Properties.Settings.Default.h_score5 = Properties.Settings.Default.h_score4;
                Properties.Settings.Default.h_score4 = Properties.Settings.Default.h_score3;
                Properties.Settings.Default.h_score3 = Properties.Settings.Default.h_score2;
                Properties.Settings.Default.h_score2 = Properties.Settings.Default.h_score1;
                Properties.Settings.Default.h_score1 = score.ToString();
            }
            else if (score > Convert.ToInt32(Properties.Settings.Default.h_score2))
            {
                Properties.Settings.Default.h_score5 = Properties.Settings.Default.h_score4;
                Properties.Settings.Default.h_score4 = Properties.Settings.Default.h_score3;
                Properties.Settings.Default.h_score3 = Properties.Settings.Default.h_score2;
                Properties.Settings.Default.h_score2 = score.ToString();
            }
            else if (score > Convert.ToInt32(Properties.Settings.Default.h_score3))
            {
                Properties.Settings.Default.h_score5 = Properties.Settings.Default.h_score4;
                Properties.Settings.Default.h_score4 = Properties.Settings.Default.h_score3;
                Properties.Settings.Default.h_score3 = score.ToString();
            }
            else if (score > Convert.ToInt32(Properties.Settings.Default.h_score4))
            {
                Properties.Settings.Default.h_score5= Properties.Settings.Default.h_score4;
                Properties.Settings.Default.h_score4 = score.ToString();
            }
            else if (score > Convert.ToInt32(Properties.Settings.Default.h_score5))
            {
                Properties.Settings.Default.h_score5 = score.ToString();
            }
            GameOver_Form gameover = new GameOver_Form();
            this.Hide();
            gameover.Show();
        }

        private void PauseEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'P' || e.KeyChar == 'p' )
            {
                if (Paused == false)
                {
                    lbl_pause.Text = "PAUSED !";
                    Paused = true;
                    GameTimer.Stop();
                    pictureBox1.Image = Properties.Resources.HuaJuly_041_removebg_preview__1_;
                }
                else if (Paused == true)
                {
                    lbl_pause.Text = "";
                    Paused = false;
                    GameTimer.Start();
                    pictureBox1.Image = Properties.Resources.HuaJuly_04_removebg_preview__1_;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Paused == false)
            {
                lbl_pause.Text = "PAUSED !";
                Paused = true;
                GameTimer.Stop();
                pictureBox1.Image = Properties.Resources.HuaJuly_041_removebg_preview__1_;
            }
            else if (Paused == true)
            {
                lbl_pause.Text = "";
                Paused = false;
                GameTimer.Start();
                pictureBox1.Image = Properties.Resources.HuaJuly_04_removebg_preview__1_;
            }
        }
    }
} 
