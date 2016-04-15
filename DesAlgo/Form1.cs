using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesAlgo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool KeyCheck(string key)
        {
            if (key.Length == 16)
            {
                return true;
            }
            else
            {
                MessageBox.Show("The key is must be 16-HexDecimal Length for DES algorithm");
                return false;
            }
        }

        private void btnTextEncrypt_Click(object sender, EventArgs e)
        {
            if (!KeyCheck(txtKey.Text))
            {
                return;
            }
        }

        private void btnTextDecrypt_Click(object sender, EventArgs e)
        {
            if (!KeyCheck(txtKey.Text))
            {
                return;
            }
        }
    }
}
