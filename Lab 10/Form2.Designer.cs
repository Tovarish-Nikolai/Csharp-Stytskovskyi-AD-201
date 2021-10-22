
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
            this.LabelRed = new System.Windows.Forms.Label();
            this.LabelGreen = new System.Windows.Forms.Label();
            this.LabelBlue = new System.Windows.Forms.Label();
            this.SBRed = new System.Windows.Forms.HScrollBar();
            this.SBGreen = new System.Windows.Forms.HScrollBar();
            this.SBBlue = new System.Windows.Forms.HScrollBar();
            this.UDRed = new System.Windows.Forms.NumericUpDown();
            this.UDGreen = new System.Windows.Forms.NumericUpDown();
            this.UDBlue = new System.Windows.Forms.NumericUpDown();
            this.PBPreview = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOtherColors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRed
            // 
            this.LabelRed.AutoSize = true;
            this.LabelRed.Location = new System.Drawing.Point(39, 31);
            this.LabelRed.Name = "LabelRed";
            this.LabelRed.Size = new System.Drawing.Size(27, 15);
            this.LabelRed.TabIndex = 0;
            this.LabelRed.Text = "Red";
            // 
            // LabelGreen
            // 
            this.LabelGreen.AutoSize = true;
            this.LabelGreen.Location = new System.Drawing.Point(39, 65);
            this.LabelGreen.Name = "LabelGreen";
            this.LabelGreen.Size = new System.Drawing.Size(38, 15);
            this.LabelGreen.TabIndex = 1;
            this.LabelGreen.Text = "Green";
            // 
            // LabelBlue
            // 
            this.LabelBlue.AutoSize = true;
            this.LabelBlue.Location = new System.Drawing.Point(39, 97);
            this.LabelBlue.Name = "LabelBlue";
            this.LabelBlue.Size = new System.Drawing.Size(30, 15);
            this.LabelBlue.TabIndex = 2;
            this.LabelBlue.Text = "Blue";
            // 
            // SBRed
            // 
            this.SBRed.LargeChange = 1;
            this.SBRed.Location = new System.Drawing.Point(117, 28);
            this.SBRed.Maximum = 255;
            this.SBRed.Name = "SBRed";
            this.SBRed.Size = new System.Drawing.Size(193, 17);
            this.SBRed.TabIndex = 3;
            this.SBRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SBRed_Scroll);
            this.SBRed.ValueChanged += new System.EventHandler(this.SBRed_ValueChanged);
            // 
            // SBGreen
            // 
            this.SBGreen.LargeChange = 1;
            this.SBGreen.Location = new System.Drawing.Point(117, 65);
            this.SBGreen.Maximum = 255;
            this.SBGreen.Name = "SBGreen";
            this.SBGreen.Size = new System.Drawing.Size(193, 17);
            this.SBGreen.TabIndex = 4;
            this.SBGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SBGreen_Scroll);
            this.SBGreen.ValueChanged += new System.EventHandler(this.SBGreen_ValueChanged);
            // 
            // SBBlue
            // 
            this.SBBlue.LargeChange = 1;
            this.SBBlue.Location = new System.Drawing.Point(117, 97);
            this.SBBlue.Maximum = 255;
            this.SBBlue.Name = "SBBlue";
            this.SBBlue.Size = new System.Drawing.Size(193, 17);
            this.SBBlue.TabIndex = 5;
            this.SBBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SBBlue_Scroll);
            this.SBBlue.ValueChanged += new System.EventHandler(this.SBBlue_ValueChanged);
            // 
            // UDRed
            // 
            this.UDRed.Location = new System.Drawing.Point(328, 29);
            this.UDRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UDRed.Name = "UDRed";
            this.UDRed.Size = new System.Drawing.Size(43, 23);
            this.UDRed.TabIndex = 6;
            this.UDRed.ValueChanged += new System.EventHandler(this.UDRed_ValueChanged);
            // 
            // UDGreen
            // 
            this.UDGreen.Location = new System.Drawing.Point(328, 65);
            this.UDGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UDGreen.Name = "UDGreen";
            this.UDGreen.Size = new System.Drawing.Size(43, 23);
            this.UDGreen.TabIndex = 7;
            this.UDGreen.ValueChanged += new System.EventHandler(this.UDGreen_ValueChanged);
            // 
            // UDBlue
            // 
            this.UDBlue.Location = new System.Drawing.Point(328, 97);
            this.UDBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UDBlue.Name = "UDBlue";
            this.UDBlue.Size = new System.Drawing.Size(43, 23);
            this.UDBlue.TabIndex = 8;
            this.UDBlue.ValueChanged += new System.EventHandler(this.UDBlue_ValueChanged);
            // 
            // PBPreview
            // 
            this.PBPreview.Location = new System.Drawing.Point(416, 31);
            this.PBPreview.Name = "PBPreview";
            this.PBPreview.Size = new System.Drawing.Size(100, 89);
            this.PBPreview.TabIndex = 9;
            this.PBPreview.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(39, 148);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(120, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOtherColors
            // 
            this.buttonOtherColors.Location = new System.Drawing.Point(416, 148);
            this.buttonOtherColors.Name = "buttonOtherColors";
            this.buttonOtherColors.Size = new System.Drawing.Size(100, 23);
            this.buttonOtherColors.TabIndex = 12;
            this.buttonOtherColors.Text = "Other Colors";
            this.buttonOtherColors.UseVisualStyleBackColor = true;
            this.buttonOtherColors.Click += new System.EventHandler(this.buttonOtherColors_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 185);
            this.Controls.Add(this.buttonOtherColors);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.PBPreview);
            this.Controls.Add(this.UDBlue);
            this.Controls.Add(this.UDGreen);
            this.Controls.Add(this.UDRed);
            this.Controls.Add(this.SBBlue);
            this.Controls.Add(this.SBGreen);
            this.Controls.Add(this.SBRed);
            this.Controls.Add(this.LabelBlue);
            this.Controls.Add(this.LabelGreen);
            this.Controls.Add(this.LabelRed);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UDRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRed;
        private System.Windows.Forms.Label LabelGreen;
        private System.Windows.Forms.Label LabelBlue;
        private System.Windows.Forms.HScrollBar SBRed;
        private System.Windows.Forms.HScrollBar SBGreen;
        private System.Windows.Forms.HScrollBar SBBlue;
        private System.Windows.Forms.NumericUpDown UDRed;
        private System.Windows.Forms.NumericUpDown UDGreen;
        private System.Windows.Forms.NumericUpDown UDBlue;
        private System.Windows.Forms.PictureBox PBPreview;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOtherColors;
    }
}