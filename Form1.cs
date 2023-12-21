using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace SerialGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum enKeyType : byte
        {
            Letters = 1,
            Numbers,
            Random
        }

        public enum enLetterType : byte
        {
            Small = 1,
            Capital,
            Random
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Save";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt) | *.txt";


            rbLetters.Checked = true;
            rbCapital.Checked = true;
        }

        public char GetRandomNumber()
        {
            return ((char)rand.Next(49, 57));
        }

        public enKeyType GetRandomKeyType()
        {
            return (enKeyType)((byte)rand.Next(1, 3));
        }

        public enLetterType GetRnadomLetterType()
        {
            return (enLetterType)((byte)rand.Next(1, 3));
        }

        public char GetRandomLetter(enLetterType Type)
        {
            switch (Type)
            {
                case enLetterType.Small:
                    return ((char)rand.Next(97, 122));

                case enLetterType.Capital:
                    return ((char)rand.Next(65, 90));

                default:
                    return GetRandomLetter(GetRnadomLetterType());
            }
        }

        public char GetRandomCharacter(enKeyType KeyType, enLetterType LetterType)
        {
            switch (KeyType)
            {
                case enKeyType.Numbers:
                    return GetRandomNumber();

                case enKeyType.Letters:
                    return GetRandomLetter(LetterType);

                default:
                    return GetRandomCharacter(GetRandomKeyType(), LetterType);
            }
        }

        public string GenerateKeyPart(byte Length, enKeyType KeyType, enLetterType LetterType)
        {
            string Part = string.Empty;

            for (byte i = 0; i < Length; i++)
            {
                Part += GetRandomCharacter(KeyType, LetterType);
            }

            return Part;
        }

        public string GenerateKey(byte KeyLength, byte PartLength, enKeyType KeyType, enLetterType LetterType, string Seperator)
        {
            string Key = string.Empty;

            for (byte i = 0; i < KeyLength; i++)
            {
                Key += GenerateKeyPart(PartLength, KeyType, LetterType) + Seperator;
            }

            return Key.Substring(0, Key.Length - 1);
        }

        public string GenerateKeys(byte NumberOfKeys, byte KeyLength, byte PartLength, enKeyType KeyType, enLetterType LetterType, string Seperator)
        {
            string Keys = string.Empty;

            for (byte i = 0; i < NumberOfKeys; i++)
            {
                Keys += GenerateKey(KeyLength, PartLength, KeyType, LetterType, Seperator) + Environment.NewLine;
            }

            return Keys;
        }

        public Random rand;

        public enKeyType KeyType = enKeyType.Letters;
        public enLetterType LettersType = enLetterType.Capital;

        public byte PartLenth = 5;
        public byte KeyLength = 5;
        public byte TotalKeys = 5;

        private string Path = @"C:\Users\Public\Documents\Keys.txt";
        private string Keys = string.Empty;
        private void rbNumbers_CheckedChanged(object sender, EventArgs e)
        {

            if (rbNumbers.Checked)
            {
                KeyType = enKeyType.Numbers;
                gbLettersType.Enabled = false;
            }
        }

        private void rbLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLetters.Checked)
            {
                KeyType = enKeyType.Letters;
                gbLettersType.Enabled = true;
            }
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandom.Checked)
            {
                KeyType = enKeyType.Random;
                gbLettersType.Enabled = true;
            }
        }

        private void rbCapital_CheckedChanged(object sender, EventArgs e)
        {
            LettersType = enLetterType.Capital;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            LettersType = enLetterType.Small;
        }

        private void rbRandomLetter_CheckedChanged(object sender, EventArgs e)
        {
            LettersType |= enLetterType.Random;
        }

        private void numTotalParts_ValueChanged(object sender, EventArgs e)
        {
            KeyLength = Convert.ToByte(numTotalParts.Value);
        }

        private void numPartLength_ValueChanged(object sender, EventArgs e)
        {
            PartLenth = Convert.ToByte(numPartLength.Value);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Keys = GenerateKeys(TotalKeys, KeyLength, PartLenth, KeyType, LettersType, "-").ToString();
            
            txbKeys.Text = Keys;
        }

        private void SaveToFile(string Text, string Path)
        {
            FileStream File = new FileStream(Path, FileMode.Create);

            if (!File.CanWrite)
            {
                MessageBox.Show("You Don't Have Access Permission To This Folder !", "Access Problem");
                return;
            }

            byte[] data = Encoding.UTF8.GetBytes(Keys);

            File.Write(data, 0, data.Length);
            File.Close();

            
        }

        private void numTotalKeys_ValueChanged(object sender, EventArgs e)
        {
            TotalKeys = ((byte)numTotalKeys.Value);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txbKeys.Text != "")
            Clipboard.SetText(txbKeys.Text);
        }

        private void GetNmae()
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbKeys.Text = "";
        }

        private void ShowTip(Button btn)
        {
            toolTip1.SetToolTip(btn, btn.Tag.ToString());
            toolTip1.Show(btn.Tag.ToString(), btn);
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
           ShowTip(btnClear);
        }

        private void btnCopy_MouseHover(object sender, EventArgs e)
        {
            ShowTip(btnCopy);
        }

        private void btnGenerate_MouseHover(object sender, EventArgs e)
        {
            ShowTip(btnGenerate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog();
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = saveFileDialog1.FileName;

                SaveToFile(Keys, Path);
            }

            //SaveToFile(Keys, Path);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form form = new Form2();

            form.ShowDialog();
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            ShowTip(btnInfo);
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            ShowTip(btnSave);
        }
    }
}
