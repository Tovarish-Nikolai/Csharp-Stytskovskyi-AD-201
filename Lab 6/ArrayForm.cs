using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ArrayForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intArray = new int[1000];

            int amountGood = 0, amountBad = 0, sum = 0, multiplication = 1, average = 1, min = 9999999, max = 0, dumb = 0, lines = 0;

            lines = textBox1.Lines.Length;

            for (int i = 0; i < lines; i++)                                                                                             //Getting the amount
            {                                                                                                                           // and putting ints into intArray
                int j = 0;
                foreach (char c in textBox1.Lines[i])
                {
                    j++;
                    if (!char.IsDigit(c))
                    {
                        amountBad++;
                        break;
                    }
                    else if (j == textBox1.Lines[i].Length) {intArray[amountGood] = Convert.ToInt32(textBox1.Lines[i]); amountGood++; }
                }
            }

            for (int i = 0; i < intArray.Length; i++)              
            {
                sum += intArray[i];                                                 //Getting the sum
                if (intArray[i] != 0) { multiplication *= intArray[i]; }           //Multiplication
                average = sum/amountGood;                                             //Average
                if (min > intArray[i] && i < amountGood) { min = intArray[i]; }   //min
                if (max < intArray[i]) { max = intArray[i]; }                 //max

                if (i < amountGood)
                {
                    int t = 0;
                    int test = intArray[i];
                    while (test != 0)
                    {
                        t += test % 10;
                        test /= 10;
                    }
                    if (intArray[i] % t == 0) { dumb++; };
                }
            }

            MessageBox.Show(string.Format("Количество строк,\nне включенных в вычисления: {0}", amountBad));

            label11.Text = string.Format("{0,10:####.##}",amountGood);
            label10.Text = string.Format("{0,10:####.##}",sum);
            label12.Text = string.Format("{0,10:####.##}",multiplication);
            label13.Text = string.Format("{0,10:####.##}",average);
            label14.Text = string.Format("{0,10:####.##}",min);
            label15.Text = string.Format("{0,10:####.##}",max);
            label16.Text = string.Format("{0,10:####.##}",dumb);
        }
    }
}
