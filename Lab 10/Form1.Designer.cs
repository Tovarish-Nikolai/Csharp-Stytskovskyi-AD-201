
namespace Lab_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editButton = new System.Windows.Forms.ToolStripMenuItem();
            this.undoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.redoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.penButton = new System.Windows.Forms.ToolStripMenuItem();
            this.styleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.solidButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dotButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotButton = new System.Windows.Forms.ToolStripMenuItem();
            this.colorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newButtonTS = new System.Windows.Forms.ToolStripButton();
            this.saveButtonTS = new System.Windows.Forms.ToolStripButton();
            this.openButtonTS = new System.Windows.Forms.ToolStripButton();
            this.colorButtonTS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButtonTS = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.editButton,
            this.helpButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.toolStripSeparator1,
            this.exitButton});
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(37, 20);
            this.fileButton.Text = "File";
            // 
            // newButton
            // 
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.Name = "newButton";
            this.newButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newButton.Size = new System.Drawing.Size(141, 22);
            this.newButton.Text = "New";
            // 
            // openButton
            // 
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.Name = "openButton";
            this.openButton.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.openButton.Size = new System.Drawing.Size(141, 22);
            this.openButton.Text = "Open";
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Name = "saveButton";
            this.saveButton.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.saveButton.Size = new System.Drawing.Size(141, 22);
            this.saveButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Name = "exitButton";
            this.exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitButton.Size = new System.Drawing.Size(141, 22);
            this.exitButton.Text = "Exit";
            // 
            // editButton
            // 
            this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoButton,
            this.redoButton,
            this.penButton});
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(39, 20);
            this.editButton.Text = "Edit";
            // 
            // undoButton
            // 
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.Name = "undoButton";
            this.undoButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoButton.Size = new System.Drawing.Size(180, 22);
            this.undoButton.Text = "Undo";
            // 
            // redoButton
            // 
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.Name = "redoButton";
            this.redoButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoButton.Size = new System.Drawing.Size(180, 22);
            this.redoButton.Text = "Redo";
            // 
            // penButton
            // 
            this.penButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleButton,
            this.colorButton});
            this.penButton.Image = ((System.Drawing.Image)(resources.GetObject("penButton.Image")));
            this.penButton.Name = "penButton";
            this.penButton.ShowShortcutKeys = false;
            this.penButton.Size = new System.Drawing.Size(180, 22);
            this.penButton.Text = "Pen";
            // 
            // styleButton
            // 
            this.styleButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidButton,
            this.dotButton,
            this.dashDotDotButton});
            this.styleButton.Name = "styleButton";
            this.styleButton.Size = new System.Drawing.Size(103, 22);
            this.styleButton.Text = "Style";
            // 
            // solidButton
            // 
            this.solidButton.Checked = true;
            this.solidButton.CheckOnClick = true;
            this.solidButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidButton.Name = "solidButton";
            this.solidButton.Size = new System.Drawing.Size(138, 22);
            this.solidButton.Text = "Solid";
            // 
            // dotButton
            // 
            this.dotButton.CheckOnClick = true;
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(138, 22);
            this.dotButton.Text = "Dot";
            // 
            // dashDotDotButton
            // 
            this.dashDotDotButton.CheckOnClick = true;
            this.dashDotDotButton.Name = "dashDotDotButton";
            this.dashDotDotButton.Size = new System.Drawing.Size(138, 22);
            this.dashDotDotButton.Text = "DashDotDot";
            // 
            // colorButton
            // 
            this.colorButton.Image = ((System.Drawing.Image)(resources.GetObject("colorButton.Image")));
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(103, 22);
            this.colorButton.Text = "Color";
            // 
            // helpButton
            // 
            this.helpButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(44, 20);
            this.helpButton.Text = "Help";
            // 
            // aboutButton
            // 
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutButton.Size = new System.Drawing.Size(126, 22);
            this.aboutButton.Text = "About";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(106, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(682, 396);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButtonTS,
            this.saveButtonTS,
            this.openButtonTS,
            this.colorButtonTS,
            this.toolStripSeparator2,
            this.exitButtonTS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 426);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newButtonTS
            // 
            this.newButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButtonTS.Image = ((System.Drawing.Image)(resources.GetObject("newButtonTS.Image")));
            this.newButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButtonTS.Name = "newButtonTS";
            this.newButtonTS.Size = new System.Drawing.Size(98, 68);
            this.newButtonTS.Text = "NEW";
            // 
            // saveButtonTS
            // 
            this.saveButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButtonTS.Image = ((System.Drawing.Image)(resources.GetObject("saveButtonTS.Image")));
            this.saveButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButtonTS.Name = "saveButtonTS";
            this.saveButtonTS.Size = new System.Drawing.Size(98, 68);
            this.saveButtonTS.Text = "SAVE";
            // 
            // openButtonTS
            // 
            this.openButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButtonTS.Image = ((System.Drawing.Image)(resources.GetObject("openButtonTS.Image")));
            this.openButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButtonTS.Name = "openButtonTS";
            this.openButtonTS.Size = new System.Drawing.Size(98, 68);
            this.openButtonTS.Text = "OPEN";
            // 
            // colorButtonTS
            // 
            this.colorButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorButtonTS.Image = ((System.Drawing.Image)(resources.GetObject("colorButtonTS.Image")));
            this.colorButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorButtonTS.Name = "colorButtonTS";
            this.colorButtonTS.Size = new System.Drawing.Size(98, 68);
            this.colorButtonTS.Text = "COLOR";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(98, 6);
            // 
            // exitButtonTS
            // 
            this.exitButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitButtonTS.Image = ((System.Drawing.Image)(resources.GetObject("exitButtonTS.Image")));
            this.exitButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButtonTS.Name = "exitButtonTS";
            this.exitButtonTS.Size = new System.Drawing.Size(98, 68);
            this.exitButtonTS.Text = "EXIT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.coordinatesLabel);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(106, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 21);
            this.panel1.TabIndex = 3;
            // 
            // coordinatesLabel
            // 
            this.coordinatesLabel.AutoSize = true;
            this.coordinatesLabel.Location = new System.Drawing.Point(18, 1);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(25, 15);
            this.coordinatesLabel.TabIndex = 1;
            this.coordinatesLabel.Text = "x, y";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(527, 1);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(155, 20);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(93, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 414);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileButton;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem helpButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem newButton;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem editButton;
        private System.Windows.Forms.ToolStripMenuItem undoButton;
        private System.Windows.Forms.ToolStripMenuItem redoButton;
        private System.Windows.Forms.ToolStripMenuItem penButton;
        private System.Windows.Forms.ToolStripMenuItem styleButton;
        private System.Windows.Forms.ToolStripMenuItem solidButton;
        private System.Windows.Forms.ToolStripMenuItem dotButton;
        private System.Windows.Forms.ToolStripMenuItem dashDotDotButton;
        private System.Windows.Forms.ToolStripMenuItem colorButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripButton newButtonTS;
        private System.Windows.Forms.ToolStripButton saveButtonTS;
        private System.Windows.Forms.ToolStripButton openButtonTS;
        private System.Windows.Forms.ToolStripButton colorButtonTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exitButtonTS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label coordinatesLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
    }
}

