using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;
using System.Collections.Generic;

namespace Ex
{
    public partial class Form1 : Form
    {
        int i;
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            n = Convert.ToInt32(textBox1.Text);
            for (; i < n; i = i + 2)
            {
                textBox2.Text = textBox2.Text + " " + Convert.ToString(i);
            }
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
