using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        bool drawing;

        System.Drawing.Drawing2D.GraphicsPath currentPath;
        Point oldLocation;
        Pen currentPen;
        Color historyColor;

        public Form1()
        {
            InitializeComponent();

            drawing = false; //Переменная, ответственная за рисование
            currentPen = new Pen(Color.Black);
            historyColor = currentPen.Color;
            currentPen.Width = trackBar1.Value;

            newButton.Click += NewButton_Click;
            saveButton.Click += SaveButton_Click;
            openButton.Click += OpenButton_Click;
            exitButton.Click += ExitButton_Click;

            newButtonTS.Click += NewButtonTS_Click;
            saveButtonTS.Click += SaveButtonTS_Click;
            openButtonTS.Click += OpenButtonTS_Click;
            exitButtonTS.Click += ExitButtonTS_Click;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            coordinatesLabel.Text = e.X.ToString() + ", " + e.Y.ToString();

            if (drawing)
            {
                Graphics g = Graphics.FromImage(pictureBox.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                pictureBox.Invalidate();
            }
        }


        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            currentPen.Color = historyColor;
            try
            {
                currentPath.Dispose();
            }
            catch { };
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new System.Drawing.Drawing2D.GraphicsPath();
            }
            else if (e.Button == MouseButtons.Right)
            {
                historyColor = currentPen.Color;

                currentPen.Color = Color.White;
                drawing = true;
                oldLocation = e.Location;
                currentPath = new System.Drawing.Drawing2D.GraphicsPath();
            }
        }


        private void OpenButtonTS_Click(object sender, EventArgs e) { OpenButton_Click(sender, e); }
        private void SaveButtonTS_Click(object sender, EventArgs e) { SaveButton_Click(sender, e); }
        private void NewButtonTS_Click(object sender, EventArgs e) { NewButton_Click(sender, e); }
        private void ExitButtonTS_Click(object sender, EventArgs e) { Application.Exit(); }

        private void ExitButton_Click(object sender, EventArgs e) { Application.Exit(); }
       
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image | *.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; //По умолчанию будет выбрано первое расширение *.jpg И, когда пользователь укажет нужный путь к картинке, ее нужно будет загрузить в PictureBox:
            if (OP.ShowDialog() != DialogResult.Cancel)
                pictureBox.Load(OP.FileName);
            pictureBox.AutoSize = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();

            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image | *.png";
            SaveDlg.Title = "Save an Image File";

            SaveDlg.FilterIndex = 4; //По умолчанию будет выбрано последнее расширение *.png
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "") //Если введено не пустое имя
            {
                System.IO.FileStream fs =
                (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        this.pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        this.pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка ? ", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                    {
                        case DialogResult.No: break;
                        case DialogResult.Yes: SaveButton_Click(sender, e); break;
                        case DialogResult.Cancel: return;
                    }
            }

            Bitmap pic = new Bitmap(750, 500);
            pictureBox.Image = pic;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar1.Value;

        }
    }
}
