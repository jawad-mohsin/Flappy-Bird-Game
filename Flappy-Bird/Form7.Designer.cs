
namespace Flappy_Bird
{
    partial class GameOver_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver_Form));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Label();
            this.lbl_retry = new System.Windows.Forms.Label();
            this.lbl_mainmenu = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Flappy_Bird.Properties.Resources.gameover;
            this.pictureBox2.Location = new System.Drawing.Point(70, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(132, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "Score";
            // 
            // btn_quit
            // 
            this.btn_quit.AutoSize = true;
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.Black;
            this.btn_quit.Location = new System.Drawing.Point(156, 347);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(62, 27);
            this.btn_quit.TabIndex = 23;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            this.btn_quit.MouseLeave += new System.EventHandler(this.btn_quit_MouseLeave);
            this.btn_quit.MouseHover += new System.EventHandler(this.btn_quit_MouseHover);
            // 
            // lbl_retry
            // 
            this.lbl_retry.AutoSize = true;
            this.lbl_retry.BackColor = System.Drawing.Color.Transparent;
            this.lbl_retry.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_retry.ForeColor = System.Drawing.Color.Black;
            this.lbl_retry.Location = new System.Drawing.Point(156, 253);
            this.lbl_retry.Name = "lbl_retry";
            this.lbl_retry.Size = new System.Drawing.Size(80, 27);
            this.lbl_retry.TabIndex = 24;
            this.lbl_retry.Text = "RETRY";
            this.lbl_retry.Click += new System.EventHandler(this.lbl_retry_Click);
            this.lbl_retry.MouseLeave += new System.EventHandler(this.lbl_retry_MouseLeave);
            this.lbl_retry.MouseHover += new System.EventHandler(this.lbl_retry_MouseHover);
            // 
            // lbl_mainmenu
            // 
            this.lbl_mainmenu.AutoSize = true;
            this.lbl_mainmenu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mainmenu.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainmenu.ForeColor = System.Drawing.Color.Black;
            this.lbl_mainmenu.Location = new System.Drawing.Point(131, 300);
            this.lbl_mainmenu.Name = "lbl_mainmenu";
            this.lbl_mainmenu.Size = new System.Drawing.Size(123, 27);
            this.lbl_mainmenu.TabIndex = 25;
            this.lbl_mainmenu.Text = "MAINMENU";
            this.lbl_mainmenu.Click += new System.EventHandler(this.lbl_mainmenu_Click);
            this.lbl_mainmenu.MouseLeave += new System.EventHandler(this.lbl_mainmenu_MouseLeave);
            this.lbl_mainmenu.MouseHover += new System.EventHandler(this.lbl_mainmenu_MouseHover);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Black;
            this.lbl_score.Location = new System.Drawing.Point(170, 161);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(36, 40);
            this.lbl_score.TabIndex = 26;
            this.lbl_score.Text = "0";
            this.lbl_score.TextChanged += new System.EventHandler(this.ScoreEvent);
            // 
            // GameOver_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.quit1;
            this.ClientSize = new System.Drawing.Size(400, 435);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_mainmenu);
            this.Controls.Add(this.lbl_retry);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameOver_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.GameOver_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btn_quit;
        private System.Windows.Forms.Label lbl_retry;
        private System.Windows.Forms.Label lbl_mainmenu;
        private System.Windows.Forms.Label lbl_score;
    }
}