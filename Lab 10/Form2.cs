using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form2 : Form
    {

        Color colorResult;

        public Form2(Color color)
        {
            InitializeComponent();

            SB_red.Tag = num_red;
            SB_green.Tag = num_green;
            SB_blue.Tag = num_blue;
            num_red.Tag = SB_red;
            num_green.Tag = SB_green;
            num_blue.Tag = SB_blue;
            num_red.Value = color.R;
            num_green.Value = color.G;
            num_blue.Value = color.B;
        }

        private void Scroll_Red_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

            UpdateColor();
        }

        private void Scroll_Green_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

            UpdateColor();
        }

        private void Scroll_Blue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

            UpdateColor();
        }

        private void numeric_Red_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void numeric_Green_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void numeric_Blue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void UpdateColor()
        {
            colorResult = Color.FromArgb(SB_red.Value, SB_green.Value,
            SB_blue.Value);
            picResultColor.BackColor = colorResult;
        }

        private void b_other_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SB_red.Value = colorDialog.Color.R;
                SB_green.Value = colorDialog.Color.G;
                SB_blue.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;

                UpdateColor();
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
                main.changeColor(colorResult);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
