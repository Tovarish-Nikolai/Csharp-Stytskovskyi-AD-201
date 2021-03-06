using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void ToolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog SaveDlg = new OpenFileDialog();

            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void ToolStripMenuItem4_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem5_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();

                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)                    
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Module AddRec = new Module();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;
            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.ResetText();
            textBox1.ResetText();
        }

        public void DeleteSelectedStrings (ListBox LB)
        {
            for (int i = LB.Items.Count - 1; i >= 0; i--)
            {
                if (LB.GetSelected(i)) 
                    LB.Items.RemoveAt(i);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteSelectedStrings(listBox1);
            DeleteSelectedStrings(listBox2);
        }

        public void moveSelectedItems (ListBox from, ListBox to)
        {
            to.BeginUpdate();
            foreach (object Item in from.SelectedItems)
            {
                to.Items.Add(Item);               
            }
            to.EndUpdate();
            DeleteSelectedStrings(from);
        }

        public void moveAllItems (ListBox from, ListBox to)
        {
            to.Items.AddRange(from.Items);
            from.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSelectedItems(listBox2, listBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            moveSelectedItems(listBox1, listBox2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            moveAllItems(listBox2, listBox1); 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            moveAllItems(listBox1, listBox2);
        }

        public static string[] SortLength(string[] arr)
        {
            string[] sorted = arr.OrderBy(x => x.Length).ToArray();

            return sorted;
        }

        public void SortFunction(ComboBox cb, ListBox lb)
        {
            if (cb.SelectedItem == "По алфавиту (возр.)")
            {
                lb.Sorted = true;
                lb.Sorted = false;
            }
            else if (cb.SelectedItem == "По алфавиту (убыв.)")
            {
                lb.Sorted = true;
                lb.Sorted = false;

                string[] Strings = lb.Items.OfType<string>().ToArray();
                Array.Reverse(Strings, 0, Strings.Length);

                lb.BeginUpdate();

                lb.Items.Clear();

                foreach (string s in Strings)
                {
                    string Str = s.Trim();
                    if (s == String.Empty) continue;

                    lb.Items.Add(Str);
                }
                lb.EndUpdate();
            }
            else if (cb.SelectedItem == "По длине (убыв.)")
            {
                string[] Strings = lb.Items.OfType<string>().ToArray();

                lb.BeginUpdate();

                lb.Items.Clear();

                foreach (string s in SortLength(Strings))
                {
                    string Str = s.Trim();
                    if (s == String.Empty) continue;

                    lb.Items.Add(Str);
                }
                lb.EndUpdate();
            }
            else if (cb.SelectedItem == "По длине (возр.)")
            {
                string[] Strings = lb.Items.OfType<string>().ToArray();

                Strings = SortLength(Strings);
                Array.Reverse(Strings, 0, Strings.Length);

                lb.BeginUpdate();

                lb.Items.Clear();

                foreach (string s in Strings)
                {
                    string Str = s.Trim();
                    if (s == String.Empty) continue;

                    lb.Items.Add(Str);
                }
                lb.EndUpdate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SortFunction(comboBox1, listBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SortFunction(comboBox2, listBox2);
        }
    }
}
