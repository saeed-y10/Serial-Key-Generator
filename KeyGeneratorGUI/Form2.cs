using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGeneratorGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void picbGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/saeed-y10");
        }

        private void picbLinkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linkedin.com/in/saeed-lahmdi");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
      
        }

    }
}
