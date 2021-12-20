
namespace Lab_10
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SB_red = new System.Windows.Forms.HScrollBar();
            this.SB_green = new System.Windows.Forms.HScrollBar();
            this.SB_blue = new System.Windows.Forms.HScrollBar();
            this.l_red = new System.Windows.Forms.Label();
            this.l_green = new System.Windows.Forms.Label();
            this.l_blue = new System.Windows.Forms.Label();
            this.num_red = new System.Windows.Forms.NumericUpDown();
            this.num_green = new System.Windows.Forms.NumericUpDown();
            this.num_blue = new System.Windows.Forms.NumericUpDown();
            this.picResultColor = new System.Windows.Forms.PictureBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_other = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).BeginInit();
            this.SuspendLayout();
            // 
            // SB_red
            // 
            this.SB_red.LargeChange = 1;
            this.SB_red.Location = new System.Drawing.Point(65, 43);
            this.SB_red.Maximum = 255;
            this.SB_red.Name = "SB_red";
            this.SB_red.Size = new System.Drawing.Size(205, 17);
            this.SB_red.TabIndex = 0;
            this.SB_red.ValueChanged += new System.EventHandler(this.Scroll_Red_ValueChanged);
            // 
            // SB_green
            // 
            this.SB_green.LargeChange = 1;
            this.SB_green.Location = new System.Drawing.Point(65, 76);
            this.SB_green.Maximum = 255;
            this.SB_green.Name = "SB_green";
            this.SB_green.Size = new System.Drawing.Size(205, 17);
            this.SB_green.TabIndex = 1;
            this.SB_green.ValueChanged += new System.EventHandler(this.Scroll_Green_ValueChanged);
            // 
            // SB_blue
            // 
            this.SB_blue.LargeChange = 1;
            this.SB_blue.Location = new System.Drawing.Point(65, 109);
            this.SB_blue.Maximum = 255;
            this.SB_blue.Name = "SB_blue";
            this.SB_blue.Size = new System.Drawing.Size(205, 17);
            this.SB_blue.TabIndex = 2;
            this.SB_blue.ValueChanged += new System.EventHandler(this.Scroll_Blue_ValueChanged);
            // 
            // l_red
            // 
            this.l_red.AutoSize = true;
            this.l_red.Location = new System.Drawing.Point(13, 43);
            this.l_red.Name = "l_red";
            this.l_red.Size = new System.Drawing.Size(27, 15);
            this.l_red.TabIndex = 3;
            this.l_red.Text = "Red";
            // 
            // l_green
            // 
            this.l_green.AutoSize = true;
            this.l_green.Location = new System.Drawing.Point(13, 76);
            this.l_green.Name = "l_green";
            this.l_green.Size = new System.Drawing.Size(38, 15);
            this.l_green.TabIndex = 4;
            this.l_green.Text = "Green";
            // 
            // l_blue
            // 
            this.l_blue.AutoSize = true;
            this.l_blue.Location = new System.Drawing.Point(13, 109);
            this.l_blue.Name = "l_blue";
            this.l_blue.Size = new System.Drawing.Size(30, 15);
            this.l_blue.TabIndex = 5;
            this.l_blue.Text = "Blue";
            // 
            // num_red
            // 
            this.num_red.Location = new System.Drawing.Point(305, 43);
            this.num_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_red.Name = "num_red";
            this.num_red.Size = new System.Drawing.Size(48, 23);
            this.num_red.TabIndex = 6;
            this.num_red.ValueChanged += new System.EventHandler(this.numeric_Red_ValueChanged);
            // 
            // num_green
            // 
            this.num_green.Location = new System.Drawing.Point(305, 76);
            this.num_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_green.Name = "num_green";
            this.num_green.Size = new System.Drawing.Size(48, 23);
            this.num_green.TabIndex = 7;
            this.num_green.ValueChanged += new System.EventHandler(this.numeric_Green_ValueChanged);
            // 
            // num_blue
            // 
            this.num_blue.Location = new System.Drawing.Point(305, 109);
            this.num_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_blue.Name = "num_blue";
            this.num_blue.Size = new System.Drawing.Size(48, 23);
            this.num_blue.TabIndex = 8;
            this.num_blue.ValueChanged += new System.EventHandler(this.numeric_Blue_ValueChanged);
            // 
            // picResultColor
            // 
            this.picResultColor.Location = new System.Drawing.Point(399, 43);
            this.picResultColor.Name = "picResultColor";
            this.picResultColor.Size = new System.Drawing.Size(100, 89);
            this.picResultColor.TabIndex = 9;
            this.picResultColor.TabStop = false;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(13, 196);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 10;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(110, 196);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 11;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // b_other
            // 
            this.b_other.Location = new System.Drawing.Point(399, 196);
            this.b_other.Name = "b_other";
            this.b_other.Size = new System.Drawing.Size(100, 23);
            this.b_other.TabIndex = 12;
            this.b_other.Text = "Other Colors";
            this.b_other.UseVisualStyleBackColor = true;
            this.b_other.Click += new System.EventHandler(this.b_other_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 231);
            this.Controls.Add(this.b_other);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.picResultColor);
            this.Controls.Add(this.num_blue);
            this.Controls.Add(this.num_green);
            this.Controls.Add(this.num_red);
            this.Controls.Add(this.l_blue);
            this.Controls.Add(this.l_green);
            this.Controls.Add(this.l_red);
            this.Controls.Add(this.SB_blue);
            this.Controls.Add(this.SB_green);
            this.Controls.Add(this.SB_red);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar SB_red;
        private System.Windows.Forms.HScrollBar SB_green;
        private System.Windows.Forms.HScrollBar SB_blue;
        private System.Windows.Forms.Label l_red;
        private System.Windows.Forms.Label l_green;
        private System.Windows.Forms.Label l_blue;
        private System.Windows.Forms.NumericUpDown num_red;
        private System.Windows.Forms.NumericUpDown num_green;
        private System.Windows.Forms.NumericUpDown num_blue;
        private System.Windows.Forms.PictureBox picResultColor;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_other;
    }
}