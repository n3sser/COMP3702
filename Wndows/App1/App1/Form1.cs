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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            String user = textBox1.Text;
           
            String password = textBox2.Text;
            int pass = password.GetHashCode();

            if (user.Equals("test") && pass =="123".GetHashCode())

            {
                label3.Text = "";
                this.Hide();
                Form2 f = new Form2(this, user);
                f.Show();
            }
            else {

                label3.Text = "Wrong username or password";

                
            }

        }


    }
}
