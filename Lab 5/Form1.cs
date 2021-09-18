using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double r;
                r = Convert.ToDouble(textBox1.Text);
                label8.Text = Convert.ToString(Math.PI * r * r);

                double h, S, V, A;

                if (textBox2.Text != "")
                {
                    h = Convert.ToDouble(textBox2.Text);
                    S = Convert.ToDouble(label8.Text);

                    label9.Text = Convert.ToString(S * h);
                    label10.Text = Convert.ToString(2 * Math.PI * r * h + 2 * S);
                }
            }
        }
        private void TextBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && textBox2.Text != "")
            //{
            //    double r, h, S, V, A;

            //    h = Convert.ToDouble(textBox2.Text);
            //    S = Convert.ToDouble(label8.Text);
            //    r = Convert.ToDouble(textBox1.Text);

            //    label9.Text = Convert.ToString(S * h);
            //    label10.Text = Convert.ToString(2 * Math.PI * r * h + 2 * S);
            //}

        }
    }
}
