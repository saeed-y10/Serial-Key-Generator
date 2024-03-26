using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KeyGeneratorLibrary;

namespace KeyGeneratorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Icon icon = (System.Drawing.Icon)(Properties.Resources.ResourceManager.GetObject("Key_32x32"));
            this.Icon = icon;

            KeyGenerator = new clsKeyGenerator();
            saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "save";
            saveFileDialog1.InitialDirectory = @"C:\Users\Public\Documents";
            saveFileDialog1.FileName = "GeneratedKeys";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt) | *.txt";

            btnGenerate.Focus();

            rbRandom.Checked = true;
            rbCapital.Checked = true;

            KeyGenerator.KeyType = clsKeyGenerator.enKeyType.Random;
            KeyGenerator.LetterType = clsKeyGenerator.enLetterType.Capital;
            KeyGenerator.TotalKeys = 5;
            KeyGenerator.KeyLength = 5;
            KeyGenerator.PartLenth = 5;
        }

        private clsKeyGenerator KeyGenerator;

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txbKeys.Text != "")
                Clipboard.SetText(txbKeys.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbKeys.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            KeyGenerator.GenerateKeys();

            string[] arrTemp = KeyGenerator.Keys;
            string strTemp = string.Empty;

            foreach (string v in arrTemp)
                strTemp += v + System.Environment.NewLine;

            txbKeys.Text = strTemp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String Path = saveFileDialog1.FileName;

                KeyGenerator.SaveTo(saveFileDialog1.FileName);
            }
        }

        private void rbNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumbers.Checked)
            {
                KeyGenerator.KeyType = KeyGeneratorLibrary.clsKeyGenerator.enKeyType.Numbers;
                gbLettersType.Enabled = false;
            }
        }

        private void rbLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLetters.Checked)
            {
                KeyGenerator.KeyType = KeyGeneratorLibrary.clsKeyGenerator.enKeyType.Letters;
                gbLettersType.Enabled = true;
            }
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandom.Checked)
            {
                KeyGenerator.KeyType = KeyGeneratorLibrary.clsKeyGenerator.enKeyType.Random;
                gbLettersType.Enabled = true;
            }
        }

        private void rbCapital_CheckedChanged(object sender, EventArgs e)
        {
            KeyGenerator.LetterType = KeyGeneratorLibrary.clsKeyGenerator.enLetterType.Capital;

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            KeyGenerator.LetterType = KeyGeneratorLibrary.clsKeyGenerator.enLetterType.Small;
        }

        private void rbRandomLetter_CheckedChanged(object sender, EventArgs e)
        {
            KeyGenerator.LetterType = KeyGeneratorLibrary.clsKeyGenerator.enLetterType.Random;
        }

        private void numTotalKeys_ValueChanged(object sender, EventArgs e)
        {
            KeyGenerator.TotalKeys = Convert.ToByte(numTotalKeys.Value);
        }

        private void numTotalParts_ValueChanged(object sender, EventArgs e)
        {
            KeyGenerator.KeyLength = Convert.ToByte(numTotalParts.Value);
        }

        private void numPartLength_ValueChanged(object sender, EventArgs e)
        {
            KeyGenerator.PartLenth = Convert.ToByte(numPartLength.Value);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();

            frm.ShowDialog();
        }

    }
}
