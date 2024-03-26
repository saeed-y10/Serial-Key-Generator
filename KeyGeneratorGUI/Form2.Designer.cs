namespace KeyGeneratorGUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbLinkedin = new System.Windows.Forms.PictureBox();
            this.picbGithub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // picbLinkedin
            // 
            this.picbLinkedin.BackColor = System.Drawing.SystemColors.Control;
            this.picbLinkedin.BackgroundImage = global::KeyGeneratorGUI.Properties.Resources.Linkedin;
            resources.ApplyResources(this.picbLinkedin, "picbLinkedin");
            this.picbLinkedin.Name = "picbLinkedin";
            this.picbLinkedin.TabStop = false;
            this.picbLinkedin.Click += new System.EventHandler(this.picbLinkedin_Click);
            // 
            // picbGithub
            // 
            this.picbGithub.BackgroundImage = global::KeyGeneratorGUI.Properties.Resources.Hithub;
            resources.ApplyResources(this.picbGithub, "picbGithub");
            this.picbGithub.Name = "picbGithub";
            this.picbGithub.TabStop = false;
            this.picbGithub.Click += new System.EventHandler(this.picbGithub_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picbLinkedin);
            this.Controls.Add(this.picbGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbLinkedin;
        private System.Windows.Forms.PictureBox picbGithub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}