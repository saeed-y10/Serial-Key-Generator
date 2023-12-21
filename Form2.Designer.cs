namespace SerialGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picbLinkedin = new System.Windows.Forms.PictureBox();
            this.picbGithub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russo One", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "About Me";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programmer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(133, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saeed Lahmdi";
            // 
            // picbLinkedin
            // 
            this.picbLinkedin.Image = global::SerialGenerator.Properties.Resources.Linkedin;
            this.picbLinkedin.Location = new System.Drawing.Point(12, 116);
            this.picbLinkedin.Name = "picbLinkedin";
            this.picbLinkedin.Size = new System.Drawing.Size(82, 78);
            this.picbLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLinkedin.TabIndex = 10;
            this.picbLinkedin.TabStop = false;
            this.picbLinkedin.Click += new System.EventHandler(this.picbLinkedin_Click);
            // 
            // picbGithub
            // 
            this.picbGithub.Image = global::SerialGenerator.Properties.Resources.Hithub;
            this.picbGithub.Location = new System.Drawing.Point(174, 116);
            this.picbGithub.Name = "picbGithub";
            this.picbGithub.Size = new System.Drawing.Size(82, 78);
            this.picbGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbGithub.TabIndex = 9;
            this.picbGithub.TabStop = false;
            this.picbGithub.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(268, 206);
            this.Controls.Add(this.picbLinkedin);
            this.Controls.Add(this.picbGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picbLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picbGithub;
        private System.Windows.Forms.PictureBox picbLinkedin;
    }
}