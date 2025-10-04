namespace Buoi03_Bai_4
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
            txtHoTen = new TextBox();
            lb1 = new Label();
            groupBox1 = new GroupBox();
            rdoChuhoa = new RadioButton();
            rdoChuthuong = new RadioButton();
            btnXoa = new Button();
            btnThoat = new Button();
            btnKQ = new Button();
            txtKQ = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(281, 54);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(273, 31);
            txtHoTen.TabIndex = 0;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lb1.ForeColor = Color.CornflowerBlue;
            lb1.Location = new Point(85, 51);
            lb1.Name = "lb1";
            lb1.Size = new Size(161, 32);
            lb1.TabIndex = 1;
            lb1.Text = "Nhập họ tên: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoChuhoa);
            groupBox1.Controls.Add(rdoChuthuong);
            groupBox1.Location = new Point(85, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 150);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn kiểu chữ";
            // 
            // rdoChuhoa
            // 
            rdoChuhoa.AutoSize = true;
            rdoChuhoa.Location = new Point(28, 96);
            rdoChuhoa.Name = "rdoChuhoa";
            rdoChuhoa.Size = new Size(141, 29);
            rdoChuhoa.TabIndex = 1;
            rdoChuhoa.TabStop = true;
            rdoChuhoa.Text = "CHỮ IN HOA";
            rdoChuhoa.UseVisualStyleBackColor = true;
            // 
            // rdoChuthuong
            // 
            rdoChuthuong.AutoSize = true;
            rdoChuthuong.Location = new Point(28, 46);
            rdoChuthuong.Name = "rdoChuthuong";
            rdoChuthuong.Size = new Size(133, 29);
            rdoChuthuong.TabIndex = 0;
            rdoChuthuong.TabStop = true;
            rdoChuthuong.Text = "Chữ thường";
            rdoChuthuong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.MenuHighlight;
            btnXoa.Location = new Point(433, 121);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 57);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.MenuHighlight;
            btnThoat.Location = new Point(433, 184);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 57);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnKQ
            // 
            btnKQ.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKQ.ForeColor = SystemColors.MenuHighlight;
            btnKQ.Location = new Point(85, 259);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(209, 57);
            btnKQ.TabIndex = 5;
            btnKQ.Text = "Kết quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(300, 276);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(245, 31);
            txtKQ.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 343);
            Controls.Add(txtKQ);
            Controls.Add(btnKQ);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(groupBox1);
            Controls.Add(lb1);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Đổi kiểu chữ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label lb1;
        private GroupBox groupBox1;
        private RadioButton rdoChuhoa;
        private RadioButton rdoChuthuong;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnKQ;
        private TextBox txtKQ;
    }
}
