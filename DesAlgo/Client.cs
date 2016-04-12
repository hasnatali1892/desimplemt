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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = CommonFunctions.tobinary(textBox1.Text);
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
