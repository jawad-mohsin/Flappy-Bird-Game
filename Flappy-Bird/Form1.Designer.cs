
namespace Flappy_Bird
{
    partial class Menu_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Main_menu = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Label();
            this.btn_highscore = new System.Windows.Forms.Label();
            this.btn_option = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Label();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Flappy_Bird.Properties.Resources.yellowbird_upflap;
            this.pictureBox2.Location = new System.Drawing.Point(455, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Main_menu
            // 
            this.Main_menu.AutoSize = true;
            this.Main_menu.BackColor = System.Drawing.Color.Transparent;
            this.Main_menu.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_menu.ForeColor = System.Drawing.Color.Yellow;
            this.Main_menu.Location = new System.Drawing.Point(412, 211);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(158, 60);
            this.Main_menu.TabIndex = 13;
            this.Main_menu.Text = "MENU";
            // 
            // btn_start
            // 
            this.btn_start.AutoSize = true;
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(449, 285);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(76, 27);
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "START";
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // btn_highscore
            // 
            this.btn_highscore.AutoSize = true;
            this.btn_highscore.BackColor = System.Drawing.Color.Transparent;
            this.btn_highscore.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highscore.Location = new System.Drawing.Point(421, 375);
            this.btn_highscore.Name = "btn_highscore";
            this.btn_highscore.Size = new System.Drawing.Size(129, 27);
            this.btn_highscore.TabIndex = 15;
            this.btn_highscore.Text = "HIGHSCORE";
            this.btn_highscore.Click += new System.EventHandler(this.btn_highscore_Click);
            this.btn_highscore.MouseLeave += new System.EventHandler(this.btn_highscore_MouseLeave);
            this.btn_highscore.MouseHover += new System.EventHandler(this.btn_highscore_MouseHover);
            // 
            // btn_option
            // 
            this.btn_option.AutoSize = true;
            this.btn_option.BackColor = System.Drawing.Color.Transparent;
            this.btn_option.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_option.Location = new System.Drawing.Point(437, 329);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(89, 27);
            this.btn_option.TabIndex = 16;
            this.btn_option.Text = "OPTION";
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            this.btn_option.MouseLeave += new System.EventHandler(this.btn_option_MouseLeave);
            this.btn_option.MouseHover += new System.EventHandler(this.btn_option_MouseHover);
            // 
            // btn_quit
            // 
            this.btn_quit.AutoSize = true;
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(450, 416);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(62, 27);
            this.btn_quit.TabIndex = 17;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            this.btn_quit.MouseLeave += new System.EventHandler(this.btn_quit_MouseLeave);
            this.btn_quit.MouseHover += new System.EventHandler(this.btn_quit_MouseHover);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(0, 477);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(10, 10);
            this.MediaPlayer.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Flappy_Bird.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(321, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.new_background_day_edited;
            this.ClientSize = new System.Drawing.Size(1012, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_option);
            this.Controls.Add(this.btn_highscore);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.Main_menu);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Main_menu;
        private System.Windows.Forms.Label btn_start;
        private System.Windows.Forms.Label btn_highscore;
        private System.Windows.Forms.Label btn_option;
        private System.Windows.Forms.Label btn_quit;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

