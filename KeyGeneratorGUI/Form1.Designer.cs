namespace KeyGeneratorGUI
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlKeys = new System.Windows.Forms.Panel();
            this.txbKeys = new System.Windows.Forms.TextBox();
            this.numTotalKeys = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numTotalParts = new System.Windows.Forms.NumericUpDown();
            this.lblTotalParts = new System.Windows.Forms.Label();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbLetters = new System.Windows.Forms.RadioButton();
            this.numPartLength = new System.Windows.Forms.NumericUpDown();
            this.rbNumbers = new System.Windows.Forms.RadioButton();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLettersType = new System.Windows.Forms.GroupBox();
            this.rbRandomLetter = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbCapital = new System.Windows.Forms.RadioButton();
            this.gbKeyType = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.pnlKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartLength)).BeginInit();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLettersType.SuspendLayout();
            this.gbKeyType.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 3000;
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 3000;
            this.toolTip1.ReshowDelay = 2000;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Russo One", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(384, 98);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Serial Key Generator";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlKeys
            // 
            this.pnlKeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlKeys.Controls.Add(this.txbKeys);
            this.pnlKeys.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKeys.Location = new System.Drawing.Point(0, 98);
            this.pnlKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKeys.Name = "pnlKeys";
            this.pnlKeys.Size = new System.Drawing.Size(487, 392);
            this.pnlKeys.TabIndex = 26;
            // 
            // txbKeys
            // 
            this.txbKeys.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbKeys.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKeys.Location = new System.Drawing.Point(0, 0);
            this.txbKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbKeys.Multiline = true;
            this.txbKeys.Name = "txbKeys";
            this.txbKeys.ReadOnly = true;
            this.txbKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbKeys.Size = new System.Drawing.Size(487, 392);
            this.txbKeys.TabIndex = 10;
            this.txbKeys.TabStop = false;
            // 
            // numTotalKeys
            // 
            this.numTotalKeys.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.numTotalKeys.Location = new System.Drawing.Point(113, 158);
            this.numTotalKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numTotalKeys.Size = new System.Drawing.Size(66, 29);
            this.numTotalKeys.TabIndex = 2;
            this.numTotalKeys.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTotalKeys.ValueChanged += new System.EventHandler(this.numTotalKeys_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Part Lenth";
            // 
            // numTotalParts
            // 
            this.numTotalParts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.numTotalParts.Location = new System.Drawing.Point(113, 201);
            this.numTotalParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numTotalParts.Size = new System.Drawing.Size(66, 29);
            this.numTotalParts.TabIndex = 3;
            this.numTotalParts.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTotalParts.ValueChanged += new System.EventHandler(this.numTotalParts_ValueChanged);
            // 
            // lblTotalParts
            // 
            this.lblTotalParts.AutoSize = true;
            this.lblTotalParts.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalParts.Location = new System.Drawing.Point(3, 199);
            this.lblTotalParts.Name = "lblTotalParts";
            this.lblTotalParts.Size = new System.Drawing.Size(87, 30);
            this.lblTotalParts.TabIndex = 13;
            this.lblTotalParts.Text = "Key Parts";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbRandom.Location = new System.Drawing.Point(204, 34);
            this.rbRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(101, 34);
            this.rbRandom.TabIndex = 2;
            this.rbRandom.Tag = "3";
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.Click += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // rbLetters
            // 
            this.rbLetters.AutoSize = true;
            this.rbLetters.Checked = true;
            this.rbLetters.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbLetters.Location = new System.Drawing.Point(113, 34);
            this.rbLetters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLetters.Name = "rbLetters";
            this.rbLetters.Size = new System.Drawing.Size(89, 34);
            this.rbLetters.TabIndex = 1;
            this.rbLetters.TabStop = true;
            this.rbLetters.Tag = "2";
            this.rbLetters.Text = "Letters";
            this.rbLetters.UseVisualStyleBackColor = true;
            this.rbLetters.Click += new System.EventHandler(this.rbLetters_CheckedChanged);
            // 
            // numPartLength
            // 
            this.numPartLength.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.numPartLength.Location = new System.Drawing.Point(113, 240);
            this.numPartLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numPartLength.Size = new System.Drawing.Size(66, 29);
            this.numPartLength.TabIndex = 4;
            this.numPartLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPartLength.ValueChanged += new System.EventHandler(this.numPartLength_ValueChanged);
            // 
            // rbNumbers
            // 
            this.rbNumbers.AutoSize = true;
            this.rbNumbers.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbNumbers.Location = new System.Drawing.Point(6, 34);
            this.rbNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNumbers.Name = "rbNumbers";
            this.rbNumbers.Size = new System.Drawing.Size(107, 34);
            this.rbNumbers.TabIndex = 0;
            this.rbNumbers.Tag = "1";
            this.rbNumbers.Text = "Numbers";
            this.rbNumbers.UseVisualStyleBackColor = true;
            this.rbNumbers.Click += new System.EventHandler(this.rbNumbers_CheckedChanged);
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.btnSave);
            this.pnlHead.Controls.Add(this.btnInfo);
            this.pnlHead.Controls.Add(this.pictureBox1);
            this.pnlHead.Controls.Add(this.lblHeader);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(813, 98);
            this.pnlHead.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::KeyGeneratorGUI.Properties.Resources.Save_32x32;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(715, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 98);
            this.btnSave.TabIndex = 8;
            this.btnSave.Tag = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::KeyGeneratorGUI.Properties.Resources._1703156531478;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(764, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(49, 98);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.Tag = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::KeyGeneratorGUI.Properties.Resources.Keychain_128x128;
            this.pictureBox1.Location = new System.Drawing.Point(384, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // gbLettersType
            // 
            this.gbLettersType.Controls.Add(this.rbRandomLetter);
            this.gbLettersType.Controls.Add(this.rbSmall);
            this.gbLettersType.Controls.Add(this.rbCapital);
            this.gbLettersType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLettersType.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.gbLettersType.Location = new System.Drawing.Point(0, 74);
            this.gbLettersType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLettersType.Name = "gbLettersType";
            this.gbLettersType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLettersType.Size = new System.Drawing.Size(327, 74);
            this.gbLettersType.TabIndex = 1;
            this.gbLettersType.TabStop = false;
            this.gbLettersType.Text = "Letters Type";
            // 
            // rbRandomLetter
            // 
            this.rbRandomLetter.AutoSize = true;
            this.rbRandomLetter.Checked = true;
            this.rbRandomLetter.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbRandomLetter.Location = new System.Drawing.Point(204, 34);
            this.rbRandomLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRandomLetter.Name = "rbRandomLetter";
            this.rbRandomLetter.Size = new System.Drawing.Size(101, 34);
            this.rbRandomLetter.TabIndex = 2;
            this.rbRandomLetter.TabStop = true;
            this.rbRandomLetter.Tag = "3";
            this.rbRandomLetter.Text = "Random";
            this.rbRandomLetter.UseVisualStyleBackColor = true;
            this.rbRandomLetter.Click += new System.EventHandler(this.rbRandomLetter_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbSmall.Location = new System.Drawing.Point(113, 34);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(79, 34);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.Tag = "2";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.Click += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbCapital
            // 
            this.rbCapital.AutoSize = true;
            this.rbCapital.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.rbCapital.Location = new System.Drawing.Point(6, 34);
            this.rbCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCapital.Name = "rbCapital";
            this.rbCapital.Size = new System.Drawing.Size(91, 34);
            this.rbCapital.TabIndex = 0;
            this.rbCapital.Tag = "1";
            this.rbCapital.Text = "Capital";
            this.rbCapital.UseVisualStyleBackColor = true;
            this.rbCapital.Click += new System.EventHandler(this.rbCapital_CheckedChanged);
            // 
            // gbKeyType
            // 
            this.gbKeyType.Controls.Add(this.rbRandom);
            this.gbKeyType.Controls.Add(this.rbLetters);
            this.gbKeyType.Controls.Add(this.rbNumbers);
            this.gbKeyType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbKeyType.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKeyType.Location = new System.Drawing.Point(0, 0);
            this.gbKeyType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKeyType.Name = "gbKeyType";
            this.gbKeyType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKeyType.Size = new System.Drawing.Size(327, 74);
            this.gbKeyType.TabIndex = 0;
            this.gbKeyType.TabStop = false;
            this.gbKeyType.Text = "Key Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 92);
            this.panel2.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::KeyGeneratorGUI.Properties.Resources.Reset_64x64;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(230, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 74);
            this.btnClear.TabIndex = 7;
            this.btnClear.Tag = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BackgroundImage = global::KeyGeneratorGUI.Properties.Resources.Copy_64x64;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.btnCopy.Location = new System.Drawing.Point(121, 12);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(67, 74);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Tag = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackgroundImage = global::KeyGeneratorGUI.Properties.Resources.Generate_64x64;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(67, 74);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Tag = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Keys";
            // 
            // pnlTools
            // 
            this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTools.Controls.Add(this.panel2);
            this.pnlTools.Controls.Add(this.gbLettersType);
            this.pnlTools.Controls.Add(this.gbKeyType);
            this.pnlTools.Controls.Add(this.label2);
            this.pnlTools.Controls.Add(this.numPartLength);
            this.pnlTools.Controls.Add(this.numTotalKeys);
            this.pnlTools.Controls.Add(this.label1);
            this.pnlTools.Controls.Add(this.numTotalParts);
            this.pnlTools.Controls.Add(this.lblTotalParts);
            this.pnlTools.Location = new System.Drawing.Point(489, 105);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(327, 378);
            this.pnlTools.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 490);
            this.Controls.Add(this.pnlKeys);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Key Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlKeys.ResumeLayout(false);
            this.pnlKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartLength)).EndInit();
            this.pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLettersType.ResumeLayout(false);
            this.gbLettersType.PerformLayout();
            this.gbKeyType.ResumeLayout(false);
            this.gbKeyType.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlKeys;
        private System.Windows.Forms.TextBox txbKeys;
        private System.Windows.Forms.NumericUpDown numTotalKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTotalParts;
        private System.Windows.Forms.Label lblTotalParts;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbLetters;
        private System.Windows.Forms.NumericUpDown numPartLength;
        private System.Windows.Forms.RadioButton rbNumbers;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.GroupBox gbLettersType;
        private System.Windows.Forms.RadioButton rbRandomLetter;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbCapital;
        private System.Windows.Forms.GroupBox gbKeyType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTools;
    }
}

