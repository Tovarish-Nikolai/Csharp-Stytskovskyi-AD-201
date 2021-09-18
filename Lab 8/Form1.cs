using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            label6.Visible = true;
            if (a == 0)
            { 
                if (b == 0) 
                {
                    label7.Text = " Abscent "; 
                    label8.Text = " No Solution ";

                    label7.Visible = true;
                    label8.Visible = true;
                }
                else
                {
                    double x1 = (-c) / b;                 

                    label9.Visible = true;
                    label11.Visible = true;                   
                    label11.Text = Convert.ToString(x1);

                    label8.Visible = true;
                    label8.Text = " One Root";                   
                }
            }
            else 
            {
                double D = b * b - 4 * a * c;

                label7.Visible = true;
                label7.Text = string.Format("{0,10:##.##}", D);

                if (D < 0) { label8.Visible = true; label8.Text = " No Roots"; }
                else if (D == 0)
                {
                    label8.Visible = true;
                    label8.Text = " One Root";

                    double x1 = (-b) / (2 * a);

                    label11.Visible = true;
                    label11.Text = Convert.ToString(x1);
                }
                else if (D > 0)
                {
                    label8.Visible = true;
                    label8.Text = " Two Roots";

                    double x1, x2;
                    x1 = (-b) / (2 * a);
                    x2 = (b) / (2 * a);

                    label11.Visible = true;
                    label11.Text = Convert.ToString(x1);

                    label12.Visible = true;
                    label12.Text = Convert.ToString(x2);
                }
            }
        }
    }
}
