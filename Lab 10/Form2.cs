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

            SBRed.Tag = UDRed;
            SBGreen.Tag = UDGreen;
            SBBlue.Tag = UDBlue;
            UDRed.Tag = SBRed.Tag;
            UDGreen.Tag = SBGreen.Tag;
            UDBlue.Tag = SBBlue.Tag;
            UDRed.Value = color.R;
            UDGreen.Value = color.G;
            UDBlue.Value = color.B;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SBRed_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void SBBlue_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void SBGreen_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void SBRed_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

            UpdateColor();
        }

        private void SBGreen_ValueChanged(object sender, EventArgs e)
        {
            SBRed_ValueChanged(sender, e);
        }

        private void SBBlue_ValueChanged(object sender, EventArgs e)
        {
            SBRed_ValueChanged(sender, e);
        }

        private void UDGreen_ValueChanged(object sender, EventArgs e)
        {
            SBRed_ValueChanged(sender, e);
        }

        private void UDBlue_ValueChanged(object sender, EventArgs e)
        {
            SBRed_ValueChanged(sender, e);
        }

        private void UDRed_ValueChanged(object sender, EventArgs e)
        {
            SBRed_ValueChanged(sender, e);
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(SBRed.Value, SBGreen.Value, SBBlue.Value);
            PBPreview.BackColor = colorResult;
        }

        private void buttonOtherColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SBRed.Value = colorDialog.Color.R;
                SBGreen.Value = colorDialog.Color.G;
                SBBlue.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;

                UpdateColor();
            }
        }
    }
}
