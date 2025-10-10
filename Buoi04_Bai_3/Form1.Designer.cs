namespace Buoi04_Bai_3
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
            btnTaomang = new Button();
            txtNhap = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            btnMax = new Button();
            btnSum = new Button();
            SuspendLayout();
            // 
            // btnTaomang
            // 
            btnTaomang.ForeColor = Color.Blue;
            btnTaomang.Location = new Point(381, 19);
            btnTaomang.Margin = new Padding(4, 3, 4, 3);
            btnTaomang.Name = "btnTaomang";
            btnTaomang.Size = new Size(253, 38);
            btnTaomang.TabIndex = 23;
            btnTaomang.Text = "Tạo mảng random";
            btnTaomang.UseVisualStyleBackColor = true;
            btnTaomang.Click += btnTaomang_Click;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(264, 22);
            txtNhap.Margin = new Padding(4, 3, 4, 3);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(109, 35);
            txtNhap.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 27);
            label1.TabIndex = 21;
            label1.Text = "Nhập số phần tử mảng: ";
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Blue;
            btnThoat.Location = new Point(473, 76);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(161, 46);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            btnMax.ForeColor = Color.Blue;
            btnMax.Location = new Point(264, 76);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(161, 46);
            btnMax.TabIndex = 25;
            btnMax.Text = "Số lớn nhất";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnSum
            // 
            btnSum.ForeColor = Color.Blue;
            btnSum.Location = new Point(16, 76);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(161, 46);
            btnSum.TabIndex = 26;
            btnSum.Text = "Tổng mảng";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(652, 151);
            Controls.Add(btnSum);
            Controls.Add(btnMax);
            Controls.Add(btnThoat);
            Controls.Add(btnTaomang);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTaomang;
        private TextBox txtNhap;
        private Label label1;
        private Button btnThoat;
        private Button btnMax;
        private Button btnSum;
    }
}
