using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GitProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "default text";
            label2.Text = "";
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Wahey!";
            label2.Text = "Double Wahey!";
            label3.Text = "Text";
        }
    }
}