
namespace Flappy_Bird
{
    partial class Option_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sound = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_exit = new System.Windows.Forms.Label();
            this.Option_menu = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "SOUND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "ON  /  OFF";
            // 
            // btn_sound
            // 
            this.btn_sound.BackColor = System.Drawing.Color.Transparent;
            this.btn_sound.Image = global::Flappy_Bird.Properties.Resources.sound_on;
            this.btn_sound.Location = new System.Drawing.Point(483, 423);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(55, 50);
            this.btn_sound.TabIndex = 5;
            this.btn_sound.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(442, 372);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(146, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(479, 487);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(59, 27);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // Option_menu
            // 
            this.Option_menu.AutoSize = true;
            this.Option_menu.BackColor = System.Drawing.Color.Transparent;
            this.Option_menu.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_menu.ForeColor = System.Drawing.Color.Yellow;
            this.Option_menu.Location = new System.Drawing.Point(392, 209);
            this.Option_menu.Name = "Option_menu";
            this.Option_menu.Size = new System.Drawing.Size(227, 60);
            this.Option_menu.TabIndex = 8;
            this.Option_menu.Text = "OPTIONS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Flappy_Bird.Properties.Resources.download_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(321, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(367, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Flappy_Bird.Properties.Resources.yellowbird_upflap;
            this.pictureBox2.Location = new System.Drawing.Point(455, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Option_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.new_background_day_edited;
            this.ClientSize = new System.Drawing.Size(1012, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Option_menu);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_sound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Option_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_sound;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label btn_exit;
        private System.Windows.Forms.Label Option_menu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}