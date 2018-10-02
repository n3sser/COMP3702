using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App1
{
    public partial class Form2 : Form
    {
        Form1 f1;
        string username;
        public Form2(Form1 f, string name)
        {
            f1 = f;
            username = name;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello " + username;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
