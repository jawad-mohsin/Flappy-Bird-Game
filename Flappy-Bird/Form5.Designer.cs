namespace Flappy_Bird
{
    partial class Start_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_pause = new System.Windows.Forms.Label();
            this.pipe_up3 = new System.Windows.Forms.PictureBox();
            this.pipe_up4 = new System.Windows.Forms.PictureBox();
            this.pipe_up2 = new System.Windows.Forms.PictureBox();
            this.pipe_down1 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipe_down3 = new System.Windows.Forms.PictureBox();
            this.pipe_down4 = new System.Windows.Forms.PictureBox();
            this.pipe_up1 = new System.Windows.Forms.PictureBox();
            this.pipe_down2 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down2)).BeginInit();
            this.Ground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // lbl_pause
            // 
            this.lbl_pause.AutoSize = true;
            this.lbl_pause.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pause.ForeColor = System.Drawing.Color.Black;
            this.lbl_pause.Location = new System.Drawing.Point(390, 177);
            this.lbl_pause.Name = "lbl_pause";
            this.lbl_pause.Size = new System.Drawing.Size(0, 79);
            this.lbl_pause.TabIndex = 27;
            this.lbl_pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pipe_up3
            // 
            this.pipe_up3.BackColor = System.Drawing.Color.Transparent;
            this.pipe_up3.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipe_up3.Location = new System.Drawing.Point(783, -8);
            this.pipe_up3.Name = "pipe_up3";
            this.pipe_up3.Size = new System.Drawing.Size(58, 168);
            this.pipe_up3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipe_up3.TabIndex = 26;
            this.pipe_up3.TabStop = false;
            // 
            // pipe_up4
            // 
            this.pipe_up4.BackColor = System.Drawing.Color.Transparent;
            this.pipe_up4.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipe_up4.Location = new System.Drawing.Point(998, -8);
            this.pipe_up4.Name = "pipe_up4";
            this.pipe_up4.Size = new System.Drawing.Size(58, 168);
            this.pipe_up4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipe_up4.TabIndex = 25;
            this.pipe_up4.TabStop = false;
            // 
            // pipe_up2
            // 
            this.pipe_up2.BackColor = System.Drawing.Color.Transparent;
            this.pipe_up2.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipe_up2.Location = new System.Drawing.Point(546, -8);
            this.pipe_up2.Name = "pipe_up2";
            this.pipe_up2.Size = new System.Drawing.Size(58, 170);
            this.pipe_up2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipe_up2.TabIndex = 24;
            this.pipe_up2.TabStop = false;
            // 
            // pipe_down1
            // 
            this.pipe_down1.BackColor = System.Drawing.Color.Transparent;
            this.pipe_down1.Image = global::Flappy_Bird.Properties.Resources.pipe_green;
            this.pipe_down1.Location = new System.Drawing.Point(185, 277);
            this.pipe_down1.Name = "pipe_down1";
            this.pipe_down1.Size = new System.Drawing.Size(52, 174);
            this.pipe_down1.TabIndex = 23;
            this.pipe_down1.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::Flappy_Bird.Properties.Resources.R_unscreen;
            this.bird.Location = new System.Drawing.Point(12, 177);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(77, 61);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird.TabIndex = 20;
            this.bird.TabStop = false;
            // 
            // pipe_down3
            // 
            this.pipe_down3.BackColor = System.Drawing.Color.Transparent;
            this.pipe_down3.Image = global::Flappy_Bird.Properties.Resources.pipe_green;
            this.pipe_down3.Location = new System.Drawing.Point(673, 306);
            this.pipe_down3.Name = "pipe_down3";
            this.pipe_down3.Size = new System.Drawing.Size(52, 145);
            this.pipe_down3.TabIndex = 19;
            this.pipe_down3.TabStop = false;
            // 
            // pipe_down4
            // 
            this.pipe_down4.BackColor = System.Drawing.Color.Transparent;
            this.pipe_down4.Image = global::Flappy_Bird.Properties.Resources.pipe_green;
            this.pipe_down4.Location = new System.Drawing.Point(898, 293);
            this.pipe_down4.Name = "pipe_down4";
            this.pipe_down4.Size = new System.Drawing.Size(52, 158);
            this.pipe_down4.TabIndex = 17;
            this.pipe_down4.TabStop = false;
            // 
            // pipe_up1
            // 
            this.pipe_up1.BackColor = System.Drawing.Color.Transparent;
            this.pipe_up1.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipe_up1.Location = new System.Drawing.Point(321, -8);
            this.pipe_up1.Name = "pipe_up1";
            this.pipe_up1.Size = new System.Drawing.Size(57, 168);
            this.pipe_up1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipe_up1.TabIndex = 9;
            this.pipe_up1.TabStop = false;
            // 
            // pipe_down2
            // 
            this.pipe_down2.BackColor = System.Drawing.Color.Transparent;
            this.pipe_down2.Image = global::Flappy_Bird.Properties.Resources.pipe_green;
            this.pipe_down2.Location = new System.Drawing.Point(437, 293);
            this.pipe_down2.Name = "pipe_down2";
            this.pipe_down2.Size = new System.Drawing.Size(52, 158);
            this.pipe_down2.TabIndex = 8;
            this.pipe_down2.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackgroundImage = global::Flappy_Bird.Properties.Resources.base1;
            this.Ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ground.Controls.Add(this.pictureBox1);
            this.Ground.Controls.Add(this.lbl_level);
            this.Ground.Controls.Add(this.lbl_lvl);
            this.Ground.Controls.Add(this.label1);
            this.Ground.Controls.Add(this.lbl_score);
            this.Ground.Location = new System.Drawing.Point(-2, 449);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1031, 112);
            this.Ground.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Flappy_Bird.Properties.Resources.HuaJuly_04_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(942, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.BackColor = System.Drawing.Color.Black;
            this.lbl_level.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_level.Location = new System.Drawing.Point(104, 74);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(25, 27);
            this.lbl_level.TabIndex = 24;
            this.lbl_level.Text = " 1";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lvl.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lvl.Location = new System.Drawing.Point(7, 74);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(91, 27);
            this.lbl_lvl.TabIndex = 23;
            this.lbl_lvl.Text = "LEVEL  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Score  :";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Black;
            this.lbl_score.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_score.Location = new System.Drawing.Point(104, 28);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(28, 27);
            this.lbl_score.TabIndex = 22;
            this.lbl_score.Text = " 0";
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1012, 561);
            this.Controls.Add(this.lbl_pause);
            this.Controls.Add(this.pipe_up3);
            this.Controls.Add(this.pipe_up4);
            this.Controls.Add(this.pipe_up2);
            this.Controls.Add(this.pipe_down1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipe_down3);
            this.Controls.Add(this.pipe_down4);
            this.Controls.Add(this.pipe_up1);
            this.Controls.Add(this.pipe_down2);
            this.Controls.Add(this.Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PauseEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down2)).EndInit();
            this.Ground.ResumeLayout(false);
            this.Ground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.PictureBox pipe_down2;
        private System.Windows.Forms.PictureBox pipe_up1;
        private System.Windows.Forms.PictureBox pipe_down4;
        private System.Windows.Forms.PictureBox pipe_down3;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pipe_down1;
        private System.Windows.Forms.PictureBox pipe_up2;
        private System.Windows.Forms.PictureBox pipe_up4;
        private System.Windows.Forms.PictureBox pipe_up3;
        private System.Windows.Forms.Label lbl_pause;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_score;
    }
}