namespace Buoi07_Bai_5
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
            label1 = new Label();
            cboHinh = new ComboBox();
            groupBox1 = new GroupBox();
            cboSize = new ComboBox();
            label6 = new Label();
            lbBorderColor = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lbFillColor = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(82, 37);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 0;
            label1.Text = "Chọn hình vẽ";
            // 
            // cboHinh
            // 
            cboHinh.FormattingEnabled = true;
            cboHinh.Items.AddRange(new object[] { "Filled Ellipse", "Square", "Circle" });
            cboHinh.Location = new Point(82, 72);
            cboHinh.Name = "cboHinh";
            cboHinh.Size = new Size(237, 40);
            cboHinh.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSize);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbBorderColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(82, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 185);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Border";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cboSize.Location = new Point(117, 116);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(176, 40);
            cboSize.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(6, 116);
            label6.Name = "label6";
            label6.Size = new Size(59, 32);
            label6.TabIndex = 2;
            label6.Text = "Size";
            // 
            // lbBorderColor
            // 
            lbBorderColor.BackColor = Color.Black;
            lbBorderColor.Location = new Point(117, 46);
            lbBorderColor.Name = "lbBorderColor";
            lbBorderColor.Size = new Size(176, 32);
            lbBorderColor.TabIndex = 1;
            lbBorderColor.Text = "label3";
            lbBorderColor.Click += lbBorderColor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 0;
            label2.Text = "Color";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbFillColor);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(82, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 107);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fill";
            // 
            // lbFillColor
            // 
            lbFillColor.BackColor = Color.Black;
            lbFillColor.Location = new Point(117, 46);
            lbFillColor.Name = "lbFillColor";
            lbFillColor.Size = new Size(176, 32);
            lbFillColor.TabIndex = 1;
            lbFillColor.Text = "label4";
            lbFillColor.Click += lbFillColor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(6, 46);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 0;
            label5.Text = "Color";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(401, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(627, 552);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 576);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cboHinh);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Vẽ hình cơ bản";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboHinh;
        private GroupBox groupBox1;
        private Label label6;
        private Label lbBorderColor;
        private Label label2;
        private GroupBox groupBox2;
        private Label lbFillColor;
        private Label label5;
        private ComboBox cboSize;
        private PictureBox pictureBox1;
    }
}
