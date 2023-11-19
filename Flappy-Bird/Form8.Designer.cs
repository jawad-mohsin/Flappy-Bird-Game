
namespace Flappy_Bird
{
    partial class Quit2_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quit2_Form));
            this.btn_no = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Label();
            this.quit_menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            resources.ApplyResources(this.btn_no, "btn_no");
            this.btn_no.BackColor = System.Drawing.Color.Transparent;
            this.btn_no.ForeColor = System.Drawing.Color.Black;
            this.btn_no.Name = "btn_no";
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            this.btn_no.MouseLeave += new System.EventHandler(this.btn_no_MouseLeave);
            this.btn_no.MouseHover += new System.EventHandler(this.btn_no_MouseHover);
            // 
            // btn_yes
            // 
            resources.ApplyResources(this.btn_yes, "btn_yes");
            this.btn_yes.BackColor = System.Drawing.Color.Transparent;
            this.btn_yes.ForeColor = System.Drawing.Color.Black;
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            this.btn_yes.MouseLeave += new System.EventHandler(this.btn_yes_MouseLeave);
            this.btn_yes.MouseHover += new System.EventHandler(this.btn_yes_MouseHover);
            // 
            // quit_menu
            // 
            resources.ApplyResources(this.quit_menu, "quit_menu");
            this.quit_menu.BackColor = System.Drawing.Color.Transparent;
            this.quit_menu.ForeColor = System.Drawing.Color.Black;
            this.quit_menu.Name = "quit_menu";
            // 
            // Quit2_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.quit1;
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.quit_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Quit2_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_no;
        private System.Windows.Forms.Label btn_yes;
        private System.Windows.Forms.Label quit_menu;
    }
}