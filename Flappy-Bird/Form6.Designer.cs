
namespace Flappy_Bird
{
    partial class Ready_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ready_Form));
            this.btn_ready = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ready
            // 
            this.btn_ready.BackColor = System.Drawing.Color.Transparent;
            this.btn_ready.Image = global::Flappy_Bird.Properties.Resources.message;
            this.btn_ready.Location = new System.Drawing.Point(132, 43);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(740, 459);
            this.btn_ready.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ready.TabIndex = 0;
            this.btn_ready.TabStop = false;
            this.btn_ready.Click += new System.EventHandler(this.btn_ready_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Flappy_Bird.Properties.Resources.download_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(324, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(367, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // Ready_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.new_background_day_edited;
            this.ClientSize = new System.Drawing.Size(1012, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_ready);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ready_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.btn_ready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_ready;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}