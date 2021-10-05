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
        public Form1()
        {
            InitializeComponent();

            newButton.Click += NewButton_Click;
            saveButton.Click += SaveButton_Click;
            openButton.Click += OpenButton_Click;

            newButtonTS.Click += NewButtonTS_Click;
            saveButtonTS.Click += SaveButtonTS_Click;
            openButtonTS.Click += OpenButtonTS_Click;
        }

        private void OpenButtonTS_Click(object sender, EventArgs e) { OpenButton_Click(sender, e); }
        private void SaveButtonTS_Click(object sender, EventArgs e) { SaveButton_Click(sender, e); }
        private void NewButtonTS_Click(object sender, EventArgs e) { NewButton_Click(sender, e); }

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

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
            }
        }
    }
}
