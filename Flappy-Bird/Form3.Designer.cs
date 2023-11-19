namespace Flappy_Bird
{
    partial class Quit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quit_Form));
            this.quit_menu = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Label();
            this.btn_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quit_menu
            // 
            this.quit_menu.AutoSize = true;
            this.quit_menu.BackColor = System.Drawing.Color.Transparent;
            this.quit_menu.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_menu.ForeColor = System.Drawing.Color.Black;
            this.quit_menu.Location = new System.Drawing.Point(101, 9);
            this.quit_menu.Name = "quit_menu";
            this.quit_menu.Size = new System.Drawing.Size(257, 40);
            this.quit_menu.TabIndex = 0;
            this.quit_menu.Text = "Are you sure? ";
            // 
            // btn_yes
            // 
            this.btn_yes.AutoSize = true;
            this.btn_yes.BackColor = System.Drawing.Color.Transparent;
            this.btn_yes.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.ForeColor = System.Drawing.Color.Black;
            this.btn_yes.Location = new System.Drawing.Point(143, 83);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(50, 27);
            this.btn_yes.TabIndex = 1;
            this.btn_yes.Text = "YES";
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            this.btn_yes.MouseLeave += new System.EventHandler(this.btn_yes_MouseLeave);
            this.btn_yes.MouseHover += new System.EventHandler(this.btn_yes_MouseHover);
            // 
            // btn_no
            // 
            this.btn_no.AutoSize = true;
            this.btn_no.BackColor = System.Drawing.Color.Transparent;
            this.btn_no.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.ForeColor = System.Drawing.Color.Black;
            this.btn_no.Location = new System.Drawing.Point(251, 83);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(40, 27);
            this.btn_no.TabIndex = 2;
            this.btn_no.Text = "NO";
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            this.btn_no.MouseLeave += new System.EventHandler(this.btn_no_MouseLeave);
            this.btn_no.MouseHover += new System.EventHandler(this.btn_no_MouseHover);
            // 
            // Quit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.quit1;
            this.ClientSize = new System.Drawing.Size(472, 153);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.quit_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quit_menu;
        private System.Windows.Forms.Label btn_yes;
        private System.Windows.Forms.Label btn_no;
    }
}