﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Module : Form
    {
        public Module()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (textBox1.Text != "")
            {
                if (this.radioButton1.Checked == true)
                    Main.listBox1.Items.Add(this.textBox1.Text);
                else Main.listBox2.Items.Add(this.textBox1.Text);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
