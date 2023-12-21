namespace SerialGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txbKeys = new System.Windows.Forms.TextBox();
            this.gbKeyType = new System.Windows.Forms.GroupBox();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbLetters = new System.Windows.Forms.RadioButton();
            this.rbNumbers = new System.Windows.Forms.RadioButton();
            this.gbLettersType = new System.Windows.Forms.GroupBox();
            this.rbRandomLetter = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbCapital = new System.Windows.Forms.RadioButton();
            this.numPartLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalParts = new System.Windows.Forms.Label();
            this.numTotalParts = new System.Windows.Forms.NumericUpDown();
            this.numTotalKeys = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbKeyType.SuspendLayout();
            this.gbLettersType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Russo One", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(455, 72);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Serial Key Generator";
            // 
            // txbKeys
            // 
            this.txbKeys.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbKeys.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKeys.Location = new System.Drawing.Point(12, 105);
            this.txbKeys.Multiline = true;
            this.txbKeys.Name = "txbKeys";
            this.txbKeys.ReadOnly = true;
            this.txbKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbKeys.Size = new System.Drawing.Size(388, 397);
            this.txbKeys.TabIndex = 7;
            // 
            // gbKeyType
            // 
            this.gbKeyType.Controls.Add(this.rbRandom);
            this.gbKeyType.Controls.Add(this.rbLetters);
            this.gbKeyType.Controls.Add(this.rbNumbers);
            this.gbKeyType.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKeyType.Location = new System.Drawing.Point(407, 105);
            this.gbKeyType.Name = "gbKeyType";
            this.gbKeyType.Size = new System.Drawing.Size(346, 74);
            this.gbKeyType.TabIndex = 0;
            this.gbKeyType.TabStop = false;
            this.gbKeyType.Text = "Key Type";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbRandom.Location = new System.Drawing.Point(237, 32);
            this.rbRandom.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(101, 34);
            this.rbRandom.TabIndex = 2;
            this.rbRandom.TabStop = true;
            this.rbRandom.Tag = "3";
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // rbLetters
            // 
            this.rbLetters.AutoSize = true;
            this.rbLetters.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbLetters.Location = new System.Drawing.Point(131, 32);
            this.rbLetters.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.rbLetters.Name = "rbLetters";
            this.rbLetters.Size = new System.Drawing.Size(89, 34);
            this.rbLetters.TabIndex = 1;
            this.rbLetters.TabStop = true;
            this.rbLetters.Tag = "2";
            this.rbLetters.Text = "Letters";
            this.rbLetters.UseVisualStyleBackColor = true;
            this.rbLetters.CheckedChanged += new System.EventHandler(this.rbLetters_CheckedChanged);
            // 
            // rbNumbers
            // 
            this.rbNumbers.AutoSize = true;
            this.rbNumbers.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbNumbers.Location = new System.Drawing.Point(7, 32);
            this.rbNumbers.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.rbNumbers.Name = "rbNumbers";
            this.rbNumbers.Size = new System.Drawing.Size(107, 34);
            this.rbNumbers.TabIndex = 0;
            this.rbNumbers.TabStop = true;
            this.rbNumbers.Tag = "1";
            this.rbNumbers.Text = "Numbers";
            this.rbNumbers.UseVisualStyleBackColor = true;
            this.rbNumbers.CheckedChanged += new System.EventHandler(this.rbNumbers_CheckedChanged);
            // 
            // gbLettersType
            // 
            this.gbLettersType.Controls.Add(this.rbRandomLetter);
            this.gbLettersType.Controls.Add(this.rbSmall);
            this.gbLettersType.Controls.Add(this.rbCapital);
            this.gbLettersType.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.gbLettersType.Location = new System.Drawing.Point(407, 185);
            this.gbLettersType.Name = "gbLettersType";
            this.gbLettersType.Size = new System.Drawing.Size(346, 74);
            this.gbLettersType.TabIndex = 1;
            this.gbLettersType.TabStop = false;
            this.gbLettersType.Text = "Letters Type";
            // 
            // rbRandomLetter
            // 
            this.rbRandomLetter.AutoSize = true;
            this.rbRandomLetter.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbRandomLetter.Location = new System.Drawing.Point(237, 32);
            this.rbRandomLetter.Name = "rbRandomLetter";
            this.rbRandomLetter.Size = new System.Drawing.Size(101, 34);
            this.rbRandomLetter.TabIndex = 2;
            this.rbRandomLetter.TabStop = true;
            this.rbRandomLetter.Tag = "3";
            this.rbRandomLetter.Text = "Random";
            this.rbRandomLetter.UseVisualStyleBackColor = true;
            this.rbRandomLetter.CheckedChanged += new System.EventHandler(this.rbRandomLetter_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbSmall.Location = new System.Drawing.Point(131, 32);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(79, 34);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "2";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbCapital
            // 
            this.rbCapital.AutoSize = true;
            this.rbCapital.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbCapital.Location = new System.Drawing.Point(7, 32);
            this.rbCapital.Name = "rbCapital";
            this.rbCapital.Size = new System.Drawing.Size(91, 34);
            this.rbCapital.TabIndex = 0;
            this.rbCapital.TabStop = true;
            this.rbCapital.Tag = "1";
            this.rbCapital.Text = "Capital";
            this.rbCapital.UseVisualStyleBackColor = true;
            this.rbCapital.CheckedChanged += new System.EventHandler(this.rbCapital_CheckedChanged);
            // 
            // numPartLength
            // 
            this.numPartLength.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.numPartLength.Location = new System.Drawing.Point(535, 358);
            this.numPartLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPartLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPartLength.Name = "numPartLength";
            this.numPartLength.Size = new System.Drawing.Size(74, 29);
            this.numPartLength.TabIndex = 4;
            this.numPartLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPartLength.ValueChanged += new System.EventHandler(this.numPartLength_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(409, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Part Lenth";
            // 
            // lblTotalParts
            // 
            this.lblTotalParts.AutoSize = true;
            this.lblTotalParts.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalParts.Location = new System.Drawing.Point(409, 318);
            this.lblTotalParts.Name = "lblTotalParts";
            this.lblTotalParts.Size = new System.Drawing.Size(87, 30);
            this.lblTotalParts.TabIndex = 13;
            this.lblTotalParts.Text = "Key Parts";
            // 
            // numTotalParts
            // 
            this.numTotalParts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.numTotalParts.Location = new System.Drawing.Point(535, 319);
            this.numTotalParts.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTotalParts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalParts.Name = "numTotalParts";
            this.numTotalParts.Size = new System.Drawing.Size(74, 29);
            this.numTotalParts.TabIndex = 3;
            this.numTotalParts.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTotalParts.ValueChanged += new System.EventHandler(this.numTotalParts_ValueChanged);
            // 
            // numTotalKeys
            // 
            this.numTotalKeys.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.numTotalKeys.Location = new System.Drawing.Point(535, 276);
            this.numTotalKeys.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotalKeys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalKeys.Name = "numTotalKeys";
            this.numTotalKeys.Size = new System.Drawing.Size(74, 29);
            this.numTotalKeys.TabIndex = 2;
            this.numTotalKeys.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTotalKeys.ValueChanged += new System.EventHandler(this.numTotalKeys_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(409, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Keys";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(714, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(39, 36);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Tag = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnInfo_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(669, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 36);
            this.btnSave.TabIndex = 15;
            this.btnSave.Tag = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::SerialGenerator.Properties.Resources.Reset_64x64;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(669, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 74);
            this.btnClear.TabIndex = 14;
            this.btnClear.Tag = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BackgroundImage = global::SerialGenerator.Properties.Resources.Copy_64x64;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.btnCopy.Location = new System.Drawing.Point(544, 428);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(77, 74);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Tag = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.MouseHover += new System.EventHandler(this.btnCopy_MouseHover);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackgroundImage = global::SerialGenerator.Properties.Resources.Generate_64x64;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(407, 428);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(89, 74);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Tag = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            this.btnGenerate.MouseHover += new System.EventHandler(this.btnGenerate_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(761, 522);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTotalKeys);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblTotalParts);
            this.Controls.Add(this.numTotalParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPartLength);
            this.Controls.Add(this.gbLettersType);
            this.Controls.Add(this.gbKeyType);
            this.Controls.Add(this.txbKeys);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Serial Key Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKeyType.ResumeLayout(false);
            this.gbKeyType.PerformLayout();
            this.gbLettersType.ResumeLayout(false);
            this.gbLettersType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txbKeys;
        private System.Windows.Forms.GroupBox gbKeyType;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbLetters;
        private System.Windows.Forms.RadioButton rbNumbers;
        private System.Windows.Forms.GroupBox gbLettersType;
        private System.Windows.Forms.RadioButton rbRandomLetter;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbCapital;
        private System.Windows.Forms.NumericUpDown numPartLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalParts;
        private System.Windows.Forms.NumericUpDown numTotalParts;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.NumericUpDown numTotalKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnInfo;
    }
}

